Public Class frmLineNumbering

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStartNumb.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLNStartNumb.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnLNOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLNOk.Click
        Dim BlockNumb As String = txtLNStartTxt.Text
        Dim Increment As Integer = txtLNIncrement.Text
        Dim Start As Integer = txtLNStartNumb.Text


        For Each line As String In frmHfCam.NcTextBox.Lines
            If line.Length >= 1 Then
                Dim firstLetter As Char = line.Substring(0, 1)

                If firstLetter = BlockNumb Then
                    MessageBox.Show("test")
                End If
            End If
        Next
    End Sub

    Private Sub btnLNCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLNCancel.Click
        Close()
    End Sub
End Class