<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_NilaiIndikator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_NilaiIndikator))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TGL1 = New System.Windows.Forms.DateTimePicker()
        Me.TGL2 = New System.Windows.Forms.DateTimePicker()
        Me._Lbl1 = New MedtindoLibrary._Lbl()
        Me.Dgv2 = New MedtindoLibrary.DGV()
        Me.BTNREFRESH = New MedtindoLibrary._Btn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._Btn5 = New MedtindoLibrary._Btn()
        Me._Btn4 = New MedtindoLibrary._Btn()
        Me._Btn2 = New MedtindoLibrary._Btn()
        Me._Btn1 = New MedtindoLibrary._Btn()
        Me.judul = New MedtindoLibrary._Lbl()
        Me.BTNPRINT = New MedtindoLibrary._Btn()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TGL1
        '
        Me.TGL1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGL1.Location = New System.Drawing.Point(148, 59)
        Me.TGL1.Name = "TGL1"
        Me.TGL1.Size = New System.Drawing.Size(127, 23)
        Me.TGL1.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.TGL1, "Periode Tanggal Awal")
        Me.TGL1.Value = New Date(2020, 1, 17, 0, 0, 0, 0)
        '
        'TGL2
        '
        Me.TGL2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGL2.Location = New System.Drawing.Point(281, 59)
        Me.TGL2.Name = "TGL2"
        Me.TGL2.Size = New System.Drawing.Size(127, 23)
        Me.TGL2.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.TGL2, "Periode Tanggal Akhir")
        Me.TGL2.Value = New Date(2020, 1, 17, 0, 0, 0, 0)
        '
        '_Lbl1
        '
        Me._Lbl1.AutoSize = True
        Me._Lbl1.BackColor = System.Drawing.Color.Transparent
        Me._Lbl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl1.Location = New System.Drawing.Point(12, 63)
        Me._Lbl1.Name = "_Lbl1"
        Me._Lbl1.Size = New System.Drawing.Size(91, 15)
        Me._Lbl1.TabIndex = 46
        Me._Lbl1.Text = "Periode Tanggal"
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
        Me.Dgv2.Location = New System.Drawing.Point(148, 88)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.ReadOnly = True
        Me.Dgv2.RowTemplate.Height = 30
        Me.Dgv2.Size = New System.Drawing.Size(450, 350)
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
        Me.BTNREFRESH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREFRESH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BTNREFRESH.Image = CType(resources.GetObject("BTNREFRESH.Image"), System.Drawing.Image)
        Me.BTNREFRESH.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNREFRESH.Location = New System.Drawing.Point(432, 12)
        Me.BTNREFRESH.Name = "BTNREFRESH"
        Me.BTNREFRESH.Size = New System.Drawing.Size(80, 70)
        Me.BTNREFRESH.TabIndex = 48
        Me.BTNREFRESH.Text = "Refresh"
        Me.BTNREFRESH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNREFRESH.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me._Btn5)
        Me.Panel1.Controls.Add(Me._Btn4)
        Me.Panel1.Controls.Add(Me._Btn2)
        Me.Panel1.Controls.Add(Me._Btn1)
        Me.Panel1.Location = New System.Drawing.Point(15, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(127, 350)
        Me.Panel1.TabIndex = 50
        '
        '_Btn5
        '
        Me._Btn5.BackColor = System.Drawing.Color.Teal
        Me._Btn5.Dock = System.Windows.Forms.DockStyle.Top
        Me._Btn5.FlatAppearance.BorderSize = 0
        Me._Btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me._Btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me._Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Btn5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Btn5.ForeColor = System.Drawing.Color.White
        Me._Btn5.Location = New System.Drawing.Point(0, 141)
        Me._Btn5.Name = "_Btn5"
        Me._Btn5.Size = New System.Drawing.Size(127, 47)
        Me._Btn5.TabIndex = 3
        Me._Btn5.Text = "Nilai Kelompok Per Unit"
        Me._Btn5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Btn5.UseVisualStyleBackColor = False
        '
        '_Btn4
        '
        Me._Btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._Btn4.Dock = System.Windows.Forms.DockStyle.Top
        Me._Btn4.FlatAppearance.BorderSize = 0
        Me._Btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me._Btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me._Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Btn4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Btn4.ForeColor = System.Drawing.Color.White
        Me._Btn4.Location = New System.Drawing.Point(0, 94)
        Me._Btn4.Name = "_Btn4"
        Me._Btn4.Size = New System.Drawing.Size(127, 47)
        Me._Btn4.TabIndex = 2
        Me._Btn4.Text = "Nilai Kelompok Per Formulir"
        Me._Btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Btn4.UseVisualStyleBackColor = False
        '
        '_Btn2
        '
        Me._Btn2.BackColor = System.Drawing.Color.Teal
        Me._Btn2.Dock = System.Windows.Forms.DockStyle.Top
        Me._Btn2.FlatAppearance.BorderSize = 0
        Me._Btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me._Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me._Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Btn2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Btn2.ForeColor = System.Drawing.Color.White
        Me._Btn2.Location = New System.Drawing.Point(0, 47)
        Me._Btn2.Name = "_Btn2"
        Me._Btn2.Size = New System.Drawing.Size(127, 47)
        Me._Btn2.TabIndex = 1
        Me._Btn2.Text = "Nilai Per Unit"
        Me._Btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Btn2.UseVisualStyleBackColor = False
        '
        '_Btn1
        '
        Me._Btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._Btn1.Dock = System.Windows.Forms.DockStyle.Top
        Me._Btn1.FlatAppearance.BorderSize = 0
        Me._Btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me._Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me._Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me._Btn1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Btn1.ForeColor = System.Drawing.Color.White
        Me._Btn1.Location = New System.Drawing.Point(0, 0)
        Me._Btn1.Name = "_Btn1"
        Me._Btn1.Size = New System.Drawing.Size(127, 47)
        Me._Btn1.TabIndex = 0
        Me._Btn1.Text = "Nilai Per Formulir"
        Me._Btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me._Btn1.UseVisualStyleBackColor = False
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.BackColor = System.Drawing.Color.Transparent
        Me.judul.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.judul.Location = New System.Drawing.Point(12, 22)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(42, 17)
        Me.judul.TabIndex = 46
        Me.judul.Text = "Judul"
        '
        'BTNPRINT
        '
        Me.BTNPRINT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNPRINT.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BTNPRINT.FlatAppearance.BorderSize = 0
        Me.BTNPRINT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BTNPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.BTNPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPRINT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPRINT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BTNPRINT.Image = CType(resources.GetObject("BTNPRINT.Image"), System.Drawing.Image)
        Me.BTNPRINT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNPRINT.Location = New System.Drawing.Point(518, 12)
        Me.BTNPRINT.Name = "BTNPRINT"
        Me.BTNPRINT.Size = New System.Drawing.Size(80, 70)
        Me.BTNPRINT.TabIndex = 48
        Me.BTNPRINT.Text = "Grafik"
        Me.BTNPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNPRINT.UseVisualStyleBackColor = False
        '
        'F_NilaiIndikator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(610, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNPRINT)
        Me.Controls.Add(Me.BTNREFRESH)
        Me.Controls.Add(Me.judul)
        Me.Controls.Add(Me._Lbl1)
        Me.Controls.Add(Me.TGL1)
        Me.Controls.Add(Me.Dgv2)
        Me.Controls.Add(Me.TGL2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_NilaiIndikator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nilai Mutu"
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents _Lbl1 As MedtindoLibrary._Lbl
    Friend WithEvents TGL1 As DateTimePicker
    Friend WithEvents Dgv2 As MedtindoLibrary.DGV
    Friend WithEvents TGL2 As DateTimePicker
    Friend WithEvents BTNREFRESH As MedtindoLibrary._Btn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _Btn2 As MedtindoLibrary._Btn
    Friend WithEvents _Btn1 As MedtindoLibrary._Btn
    Friend WithEvents judul As MedtindoLibrary._Lbl
    Friend WithEvents BTNPRINT As MedtindoLibrary._Btn
    Friend WithEvents _Btn5 As MedtindoLibrary._Btn
    Friend WithEvents _Btn4 As MedtindoLibrary._Btn
End Class
