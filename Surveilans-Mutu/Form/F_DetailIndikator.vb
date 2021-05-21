Imports MedtindoLibrary

Public Class F_DetailIndikator
    Public NOTRANS As String
    Private i As Integer
    Public dt_detail As DataTable = Nothing

    Private Sub F_DetailIndikator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Dgv1
            .BorderStyle = BorderStyle.None
            .RowHeadersWidth = 30
            .EnableHeadersVisualStyles = False 'matikan visual xpstyle agar warna header kolom tidak berubah
            .RowHeadersVisible = False 'Hilangkan border kiri
            .ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.SelectionBackColor = Color.DodgerBlue
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            '.GridColor = Color.Teal
            .ColumnHeadersBorderStyle = BorderStyle.FixedSingle
            .RowHeadersBorderStyle = BorderStyle.FixedSingle
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .RowTemplate.Height = 40
            .Font = New Font("Segoe UI", 9)
            .BackgroundColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
        Me.KeyPreview = True
        Get_Data()
    End Sub

    Private Async Sub Get_Data()
        Try
            Dim sql As String
            If ExScalar("SELECT count(IDR) from DETAIL_INDIKATOR where NOTRANS = '" & NOTRANS & "'") > 0 Then
                sql = "select 'IDR' as IDR,d.notrans,'KLP' as IDKELOMPOK,d.idkelompok as IDINDIKATOR,k.nmkelompok as URAIAN,
                        null as NILAI,d.nilaiklp as NILAIKLP,k.isian as ISIAN,null as KETERANGAN
                        from detail_indikator d
                        inner join MAST_KELOMPOK k on d.idkelompok=k.idkelompok
                        where notrans = '" & NOTRANS & "'
                        group by 1,2,3,4,5,6,7,8,9
                        union
                        select d.idr,d.notrans,k.idkelompok,d.idindikator,i.uraian,d.nilai,d.nilaiklp,null,d.keterangan
                        from detail_indikator d
                        inner join indikator i on d.idindikator = i.idindikator
                        inner join mast_kelompok k on i.idkelompok=k.idkelompok
                        where notrans = '" & NOTRANS & "'
                        order by 4"
            Else
                sql = "SELECT 'IDR' AS IDR,'" & NOTRANS & "' AS NOTRANS,'KLP' as IDKELOMPOK,
                        k.idkelompok as IDINDIKATOR,k.nmkelompok as URAIAN,null as NILAI,
                        null as NILAIKLP,k.isian,null AS KETERANGAN
                        FROM MAST_KELOMPOK k
                        WHERE k.idform = '" & IDFORM.Text & "'
                        union
                        select 'IDR','" & NOTRANS & "',v.idkelompok,
                        v.idindikator,v.uraian,null,null,null,null
                        from v_indikator_jenisform v where v.idform = '" & IDFORM.Text & "'
                        order by 4"
            End If
            Dim dt As New DataTable
            If dt_detail IsNot Nothing Then
                dt = dt_detail
            Else
                dt = Await Tampilkan(sql)
                dt.Columns.Add("NO")
                dt.Columns.Add("NIL")
            End If
            Dgv1.DataSource = dt
            Dgv1.Columns("NO").DisplayIndex = 0
            Dgv1.Columns("PILIH").DisplayIndex = 7
            Dgv1.Columns("NIL").DisplayIndex = 8
            Dgv1.Columns("IDR").Visible = False
            Dgv1.Columns("NOTRANS").Visible = False
            Dgv1.Columns("IDINDIKATOR").Visible = False
            Dgv1.Columns("IDKELOMPOK").Visible = False
            Dgv1.Columns("ISIAN").Visible = False
            Dgv1.Columns("NILAI").Visible = False
            Dgv1.Columns("NILAIKLP").Visible = False
            Dgv1.Columns("NO").ReadOnly = True
            Dgv1.Columns("URAIAN").ReadOnly = True
            Dgv1.Columns("NIL").ReadOnly = True
            Dgv1.Columns("NIL").HeaderText = "NILAI"

            Dgv1.Columns("NO").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Dgv1.Columns("NO").Width = 50
            Dgv1.Columns("NIL").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Dgv1.Columns("NIL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Dgv1.Columns("NIL").Width = 50
            Dgv1.Columns("PILIH").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Dgv1.Columns("PILIH").Width = 50
            Dgv1.Columns("KETERANGAN").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Dgv1.Columns("KETERANGAN").Width = 200
            Application.DoEvents()

            Dim n As Integer = 0
            For r As Integer = 0 To Dgv1.Rows.Count - 1
                If Dgv1.Rows(r).Cells("IDKELOMPOK").Value = "KLP" Then
                    Dgv1.Rows(r).Cells("NO").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Dgv1.Rows(r).DefaultCellStyle.BackColor = Color.Azure
                    Dgv1.Rows(r).DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    Dgv1.Rows(r).Cells("NO").Value = Dgv1.Rows(r).Cells("IDINDIKATOR").Value.ToString.Substring(5, 3)
                    If Dgv1.Rows(r).Cells("ISIAN").Value = "Y" Then
                        Dgv1.Rows(r).Cells("PILIH").Value = "Pilih"
                        Dgv1.Rows(r).Cells("URAIAN").Value = Dgv1.Rows(r).Cells("URAIAN").Value
                        Dgv1.Rows(r).Cells("PILIH").Style.BackColor = Color.Teal
                    Else
                        Dgv1.Rows(r).Cells("PILIH").Style.BackColor = Color.Azure
                    End If
                    If Dgv1.Item("NILAIKLP", r).Value.ToString.Contains("Y") Then
                        Dgv1.Rows(r).Cells("NIL").Value = "YA"
                    ElseIf Dgv1.Item("NILAIKLP", r).Value.ToString.Contains("T") Then
                        Dgv1.Rows(r).Cells("NIL").Value = "TIDAK"
                    End If
                    n = 0
                Else
                    n += 1
                    Dgv1.Rows(r).Cells("NO").Value = n & "."
                    Dgv1.Rows(r).Cells("NO").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    Dgv1.Rows(r).Cells("PILIH").Value = "Pilih"
                    Dgv1.Rows(r).Cells("PILIH").Style.BackColor = Color.DarkSlateGray
                    Dgv1.Rows(r).DefaultCellStyle.Font = New Font("Segoe UI", 9)
                    If Dgv1.Item("NILAI", r).Value.ToString.Contains("Y") Then
                        Dgv1.Rows(r).Cells("NIL").Value = "YA"
                    ElseIf Dgv1.Item("NILAI", r).Value.ToString.Contains("T") Then
                        Dgv1.Rows(r).Cells("NIL").Value = "TIDAK"
                    End If
                End If
                Dgv1.Rows(r).Cells("NIL").Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            Next
            Disablesortmode_dgv(Dgv1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pilihan(ByVal i As Integer)
        If i > -1 Then
            If Dgv1.Item("PILIH", i).Value Is "Pilih" Then
                Using f As New F_PilihanIndikator
                    f.ShowDialog()
                    Dgv1.Item("NIL", i).Value = f.VALUENYA
                    If Dgv1.Item("IDR", i).Value = "IDR" And Dgv1.Item("ISIAN", i).Value.ToString.Contains("Y") Then
                        Dgv1.Item("NILAIKLP", i).Value = f.IDNYA
                        For r As Integer = 0 To Dgv1.Rows.Count - 1
                            If Dgv1.Item("IDKELOMPOK", r).Value = Dgv1.Item("IDINDIKATOR", i).Value Then
                                Dgv1.Item("NILAIKLP", r).Value = f.IDNYA
                                If f.IDNYA = "T" Then
                                    Dgv1.Item("NILAI", r).Value = f.IDNYA
                                    Dgv1.Item("NIL", r).Value = f.VALUENYA
                                End If
                            End If
                        Next
                    Else
                        Dgv1.Item("NILAI", i).Value = f.IDNYA
                    End If
                End Using
            End If
        End If
    End Sub

    Private Sub Dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellClick
        If e.ColumnIndex = 0 Then
            pilihan(e.RowIndex)
        End If
    End Sub

    Private Sub Dgv1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellEnter
        i = e.RowIndex
    End Sub

    Private Sub Dgv1_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgv1.KeyDown
        If e.KeyCode = Keys.Enter Then
            pilihan(i)
        End If
    End Sub

    Private Sub Dgv1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Dgv1.CellFormatting
        If Dgv1.DataSource IsNot Nothing Then
            With e.CellStyle
                If e.ColumnIndex = Dgv1.Columns("NIL").Index Then
                    If e.Value.ToString.Contains("TIDAK") Then
                        .ForeColor = Color.Red
                    Else
                        .ForeColor = Color.Navy
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub F_DetailIndikator_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub F_DetailIndikator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        Dim dt As New DataTable
        dt = Dgv1.DataSource
        dt_detail = New DataTable
        dt_detail = dt
    End Sub
End Class