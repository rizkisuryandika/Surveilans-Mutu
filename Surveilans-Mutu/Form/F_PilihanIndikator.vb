Public Class F_PilihanIndikator
    Public IDNYA, VALUENYA As Object
    Private i As Integer

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            IDNYA = Me.DataGridView1.Item("NILAI", i).Value
            VALUENYA = Me.DataGridView1.Item("JAWABAN", i).Value
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            IDNYA = ""
            VALUENYA = ""
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex > -1 Then
            IDNYA = Me.DataGridView1.Item("NILAI", e.RowIndex).Value
            VALUENYA = Me.DataGridView1.Item("JAWABAN", e.RowIndex).Value
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        i = e.RowIndex
    End Sub

    Private Sub F_PilihanIndikator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.DataGridView1
            .BorderStyle = BorderStyle.None
            .RowHeadersWidth = 30
            .ColumnHeadersVisible = False
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
            .Font = New Font("Segoe UI", 10)
            .BackgroundColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        End With
        Try
            Dim dt As New DataTable
            dt.Columns.Add("NILAI")
            dt.Columns.Add("JAWABAN")
            dt.Rows.Add("Y", "YA")
            dt.Rows.Add("T", "TIDAK")
            Me.DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class