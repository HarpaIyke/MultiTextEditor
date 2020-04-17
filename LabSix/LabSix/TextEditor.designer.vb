<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditor))
        Me.txtTextEditor = New System.Windows.Forms.TextBox()
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.ttpTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtTextEditor
        '
        Me.txtTextEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTextEditor.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.txtTextEditor.Location = New System.Drawing.Point(0, 0)
        Me.txtTextEditor.Multiline = True
        Me.txtTextEditor.Name = "txtTextEditor"
        Me.txtTextEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTextEditor.Size = New System.Drawing.Size(800, 450)
        Me.txtTextEditor.TabIndex = 1
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTextEditor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTextEditor As TextBox
    Friend WithEvents opdOpen As OpenFileDialog
    Friend WithEvents sfdSaveAs As SaveFileDialog
    Friend WithEvents ttpTextEditor As ToolTip
End Class
