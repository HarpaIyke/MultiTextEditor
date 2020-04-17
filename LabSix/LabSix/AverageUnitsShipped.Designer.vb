<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.txtEmployeeOne = New System.Windows.Forms.TextBox()
        Me.txtEmployeeTwo = New System.Windows.Forms.TextBox()
        Me.txtEmployeeThree = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblAverageOne = New System.Windows.Forms.Label()
        Me.lblAverageTwo = New System.Windows.Forms.Label()
        Me.lblAverageThree = New System.Windows.Forms.Label()
        Me.lblAverageTotal = New System.Windows.Forms.Label()
        Me.lblEmployeeOne = New System.Windows.Forms.Label()
        Me.lblEmployeeTwo = New System.Windows.Forms.Label()
        Me.lblEmployeeThree = New System.Windows.Forms.Label()
        Me.ttpAverageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtEmployeeOne
        '
        Me.txtEmployeeOne.Location = New System.Drawing.Point(49, 141)
        Me.txtEmployeeOne.Multiline = True
        Me.txtEmployeeOne.Name = "txtEmployeeOne"
        Me.txtEmployeeOne.ReadOnly = True
        Me.txtEmployeeOne.Size = New System.Drawing.Size(130, 197)
        Me.txtEmployeeOne.TabIndex = 3
        '
        'txtEmployeeTwo
        '
        Me.txtEmployeeTwo.Location = New System.Drawing.Point(206, 141)
        Me.txtEmployeeTwo.Multiline = True
        Me.txtEmployeeTwo.Name = "txtEmployeeTwo"
        Me.txtEmployeeTwo.ReadOnly = True
        Me.txtEmployeeTwo.Size = New System.Drawing.Size(130, 197)
        Me.txtEmployeeTwo.TabIndex = 5
        '
        'txtEmployeeThree
        '
        Me.txtEmployeeThree.Location = New System.Drawing.Point(363, 141)
        Me.txtEmployeeThree.Multiline = True
        Me.txtEmployeeThree.Name = "txtEmployeeThree"
        Me.txtEmployeeThree.ReadOnly = True
        Me.txtEmployeeThree.Size = New System.Drawing.Size(130, 197)
        Me.txtEmployeeThree.TabIndex = 7
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(57, 441)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(90, 28)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "&Enter"
        Me.ttpAverageUnitsShippedTips.SetToolTip(Me.btnEnter, "Press to enter input")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(227, 441)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 28)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.ttpAverageUnitsShippedTips.SetToolTip(Me.btnReset, "Reset the application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(387, 441)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 28)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.ttpAverageUnitsShippedTips.SetToolTip(Me.btnExit, "Exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(17, 62)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(44, 17)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(432, 27)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(45, 17)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(79, 59)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 22)
        Me.txtInput.TabIndex = 2
        Me.ttpAverageUnitsShippedTips.SetToolTip(Me.txtInput, "Enter the number of units shipped here")
        '
        'lblAverageOne
        '
        Me.lblAverageOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageOne.Location = New System.Drawing.Point(49, 356)
        Me.lblAverageOne.Name = "lblAverageOne"
        Me.lblAverageOne.Size = New System.Drawing.Size(130, 23)
        Me.lblAverageOne.TabIndex = 4
        Me.lblAverageOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverageTwo
        '
        Me.lblAverageTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageTwo.Location = New System.Drawing.Point(206, 356)
        Me.lblAverageTwo.Name = "lblAverageTwo"
        Me.lblAverageTwo.Size = New System.Drawing.Size(130, 23)
        Me.lblAverageTwo.TabIndex = 6
        Me.lblAverageTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverageThree
        '
        Me.lblAverageThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageThree.Location = New System.Drawing.Point(363, 356)
        Me.lblAverageThree.Name = "lblAverageThree"
        Me.lblAverageThree.Size = New System.Drawing.Size(130, 23)
        Me.lblAverageThree.TabIndex = 8
        Me.lblAverageThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverageTotal
        '
        Me.lblAverageTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageTotal.Location = New System.Drawing.Point(49, 397)
        Me.lblAverageTotal.Name = "lblAverageTotal"
        Me.lblAverageTotal.Size = New System.Drawing.Size(444, 23)
        Me.lblAverageTotal.TabIndex = 9
        Me.lblAverageTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeOne
        '
        Me.lblEmployeeOne.AutoSize = True
        Me.lblEmployeeOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeOne.Location = New System.Drawing.Point(69, 111)
        Me.lblEmployeeOne.Name = "lblEmployeeOne"
        Me.lblEmployeeOne.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployeeOne.TabIndex = 13
        Me.lblEmployeeOne.Text = "Employee 1"
        '
        'lblEmployeeTwo
        '
        Me.lblEmployeeTwo.AutoSize = True
        Me.lblEmployeeTwo.Location = New System.Drawing.Point(228, 111)
        Me.lblEmployeeTwo.Name = "lblEmployeeTwo"
        Me.lblEmployeeTwo.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployeeTwo.TabIndex = 14
        Me.lblEmployeeTwo.Text = "Employee 2"
        '
        'lblEmployeeThree
        '
        Me.lblEmployeeThree.AutoSize = True
        Me.lblEmployeeThree.Location = New System.Drawing.Point(387, 111)
        Me.lblEmployeeThree.Name = "lblEmployeeThree"
        Me.lblEmployeeThree.Size = New System.Drawing.Size(82, 17)
        Me.lblEmployeeThree.TabIndex = 15
        Me.lblEmployeeThree.Text = "Employee 3"
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(531, 503)
        Me.Controls.Add(Me.lblEmployeeThree)
        Me.Controls.Add(Me.lblEmployeeTwo)
        Me.Controls.Add(Me.lblEmployeeOne)
        Me.Controls.Add(Me.lblAverageTotal)
        Me.Controls.Add(Me.lblAverageThree)
        Me.Controls.Add(Me.lblAverageTwo)
        Me.Controls.Add(Me.lblAverageOne)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtEmployeeThree)
        Me.Controls.Add(Me.txtEmployeeTwo)
        Me.Controls.Add(Me.txtEmployeeOne)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmployeeOne As TextBox
    Friend WithEvents txtEmployeeTwo As TextBox
    Friend WithEvents txtEmployeeThree As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblAverageOne As Label
    Friend WithEvents lblAverageTwo As Label
    Friend WithEvents lblAverageThree As Label
    Friend WithEvents lblAverageTotal As Label
    Friend WithEvents lblEmployeeOne As Label
    Friend WithEvents lblEmployeeTwo As Label
    Friend WithEvents lblEmployeeThree As Label
    Friend WithEvents ttpAverageUnitsShippedTips As ToolTip
End Class
