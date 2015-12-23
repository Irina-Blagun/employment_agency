Imports System.Data.Sql
Imports System.Data.SqlClient

Public Module SQLControl
    Dim Server As String = "IRINABLAGUN7D0D\SQLEXPRESS"
    Dim Security As String = "SSPI"
    Dim Database As String = "employment.agency"
    Dim User As String = "IRINABLAGUN7D0D\Irina"

    Public SQLCon As New SqlConnection With {.ConnectionString = "Server='" & Server & "';Integrated Security='" & Security & "';Database='" & Database & "';User='" & User & "';"}

    Public Function hasConecction() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Module
