<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileHorizontally = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileVertically = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWindowTextEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowCarInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowAverageUnitsShipped = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHideToolbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowToolbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTools = New System.Windows.Forms.ToolStrip()
        Me.btnToolStripTextEditor = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripCarInventory = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripAverageUnitsShipped = New System.Windows.Forms.ToolStripButton()
        Me.ttpMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMainMenu.SuspendLayout()
        Me.tsTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindow, Me.mnuHelp})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(1120, 28)
        Me.mnuMainMenu.TabIndex = 1
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.ToolStripSeparator2, Me.mnuFileSave, Me.mnuFileSaveAs, Me.ToolStripSeparator3, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Image = Global.LabSix.My.Resources.Resources._new
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(173, 26)
        Me.mnuFileNew.Text = "&New"
        Me.mnuFileNew.ToolTipText = "Clear the current window (text editor only)"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Image = Global.LabSix.My.Resources.Resources.open
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(173, 26)
        Me.mnuFileOpen.Text = "&Open"
        Me.mnuFileOpen.ToolTipText = "Open a file (text editor only)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Image = Global.LabSix.My.Resources.Resources.save
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(173, 26)
        Me.mnuFileSave.Text = "&Save"
        Me.mnuFileSave.ToolTipText = "Save the current file (text editor only)"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(173, 26)
        Me.mnuFileSaveAs.Text = "Save &As..."
        Me.mnuFileSaveAs.ToolTipText = "Save the current file as something else (text editor only)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(170, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(173, 26)
        Me.mnuFileExit.Text = "E&xit"
        Me.mnuFileExit.ToolTipText = "Close the currently selected window"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(47, 24)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Image = Global.LabSix.My.Resources.Resources.cut1
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(169, 26)
        Me.mnuEditCut.Text = "Cu&t"
        Me.mnuEditCut.ToolTipText = "Cut the selected text (text editor only)"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Image = Global.LabSix.My.Resources.Resources.copy
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(169, 26)
        Me.mnuEditCopy.Text = "&Copy"
        Me.mnuEditCopy.ToolTipText = "Copy the selected text (text editor only)"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Image = Global.LabSix.My.Resources.Resources.paste
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(169, 26)
        Me.mnuEditPaste.Text = "&Paste"
        Me.mnuEditPaste.ToolTipText = "Paste any copied text (text editor only)"
        '
        'mnuWindow
        '
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowCascade, Me.mnuWindowTileHorizontally, Me.mnuWindowTileVertically, Me.ToolStripSeparator1, Me.mnuWindowTextEditor, Me.mnuWindowCarInventory, Me.mnuWindowAverageUnitsShipped, Me.ToolStripSeparator4, Me.mnuHideToolbar, Me.mnuShowToolbar})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(76, 24)
        Me.mnuWindow.Text = "&Window"
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Name = "mnuWindowCascade"
        Me.mnuWindowCascade.Size = New System.Drawing.Size(269, 26)
        Me.mnuWindowCascade.Text = "&Cascade"
        Me.mnuWindowCascade.ToolTipText = "Cascade the opened windows"
        '
        'mnuWindowTileHorizontally
        '
        Me.mnuWindowTileHorizontally.Name = "mnuWindowTileHorizontally"
        Me.mnuWindowTileHorizontally.Size = New System.Drawing.Size(269, 26)
        Me.mnuWindowTileHorizontally.Text = "Tile Hori&zontally"
        Me.mnuWindowTileHorizontally.ToolTipText = "Place the opened windows side by side horizontally"
        '
        'mnuWindowTileVertically
        '
        Me.mnuWindowTileVertically.Name = "mnuWindowTileVertically"
        Me.mnuWindowTileVertically.Size = New System.Drawing.Size(269, 26)
        Me.mnuWindowTileVertically.Text = "Tile &Vertically"
        Me.mnuWindowTileVertically.ToolTipText = "Place the opened windows side by side vertically"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(266, 6)
        '
        'mnuWindowTextEditor
        '
        Me.mnuWindowTextEditor.Image = Global.LabSix.My.Resources.Resources.notepad
        Me.mnuWindowTextEditor.Name = "mnuWindowTextEditor"
        Me.mnuWindowTextEditor.Size = New System.Drawing.Size(269, 26)
        Me.mnuWindowTextEditor.Text = "New Text &Editor"
        Me.mnuWindowTextEditor.ToolTipText = "Open a new text editor window"
        '
        'mnuWindowCarInventory
        '
        Me.mnuWindowCarInventory.Image = Global.LabSix.My.Resources.Resources.car
        Me.mnuWindowCarInventory.Name = "mnuWindowCarInventory"
        Me.mnuWindowCarInventory.Size = New System.Drawing.Size(269, 26)
        Me.mnuWindowCarInventory.Text = "New Car &Inventory"
        Me.mnuWindowCarInventory.ToolTipText = "Open a new car inventory window"
        '
        'mnuWindowAverageUnitsShipped
        '
        Me.mnuWindowAverageUnitsShipped.Image = Global.LabSix.My.Resources.Resources.calculator
        Me.mnuWindowAverageUnitsShipped.Name = "mnuWindowAverageUnitsShipped"
        Me.mnuWindowAverageUnitsShipped.Size = New System.Drawing.Size(269, 26)
        Me.mnuWindowAverageUnitsShipped.Text = "New Average &Units Shipped"
        Me.mnuWindowAverageUnitsShipped.ToolTipText = "Open the average units shipped window"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(266, 6)
        '
        'mnuHideToolbar
        '
        Me.mnuHideToolbar.Name = "mnuHideToolbar"
        Me.mnuHideToolbar.Size = New System.Drawing.Size(269, 26)
        Me.mnuHideToolbar.Text = "&Hide Toolbar"
        Me.mnuHideToolbar.ToolTipText = "Hide the toolbar"
        '
        'mnuShowToolbar
        '
        Me.mnuShowToolbar.Name = "mnuShowToolbar"
        Me.mnuShowToolbar.Size = New System.Drawing.Size(269, 26)
        Me.mnuShowToolbar.Text = "&Show Toolbar"
        Me.mnuShowToolbar.ToolTipText = "Show the toolbar"
        Me.mnuShowToolbar.Visible = False
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "About the creation of this application"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(125, 26)
        Me.mnuHelpAbout.Text = "&About"
        '
        'tsTools
        '
        Me.tsTools.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolStripTextEditor, Me.btnToolStripCarInventory, Me.btnToolStripAverageUnitsShipped})
        Me.tsTools.Location = New System.Drawing.Point(0, 28)
        Me.tsTools.Name = "tsTools"
        Me.tsTools.Size = New System.Drawing.Size(1120, 27)
        Me.tsTools.TabIndex = 3
        Me.tsTools.Text = "ToolStrip1"
        '
        'btnToolStripTextEditor
        '
        Me.btnToolStripTextEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripTextEditor.Image = Global.LabSix.My.Resources.Resources.notepad
        Me.btnToolStripTextEditor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripTextEditor.Name = "btnToolStripTextEditor"
        Me.btnToolStripTextEditor.Size = New System.Drawing.Size(24, 24)
        Me.btnToolStripTextEditor.Text = "Open New Text Editor"
        '
        'btnToolStripCarInventory
        '
        Me.btnToolStripCarInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripCarInventory.Image = Global.LabSix.My.Resources.Resources.car
        Me.btnToolStripCarInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripCarInventory.Name = "btnToolStripCarInventory"
        Me.btnToolStripCarInventory.Size = New System.Drawing.Size(24, 24)
        Me.btnToolStripCarInventory.Text = "Open New Car Inventory"
        '
        'btnToolStripAverageUnitsShipped
        '
        Me.btnToolStripAverageUnitsShipped.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripAverageUnitsShipped.Image = Global.LabSix.My.Resources.Resources.calculator
        Me.btnToolStripAverageUnitsShipped.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripAverageUnitsShipped.Name = "btnToolStripAverageUnitsShipped"
        Me.btnToolStripAverageUnitsShipped.Size = New System.Drawing.Size(24, 24)
        Me.btnToolStripAverageUnitsShipped.Text = "Open Average Units Shipped"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 676)
        Me.Controls.Add(Me.tsTools)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Text Editor"
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.tsTools.ResumeLayout(False)
        Me.tsTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMainMenu As MenuStrip
    Friend WithEvents mnuWindow As ToolStripMenuItem
    Friend WithEvents mnuWindowCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowTileHorizontally As ToolStripMenuItem
    Friend WithEvents mnuWindowTileVertically As ToolStripMenuItem
    Friend WithEvents mnuWindowTextEditor As ToolStripMenuItem
    Friend WithEvents mnuWindowCarInventory As ToolStripMenuItem
    Friend WithEvents tsTools As ToolStrip
    Friend WithEvents btnToolStripTextEditor As ToolStripButton
    Friend WithEvents btnToolStripCarInventory As ToolStripButton
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuHideToolbar As ToolStripMenuItem
    Friend WithEvents mnuShowToolbar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ttpMain As ToolTip
    Friend WithEvents btnToolStripAverageUnitsShipped As ToolStripButton
    Friend WithEvents mnuWindowAverageUnitsShipped As ToolStripMenuItem
End Class
