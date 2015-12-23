Imports System.Data.Sql
Imports System.Data.SqlClient

Public Module SQLControl
    Dim Server As String = "localhost\IlyaSuhodolskiy"
    Dim Security As String = True
    Dim Database As String = "employment.agency"
    Dim User As String = "sa"
    Dim Password As String = "saa"

    Public SQLCon As New SqlConnection With {.ConnectionString = "Server='" & Server & "';Integrated Security='" & Security & "';Database='" & Database & "';User='" & User & "';Password='" & Password & "'"}

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