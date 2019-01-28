Imports System.Net.Mail
Public Class frmEnvironment

    Dim strEmailAddress As String
    Dim strCustomMenu As String
    Dim SubMenu = " "
    Private Sub frmEnvironment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim frmEditNCLines As New frmEditNCLines

        If lstCustomMenu.SelectedIndex = -1 Then
            MessageBox.Show("Please make a selection")
        Else
            Dim strTitle As String = lstCustomMenu.SelectedIndex
            frmEditNCLines.Show()
        End If

    End Sub
    Private Sub btnEnvironmentAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvironmentAdd.Click

        strEmailAddress = txtBoxEmailAddress.Text  'setting text box entry as EmailAddress String

        If txtBoxEmailAddress.Text = "" Then  'Verify the text box isn't empty
            MessageBox.Show("Please enter a valid email address")
            txtBoxEmailAddress.Clear()
        Else
            Try
                Dim testAddress = New MailAddress(strEmailAddress)
                lstBoxAddRemoveEmailAddresses.Items.Add(strEmailAddress)  'Check format of entry
                txtBoxEmailAddress.Clear()
            Catch ex As FormatException
                MessageBox.Show("Please enter a valid email address")
                txtBoxEmailAddress.Clear()
            End Try
        End If
    End Sub
    Private Sub btnEnvironmentRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvironmentRemove.Click
        If lstBoxAddRemoveEmailAddresses.SelectedIndex = -1 Then
            MessageBox.Show("Please make a selection")
        Else
            lstBoxAddRemoveEmailAddresses.Items.Remove(lstBoxAddRemoveEmailAddresses.SelectedItem)
        End If

    End Sub
    Private Sub btnEnvironmentBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvironmentBrowse.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Path = My.Computer.FileSystem.GetParentPath(OpenFileDialog1.FileName)
            Dim File = My.Computer.FileSystem.GetName(OpenFileDialog1.FileName)
            txtBoxSetCadFilePath.Text = Path + "\" + File
        End If
    End Sub

    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        strCustomMenu = txtBoxCustomMenu.Text

        If txtBoxCustomMenu.Text = "" Then
            MessageBox.Show("Invalid Entry")
            txtBoxCustomMenu.Clear()
        Else
            If chkSubmenu.Checked Then
                lstCustomMenu.Items.Add(strCustomMenu)
                txtBoxCustomMenu.Clear()
            Else
                lstCustomMenu.Items.Add(SubMenu + strCustomMenu)
                txtBoxCustomMenu.Clear()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lstCustomMenu.SelectedIndex = -1 Then
            MessageBox.Show("Please make a selection")
        Else
            lstCustomMenu.Items.Remove(lstCustomMenu.SelectedItem)
        End If
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim i As Integer
        i = lstCustomMenu.SelectedIndex

        If lstCustomMenu.SelectedIndex = -1 Then
            MessageBox.Show("Please make a selection")
        Else
            Dim item As String
            item = lstCustomMenu.SelectedItem.ToString

            If i > 0 Then
                lstCustomMenu.Items.RemoveAt(i)
                lstCustomMenu.Items.Insert(i - 1, item)
                lstCustomMenu.SetSelected(i - 1, True)
            End If
        End If

    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim i As Integer
        i = lstCustomMenu.SelectedIndex

        If lstCustomMenu.SelectedIndex = -1 Then
            MessageBox.Show("Please make a selection")
        Else
            Dim item As String
            item = lstCustomMenu.SelectedItem.ToString

            If i < lstCustomMenu.Items.Count - 1 Then
                lstCustomMenu.Items.RemoveAt(i)
                lstCustomMenu.Items.Insert(i + 1, item)
                lstCustomMenu.SetSelected(i + 1, True)
            End If
        End If
    End Sub
    Private Sub btnEnvironmentOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvironmentOk.Click

        txtBoxSetCadFilePath.Text = My.Settings.CadPath
        My.Settings.Save()
        Close()

    End Sub
End Class