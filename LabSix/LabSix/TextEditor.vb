' Name: Shaheed Ramjohn
' Date: April 5, 2020
' Description: Create a text editor

Option Strict On
Imports System.IO

Public Class TextEditor

#Region "Variable Declarations"

    Dim isOk As Boolean = False
    Dim hasTextChanged As Boolean = False
    Dim openFilePath As String = String.Empty
    Dim saveFilePath As String = String.Empty

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' Exit the application
    ''' </summary>
    Friend Sub FileExit()

        ConfirmClose()

        ' Continue if it's okay with the user
        If isOk = True Then

            Me.Close()

        End If

    End Sub

    ''' <summary>
    ''' Create a new file
    ''' </summary>
    Friend Sub FileNew()

        ConfirmClose()

        ' Continue if it's okay with the user
        If isOk = True Then

            isOk = False
            txtTextEditor.Clear()
            openFilePath = String.Empty
            hasTextChanged = False

        End If


    End Sub

    ''' <summary>
    ''' Open an existing file
    ''' </summary>
    Friend Sub FileOpen()

        Dim openFile As FileStream
        Dim fileReader As StreamReader

        ConfirmClose()

        ' Continue if it's okay with the user
        If isOk = True Then

            ' Open a file if the user selected one
            If opdOpen.ShowDialog() = DialogResult.OK Then

                openFilePath = opdOpen.FileName

                openFile = New FileStream(openFilePath, FileMode.Open, FileAccess.Read)
                fileReader = New StreamReader(openFile)

                txtTextEditor.Text = fileReader.ReadToEnd

                fileReader.Close()

            End If

        End If

    End Sub

    ''' <summary>
    ''' Save a copy of the file
    ''' </summary>
    Friend Sub FileSaveAs()

        sfdSaveAs.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*"

        ' Save the file in the place that the user chooses
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then

            saveFilePath = sfdSaveAs.FileName

            SaveFile(saveFilePath)

        End If

    End Sub

    ''' <summary>
    ''' Save the current file
    ''' </summary>
    Friend Sub FileSave()

        ' If there is no save file path, it works like Save As...
        If saveFilePath = String.Empty Then

            FileSaveAs()

        Else

            SaveFile(saveFilePath)

        End If

    End Sub

    ''' <summary>
    ''' Checks to see if the text has changed
    ''' </summary>
    Private Sub txtTextEditor_TextChanged(sender As Object, e As EventArgs) Handles txtTextEditor.TextChanged

        hasTextChanged = True

    End Sub

#End Region

#Region "Methods"

    ''' <summary>
    ''' Save the file
    ''' </summary>
    ''' <param name="path">The save file path</param>
    Sub SaveFile(path As String)

        Dim fileWriter As New StreamWriter(path)
        fileWriter.Write(txtTextEditor.Text)
        fileWriter.Close()

    End Sub

    ''' <summary>
    ''' Copy the text that the user selected
    ''' </summary>
    Sub CopyText()

        Clipboard.SetText(txtTextEditor.SelectedText)

    End Sub

    ''' <summary>
    ''' Cut the text that the user selected
    ''' </summary>
    Sub CutText()

        CopyText()
        txtTextEditor.SelectedText = String.Empty

    End Sub

    ''' <summary>
    ''' Paste the copied text where the user chooses
    ''' </summary>
    Sub PasteText()

        txtTextEditor.SelectedText = Clipboard.GetText()

    End Sub

    ''' <summary>
    ''' Make sure the user is okay with closing the current file
    ''' </summary>
    Sub ConfirmClose()

        If Not txtTextEditor.Text = String.Empty Or hasTextChanged = True Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to close this file?" & vbCrLf & vbCrLf & "Everything not saved will be lost.", "Warning!", MessageBoxButtons.OKCancel)

            If result = DialogResult.OK Then

                isOk = True
                hasTextChanged = False

            ElseIf result = DialogResult.Cancel Then

                isOk = False

            End If

        Else

            isOk = True

        End If

    End Sub

#End Region

End Class
