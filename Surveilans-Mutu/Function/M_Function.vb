Imports System.IO
Imports FirebirdSql.Data.FirebirdClient

Module M_Function
    Private Ini As New Class_fileini

    ''' <summary>
    ''' Buat String Koneksi
    ''' </summary>
    Public Sub Get_StrKoneksi(Optional pooling As Boolean = True)
        If Not My.Computer.FileSystem.FileExists(FileKoneksi) Then BuatFileKoneksi()
        Dim CB As New FbConnectionStringBuilder With {
            .DataSource = Ini.Baca_file_ini_perbaris(FileKoneksi, "SERVER", "IP"),
            .Database = Ini.Baca_file_ini_perbaris(FileKoneksi, "SERVER", "DB"),
            .UserID = "SYSDBA",
            .Password = "ihsan",
            .Port = Ini.Baca_file_ini_perbaris(FileKoneksi, "SERVER", "Port"),
            .Charset = "NONE",
            .Pooling = pooling
        }
        StrKoneksi = CB.ToString
    End Sub

    ''' <summary>
    ''' Cek koneksi database
    ''' </summary>
    ''' <returns>true dan false</returns>
    Public Function CekKoneksiDatabase() As Boolean
        Get_StrKoneksi()
        Try
            Using CON As New FbConnection(StrKoneksi)
                CON.Open()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Buat File Koneksi
    ''' </summary>
    Public Sub BuatFileKoneksi()
        File.Create(FileKoneksi).Dispose()
        Ini.Tulis_file_ini_perbaris(FileKoneksi, "SERVER", "IP", "localhost")
        Ini.Tulis_file_ini_perbaris(FileKoneksi, "SERVER", "Port", "3050")
        Ini.Tulis_file_ini_perbaris(FileKoneksi, "SERVER", "DB", "DBMUTU")
    End Sub

    Public Function Userentry() As String
        Return CurrentUserName & " - " & Datedatabase_waktu()
    End Function

    ''' <summary>
    ''' Get record 1 row/value
    ''' </summary>
    ''' <param name="SQL"></param>
    ''' <returns></returns>
    Public Function ExScalar(ByVal SQL As String)
        Get_StrKoneksi()
        Using con As New FbConnection(StrKoneksi)
            Try
                con.Open()
                Dim cmd As New FbCommand(SQL, con)
                Return cmd.ExecuteScalar()
            Catch ex As Exception
                Return Nothing
            End Try
        End Using
    End Function

    ''' <summary>
    ''' get data dengan nilai kembalian datatable
    ''' </summary>
    ''' <param name="SQL"></param>
    ''' <returns></returns>
    Public Async Function Tampilkan(ByVal SQL As String) As Task(Of DataTable)
        Dim dt As New DataTable
        Try
            Get_StrKoneksi()
            Using da As New FbDataAdapter(SQL, StrKoneksi)
                da.Fill(dt)
                Await Task.Delay(500)
            End Using
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox("Telah terjadi masalah.
                    Error : " & Err.Description, vbCritical + vbDefaultButton2, "Tampilkan Data ")
        End Try
    End Function

    ''' <summary>
    ''' tgl server
    ''' </summary>
    ''' <returns></returns>
    Public Function Datedatabase() As String
        Try
            Return Format(ExScalar("Select Current_date from rdb$database"), "dd.MM.yyy")
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' tgl jam server
    ''' </summary>
    ''' <returns></returns>
    Public Function Datedatabase_waktu() As String
        Try
            Return ExScalar("Select Current_timestamp from rdb$database")
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' format dd.MM.yyyy
    ''' </summary>
    ''' <returns></returns>
    Public Function Datedatabase_awalbulan() As String
        Try
            Return Format(CDate(ExScalar("SELECT DATEADD (-EXTRACT(DAY FROM CURRENT_DATE)+1 DAY TO CURRENT_DATE) AS FIRST_DAY_OF_MONTH FROM RDB$DATABASE")), "dd.MM.yyyy")
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' format dd.MM.yyyy
    ''' </summary>
    ''' <returns></returns>
    Public Function Datedatabase_awaltahun() As String
        Try
            Return Format(CDate("01.01." & ExScalar("SELECT EXTRACT(YEAR from CURRENT_DATE ) FROM RDB$DATABASE")), "dd.MM.yyyy")
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' mengubah format tgl ke dd.MM.yyyy
    ''' </summary>
    ''' <param name="tgl"></param>
    ''' <returns></returns>
    Public Function Format_date(ByVal tgl As String) As String
        Try
            Return Format(CDate(tgl), "dd.MM.yyyy")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' rekam aktivitas di save di log
    ''' </summary>
    ''' <param name="info"></param>
    Public Sub Rekam_aktivitas(ByVal info As String)
        Try
            Using FBCON = New FbConnection(StrKoneksi)
                FBCON.Open()
                '---------------Rekam Aktivitas Nya---------------- 
                FBCmd = New FbCommand With {
                    .Connection = FBCON,
                    .CommandType = CommandType.StoredProcedure,
                    .CommandText = "Execute Procedure S_LOG_INSERT('" & CurrentKodeUser & "',
                    '" & CurrentUserName & "',
                    '" & info & "',
                    '" & Environ("ComputerName") & "')"
                }
                FBCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' untuk memakai funsi ini, harus membuat variable dalam bentuk keyvaluepair agar dapat mengambil nilainya
    ''' ex : Dim pair As KeyValuePair(Of String, String) = panggilpencarian(SQLNYA,NMFORM,FORMNYA)
    ''' </summary>
    ''' <param name="SQLNYA"></param>
    ''' <param name="NMFORM"></param>
    ''' <param name="formnya"></param>
    ''' <returns></returns>
    Public Function Panggilpencarian(ByVal SQLNYA As String, ByVal KOLOMCARI As String, ByVal KOLOMID As String, ByVal KOLOMVALUE As String,
                                     ByVal NMFORM As String, ByVal formnya As Form) As KeyValuePair(Of String, String)
        Using f As New F_Pencarian
            f.Text = NMFORM
            f.SQLNYA = SQLNYA
            f.KOLOMCARI = KOLOMCARI
            f.KOLOMID = KOLOMID
            f.KOLOMVALUE = KOLOMVALUE
            f.ShowDialog(formnya)
            Return New KeyValuePair(Of String, String)(f.IDNYA, f.VALUENYA)
        End Using
    End Function

    Public Sub Disablesortmode_dgv(ByVal dgv As DataGridView)
        For i As Integer = 0 To dgv.Columns.Count - 1
            dgv.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

#Region "Transaction"
    Public Sub Start_Transaction()
        Get_StrKoneksi()
        FBCON = New FbConnection(StrKoneksi)
        FBCON.Open()
        FBCmd = New FbCommand With {
            .Connection = FBCON
        }
        FBT = FBCON.BeginTransaction 'START TRANSACTION
        FBCmd.Transaction = FBT
    End Sub
    Public Sub Transaction_di_Tutup()
        FBT = Nothing
        FBCmd = Nothing
        FBCON.Close()
    End Sub
    Public Sub Transaction_Execute(ByVal Sql_Insert_Update_Delete As String)
        FBCmd.CommandType = CommandType.Text
        FBCmd.CommandText = Sql_Insert_Update_Delete
        FBCmd.ExecuteNonQuery()
    End Sub
    Public Sub Transaction_di_Commit(Optional Pesan As String = "")  ' Tanpa dengan Pesan ...
        Try
            FBT.Commit()
            If Pesan <> "" Then MsgBox(Pesan & " -> Sukses", vbInformation, "Sukses")
        Catch ex As Exception
            MsgBox("Telah terjadi masalah.
                    Error : " & Err.Description, vbCritical + vbDefaultButton2, "Commit Transaction ")
        End Try
    End Sub
    Public Sub Transaction_di_Rollback(Optional Pesan As String = "")
        Try
            FBT.Rollback()
            If Pesan <> "" Then MsgBox(Pesan & " -> Gagal " & Err.Description, vbExclamation, "Transaction --> Rollback")
        Catch ex As Exception
            MsgBox("Telah terjadi masalah.
                    Error : " & Err.Description, vbCritical + vbDefaultButton2, "Rollback Transaction ")
        End Try
    End Sub
#End Region

#Region "Transaction with FBAdapter"
    Public Function Start_Transaction_withFBdataadapter(ByVal sql As String) As Boolean
        Try
            FBCON = New FbConnection(StrKoneksi)
            FBCON.Open()
            FBCmd = New FbCommand With {
                .Connection = FBCON
            }

            FBA = New FbDataAdapter(sql, FBCON)
            Dim cmdBuilder As New FbCommandBuilder(FBA)
            da_delete = cmdBuilder.GetDeleteCommand
            da_Insert = cmdBuilder.GetInsertCommand
            da_update = cmdBuilder.GetUpdateCommand

            FBT = FBCON.BeginTransaction
            FBCmd.Transaction = FBT
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub Commit_Transaction_withFBdataadapter(ByVal dgv As DataTable, Optional pesan As String = "")
        da_delete.Transaction = FBT
        da_Insert.Transaction = FBT
        da_update.Transaction = FBT
        FBA.Update(dgv)

        FBT.Commit()
        If pesan <> "" Then MsgBox(pesan & " -> Sukses", vbInformation, "Sukses")
    End Sub
    Public Sub Rollback_Transaction_withFBdataadapter(Optional pesan As String = "")
        FBT.Rollback()
        If pesan <> "" Then MsgBox(pesan & " -> Gagal " & Err.Description, vbExclamation, "Transaction --> Rollback")
    End Sub
#End Region

End Module
