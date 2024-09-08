Public Class mdiMain
    Private Sub mnuForm2_Click(sender As Object, e As EventArgs) Handles mnuForm2.Click
        Dim F As New Form2
        F.MdiParent = Me
        F.BringToFront()
        F.Show()
    End Sub
End Class