Option Strict On

' Peter Manankil
' July 11 2019
'Description: form keep track of car inventory which can add new vehicles
'
Public Class MainForm
    Private vehicleList As New SortedList
    Private selectID As String = String.Empty
    Private editMode As Boolean = False

    Private Sub Enterbtn_Click(sender As Object, e As EventArgs) Handles Enterbtn.Click


        Dim vehicle As Vehicles
        Dim vehicleItem As ListViewItem

        If IsValidInput() = True Then

            editMode = True

            lblResult.Text = "Works"

            If selectID.Trim.Length = 0 Then

                vehicle = New Vehicles(txtPrice.Text, txtModel.Text, txtMake.Text, txtYear.Text, Checkbox.Checked)

                vehicleList.Add(vehicle.ToString(), vehicle)

            Else
                vehicle = CType(vehicleList.Item(selectID), Vehicles)


                vehicle.make = txtMake.Text
                vehicle.Model = txtModel.Text
                vehicle.Year = txtYear.Text
                vehicle.Price = txtPrice.Text
                vehicle.newCar = Checkbox.Checked

            End If
            listVehicles.Items.Clear()


            For Each vehicleEntry As DictionaryEntry In vehicleList


                vehicleItem = New ListViewItem()


                vehicle = CType(vehicleEntry.Value, Vehicles)


                vehicleItem.Checked = vehicle.newCar
                vehicleItem.SubItems.Add(vehicle.ToString())
                vehicleItem.SubItems.Add(vehicle.make)
                vehicleItem.SubItems.Add(vehicle.model)
                vehicleItem.SubItems.Add(vehicle.Year)
                vehicleItem.SubItems.Add(FormatCurrency(vehicle.Price.ToString))


                listVehicles.Items.Add(vehicleItem)

            Next vehicleEntry

            txtModel.Text = String.Empty
            txtPrice.Text = String.Empty
            Checkbox.Checked = False
            txtMake.SelectedIndex = -1
            txtYear.SelectedIndex = -1
            lblResult.Text = String.Empty

            selectID = String.Empty
            editMode = False

        End If

    End Sub

    Private Function IsValidInput() As Boolean
        Dim returnValue As Boolean = True
        Dim DisplayMessage As String = String.Empty


        If txtMake.SelectedIndex = -1 Then
            DisplayMessage += "Vehicle Make Not Selected" & vbCrLf

            returnValue = False
        End If


        If txtModel.Text.Trim.Length = 0 Then
            DisplayMessage += "Vehicle Model Not Entered" & vbCrLf

            returnValue = False
        End If


        If txtYear.SelectedIndex = -1 Then
            DisplayMessage += "Year Not Selected" & vbCrLf

            returnValue = False
        End If


        If txtPrice.Text.Trim.Length = 0 Then
            DisplayMessage += "Price Not Selected" & vbCrLf

            returnValue = False
        End If


        If returnValue = False Then

            lblResult.Text = "Error" & vbCrLf & DisplayMessage

        End If


        Return returnValue

    End Function
    Private Sub listVehicles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listVehicles.SelectedIndexChanged

        Const identificationIndex As Integer = 1

        selectID = listVehicles.Items(listVehicles.FocusedItem.Index).SubItems(identificationIndex).Text

        Dim vehicle As Vehicles = CType(vehicleList.Item(selectID), Vehicles)


        txtMake.Text = vehicle.make
        txtModel.Text = vehicle.model
        txtYear.Text = vehicle.Year
        txtPrice.Text = vehicle.Price
        Checkbox.Checked = vehicle.newCar


        lblResult.Text = vehicle.GetSalutation()

    End Sub
    Private Sub listVehicles_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles listVehicles.ItemCheck

        If editMode = False Then
            e.NewValue = e.CurrentValue
        End If
    End Sub

    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click

        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        Checkbox.Checked = False
        txtMake.SelectedIndex = -1
        txtYear.SelectedIndex = -1
        lblResult.Text = String.Empty

        selectID = String.Empty
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
