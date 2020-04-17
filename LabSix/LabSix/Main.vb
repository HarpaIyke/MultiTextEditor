' Name: Shaheed Ramjohn
' Co-Author: Kyle Chapman
' Date: April 17, 2020
' Description: Create an MDI parent form with children consisting of previous labs

Option Strict On

Public Class frmMain

#Region "Tool Strip"

    ''' <summary>
    ''' Open the text editor form
    ''' </summary>
    Private Sub btnToolStripTextEditor_Click(sender As Object, e As EventArgs) Handles btnToolStripTextEditor.Click

        Dim myTextEditor As New TextEditor
        myTextEditor.MdiParent = Me
        myTextEditor.Show()

    End Sub

    ''' <summary>
    ''' Open the car inventory form
    ''' </summary>
    Private Sub btnToolStripCarInventory_Click(sender As Object, e As EventArgs) Handles btnToolStripCarInventory.Click

        Dim myCarInventory As New frmCarInventory
        myCarInventory.MdiParent = Me
        myCarInventory.Show()

    End Sub

    ''' <summary>
    ''' Open the average units shipped form
    ''' </summary>
    Private Sub btnToolStripAverageUnitsShipped_Click(sender As Object, e As EventArgs) Handles btnToolStripAverageUnitsShipped.Click

        Dim myAverageUnits As New AverageUnitsShipped
        myAverageUnits.MdiParent = Me
        myAverageUnits.Show()

    End Sub

#End Region

#Region "File"

    ''' <summary>
    ''' Save the current file in the text editor
    ''' </summary>
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click

        If TypeOf (ActiveMdiChild) Is TextEditor Then

            CType(ActiveMdiChild, TextEditor).FileSave()

        Else

            MessageBox.Show("Cannot save selected window!")

        End If

    End Sub

    ''' <summary>
    ''' Save the current file in the text editor as something
    ''' </summary>
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click

        If TypeOf (ActiveMdiChild) Is TextEditor Then

            CType(ActiveMdiChild, TextEditor).FileSaveAs()

        Else

            MessageBox.Show("Cannot save selected window!")

        End If

    End Sub

    ''' <summary>
    ''' Clear the window and treat it as a new file
    ''' </summary>
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click

        If TypeOf (ActiveMdiChild) Is TextEditor Then

            CType(ActiveMdiChild, TextEditor).FileNew()

        Else

            MessageBox.Show("Operation not compatible with selected window!")

        End If

    End Sub

    ''' <summary>
    ''' Open a new file in the text editor
    ''' </summary>
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click

        If TypeOf (ActiveMdiChild) Is TextEditor Then

            CType(ActiveMdiChild, TextEditor).FileOpen()

        Else

            MessageBox.Show("Cannot open file in selected window!")

        End If

    End Sub

    ''' <summary>
    ''' Close the active window, if there are none close the application
    ''' </summary>
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click

        If MdiChildren.Count > 0 Then

            ActiveMdiChild.Close()

        Else

            Me.Close()

        End If

    End Sub

#End Region

#Region "Edit"

    ''' <summary>
    ''' Cut the selected text in the text editor
    ''' </summary>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click

        If TypeOf (ActiveMdiChild) Is TextEditor Then

            CType(ActiveMdiChild, TextEditor).CutText()

        Else

            MessageBox.Show("Canot cut text in the selected window!")

        End If

    End Sub

    ''' <summary>
    ''' Copy the selected text in the text editor
    ''' </summary>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click

        If TypeOf (ActiveMdiChild) Is TextEditor Then

            CType(ActiveMdiChild, TextEditor).CopyText()

        Else

            MessageBox.Show("Cannot copy text in the selected window!")

        End If

    End Sub

    ''' <summary>
    ''' Paste the copied text in the text editor
    ''' </summary>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click

        If TypeOf (ActiveMdiChild) Is TextEditor Then

            CType(ActiveMdiChild, TextEditor).PasteText()

        Else

            MessageBox.Show("Cannot paste text in the selected window!")

        End If

    End Sub

#End Region

#Region "Help"

    ''' <summary>
    ''' Show information about the creation of this application
    ''' </summary>
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click

        MessageBox.Show("By: Shaheed Ramjohn" & vbCrLf & vbCrLf & "NETD 2202" & vbCrLf & vbCrLf & "April 17, 2020", "About")

    End Sub

#End Region

#Region "Window"

    ''' <summary>
    ''' Cascade the opened windows
    ''' </summary>
    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    ''' <summary>
    ''' Place the opened windows side by side horizontally
    ''' </summary>
    Private Sub mnuWindowTileHorizontally_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontally.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    ''' <summary>
    ''' Place the opened windows side by side vertically
    ''' </summary>
    Private Sub mnuWindowTileVertically_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertically.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    ''' <summary>
    ''' Hide the toolbar
    ''' </summary>
    Private Sub mnuHideToolbar_Click(sender As Object, e As EventArgs) Handles mnuHideToolbar.Click

        tsTools.Visible = False
        mnuHideToolbar.Visible = False
        mnuShowToolbar.Visible = True

    End Sub

    ''' <summary>
    ''' Show the toolbar
    ''' </summary>
    Private Sub mnuShowToolbar_Click(sender As Object, e As EventArgs) Handles mnuShowToolbar.Click

        tsTools.Visible = True
        mnuHideToolbar.Visible = True
        mnuShowToolbar.Visible = False

    End Sub

    ''' <summary>
    ''' Open the text editor through the toolbar
    ''' </summary>
    Private Sub mnuWindowTextEditor_Click(sender As Object, e As EventArgs) Handles mnuWindowTextEditor.Click

        btnToolStripTextEditor_Click(sender, e)

    End Sub

    ''' <summary>
    ''' Open the car inventory through the toolbar
    ''' </summary>
    Private Sub mnuWindowCarInventory_Click(sender As Object, e As EventArgs) Handles mnuWindowCarInventory.Click

        btnToolStripCarInventory_Click(sender, e)

    End Sub

    Private Sub mnuWindowAverageUnitsShipped_Click(sender As Object, e As EventArgs) Handles mnuWindowAverageUnitsShipped.Click

        btnToolStripAverageUnitsShipped_Click(sender, e)

    End Sub



#End Region

End Class
