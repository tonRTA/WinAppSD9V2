Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection

Public Class Form1
    Public ActionMode As String
    Dim transaction As SqlTransaction
    Dim sSQL As String = String.Empty
    Dim m As New clsForm
    Dim x As Integer
    Public xIndex As Integer
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim dob = CDate(mskDOB.Text).ToString("M/d/yyyy", New System.Globalization.CultureInfo("en-US"))

        Using dbCon As New SqlConnection(SQLConnectionString)
            dbCon.Open()
            Try
                transaction = dbCon.BeginTransaction
                Select Case ActionMode
                    Case "ADD" : sSQL = "InsertMan"
                    Case "EDIT" : sSQL = "UpdateMan"
                End Select
                Using cmd As New SqlCommand(sSQL, dbCon, transaction)
                    If ActionMode = "EDIT" Then
                        cmd.Parameters.AddWithValue("@PK", x)
                    End If
                    cmd.Parameters.Add(New SqlParameter("@PID", txtPID.Text))
                    cmd.Parameters.Add(New SqlParameter("@FirstName", txtFirstName.Text))
                    cmd.Parameters.Add(New SqlParameter("@LastName", txtLastName.Text))
                    cmd.Parameters.Add(New SqlParameter("@DOB", dob))
                    cmd.Parameters.Add(New SqlParameter("@scar", cbsc.Text))
                    cmd.Parameters.Add(New SqlParameter("@M_villar", txtM_villar.Text))
                    cmd.Parameters.Add(New SqlParameter("@M_add", txtM_addr.Text))
                    cmd.Parameters.Add(New SqlParameter("@M_mo", txtM_moo.Text))
                    cmd.Parameters.Add(New SqlParameter("@M_Tambon", cbTT.SelectedValue))
                    cmd.Parameters.Add(New SqlParameter("@M_Amphoer", cbAA.SelectedValue))
                    cmd.Parameters.Add(New SqlParameter("@M_Province", cbCC.SelectedValue))
                    cmd.Parameters.Add(New SqlParameter("@FaName", txtFaName.Text))
                    cmd.Parameters.Add(New SqlParameter("@FalName", txtFalName.Text))
                    cmd.Parameters.Add(New SqlParameter("@MaName", txtMaName.Text))
                    cmd.Parameters.Add(New SqlParameter("@MalName", txtMalName.Text))
                    cmd.Parameters.Add(New SqlParameter("@Edu", txtEdu.Text))
                    cmd.Parameters.Add(New SqlParameter("@School", cbSch.SelectedValue))
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                    transaction.Commit()
                    'ClearForm()
                    Alert(ActionMode & " Success !")
                End Using
            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Error : " & ex.Message, vbCritical, "Response")
            End Try
        End Using
        My.Settings.xIndex = xIndex
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        m.doSet(Me)
        ' Dim sSQL As String
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
            e.SuppressKeyPress = True
        End If
        'If e.KeyCode = Keys.Enter Then SendKeys.Send("{TAB}")
        If e.KeyCode = Keys.Up Then SendKeys.Send("+{TAB}")
        'If e.KeyCode = Keys.F8 Then Call btnSave_Click(sender, e)
    End Sub

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave
        Me.txtFalName.Text = Me.txtLastName.Text.Trim
        Me.txtMalName.Text = Me.txtLastName.Text.Trim
    End Sub

    Sub ClearForm()
        txtPID.Clear()
        mskDOB.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtFaName.Clear()
        txtMaName.Clear()
        txtFalName.Clear()
        txtMalName.Clear()
        cbsc.SelectedIndex = 0
        txtPID.Select()
    End Sub
    Sub New(PK As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        'GetProvince()
        FillCombobox("GetProvince", cbCC)
        Dim edu As New AutoCompleteStringCollection()
        edu.AddRange((New String() {"ชั้นมัธยมศึกษาปีที่ 6", "ประกาศนียบัตรวิชาชีพ"}))

        txtEdu.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtEdu.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtEdu.AutoCompleteCustomSource = edu
        x = PK
        ' Add any initialization after the InitializeComponent() call.
        'Me.Text = Me.Text & PK

        Call FillCombobox("SELECT sc_id,sc FROM dbSC ORDER BY sc asc", cbsc)
        Call FillCombobox("select UserName,FullName From [dbo].[User];", cbSch)
        If PK = 0 Then
            ActionMode = "ADD"
        ElseIf PK <> 0 Then
            ActionMode = "EDIT"
            Call GetMan(PK)
        End If


    End Sub

    Sub GetMan(PK As Integer)
        Dim dt As DataTable = getDatatable("exec GetMan " & PK & "")
        Me.txtPID.Text = dt(0)("PID").ToString
        Me.txtFirstName.Text = dt(0)("FirstName").ToString
        Me.txtLastName.Text = dt(0)("LastName").ToString
        Me.mskDOB.Text = CDate(dt(0)("DOB")).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("th-TH"))
        Me.cbsc.Text = dt(0)("Scar").ToString
        Me.txtM_villar.Text = dt(0)("M_Villar").ToString
        Me.txtM_addr.Text = dt(0)("M_add").ToString
        Me.txtM_moo.Text = dt(0)("M_mo").ToString
        If Not String.IsNullOrWhiteSpace(dt(0)("Province").ToString) Then
            cbCC.SelectedValue = dt(0)("Province").ToString
        End If
        If Not String.IsNullOrWhiteSpace(dt(0)("District").ToString) Then
            cbAA.SelectedValue = dt(0)("District").ToString
        End If
        If Not String.IsNullOrWhiteSpace(dt(0)("District").ToString) Then
            cbTT.SelectedValue = dt(0)("Subdistrict").ToString
        End If

        Me.txtFaName.Text = dt(0)("FaName").ToString
        Me.txtFalName.Text = dt(0)("Fal_Name").ToString
        Me.txtMaName.Text = dt(0)("MaName").ToString
        Me.txtMalName.Text = dt(0)("Mal_Name").ToString
        Me.txtEdu.Text = dt(0)("Edu_Level").ToString
        Me.cbSch.SelectedValue = dt(0)("SchoolName").ToString
    End Sub

    Private Sub cbCC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCC.SelectedIndexChanged
        'GetDistrict(cbCC.SelectedValue)
        'cbTT.Text = "--โปรดเลือก--"
        FillCombobox("GetDistrict " & cbCC.SelectedValue & "", cbAA)
    End Sub

    Private Sub cbAA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAA.SelectedIndexChanged
        'GetSubDistrict(cbAA.SelectedValue)
        If cbAA.SelectedValue IsNot Nothing Then
            FillCombobox("GetSubDistrict " & cbAA.SelectedValue & "", cbTT)
        End If
    End Sub

    Private Sub txtPID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPID.KeyPress
        e.Handled = CheckDigitOnly(Asc(e.KeyChar))
    End Sub

    Private Sub txtPID_Leave(sender As Object, e As EventArgs) Handles txtPID.Leave
        If CheckBox1.Checked Then
            If Not CheckIDCardNumber(Me.txtPID.Text) Then
                MsgBox("เลขบัตรประชาชน " & txtPID.Text & " ไม่ถูกต้อง", vbOKOnly + MessageBoxIcon.Error, "รายงานความผิดพลาด")
                HiLightTexttox(txtPID)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.xIndex = xIndex
        My.Settings.Save()
    End Sub
End Class
