Module modFunction
    '//MessageBox
    Public Function ConFirm(ByVal Message As String, Optional ByVal Title As String = "ยืนยัน") As MsgBoxResult
        Return MsgBox(Message, MsgBoxStyle.Question + MsgBoxStyle.YesNo, Title)
    End Function

    Public Function Alert(ByVal Message As String, Optional ByVal Icon As MsgBoxStyle = MsgBoxStyle.Information,
        Optional ByVal Title As String = "รายงาน")
        Return MsgBox(Message, Icon, Title)
    End Function

    Public Function VerifyThaiIdCard(PID As [String]) As [Boolean]
        'ตรวจสอบว่าทุก ๆ ตัวอักษรเป็นตัวเลข
        'If PID.ToCharArray().All(Function(c) Char.IsNumber(c)) = False Then
        '    Return False
        'End If
        'ตรวจสอบว่าข้อมูลมีทั้งหมด 13 ตัวอักษร
        If PID.Trim().Length <> 13 Then
            Return False
        End If

        Dim sumValue As Integer = 0
        For i As Integer = 0 To PID.Length - 2
            sumValue += Integer.Parse(PID(i).ToString()) * (13 - i)
        Next
        Dim v As Integer = 11 - (sumValue Mod 11)
        Return PID(12).ToString() = v.ToString()
    End Function

    Function NumTH(MyText As Object) As String 'แปลงเลขอารบิค เป็นเลขไทย
        On Error GoTo ERR_TH
        If Len(MyText) > 0 Then
            Dim L As String, R As String, N As String
            Dim I As Single
            For I = 1 To Len(MyText)
                N = Mid(MyText, I, 1)
                For x = 0 To 9
                    N = N.Replace(Chr(48 + x), Chr(240 + x))
                Next
                L = Microsoft.VisualBasic.Left(MyText, I - 1)
                R = Microsoft.VisualBasic.Right(MyText, Len(MyText) - I)
                If I > 0 Then MyText = L + N + R
            Next I
            NumTH = MyText
        Else
            NumTH = ""
        End If
        Exit Function
ERR_TH:
        NumTH = ""
    End Function

    Function CheckDigitOnly(ByVal index As Integer) As Boolean
        Select Case index
            Case 48 To 57 ' Numeric 0 - 9
                CheckDigitOnly = False
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
                CheckDigitOnly = False
            Case Else
                CheckDigitOnly = True
        End Select
    End Function

    Public Sub HiLightTexttox(ByVal txt As TextBox)
        txt.Focus()
        txt.SelectAll()
    End Sub

    Public Function CheckIDCardNumber(ByVal IDCardNumber As String) As Boolean
        Dim Sum As Integer
        Dim Count As Integer
        ' ไม่มีการป้อนข้อมูล ก็ให้ออกจากโปรแกรมย่อยไปเหอะ
        'If IDCardNumber = "" Or Len(IDCardNumber) = 0 Then Exit Function
        ' ความยาวต้องเท่ากับ 13 หลัก
        'If Len(IDCardNumber) < 13 Then
        '    MsgBox("กรุณากรอกหมายเลขบัตรประชาชนให้ครบทั้ง 13 หลักด้วย.", vbOKOnly + vbExclamation, "รายงานความผิดพลาด")
        '    Exit Function
        'End If
        ' หาผลรวมตั้งแต่หลักที่ 1 ไปจนถึงหลักที่ 12
        'If IDCardNumber = "" Then Exit Function
        Sum = 0
        For Count = 1 To 12
            Sum = Sum + Val(Mid(IDCardNumber, Count, 1)) * (14 - Count)
        Next
        ' เปรียบเทียบค่าที่ได้กับหลักที่ 13
        If Microsoft.VisualBasic.Right(IDCardNumber, 1) = Microsoft.VisualBasic.Right(Str(11 - (Sum Mod 11)), 1) Then
            'MessageBox.Show("หมายเลขบัตรประชาชน " & txtIDcard.Text & " ถูกต้อง.", "รายงานการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckIDCardNumber = True
        Else
            'MessageBox.Show("หมายเลขบัตรประชาชน " & txtIDcard.Text & " ไม่ถูกต้อง.", "รายงานการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CheckIDCardNumber = False
        End If
    End Function
End Module
