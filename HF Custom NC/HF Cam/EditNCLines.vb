Imports System.IO

Public Class frmEditNCLines
    Private Sub btnNCLineOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNCLineOk.Click
        Dim strTitle As String = frmEnvironment.lstCustomMenu.SelectedIndex
        Dim Value As String = rtbNcLines.Text




    End Sub

    Private Sub btnNCLineCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNCLineCancel.Click
        Close()
    End Sub
End Class