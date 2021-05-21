Imports MedtindoLibrary

Public Class F_NilaiIndikator
    Private ReadOnly VALUENYA, IDNYA As String
    Private n, i, ii, iii As Integer
    Private dt As New DataTable

    Private Sub _Btn1_Click(sender As Object, e As EventArgs) Handles _Btn1.Click
        judul.Text = "Nilai Per Formulir"
        Get_data()
    End Sub

    Private Sub _Btn2_Click(sender As Object, e As EventArgs) Handles _Btn2.Click
        judul.Text = "Nilai Per Unit"
        Get_data()
    End Sub

    Private Sub _Btn3_Click(sender As Object, e As EventArgs) Handles BTNPRINT.Click

    End Sub

    Private Sub _Btn4_Click(sender As Object, e As EventArgs) Handles _Btn4.Click
        judul.Text = "Nilai Kelompok Per Formulir"
        Get_data()
    End Sub

    Private Sub _Btn5_Click(sender As Object, e As EventArgs) Handles _Btn5.Click
        judul.Text = "Nilai Kelompok Per Unit"
        Get_data()
    End Sub

    Private Sub Dgv2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Dgv2.CellFormatting
        If Dgv2.DataSource IsNot Nothing Then
            With e.CellStyle
                If e.ColumnIndex = Dgv2.Columns("YA").Index Then
                    .ForeColor = Color.Navy
                    e.Value = e.Value & "%"
                ElseIf e.ColumnIndex = Dgv2.Columns("TIDAK").Index Then
                    .ForeColor = Color.OrangeRed
                    e.Value = e.Value & "%"
                ElseIf e.ColumnIndex = Dgv2.Columns("ABSTAIN").Index Then
                    .ForeColor = Color.DarkRed
                    e.Value = e.Value & "%"
                End If
            End With
        End If
    End Sub

    Private Async Sub Get_data()
        Try
            Dim sql As String = ""
            dt = New DataTable
            Select Case judul.Text
                Case "Nilai Per Formulir"
                    sql = "SELECT NMFORM as FORMULIR,Y as YA,T as TIDAK,A as ABSTAIN FROM P_NILAIBYFORM('" & Format_date(TGL1.Value) & "','" & Format_date(TGL2.Value) & "')
                           order by IDFORM"
                Case "Nilai Per Unit"
                    sql = "SELECT NMUPF as UNIT,Y as YA,T as TIDAK,A as ABSTAIN FROM P_NILAIBYUPF('" & Format_date(TGL1.Value) & "','" & Format_date(TGL2.Value) & "')
                           order by IDUPF"
                Case "Nilai Kelompok Per Formulir"
                    sql = "SELECT NMFORM as FORMULIR,Y as YA,T as TIDAK,A as ABSTAIN FROM P_NILAIKLPBYFORM('" & Format_date(TGL1.Value) & "','" & Format_date(TGL2.Value) & "')
                           order by IDFORM"
                Case "Nilai Kelompok Per Unit"
                    sql = "SELECT NMUPF as UNIT,Y as YA,T as TIDAK,A as ABSTAIN FROM P_NILAIKLPBYUPF('" & Format_date(TGL1.Value) & "','" & Format_date(TGL2.Value) & "')
                           order by IDUPF"
                Case Else
                    MessageBox.Show("Silahkan pilih terlebih dahulu data yang akan di tampilkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Try
            End Select

            dt = Await Tampilkan(sql)
            With Dgv2
                .DataSource = dt
                If dt.Rows.Count > 0 Then
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                End If
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
    End Sub

    Private Sub BTNBARU_Click(sender As Object, e As EventArgs) Handles BTNREFRESH.Click
        Get_data()
    End Sub

    Private Sub Dgv2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv2.CellEnter
        i = e.RowIndex
    End Sub

End Class