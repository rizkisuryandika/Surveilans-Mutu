<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_EntryIndikator
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
        Me.IDUPF = New MedtindoLibrary.Tx()
        Me.STATUSFORM = New MedtindoLibrary._Lbl()
        Me._Lbl1 = New MedtindoLibrary._Lbl()
        Me._Lbl2 = New MedtindoLibrary._Lbl()
        Me.IDFORM = New MedtindoLibrary.Tx()
        Me.AUDITOR = New MedtindoLibrary.Tx()
        Me._Lbl3 = New MedtindoLibrary._Lbl()
        Me.BTNBARU = New MedtindoLibrary._Btn()
        Me.NMUPF = New MedtindoLibrary._Lbl()
        Me.BTNSIMPAN = New MedtindoLibrary._Btn()
        Me.BTNHAPUS = New MedtindoLibrary._Btn()
        Me._Lbl4 = New MedtindoLibrary._Lbl()
        Me._Lbl5 = New MedtindoLibrary._Lbl()
        Me.NMFORM = New MedtindoLibrary._Lbl()
        Me.ENTRYBY = New MedtindoLibrary._Lbl()
        Me.EDITBY = New MedtindoLibrary._Lbl()
        Me.BTNFORM = New MedtindoLibrary._Btn()
        Me.BTNUPF = New MedtindoLibrary._Btn()
        Me.TGLTRANS = New System.Windows.Forms.DateTimePicker()
        Me._Lbl6 = New MedtindoLibrary._Lbl()
        Me.NOTRANS = New MedtindoLibrary._Lbl()
        Me.BTNMUTU = New MedtindoLibrary._Btn()
        Me.SuspendLayout()
        '
        'IDUPF
        '
        Me.IDUPF.AutoEnter = True
        Me.IDUPF.BackColor = System.Drawing.Color.White
        Me.IDUPF.Enabled = False
        Me.IDUPF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDUPF.ForeColor = System.Drawing.Color.Black
        Me.IDUPF.Konversi_HurufBesarKecil = MedtindoLibrary.Tx.EnumKonversiNya.Normal
        Me.IDUPF.Location = New System.Drawing.Point(136, 103)
        Me.IDUPF.Name = "IDUPF"
        Me.IDUPF.Size = New System.Drawing.Size(142, 29)
        Me.IDUPF.TabIndex = 17
        Me.IDUPF.WarnaBackGround_Ketika_FocusEnter = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDUPF.WarnaBorder = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.IDUPF.WarnaTulisan_Ketika_FocusEnter = System.Drawing.SystemColors.ControlText
        '
        'STATUSFORM
        '
        Me.STATUSFORM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.STATUSFORM.BackColor = System.Drawing.Color.MidnightBlue
        Me.STATUSFORM.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STATUSFORM.ForeColor = System.Drawing.Color.White
        Me.STATUSFORM.Location = New System.Drawing.Point(0, 0)
        Me.STATUSFORM.Name = "STATUSFORM"
        Me.STATUSFORM.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.STATUSFORM.Size = New System.Drawing.Size(377, 39)
        Me.STATUSFORM.TabIndex = 18
        Me.STATUSFORM.Text = "..."
        Me.STATUSFORM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_Lbl1
        '
        Me._Lbl1.AutoSize = True
        Me._Lbl1.BackColor = System.Drawing.Color.Transparent
        Me._Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl1.Location = New System.Drawing.Point(37, 106)
        Me._Lbl1.Name = "_Lbl1"
        Me._Lbl1.Size = New System.Drawing.Size(39, 21)
        Me._Lbl1.TabIndex = 20
        Me._Lbl1.Text = "Unit"
        '
        '_Lbl2
        '
        Me._Lbl2.AutoSize = True
        Me._Lbl2.BackColor = System.Drawing.Color.Transparent
        Me._Lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl2.Location = New System.Drawing.Point(37, 188)
        Me._Lbl2.Name = "_Lbl2"
        Me._Lbl2.Size = New System.Drawing.Size(70, 21)
        Me._Lbl2.TabIndex = 22
        Me._Lbl2.Text = "Formulir"
        '
        'IDFORM
        '
        Me.IDFORM.AutoEnter = True
        Me.IDFORM.BackColor = System.Drawing.Color.White
        Me.IDFORM.Enabled = False
        Me.IDFORM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDFORM.ForeColor = System.Drawing.Color.Black
        Me.IDFORM.Konversi_HurufBesarKecil = MedtindoLibrary.Tx.EnumKonversiNya.Normal
        Me.IDFORM.Location = New System.Drawing.Point(136, 185)
        Me.IDFORM.Name = "IDFORM"
        Me.IDFORM.Size = New System.Drawing.Size(142, 29)
        Me.IDFORM.TabIndex = 21
        Me.IDFORM.WarnaBackGround_Ketika_FocusEnter = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDFORM.WarnaBorder = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.IDFORM.WarnaTulisan_Ketika_FocusEnter = System.Drawing.SystemColors.ControlText
        '
        'AUDITOR
        '
        Me.AUDITOR.AutoEnter = True
        Me.AUDITOR.BackColor = System.Drawing.Color.White
        Me.AUDITOR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUDITOR.ForeColor = System.Drawing.Color.Black
        Me.AUDITOR.Konversi_HurufBesarKecil = MedtindoLibrary.Tx.EnumKonversiNya.Normal
        Me.AUDITOR.Location = New System.Drawing.Point(136, 267)
        Me.AUDITOR.Name = "AUDITOR"
        Me.AUDITOR.Size = New System.Drawing.Size(264, 29)
        Me.AUDITOR.TabIndex = 3
        Me.AUDITOR.WarnaBackGround_Ketika_FocusEnter = System.Drawing.SystemColors.HotTrack
        Me.AUDITOR.WarnaBorder = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.AUDITOR.WarnaTulisan_Ketika_FocusEnter = System.Drawing.Color.White
        '
        '_Lbl3
        '
        Me._Lbl3.AutoSize = True
        Me._Lbl3.BackColor = System.Drawing.Color.Transparent
        Me._Lbl3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl3.Location = New System.Drawing.Point(37, 270)
        Me._Lbl3.Name = "_Lbl3"
        Me._Lbl3.Size = New System.Drawing.Size(62, 21)
        Me._Lbl3.TabIndex = 22
        Me._Lbl3.Text = "Auditor"
        '
        'BTNBARU
        '
        Me.BTNBARU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNBARU.BackColor = System.Drawing.Color.DodgerBlue
        Me.BTNBARU.FlatAppearance.BorderSize = 0
        Me.BTNBARU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BTNBARU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNBARU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBARU.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBARU.ForeColor = System.Drawing.Color.White
        Me.BTNBARU.Location = New System.Drawing.Point(12, 400)
        Me.BTNBARU.Name = "BTNBARU"
        Me.BTNBARU.Size = New System.Drawing.Size(118, 52)
        Me.BTNBARU.TabIndex = 6
        Me.BTNBARU.Text = "BARU F6"
        Me.BTNBARU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNBARU.UseVisualStyleBackColor = False
        '
        'NMUPF
        '
        Me.NMUPF.AutoSize = True
        Me.NMUPF.BackColor = System.Drawing.Color.Transparent
        Me.NMUPF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NMUPF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.NMUPF.Location = New System.Drawing.Point(132, 148)
        Me.NMUPF.Name = "NMUPF"
        Me.NMUPF.Size = New System.Drawing.Size(16, 21)
        Me.NMUPF.TabIndex = 22
        Me.NMUPF.Text = "-"
        '
        'BTNSIMPAN
        '
        Me.BTNSIMPAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNSIMPAN.BackColor = System.Drawing.Color.Green
        Me.BTNSIMPAN.FlatAppearance.BorderSize = 0
        Me.BTNSIMPAN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BTNSIMPAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNSIMPAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSIMPAN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSIMPAN.ForeColor = System.Drawing.Color.White
        Me.BTNSIMPAN.Location = New System.Drawing.Point(136, 400)
        Me.BTNSIMPAN.Name = "BTNSIMPAN"
        Me.BTNSIMPAN.Size = New System.Drawing.Size(118, 52)
        Me.BTNSIMPAN.TabIndex = 5
        Me.BTNSIMPAN.Text = "SIMPAN F7"
        Me.BTNSIMPAN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNSIMPAN.UseVisualStyleBackColor = False
        Me.BTNSIMPAN.Visible = False
        '
        'BTNHAPUS
        '
        Me.BTNHAPUS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNHAPUS.BackColor = System.Drawing.Color.DarkRed
        Me.BTNHAPUS.FlatAppearance.BorderSize = 0
        Me.BTNHAPUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BTNHAPUS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNHAPUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNHAPUS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHAPUS.ForeColor = System.Drawing.Color.White
        Me.BTNHAPUS.Location = New System.Drawing.Point(260, 400)
        Me.BTNHAPUS.Name = "BTNHAPUS"
        Me.BTNHAPUS.Size = New System.Drawing.Size(118, 52)
        Me.BTNHAPUS.TabIndex = 7
        Me.BTNHAPUS.Text = "HAPUS F8"
        Me.BTNHAPUS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNHAPUS.UseVisualStyleBackColor = False
        Me.BTNHAPUS.Visible = False
        '
        '_Lbl4
        '
        Me._Lbl4.AutoSize = True
        Me._Lbl4.BackColor = System.Drawing.Color.Transparent
        Me._Lbl4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl4.Location = New System.Drawing.Point(37, 349)
        Me._Lbl4.Name = "_Lbl4"
        Me._Lbl4.Size = New System.Drawing.Size(57, 21)
        Me._Lbl4.TabIndex = 26
        Me._Lbl4.Text = "Edit By"
        '
        '_Lbl5
        '
        Me._Lbl5.AutoSize = True
        Me._Lbl5.BackColor = System.Drawing.Color.Transparent
        Me._Lbl5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl5.Location = New System.Drawing.Point(37, 312)
        Me._Lbl5.Name = "_Lbl5"
        Me._Lbl5.Size = New System.Drawing.Size(67, 21)
        Me._Lbl5.TabIndex = 27
        Me._Lbl5.Text = "Entry By"
        '
        'NMFORM
        '
        Me.NMFORM.AutoSize = True
        Me.NMFORM.BackColor = System.Drawing.Color.Transparent
        Me.NMFORM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NMFORM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.NMFORM.Location = New System.Drawing.Point(132, 230)
        Me.NMFORM.Name = "NMFORM"
        Me.NMFORM.Size = New System.Drawing.Size(16, 21)
        Me.NMFORM.TabIndex = 22
        Me.NMFORM.Text = "-"
        '
        'ENTRYBY
        '
        Me.ENTRYBY.AutoSize = True
        Me.ENTRYBY.BackColor = System.Drawing.Color.Transparent
        Me.ENTRYBY.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENTRYBY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ENTRYBY.Location = New System.Drawing.Point(133, 312)
        Me.ENTRYBY.Name = "ENTRYBY"
        Me.ENTRYBY.Size = New System.Drawing.Size(16, 21)
        Me.ENTRYBY.TabIndex = 22
        Me.ENTRYBY.Text = "-"
        '
        'EDITBY
        '
        Me.EDITBY.AutoSize = True
        Me.EDITBY.BackColor = System.Drawing.Color.Transparent
        Me.EDITBY.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDITBY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.EDITBY.Location = New System.Drawing.Point(133, 349)
        Me.EDITBY.Name = "EDITBY"
        Me.EDITBY.Size = New System.Drawing.Size(16, 21)
        Me.EDITBY.TabIndex = 22
        Me.EDITBY.Text = "-"
        '
        'BTNFORM
        '
        Me.BTNFORM.BackColor = System.Drawing.Color.Orange
        Me.BTNFORM.FlatAppearance.BorderSize = 0
        Me.BTNFORM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BTNFORM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNFORM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNFORM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFORM.ForeColor = System.Drawing.Color.White
        Me.BTNFORM.Location = New System.Drawing.Point(284, 184)
        Me.BTNFORM.Name = "BTNFORM"
        Me.BTNFORM.Size = New System.Drawing.Size(116, 29)
        Me.BTNFORM.TabIndex = 2
        Me.BTNFORM.Text = "Cari"
        Me.BTNFORM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNFORM.UseVisualStyleBackColor = False
        '
        'BTNUPF
        '
        Me.BTNUPF.BackColor = System.Drawing.Color.Orange
        Me.BTNUPF.FlatAppearance.BorderSize = 0
        Me.BTNUPF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BTNUPF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNUPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNUPF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUPF.ForeColor = System.Drawing.Color.White
        Me.BTNUPF.Location = New System.Drawing.Point(284, 102)
        Me.BTNUPF.Name = "BTNUPF"
        Me.BTNUPF.Size = New System.Drawing.Size(116, 29)
        Me.BTNUPF.TabIndex = 1
        Me.BTNUPF.Text = "Cari"
        Me.BTNUPF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNUPF.UseVisualStyleBackColor = False
        '
        'TGLTRANS
        '
        Me.TGLTRANS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGLTRANS.Location = New System.Drawing.Point(136, 58)
        Me.TGLTRANS.Name = "TGLTRANS"
        Me.TGLTRANS.Size = New System.Drawing.Size(200, 29)
        Me.TGLTRANS.TabIndex = 0
        Me.TGLTRANS.Value = New Date(2020, 1, 17, 0, 0, 0, 0)
        '
        '_Lbl6
        '
        Me._Lbl6.AutoSize = True
        Me._Lbl6.BackColor = System.Drawing.Color.Transparent
        Me._Lbl6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl6.Location = New System.Drawing.Point(38, 62)
        Me._Lbl6.Name = "_Lbl6"
        Me._Lbl6.Size = New System.Drawing.Size(63, 21)
        Me._Lbl6.TabIndex = 20
        Me._Lbl6.Text = "Tanggal"
        '
        'NOTRANS
        '
        Me.NOTRANS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NOTRANS.BackColor = System.Drawing.Color.Crimson
        Me.NOTRANS.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOTRANS.ForeColor = System.Drawing.Color.White
        Me.NOTRANS.Location = New System.Drawing.Point(377, 0)
        Me.NOTRANS.Name = "NOTRANS"
        Me.NOTRANS.Size = New System.Drawing.Size(162, 39)
        Me.NOTRANS.TabIndex = 29
        Me.NOTRANS.Text = "..."
        Me.NOTRANS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNMUTU
        '
        Me.BTNMUTU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNMUTU.BackColor = System.Drawing.Color.Indigo
        Me.BTNMUTU.FlatAppearance.BorderSize = 0
        Me.BTNMUTU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BTNMUTU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNMUTU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMUTU.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMUTU.ForeColor = System.Drawing.Color.White
        Me.BTNMUTU.Location = New System.Drawing.Point(384, 400)
        Me.BTNMUTU.Name = "BTNMUTU"
        Me.BTNMUTU.Size = New System.Drawing.Size(143, 52)
        Me.BTNMUTU.TabIndex = 4
        Me.BTNMUTU.Text = "DATA MONITORING F9"
        Me.BTNMUTU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNMUTU.UseVisualStyleBackColor = False
        '
        'F_EntryIndikator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(539, 464)
        Me.Controls.Add(Me.NOTRANS)
        Me.Controls.Add(Me.TGLTRANS)
        Me.Controls.Add(Me._Lbl4)
        Me.Controls.Add(Me._Lbl5)
        Me.Controls.Add(Me.BTNMUTU)
        Me.Controls.Add(Me.BTNHAPUS)
        Me.Controls.Add(Me.BTNSIMPAN)
        Me.Controls.Add(Me.BTNUPF)
        Me.Controls.Add(Me.BTNFORM)
        Me.Controls.Add(Me.BTNBARU)
        Me.Controls.Add(Me._Lbl3)
        Me.Controls.Add(Me.EDITBY)
        Me.Controls.Add(Me.ENTRYBY)
        Me.Controls.Add(Me.NMFORM)
        Me.Controls.Add(Me.NMUPF)
        Me.Controls.Add(Me._Lbl2)
        Me.Controls.Add(Me.AUDITOR)
        Me.Controls.Add(Me.IDFORM)
        Me.Controls.Add(Me._Lbl6)
        Me.Controls.Add(Me._Lbl1)
        Me.Controls.Add(Me.STATUSFORM)
        Me.Controls.Add(Me.IDUPF)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_EntryIndikator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Indikator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDUPF As MedtindoLibrary.Tx
    Friend WithEvents STATUSFORM As MedtindoLibrary._Lbl
    Friend WithEvents _Lbl1 As MedtindoLibrary._Lbl
    Friend WithEvents _Lbl2 As MedtindoLibrary._Lbl
    Friend WithEvents IDFORM As MedtindoLibrary.Tx
    Friend WithEvents AUDITOR As MedtindoLibrary.Tx
    Friend WithEvents _Lbl3 As MedtindoLibrary._Lbl
    Friend WithEvents BTNBARU As MedtindoLibrary._Btn
    Friend WithEvents NMUPF As MedtindoLibrary._Lbl
    Friend WithEvents BTNSIMPAN As MedtindoLibrary._Btn
    Friend WithEvents BTNHAPUS As MedtindoLibrary._Btn
    Friend WithEvents _Lbl4 As MedtindoLibrary._Lbl
    Friend WithEvents _Lbl5 As MedtindoLibrary._Lbl
    Friend WithEvents NMFORM As MedtindoLibrary._Lbl
    Friend WithEvents ENTRYBY As MedtindoLibrary._Lbl
    Friend WithEvents EDITBY As MedtindoLibrary._Lbl
    Friend WithEvents BTNFORM As MedtindoLibrary._Btn
    Friend WithEvents BTNUPF As MedtindoLibrary._Btn
    Friend WithEvents TGLTRANS As DateTimePicker
    Friend WithEvents _Lbl6 As MedtindoLibrary._Lbl
    Friend WithEvents NOTRANS As MedtindoLibrary._Lbl
    Friend WithEvents BTNMUTU As MedtindoLibrary._Btn
End Class
