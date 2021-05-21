Imports MedtindoLibrary

Public Class F_EntryIndikator
    Private sql As String = "", info As String = ""
    Private dt_detail As DataTable = Nothing

    Private Sub BTNUPF_Click(sender As Object, e As EventArgs) Handles BTNUPF.Click
        Try
            Dim keyValuePair = Panggilpencarian("SELECT IDUPF,NMUPF FROM MASTUPF WHERE AKTIF ='Y'", "NMUPF",
                                                "IDUPF", "NMUPF", "Pencarian Unit", Me)
            Me.IDUPF.Text = keyValuePair.Key
            Me.NMUPF.Text = keyValuePair.Value
        Catch ex As Exception
            Me.IDUPF.Text = ""
            Me.NMUPF.Text = ""
        End Try
    End Sub

    Private Sub BTNFORM_Click(sender As Object, e As EventArgs) Handles BTNFORM.Click
        Try
            Dim keyValuePair = Panggilpencarian("SELECT IDFORM,NMFORM FROM V_JENISFORM_UPF WHERE IDUPF ='" & IDUPF.Text & "'", "NMFORM",
                                                "IDFORM", "NMFORM", "Pencarian Formulir Mutu", Me)
            Me.IDFORM.Text = keyValuePair.Key
            Me.NMFORM.Text = keyValuePair.Value
        Catch ex As Exception
            Me.IDFORM.Text = ""
            Me.NMFORM.Text = ""
        End Try
    End Sub

    Private Sub nomorbaru()
        Try
            Me.NOTRANS.Text = ExScalar("SELECT * FROM NOTRANS_INDIKATOR('" & Format_date(TGLTRANS.Value) & "')")
        Catch ex As Exception
            Me.NOTRANS.Text = "..."
        End Try
    End Sub

    Private Sub kosongkan()
        Me.NOTRANS.Text = "..."
        Me.STATUSFORM.Text = "..."
        Me.TGLTRANS.Value = Datedatabase()
        Me.IDUPF.Text = ""
        Me.NMUPF.Text = ""
        Me.IDFORM.Text = ""
        Me.NMFORM.Text = ""
        Me.AUDITOR.Text = ""
        Me.ENTRYBY.Text = "-"
        Me.EDITBY.Text = "-"
    End Sub

    Private Async Sub Get_data()
        Try
            Dim dt As New DataTable
            dt = Await Tampilkan("SELECT h.*,u.nmupf,j.nmform
                                        from HEADER_INDIKATOR h
                                        inner join MASTUPF u on h.idupf = u.idupf
                                        inner join mast_jenisform j on h.idform = j.idform
                                        where h.NOTRANS =  '" & NOTRANS.Text & "'")
            If dt.Rows.Count > 0 Then
                TGLTRANS.Value = Format_date(dt.Rows(0).Item("TGLTRANS").ToString)
                IDUPF.Text = dt.Rows(0).Item("IDUPF").ToString
                NMUPF.Text = dt.Rows(0).Item("NMUPF").ToString
                IDFORM.Text = dt.Rows(0).Item("IDFORM").ToString
                NMFORM.Text = dt.Rows(0).Item("NMFORM").ToString
                AUDITOR.Text = dt.Rows(0).Item("AUDITOR").ToString
                ENTRYBY.Text = dt.Rows(0).Item("ENTRYBY").ToString
                EDITBY.Text = dt.Rows(0).Item("EDITBY").ToString
                BTNUPF.Enabled = False
                BTNFORM.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNBARU_Click(sender As Object, e As EventArgs) Handles BTNBARU.Click
        If BTNBARU.Text = "BARU F6" Then
            Me.BTNBARU.Text = "BATAL F6"
            Me.TGLTRANS.Value = Datedatabase()
            Me.STATUSFORM.Text = "Buat Data Monitoring"
            Me.BTNUPF.Select()
            Me.nomorbaru()
            Me.BTNSIMPAN.Visible = True
            Me.BTNHAPUS.Visible = False
            Me.BTNMUTU.Visible = True
            Me.BTNUPF.Enabled = True
            Me.BTNFORM.Enabled = True
            Me.ENTRYBY.Text = Userentry()
        Else
            Me.BTNBARU.Text = "BARU F6"
            kosongkan()
            Me.BTNSIMPAN.Visible = False
            Me.BTNHAPUS.Visible = False
            Me.BTNMUTU.Visible = False
            Me.BTNUPF.Enabled = False
            Me.BTNFORM.Enabled = False
            Me.dt_detail = Nothing
        End If
    End Sub

    Private Function cek_() As Boolean
        If IDUPF.Text = "" Or IDUPF.Text = String.Empty Then
            MessageBox.Show("Unit belum di pilih, cek kembali", "Peringatan !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            BTNUPF.Select()
            Return False
        ElseIf IDFORM.Text = "" Or IDFORM.Text = String.Empty Then
            MessageBox.Show("Unit belum di pilih, cek kembali", "Peringatan !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            BTNFORM.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function SIMPAN() As Boolean
        Try
            Start_Transaction()
            If STATUSFORM.Text = "Buat Data Monitoring" Then
                If cek_() = False Then
                    Return False
                    Exit Try
                End If
                nomorbaru()
                info = "Simpan Data "
                sql = "INSERT INTO HEADER_INDIKATOR
                           (NOTRANS,IDUPF,TGLTRANS,IDFORM,AUDITOR,ENTRYBY)
                           VALUES
                           ('" & NOTRANS.Text & "','" & IDUPF.Text & "','" & Format_date(TGLTRANS.Value) & "','" & IDFORM.Text & "',
                           '" & AUDITOR.Text & "','" & Userentry() & "')"
            Else
                If IDFORM.Text <> ExScalar("SELECT IDFORM FROM HEADER_INDIKATOR where NOTRANS = '" & NOTRANS.Text & "'") Then
                    Dim result = MessageBox.Show("Data formulir berbeda dari sebelumnya, yakin ingin mengubah data ini? jika YES maka data nilai sebelumnya akan di hapus", "Peringatan !", MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                    If result = DialogResult.No Then
                        Transaction_di_Tutup()
                        Return False
                        Exit Function
                    End If
                End If
                info = "Update Data "
                sql = "UPDATE HEADER_INDIKATOR SET
                           IDUPF = '" & IDUPF.Text & "',TGLTRANS = '" & Format_date(TGLTRANS.Value) & "',IDFORM = '" & IDFORM.Text & "',
                           AUDITOR = '" & AUDITOR.Text & "',EDITBY = '" & Userentry() & "'
                           WHERE NOTRANS = '" & NOTRANS.Text & "'"
            End If
            Transaction_Execute(sql)
            Transaction_di_Commit()
            If STATUSFORM.Text = "Buat Data Monitoring" Then
                STATUSFORM.Text = "Data Monitoring"
            End If
            Return True
        Catch ex As Exception
            Transaction_di_Rollback(info)
            Return False
        Finally
            Transaction_di_Tutup()
        End Try
    End Function

    Private Function SIMPANDETAIL() As Boolean
        Try
            Dim tf As Boolean = False
            Dim n As Boolean = False
            If dt_detail.Rows.Count > 0 Then
                If ExScalar("SELECT count(IDR) from DETAIL_INDIKATOR where NOTRANS = '" & NOTRANS.Text & "'") > 0 Then
                    n = True
                Else
                    n = False
                End If
                For Each r As DataRow In dt_detail.Rows
                    If r.Item("IDKELOMPOK").ToString <> "KLP" Then
                        Try
                            Start_Transaction()
                            Console.WriteLine(r.Item("NILAI").ToString)
                            Dim _nil = IIf(r.Item("NILAI").ToString = String.Empty, "A", r.Item("NILAI").ToString)
                            Dim _nilklp = IIf(r.Item("NILAIKLP").ToString = String.Empty Or r.Item("NILAIKLP").ToString = "" And r.Item("ISIAN").ToString = "Y", "A", r.Item("NILAIKLP").ToString)
                            If n = True Then
                                sql = "UPDATE DETAIL_INDIKATOR SET
                                    NILAI ='" & _nil & "',NILAIKLP='" & _nilklp & "',
                                    KETERANGAN ='" & r.Item("KETERANGAN").ToString & "'
                                    where IDR = '" & r.Item("IDR").ToString & "'"
                            Else
                                sql = "INSERT INTO DETAIL_INDIKATOR
                                   (NOTRANS,IDINDIKATOR,IDKELOMPOK,NILAI,NILAIKLP,KETERANGAN)
                                   values
                                   ('" & r.Item("NOTRANS").ToString & "','" & r.Item("IDINDIKATOR").ToString & "','" & r.Item("IDKELOMPOK").ToString & "',
                                   '" & _nil & "','" & _nilklp & "','" & r.Item("KETERANGAN").ToString & "')"
                            End If
                            Transaction_Execute(sql)
                            Transaction_di_Commit()
                            tf = True
                        Catch ex As Exception
                            Transaction_di_Rollback("gagal")
                            Transaction_di_Tutup()
                            tf = False
                            Exit For
                        Finally
                            Transaction_di_Tutup()
                        End Try
                    End If
                Next
                Return tf
            Else
                dt_detail = Nothing
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        If SIMPAN() Then
            If SIMPANDETAIL() Then
                If STATUSFORM.Text = "Buat Data Monitoring" Then
                    STATUSFORM.Text = "Detail Data Mutu"
                End If
                MessageBox.Show("Simpan Data Berhasil.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                BTNBARU.PerformClick()
            End If
        End If
    End Sub

    Private Sub TGLTRANS_ValueChanged(sender As Object, e As EventArgs) Handles TGLTRANS.ValueChanged
        If STATUSFORM.Text = "Buat Data Monitoring" Then
            If IsDate(TGLTRANS.Value) Then
                nomorbaru()
            End If
        End If
    End Sub

    Private Sub F_EntryIndikator_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F6
                BTNBARU.PerformClick()
            Case Keys.F7
                BTNSIMPAN.PerformClick()
            Case Keys.F8
                BTNHAPUS.PerformClick()
            Case Keys.F9
                BTNMUTU.PerformClick()
        End Select
    End Sub

    Private Sub F_EntryIndikator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If STATUSFORM.Text = "Detail Data Mutu" Then
            Get_data()
            Me.BTNBARU.Text = "BATAL F6"
            Me.BTNSIMPAN.Visible = True
            Me.BTNHAPUS.Visible = True
            BTNMUTU.Visible = True
        Else
            BTNBARU.PerformClick()
        End If
    End Sub

    Private Function Hapus_data()
        Try
            Start_Transaction()
            Transaction_Execute("DELETE FROM HEADER_INDIKATOR where NOTRANS = '" & NOTRANS.Text & "'")
            Transaction_di_Commit()
            Return True
        Catch ex As Exception
            Transaction_di_Rollback("Hapus ")
            Return False
        Finally
            Transaction_di_Tutup()
        End Try
    End Function

    Private Sub BTNHAPUS_Click(sender As Object, e As EventArgs) Handles BTNHAPUS.Click
        Dim result = MessageBox.Show("Yakin data indikator dihapus ?", "Peringatan !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            If Hapus_data() Then
                MessageBox.Show("Hapus data berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                'Me.Close()
                BTNBARU.PerformClick()
            End If
        End If
    End Sub

    Private Sub BTNMUTU_Click(sender As Object, e As EventArgs) Handles BTNMUTU.Click
        If cek_() Then
            Using f As New F_DetailIndikator
                If dt_detail IsNot Nothing Then
                    f.dt_detail = dt_detail
                End If
                f.IDFORM.Text = IDFORM.Text
                f.IDUPF.Text = IDUPF.Text
                f.NMUPF.Text = NMUPF.Text
                f.NMFORM.Text = NMFORM.Text
                f.NOTRANS = NOTRANS.Text
                f.ShowDialog()
                dt_detail = New DataTable
                dt_detail = f.Dgv1.DataSource
            End Using
        End If
    End Sub

End Class