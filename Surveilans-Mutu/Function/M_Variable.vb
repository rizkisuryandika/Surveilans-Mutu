Imports FirebirdSql.Data.FirebirdClient

Module M_Variable
    Public FBCON As New FbConnection
    Public FBA As FbDataAdapter
    Public dr As FbDataReader
    Public FBCmd As New FbCommand
    Public FBT As FbTransaction
    Public fbTransOption As FbTransactionOptions
    Public RE As FbRemoteEvent
    Public REH As FbRemoteEventEventHandler
    Public da_delete As FbCommand
    Public da_Insert As FbCommand
    Public da_update As FbCommand

    Public StrKoneksi As String
    Public FileKoneksi As String = "C:\SIM\MUTU.ini"

    Public CurrentKodeUser As String
    Public CurrentUserName As String

End Module
