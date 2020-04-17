<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cboMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttpCarInventory = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(26, 152)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(69, 21)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.ttpCarInventory.SetToolTip(Me.chkNew, "Check the box if the car is new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(7, 34)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(64, 17)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(0, 67)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(71, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Mo&del:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(0, 97)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(71, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(0, 126)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(71, 17)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboMake
        '
        Me.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMake.FormattingEnabled = True
        Me.cboMake.Items.AddRange(New Object() {"Honda", "Hyundai", "Volkswagon", "Mitsubishi", "Ford", "Toyota", "Nissan", "Jeep", "BMW"})
        Me.cboMake.Location = New System.Drawing.Point(77, 31)
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(121, 24)
        Me.cboMake.TabIndex = 1
        Me.ttpCarInventory.SetToolTip(Me.cboMake, "Enter the make of the car")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(77, 63)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 22)
        Me.txtModel.TabIndex = 3
        Me.ttpCarInventory.SetToolTip(Me.txtModel, "Enter the model of the car")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(77, 123)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(120, 22)
        Me.txtPrice.TabIndex = 7
        Me.ttpCarInventory.SetToolTip(Me.txtPrice, "Enter how much the car costs")
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(77, 93)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(120, 22)
        Me.nudYear.TabIndex = 5
        Me.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpCarInventory.SetToolTip(Me.nudYear, "Enter the year the car was made")
        Me.nudYear.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.HideSelection = False
        Me.lvwCars.Location = New System.Drawing.Point(13, 190)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(496, 176)
        Me.lvwCars.TabIndex = 9
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 46
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.Width = 36
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 82
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 81
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 66
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(13, 386)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(496, 85)
        Me.lblError.TabIndex = 10
        Me.ttpCarInventory.SetToolTip(Me.lblError, "This is where you'll see details of cars you click on, as well as any error that " &
        "appear")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(123, 495)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 28)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarInventory.SetToolTip(Me.btnEnter, "Press to enter the information")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(213, 495)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 28)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.ttpCarInventory.SetToolTip(Me.btnReset, "Press to reset the boxes")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(303, 495)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 28)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.ttpCarInventory.SetToolTip(Me.btnExit, "Press to close the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(523, 534)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cboMake)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.chkNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents cboMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents lvwCars As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblError As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttpCarInventory As ToolTip
End Class
