<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_DetailIndikator
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IDUPF = New MedtindoLibrary._Lbl()
        Me.IDFORM = New MedtindoLibrary._Lbl()
        Me.NMFORM = New MedtindoLibrary._Lbl()
        Me.NMUPF = New MedtindoLibrary._Lbl()
        Me.Dgv1 = New MedtindoLibrary.DGV()
        Me.PILIH = New System.Windows.Forms.DataGridViewButtonColumn()
        Me._Lbl1 = New MedtindoLibrary._Lbl()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDUPF
        '
        Me.IDUPF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDUPF.BackColor = System.Drawing.Color.PaleVioletRed
        Me.IDUPF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDUPF.ForeColor = System.Drawing.Color.White
        Me.IDUPF.Location = New System.Drawing.Point(810, 0)
        Me.IDUPF.Name = "IDUPF"
        Me.IDUPF.Size = New System.Drawing.Size(50, 29)
        Me.IDUPF.TabIndex = 23
        Me.IDUPF.Text = "000"
        Me.IDUPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IDFORM
        '
        Me.IDFORM.BackColor = System.Drawing.Color.MediumBlue
        Me.IDFORM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDFORM.ForeColor = System.Drawing.Color.White
        Me.IDFORM.Location = New System.Drawing.Point(0, 0)
        Me.IDFORM.Name = "IDFORM"
        Me.IDFORM.Size = New System.Drawing.Size(60, 29)
        Me.IDFORM.TabIndex = 23
        Me.IDFORM.Text = "A000"
        Me.IDFORM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NMFORM
        '
        Me.NMFORM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NMFORM.BackColor = System.Drawing.Color.Navy
        Me.NMFORM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NMFORM.ForeColor = System.Drawing.Color.White
        Me.NMFORM.Location = New System.Drawing.Point(60, 0)
        Me.NMFORM.Name = "NMFORM"
        Me.NMFORM.Size = New System.Drawing.Size(750, 29)
        Me.NMFORM.TabIndex = 23
        Me.NMFORM.Text = "Formulir"
        Me.NMFORM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NMUPF
        '
        Me.NMUPF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NMUPF.BackColor = System.Drawing.Color.Crimson
        Me.NMUPF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NMUPF.ForeColor = System.Drawing.Color.White
        Me.NMUPF.Location = New System.Drawing.Point(860, 0)
        Me.NMUPF.Name = "NMUPF"
        Me.NMUPF.Size = New System.Drawing.Size(204, 29)
        Me.NMUPF.TabIndex = 23
        Me.NMUPF.Text = "Unit"
        Me.NMUPF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv1.BackgroundColor = System.Drawing.Color.White
        Me.Dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PILIH})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv1.Location = New System.Drawing.Point(0, 29)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.RowTemplate.Height = 20
        Me.Dgv1.Size = New System.Drawing.Size(1064, 436)
        Me.Dgv1.TabIndex = 24
        '
        'PILIH
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.PILIH.DefaultCellStyle = DataGridViewCellStyle2
        Me.PILIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PILIH.HeaderText = ""
        Me.PILIH.Name = "PILIH"
        Me.PILIH.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PILIH.Width = 50
        '
        '_Lbl1
        '
        Me._Lbl1.AutoSize = True
        Me._Lbl1.BackColor = System.Drawing.Color.Transparent
        Me._Lbl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(46, Byte), Integer))
        Me._Lbl1.Location = New System.Drawing.Point(12, 468)
        Me._Lbl1.Name = "_Lbl1"
        Me._Lbl1.Size = New System.Drawing.Size(948, 17)
        Me._Lbl1.TabIndex = 27
        Me._Lbl1.Text = "Note : Jika pengisian data sudah selesai langsung close formnya atau tekan ESCAPE" &
    ", lalu lakukan proses simpan agar data dapat tersimpan di database."
        '
        'F_DetailIndikator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 491)
        Me.Controls.Add(Me._Lbl1)
        Me.Controls.Add(Me.Dgv1)
        Me.Controls.Add(Me.NMFORM)
        Me.Controls.Add(Me.IDFORM)
        Me.Controls.Add(Me.NMUPF)
        Me.Controls.Add(Me.IDUPF)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1080, 530)
        Me.Name = "F_DetailIndikator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Indikator"
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDUPF As MedtindoLibrary._Lbl
    Friend WithEvents IDFORM As MedtindoLibrary._Lbl
    Friend WithEvents NMFORM As MedtindoLibrary._Lbl
    Friend WithEvents NMUPF As MedtindoLibrary._Lbl
    Friend WithEvents Dgv1 As MedtindoLibrary.DGV
    Friend WithEvents PILIH As DataGridViewButtonColumn
    Friend WithEvents _Lbl1 As MedtindoLibrary._Lbl
End Class
