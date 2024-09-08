Imports System.Data.SqlClient

Module modMain
    Public Const SQLConnectionString = "Data Source=202.139.197.171;Initial Catalog=dbMan;User ID=sa;Password=64&niTv4;"


    Public Function getDatatable(ByVal strSQL As String) As DataTable
        On Error GoTo RAE
        Using db As New SqlConnection(SQLConnectionString)
            Dim DA As New SqlDataAdapter(strSQL, db)
            Dim DS As New DataSet
            DA.Fill(DS)
            Return DS.Tables(0)
        End Using
RAE:
        MsgBox(Err.Description)
        Exit Function
    End Function

    Public Sub FillCombobox(ByVal sSQL As String, ByVal Cbo As ComboBox)
        Cbo.DataSource = Nothing
        Cbo.Items.Clear()
        Dim DT As DataTable = getDatatable(sSQL)
        Cbo.ValueMember = DT.Columns(0).ToString
        Cbo.DisplayMember = DT.Columns(1).ToString
        Cbo.DataSource = DT
        Cbo.SelectedIndex = 0
    End Sub

End Module

