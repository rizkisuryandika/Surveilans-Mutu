<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_CariIndikator
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_CariIndikator))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TGL1 = New System.Windows.Forms.DateTimePicker()
        Me.TGL2 = New System.Windows.Forms.DateTimePicker()
        Me.cb_ = New System.Windows.Forms.ComboBox()
        Me._Lbl1 = New MedtindoLibrary._Lbl()
        Me._Lbl2 = New MedtindoLibrary._Lbl()
        Me.Dgv2 = New MedtindoLibrary.DGV()
        Me.BTNREFRESH = New MedtindoLibrary._Btn()
        Me.txpencarian = New MedtindoLibrary.Tx()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me._Btn1 = New MedtindoLibrary._Btn()
        Me._Btn2 = New MedtindoLibrary._Btn()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TGL1
        '
        Me.TGL1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TGL1.Location = New System.Drawing.Point(15, 59)
        Me.TGL1.Name = "TGL1"
        Me.TGL1.Size = New System.Drawing.Size(127, 23)
        Me.TGL1.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.TGL1, "Periode Tanggal Awal")
        Me.TGL1.Value = New Date(2020, 1, 17, 0, 0, 0, 0)
        '
        'TGL2
        '
        Me.TGL2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TGL2.Location = New System.Drawing.Point(141, 59)
        Me.TGL2.Name = "TGL2"
        Me.TGL2.Size = New System.Drawing.Size(127, 23)
        Me.TGL2.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.TGL2, "Periode Tanggal Akhir")
        Me.TGL2.Value = New Date(2020, 1, 17, 0, 0, 0, 0)
        '
        'cb_
        '
        Me.cb_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cb_.FormattingEnabled = True
        Me.cb_.Items.AddRange(New Object() {"NOTRANS", "AUDITOR", "NMFORM", "NMUPF"})
        Me.cb_.Location = New System.Drawing.Point(274, 59)
        Me.cb_.Name = "cb_"
        Me.cb_.Size = New System.Drawing.Size(144, 23)
        Me.cb_.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.cb_, "Pilihan kolom pencarian")
        '
        '_Lbl1
        '
        Me._Lbl1.AutoSize = True
        Me._Lbl1.BackColor = System.Drawing.Color.Transparent
        Me._Lbl1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me._Lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl1.Location = New System.Drawing.Point(12, 42)
        Me._Lbl1.Name = "_Lbl1"
        Me._Lbl1.Size = New System.Drawing.Size(94, 14)
        Me._Lbl1.TabIndex = 46
        Me._Lbl1.Text = "Periode Tanggal"
        '
        '_Lbl2
        '
        Me._Lbl2.AutoSize = True
        Me._Lbl2.BackColor = System.Drawing.Color.Transparent
        Me._Lbl2.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me._Lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl2.Location = New System.Drawing.Point(271, 42)
        Me._Lbl2.Name = "_Lbl2"
        Me._Lbl2.Size = New System.Drawing.Size(89, 14)
        Me._Lbl2.TabIndex = 47
        Me._Lbl2.Text = "Pencarian data"
        '
        'Dgv2
        '
        Me.Dgv2.AllowUserToAddRows = False
        Me.Dgv2.AllowUserToDeleteRows = False
        Me.Dgv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv2.Location = New System.Drawing.Point(15, 88)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.RowTemplate.Height = 30
        Me.Dgv2.Size = New System.Drawing.Size(878, 416)
        Me.Dgv2.TabIndex = 43
        '
        'BTNREFRESH
        '
        Me.BTNREFRESH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNREFRESH.BackColor = System.Drawing.Color.RoyalBlue
        Me.BTNREFRESH.FlatAppearance.BorderSize = 0
        Me.BTNREFRESH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BTNREFRESH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BTNREFRESH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNREFRESH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREFRESH.ForeColor = System.Drawing.Color.White
        Me.BTNREFRESH.Image = CType(resources.GetObject("BTNREFRESH.Image"), System.Drawing.Image)
        Me.BTNREFRESH.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNREFRESH.Location = New System.Drawing.Point(641, 12)
        Me.BTNREFRESH.Name = "BTNREFRESH"
        Me.BTNREFRESH.Size = New System.Drawing.Size(80, 70)
        Me.BTNREFRESH.TabIndex = 48
        Me.BTNREFRESH.Text = "Refresh"
        Me.BTNREFRESH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNREFRESH.UseVisualStyleBackColor = False
        '
        'txpencarian
        '
        Me.txpencarian.AutoEnter = True
        Me.txpencarian.BackColor = System.Drawing.Color.White
        Me.txpencarian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txpencarian.ForeColor = System.Drawing.Color.Black
        Me.txpencarian.Konversi_HurufBesarKecil = MedtindoLibrary.Tx.EnumKonversiNya.Normal
        Me.txpencarian.Location = New System.Drawing.Point(424, 59)
        Me.txpencarian.Name = "txpencarian"
        Me.txpencarian.Size = New System.Drawing.Size(211, 23)
        Me.txpencarian.TabIndex = 49
        Me.txpencarian.WarnaBackGround_Ketika_FocusEnter = System.Drawing.SystemColors.Highlight
        Me.txpencarian.WarnaBorder = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txpencarian.WarnaTulisan_Ketika_FocusEnter = System.Drawing.Color.White
        '
        'Timer1
        '
        '
        '_Btn1
        '
        Me._Btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Btn1.BackColor = System.Drawing.Color.OrangeRed
        Me._Btn1.FlatAppearance.BorderSize = 0
        Me._Btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me._Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me._Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Btn1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Btn1.ForeColor = System.Drawing.Color.White
        Me._Btn1.Image = CType(resources.GetObject("_Btn1.Image"), System.Drawing.Image)
        Me._Btn1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Btn1.Location = New System.Drawing.Point(813, 12)
        Me._Btn1.Name = "_Btn1"
        Me._Btn1.Size = New System.Drawing.Size(80, 70)
        Me._Btn1.TabIndex = 48
        Me._Btn1.Text = "Tambah"
        Me._Btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Btn1.UseVisualStyleBackColor = False
        '
        '_Btn2
        '
        Me._Btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._Btn2.BackColor = System.Drawing.Color.Green
        Me._Btn2.FlatAppearance.BorderSize = 0
        Me._Btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me._Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me._Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Btn2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Btn2.ForeColor = System.Drawing.Color.White
        Me._Btn2.Image = CType(resources.GetObject("_Btn2.Image"), System.Drawing.Image)
        Me._Btn2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me._Btn2.Location = New System.Drawing.Point(727, 12)
        Me._Btn2.Name = "_Btn2"
        Me._Btn2.Size = New System.Drawing.Size(80, 70)
        Me._Btn2.TabIndex = 48
        Me._Btn2.Text = "Nilai"
        Me._Btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Btn2.UseVisualStyleBackColor = False
        '
        'F_CariIndikator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 516)
        Me.Controls.Add(Me.txpencarian)
        Me.Controls.Add(Me._Btn1)
        Me.Controls.Add(Me._Btn2)
        Me.Controls.Add(Me.BTNREFRESH)
        Me.Controls.Add(Me._Lbl1)
        Me.Controls.Add(Me._Lbl2)
        Me.Controls.Add(Me.TGL1)
        Me.Controls.Add(Me.Dgv2)
        Me.Controls.Add(Me.TGL2)
        Me.Controls.Add(Me.cb_)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_CariIndikator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pencarian Data Indikator Mutu"
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents _Lbl1 As MedtindoLibrary._Lbl
    Friend WithEvents _Lbl2 As MedtindoLibrary._Lbl
    Friend WithEvents TGL1 As DateTimePicker
    Friend WithEvents Dgv2 As MedtindoLibrary.DGV
    Friend WithEvents TGL2 As DateTimePicker
    Friend WithEvents cb_ As ComboBox
    Friend WithEvents BTNREFRESH As MedtindoLibrary._Btn
    Friend WithEvents txpencarian As MedtindoLibrary.Tx
    Friend WithEvents Timer1 As Timer
    Friend WithEvents _Btn1 As MedtindoLibrary._Btn
    Friend WithEvents _Btn2 As MedtindoLibrary._Btn
End Class
