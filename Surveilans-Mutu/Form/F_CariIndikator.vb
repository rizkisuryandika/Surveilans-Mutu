Imports MedtindoLibrary

Public Class F_CariIndikator
    Private ReadOnly VALUENYA, IDNYA As String
    Private n, i, ii, iii As Integer
    Private dt As New DataTable
    Private bind As New BindingSource()

    Private Async Sub Get_data()
        Try
            dt = New DataTable
            dt = Await Tampilkan("Select i.notrans,i.tgltrans as TANGGAL,i.auditor,j.nmform,u.nmupf
                            from HEADER_INDIKATOR i
                            inner join MASTUPF u on i.idupf = u.idupf
                            inner join mast_jenisform j on i.idform = j.idform
                            WHERE i.TGLTRANS BETWEEN '" & Format_date(TGL1.Value) & "' and '" & Format_date(TGL2.Value) & "'
                            order by i.tgltrans desc, i.notrans asc")
            With Dgv2
                .DataSource = dt
                If dt.Rows.Count > 0 Then
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                End If
                Me.txpencarian.Select()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub F_CariIndikator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        cs_DGV.Skin1(Dgv2)
        Dgv2.BorderStyle = BorderStyle.FixedSingle
        TGL1.Value = Datedatabase_awalbulan()
        TGL2.Value = Datedatabase()
        BTNREFRESH.PerformClick()
        cb_.SelectedIndex = 2
        Me.txpencarian.Select()
    End Sub

    Private Sub BTNBARU_Click(sender As Object, e As EventArgs) Handles BTNREFRESH.Click
        Get_data()
    End Sub

    Private Sub Dgv2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv2.CellEnter
        i = e.RowIndex
    End Sub

    Private Function Txcari() As String
        If txpencarian.Text = "" Then
            Return "%"
        Else
            Return txpencarian.Text
        End If
    End Function

    Private Sub Panggilform(ByVal n As Integer)
        Using f As New F_EntryIndikator
            f.NOTRANS.Text = Dgv2.Item("NOTRANS", n).Value
            f.STATUSFORM.Text = "Detail Data Mutu"
            f.ShowDialog()
        End Using
        BTNREFRESH.PerformClick()
    End Sub

    Private Sub Search_dgv()
        Try
            If dt.Rows.Count > 0 Then
                bind.DataSource = dt
                bind.Filter = String.Format("{0} LIKE '%{1}%'", cb_.SelectedItem, Txcari)
            End If
        Catch ex As Exception
            Cs_Pesan.KesalahanDetail(ex)
        End Try
    End Sub

    Private Sub txpencarian_TextChanged(sender As Object, e As EventArgs) Handles txpencarian.TextChanged
        iii = 0
        Me.Timer1.Enabled = True
        If Me.txpencarian.Text = "" Then
            Get_data()
        End If
    End Sub

    Private Sub _Btn1_Click(sender As Object, e As EventArgs) Handles _Btn1.Click
        Using f As New F_EntryIndikator
            f.ShowDialog()
            BTNREFRESH.PerformClick()
        End Using
    End Sub

    Private Sub _Btn2_Click(sender As Object, e As EventArgs) Handles _Btn2.Click
        Dim f As New F_NilaiIndikator
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If iii = 3 Then
            Search_dgv()
            Me.Timer1.Enabled = False
        Else
            iii += 1
        End If
    End Sub

    Private Sub Dgv2_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgv2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Panggilform(i)
        End If
    End Sub

    Private Sub txpencarian_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txpencarian.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Panggilform(i)
            Case Keys.Up
                If ii <> i Then
                    ii = i
                End If
                If ii > 0 Then
                    ii = ii - 1
                    Dgv2.CurrentCell = Dgv2.Rows(ii).Cells("NOTRANS")
                End If
            Case Keys.Down
                If ii <> i Then
                    ii = i
                End If
                If ii < Dgv2.RowCount - 1 Then
                    ii = ii + 1
                    Dgv2.CurrentCell = Dgv2.Rows(ii).Cells("NOTRANS")
                End If
        End Select
    End Sub

    Private Sub Dgv2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv2.CellDoubleClick
        If e.RowIndex > -1 Then
            Panggilform(e.RowIndex)
        End If
    End Sub

End Class