Imports System.Data.SqlClient
Public Class Form2
    Dim sSQL As String
    Dim x As Integer
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Call GetSchool()

    End Sub

    Sub GetSchool()
        ' Add any initialization after the InitializeComponent() call.
        cbSchool.DataSource = Nothing
        cbSchool.Items.Clear()
        FillCombobox("select UserName,FullName From [dbo].[User] where ID >15", cbSchool)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim dt = getDatatable("select * from ShowManQuery where SchoolName='" & cbSchool.SelectedValue & "' ORDER by PK asc")
        If dt.Rows.Count = 0 Then
            gvMan.DataSource = Nothing
            Exit Sub
        End If
        gvMan.AutoGenerateColumns = False
        gvMan.DataSource = dt

        Dim i = 0
        For Each row In gvMan.Rows
            gvMan.Rows(i).HeaderCell.Value = (1 + i).ToString : i += 1
        Next
        Me.Text = "รายชื่อนักศึกษาวิชาทหาร "
    End Sub

    Private Sub gvMan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvMan.CellContentClick
        If e.ColumnIndex.Equals(5) Then

            'Me.Text = "รายชื่อนักศึกษาวิชาทหาร " & xIndex
            Using frm As New Form1(Me.gvMan.CurrentRow.Cells("PK").Value.ToString.Trim())
                frm.xIndex = Me.gvMan.CurrentRow.Index
                If frm.ShowDialog.Equals(DialogResult.OK) Then
                    Me.btnSearch.PerformClick()
                End If
            End Using
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using frm As New Form1(0)
            frm.xIndex = gvMan.Rows.Count + 1
            If frm.ShowDialog.Equals(DialogResult.OK) Then
                Me.btnSearch.PerformClick()
            End If
        End Using
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetSchool()
    End Sub

    Private Sub gvMan_KeyDown(sender As Object, e As KeyEventArgs) Handles gvMan.KeyDown
        '///
        Select Case e.KeyCode
            Case Keys.Up
                Me.gvMan.Rows(My.Settings.xIndex - 1).Selected = True
            Case Keys.Down
                Me.gvMan.Rows(My.Settings.xIndex + 1).Selected = True
            Case Keys.Enter
                Using frm As New Form1(Me.gvMan.CurrentRow.Cells("PK").Value.ToString.Trim())
                    frm.xIndex = Me.gvMan.CurrentRow.Index
                    If frm.ShowDialog.Equals(DialogResult.OK) Then
                        Me.btnSearch.PerformClick()
                    End If
                End Using
        End Select

    End Sub

    Private Sub gvMan_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gvMan.DataBindingComplete
        On Error Resume Next
        gvMan.ClearSelection()
        'gvMan.CurrentCell.Selected = False
        If gvMan.Rows.Count > 0 Then
            gvMan.CurrentCell = gvMan.Rows(My.Settings.xIndex).Cells(0)
            gvMan.Rows(My.Settings.xIndex).Selected = True
            gvMan.Select()
        End If
    End Sub

End Class