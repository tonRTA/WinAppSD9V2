<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtM_villar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtM_addr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtM_moo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFaName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaName = New System.Windows.Forms.TextBox()
        Me.txtFalName = New System.Windows.Forms.TextBox()
        Me.txtMalName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEdu = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.mskDOB = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbsc = New System.Windows.Forms.ComboBox()
        Me.cbCC = New System.Windows.Forms.ComboBox()
        Me.cbAA = New System.Windows.Forms.ComboBox()
        Me.cbTT = New System.Windows.Forms.ComboBox()
        Me.cbSch = New System.Windows.Forms.ComboBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เลขประจำตัว ปชช"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtFirstName.Location = New System.Drawing.Point(167, 54)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(272, 26)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtLastName.Location = New System.Drawing.Point(511, 54)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(272, 26)
        Me.txtLastName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อตัว"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "วัน เดือน ปี เกิด"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ตำหนิ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ภูมิลำเนา บ้าน"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtM_villar
        '
        Me.txtM_villar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtM_villar.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtM_villar.Location = New System.Drawing.Point(167, 164)
        Me.txtM_villar.Name = "txtM_villar"
        Me.txtM_villar.Size = New System.Drawing.Size(616, 26)
        Me.txtM_villar.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "บ้านเลขที่"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtM_addr
        '
        Me.txtM_addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtM_addr.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtM_addr.Location = New System.Drawing.Point(167, 196)
        Me.txtM_addr.Name = "txtM_addr"
        Me.txtM_addr.Size = New System.Drawing.Size(130, 26)
        Me.txtM_addr.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "อำเภอ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtM_moo
        '
        Me.txtM_moo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtM_moo.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtM_moo.Location = New System.Drawing.Point(360, 196)
        Me.txtM_moo.Name = "txtM_moo"
        Me.txtM_moo.Size = New System.Drawing.Size(79, 26)
        Me.txtM_moo.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "บิดาชื่อ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFaName
        '
        Me.txtFaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFaName.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtFaName.Location = New System.Drawing.Point(167, 280)
        Me.txtFaName.Name = "txtFaName"
        Me.txtFaName.Size = New System.Drawing.Size(272, 26)
        Me.txtFaName.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "มารดาชื่อ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMaName
        '
        Me.txtMaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaName.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtMaName.Location = New System.Drawing.Point(167, 312)
        Me.txtMaName.Name = "txtMaName"
        Me.txtMaName.Size = New System.Drawing.Size(272, 26)
        Me.txtMaName.TabIndex = 13
        '
        'txtFalName
        '
        Me.txtFalName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFalName.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtFalName.Location = New System.Drawing.Point(511, 280)
        Me.txtFalName.Name = "txtFalName"
        Me.txtFalName.Size = New System.Drawing.Size(272, 26)
        Me.txtFalName.TabIndex = 12
        '
        'txtMalName
        '
        Me.txtMalName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMalName.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtMalName.Location = New System.Drawing.Point(511, 312)
        Me.txtMalName.Name = "txtMalName"
        Me.txtMalName.Size = New System.Drawing.Size(272, 26)
        Me.txtMalName.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 23)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "รู้วิชา"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEdu
        '
        Me.txtEdu.AutoCompleteCustomSource.AddRange(New String() {"ชั้นมัธยมศึกษาปีที่ 6", "ประกาศนียบัตรวิชาชีพ", "ประกาศนียบัตรวิชาชีพชั้นสูง"})
        Me.txtEdu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtEdu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdu.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtEdu.Location = New System.Drawing.Point(167, 359)
        Me.txtEdu.Name = "txtEdu"
        Me.txtEdu.Size = New System.Drawing.Size(616, 26)
        Me.txtEdu.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 23)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "สถานศึกษา"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(640, 441)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 32)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'mskDOB
        '
        Me.mskDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskDOB.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.mskDOB.Location = New System.Drawing.Point(167, 86)
        Me.mskDOB.Mask = "00/00/0000"
        Me.mskDOB.Name = "mskDOB"
        Me.mskDOB.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.mskDOB.Size = New System.Drawing.Size(170, 26)
        Me.mskDOB.TabIndex = 3
        Me.mskDOB.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mskDOB.ValidatingType = GetType(Date)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label12.Location = New System.Drawing.Point(445, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "ชื่อสกุล"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label13.Location = New System.Drawing.Point(303, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 23)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "หมู่ที่"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label14.Location = New System.Drawing.Point(445, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 23)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "ตำบล"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label15.Location = New System.Drawing.Point(445, 197)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 23)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "จังหวัด"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label16.Location = New System.Drawing.Point(445, 283)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 23)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "ชื่อสกุล"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label17.Location = New System.Drawing.Point(445, 315)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 23)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "ชื่อสกุล"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbsc
        '
        Me.cbsc.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.cbsc.FormattingEnabled = True
        Me.cbsc.Location = New System.Drawing.Point(167, 118)
        Me.cbsc.Name = "cbsc"
        Me.cbsc.Size = New System.Drawing.Size(616, 26)
        Me.cbsc.TabIndex = 4
        '
        'cbCC
        '
        Me.cbCC.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbCC.FormattingEnabled = True
        Me.cbCC.Location = New System.Drawing.Point(511, 196)
        Me.cbCC.Name = "cbCC"
        Me.cbCC.Size = New System.Drawing.Size(272, 26)
        Me.cbCC.TabIndex = 8
        '
        'cbAA
        '
        Me.cbAA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbAA.FormattingEnabled = True
        Me.cbAA.Location = New System.Drawing.Point(167, 227)
        Me.cbAA.Name = "cbAA"
        Me.cbAA.Size = New System.Drawing.Size(272, 26)
        Me.cbAA.TabIndex = 9
        '
        'cbTT
        '
        Me.cbTT.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTT.FormattingEnabled = True
        Me.cbTT.Location = New System.Drawing.Point(511, 227)
        Me.cbTT.Name = "cbTT"
        Me.cbTT.Size = New System.Drawing.Size(272, 26)
        Me.cbTT.TabIndex = 10
        '
        'cbSch
        '
        Me.cbSch.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbSch.FormattingEnabled = True
        Me.cbSch.Location = New System.Drawing.Point(167, 390)
        Me.cbSch.Name = "cbSch"
        Me.cbSch.Size = New System.Drawing.Size(616, 26)
        Me.cbSch.TabIndex = 16
        '
        'txtPID
        '
        Me.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPID.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPID.Location = New System.Drawing.Point(167, 22)
        Me.txtPID.MaxLength = 13
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(194, 26)
        Me.txtPID.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(661, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(131, 22)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "ตรวจสอบเลขบัตร"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 487)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtPID)
        Me.Controls.Add(Me.cbSch)
        Me.Controls.Add(Me.cbTT)
        Me.Controls.Add(Me.cbAA)
        Me.Controls.Add(Me.cbCC)
        Me.Controls.Add(Me.cbsc)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mskDOB)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEdu)
        Me.Controls.Add(Me.txtMalName)
        Me.Controls.Add(Me.txtFalName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMaName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFaName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtM_moo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtM_addr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtM_villar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Edit Man Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtM_villar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtM_addr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtM_moo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFaName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMaName As TextBox
    Friend WithEvents txtFalName As TextBox
    Friend WithEvents txtMalName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEdu As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents mskDOB As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbsc As ComboBox
    Friend WithEvents cbCC As ComboBox
    Friend WithEvents cbAA As ComboBox
    Friend WithEvents cbTT As ComboBox
    Friend WithEvents cbSch As ComboBox
    Friend WithEvents txtPID As TextBox
    Friend WithEvents CheckBox1 As CheckBox

End Class
