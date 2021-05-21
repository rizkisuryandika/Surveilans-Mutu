Imports FirebirdSql.Data.FirebirdClient
Public Class F_Splash
    Dim n As Integer
    'Dim Status As String
    'Setting Form Utama setelah Flash =======
    Dim loadform As Form = F_CariIndikator


    Private Sub F_Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n = 1
        Me.Timer1.Start()
        CheckForIllegalCrossThreadCalls = False

        For Each arg As String In My.Application.CommandLineArgs
            Console.WriteLine(arg)
        Next
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        BackgroundWorker1.Dispose()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Select Case status.Text
            Case "Loading..."
                Get_StrKoneksi()
                n = 2
            Case "Setting Koneksi Database..."
                Try
                    Dim con As New FbConnection(StrKoneksi)
                    con.Open()
                    n = 4
                Catch ex As Exception
                    n = 3
                End Try
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case n
            Case 1
                n = 0
                status.Text = "Loading..."
                Application.DoEvents()
                Get_StrKoneksi()
                BackgroundWorker1.RunWorkerAsync()
            Case 2
                n = 0
                status.Text = "Setting Koneksi Database..."
                Application.DoEvents()
                BackgroundWorker1.RunWorkerAsync()
            Case 3
                n = 0
                Dim result As DialogResult = MessageBox.Show("Koneksi aplikasi ke database gagal. Setting koneksi sekarang ?", "Koneksi Gagal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.No Then
                    Me.Close()
                ElseIf result = DialogResult.Yes Then
                    'My.Forms.S_PasswordSetting.ShowDialog()
                    n = 2
                    status.Text = "Setting Koneksi Database..."
                    BackgroundWorker1.RunWorkerAsync()
                End If
            Case 4
                status.Text = "Mempersiapkan Sistem, Tunggu Sebentar..."
                Application.DoEvents()
                Try
                    loadform.Show()
                    loadform.Focus()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select
    End Sub
End Class