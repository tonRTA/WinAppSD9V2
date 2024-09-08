Imports System.Windows.Forms
Public Class clsForm
    Dim OldColor As Color
    Public Sub doSet(ByVal parentCtr As Control)
        Dim ctr As Control
        For Each ctr In parentCtr.Controls
            If TypeOf ctr Is TextBox Or TypeOf ctr Is ComboBox Or TypeOf ctr Is MaskedTextBox Then
                AddHandler ctr.LostFocus, AddressOf meLostFocus
                AddHandler ctr.GotFocus, AddressOf meGotFocus
                doSet(ctr)
            End If
        Next
    End Sub
    '
    Public Sub doClearTextbox(ByVal parentCtr As Control)
        Dim ctr As Control
        For Each ctr In parentCtr.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = String.Empty
                doClearTextbox(ctr)
            ElseIf TypeOf ctr Is MaskedTextBox Then
                ctr.Text = ""
                doClearTextbox(ctr)
            End If
        Next
    End Sub
    Private Sub meLostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, Control).BackColor = OldColor
    End Sub
    Private Sub meGotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        OldColor = DirectCast(sender, Control).BackColor
        DirectCast(sender, Control).BackColor = Color.DarkKhaki
        If TypeOf (sender) Is TextBox Then
            DirectCast(sender, TextBox).SelectAll()
        ElseIf TypeOf (sender) Is MaskedTextBox Then
            DirectCast(sender, MaskedTextBox).SelectAll()
        End If
    End Sub
End Class
