Imports System.Data.SqlClient

Public Module User
    Public SQLCmd As SqlCommand

    Public _id As Integer
    Public _email As String
    Public _fullname As String
    Public _phone As String

    Public Function Login(Email As String, Password As String) As Boolean
        Dim Query As String = "SELECT id, email, fullname, phone FROM members WHERE email='" & Email & "' and password='" & Password & "'"

        Try
            SQLControl.SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLControl.SQLCon)
            Dim reader As SqlDataReader = SQLCmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                _id = reader(0)
                _email = reader(1)
                _fullname = reader(2)
                _phone = reader(3)

                MsgBox("Успешно авторизировались")
            End If
            SQLControl.SQLCon.Close()
            Return True
        Catch ex As Exception
            SQLControl.SQLCon.Close()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Module
