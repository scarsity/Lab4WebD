<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Checkbox = New System.Windows.Forms.CheckBox()
        Me.listVehicles = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.ComboBox()
        Me.Enterbtn = New System.Windows.Forms.Button()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Checkbox
        '
        Me.Checkbox.AutoSize = True
        Me.Checkbox.Location = New System.Drawing.Point(70, 114)
        Me.Checkbox.Name = "Checkbox"
        Me.Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.Checkbox.TabIndex = 0
        Me.Checkbox.UseVisualStyleBackColor = True
        '
        'listVehicles
        '
        Me.listVehicles.CheckBoxes = True
        Me.listVehicles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.listVehicles.FullRowSelect = True
        Me.listVehicles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listVehicles.Location = New System.Drawing.Point(16, 133)
        Me.listVehicles.Margin = New System.Windows.Forms.Padding(2)
        Me.listVehicles.MaximumSize = New System.Drawing.Size(342, 192)
        Me.listVehicles.MinimumSize = New System.Drawing.Size(342, 192)
        Me.listVehicles.MultiSelect = False
        Me.listVehicles.Name = "listVehicles"
        Me.listVehicles.Size = New System.Drawing.Size(342, 192)
        Me.listVehicles.TabIndex = 10
        Me.listVehicles.UseCompatibleStateImageBehavior = False
        Me.listVehicles.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colId
        '
        Me.colId.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(70, 88)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(92, 20)
        Me.txtPrice.TabIndex = 11
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(70, 37)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(92, 20)
        Me.txtModel.TabIndex = 12
        '
        'txtMake
        '
        Me.txtMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMake.FormattingEnabled = True
        Me.txtMake.Items.AddRange(New Object() {"Audi", "Acura", "BMW", "Ford", "Honda", "Toyota", "Chevrolet", "Volvo", "Tesla", "Nissan"})
        Me.txtMake.Location = New System.Drawing.Point(70, 11)
        Me.txtMake.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(92, 21)
        Me.txtMake.TabIndex = 13
        '
        'txtYear
        '
        Me.txtYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtYear.FormattingEnabled = True
        Me.txtYear.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010"})
        Me.txtYear.Location = New System.Drawing.Point(70, 62)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(2)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(92, 21)
        Me.txtYear.TabIndex = 14
        '
        'Enterbtn
        '
        Me.Enterbtn.Location = New System.Drawing.Point(31, 389)
        Me.Enterbtn.Name = "Enterbtn"
        Me.Enterbtn.Size = New System.Drawing.Size(75, 23)
        Me.Enterbtn.TabIndex = 15
        Me.Enterbtn.Text = "&Enter"
        Me.Enterbtn.UseVisualStyleBackColor = True
        '
        'Resetbtn
        '
        Me.Resetbtn.Location = New System.Drawing.Point(127, 389)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(75, 23)
        Me.Resetbtn.TabIndex = 16
        Me.Resetbtn.Text = "&Reset"
        Me.Resetbtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitBtn.Location = New System.Drawing.Point(217, 389)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 17
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Make:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Year:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "New:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(17, 327)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(341, 46)
        Me.lblResult.TabIndex = 23
        '
        'MainForm
        '
        Me.AcceptButton = Me.Enterbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitBtn
        Me.ClientSize = New System.Drawing.Size(369, 424)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.Resetbtn)
        Me.Controls.Add(Me.Enterbtn)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.listVehicles)
        Me.Controls.Add(Me.Checkbox)
        Me.Name = "MainForm"
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Checkbox As CheckBox
    Friend WithEvents listVehicles As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtMake As ComboBox
    Friend WithEvents txtYear As ComboBox
    Friend WithEvents Enterbtn As Button
    Friend WithEvents Resetbtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblResult As Label
End Class
