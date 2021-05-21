Imports cdgv = MedtindoLibrary.cs_DGV

Public Class F_Pencarian

    Private dt As New DataTable
    Private n As Integer = 0, t As Integer = 0
    Public SQLNYA, IDNYA, VALUENYA, KOLOMCARI, KOLOMID, KOLOMVALUE As String
    Private ReadOnly bs As New BindingSource()

    Private Sub get_columns()
        Try
            isi_pilihFaskes.Items.Clear()
            For Each col As DataColumn In dt.Columns
                isi_pilihFaskes.Items.Add(col.ColumnName)
            Next
            isi_pilihFaskes.SelectedItem = KOLOMCARI
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Txcari() As String
        If txpencarian.Text = "" Then
            Return "%"
        Else
            Return txpencarian.Text
        End If
    End Function

    Private Sub Search_dgv()
        Try
            If dt.Rows.Count > 0 Then
                bs.DataSource = dt
                bs.Filter = String.Format("{0} LIKE '%{1}%'", isi_pilihFaskes.SelectedItem, Txcari)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txpencarian.TextChanged
        t = 0
        Me.Timer1.Enabled = True
        If Me.txpencarian.Text = "" Then
            Refreshdatanya()
        End If
    End Sub

    Private Sub F_Pencarian_Load(sender As Object, e As EventArgs) Handles Me.Load
        cdgv.Skin1(Dgv1)
        Dgv1.RowTemplate.Height = 30
        Me.Dgv1.ReadOnly = True
        txpencarian.Select()
        Refreshdatanya()
    End Sub

    Private Sub txcari_KeyDown(sender As Object, e As KeyEventArgs) Handles txpencarian.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                IDNYA = ""
                VALUENYA = ""
                SendKeys.Send("{ENTER}")
            Case Keys.Enter
                Me.Close()
            Case Keys.Up
                If n > 0 Then
                    n -= 1
                    Dgv1.CurrentCell = Dgv1.Rows(n).Cells(1)
                End If
            Case Keys.Down
                If n < Dgv1.Rows.Count - 1 Then
                    n += 1
                    Dgv1.CurrentCell = Dgv1.Rows(n).Cells(1)
                End If
        End Select
    End Sub

    Private Sub Dgv1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellEnter
        n = Dgv1.CurrentRow.Index
        IDNYA = Dgv1.Item(KOLOMID, n).Value
        VALUENYA = Dgv1.Item(KOLOMVALUE, n).Value
    End Sub

    Private Sub Dgv1_DoubleClick(sender As Object, e As EventArgs) Handles Dgv1.DoubleClick
        SendKeys.Send("{ENTER}")
    End Sub

    Private Async Sub Refreshdatanya()
        Try
            dt = Await Tampilkan(SQLNYA)
            If dt IsNot Nothing Then
                Dgv1.DataSource = dt
                Dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                get_columns()
                Me.txpencarian.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If t = 3 Then
            Search_dgv()
            Me.Timer1.Enabled = False
            t = 0
        Else
            t += 1
        End If
    End Sub

    Private Sub Dgv1_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgv1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.Close()
        End If
    End Sub
End Class