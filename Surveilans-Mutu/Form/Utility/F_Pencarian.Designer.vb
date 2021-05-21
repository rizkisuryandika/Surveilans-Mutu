<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Pencarian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.isi_pilihFaskes = New System.Windows.Forms.ComboBox()
        Me.txpencarian = New MedtindoLibrary.Tx()
        Me.Dgv1 = New MedtindoLibrary.DGV()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'isi_pilihFaskes
        '
        Me.isi_pilihFaskes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.isi_pilihFaskes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.isi_pilihFaskes.FormattingEnabled = True
        Me.isi_pilihFaskes.Location = New System.Drawing.Point(12, 9)
        Me.isi_pilihFaskes.Name = "isi_pilihFaskes"
        Me.isi_pilihFaskes.Size = New System.Drawing.Size(175, 23)
        Me.isi_pilihFaskes.TabIndex = 15
        '
        'txpencarian
        '
        Me.txpencarian.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txpencarian.AutoEnter = True
        Me.txpencarian.BackColor = System.Drawing.Color.White
        Me.txpencarian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txpencarian.ForeColor = System.Drawing.Color.Black
        Me.txpencarian.Konversi_HurufBesarKecil = MedtindoLibrary.Tx.EnumKonversiNya.Normal
        Me.txpencarian.Location = New System.Drawing.Point(193, 9)
        Me.txpencarian.Name = "txpencarian"
        Me.txpencarian.Size = New System.Drawing.Size(419, 23)
        Me.txpencarian.TabIndex = 16
        Me.txpencarian.WarnaBackGround_Ketika_FocusEnter = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txpencarian.WarnaBorder = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txpencarian.WarnaTulisan_Ketika_FocusEnter = System.Drawing.SystemColors.ControlText
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv1.BackgroundColor = System.Drawing.Color.White
        Me.Dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv1.Location = New System.Drawing.Point(12, 41)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.RowTemplate.Height = 20
        Me.Dgv1.Size = New System.Drawing.Size(600, 488)
        Me.Dgv1.TabIndex = 17
        '
        'Timer1
        '
        '
        'F_Pencarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 541)
        Me.Controls.Add(Me.Dgv1)
        Me.Controls.Add(Me.txpencarian)
        Me.Controls.Add(Me.isi_pilihFaskes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 580)
        Me.Name = "F_Pencarian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "F_Pencarian"
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents isi_pilihFaskes As ComboBox
    Friend WithEvents txpencarian As MedtindoLibrary.Tx
    Friend WithEvents Dgv1 As MedtindoLibrary.DGV
    Friend WithEvents Timer1 As Timer
End Class
