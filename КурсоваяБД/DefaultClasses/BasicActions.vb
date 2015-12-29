Imports System.Data.SqlClient

Public Class BasicActions
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet

    Dim Table As DataGridView
    Dim TableQueryDefault As String

    Public Sub New(Table As DataGridView, TableQueryDefault As String)
        Me.Table = Table
        Me.TableQueryDefault = TableQueryDefault
        Me.UpdateDataset()
    End Sub

    ' Default methods and function

    Public Function checkSelectedRow() As Boolean
        If Table.CurrentCell.ToString And Table.Rows(Table.CurrentCell.RowIndex).Cells(0).Value.ToString.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getCellSelectedRow(Number As Integer) As String
        Return Table.Rows(Table.CurrentCell.RowIndex).Cells(Number).Value
    End Function

    Public Function getCellSelectedRowByte(Number As Integer) As Byte()
        If IsDBNull(Table.Rows(Table.CurrentCell.RowIndex).Cells(Number)) Then
            Return Table.Rows(Table.CurrentCell.RowIndex).Cells(Number).Value
        End If
    End Function

    Public Sub UpdateDataset()
        Try
            SQLControl.SQLCon.Open()

            SQLCmd = New SqlCommand(TableQueryDefault, SQLControl.SQLCon)
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataset = New DataSet
            SQLDA.Fill(SQLDataset)

            SQLControl.SQLCon.Close()

            If SQLDataset.Tables.Count > 0 Then
                Table.DataSource = SQLDataset.Tables(0)
            End If
        Catch ex As Exception
            SQLControl.SQLCon.Close()
        End Try
    End Sub

    Public Sub RunQueryAndUpdate(Query As String, ErrorMsg As String)
        Try
            SQLControl.SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLControl.SQLCon)
            SQLCmd.ExecuteNonQuery()
            SQLControl.SQLCon.Close()
        Catch ex As Exception
            SQLControl.SQLCon.Close()
            MsgBox(ErrorMsg & "', ['" & ex.Message & "']'")
        Finally
            Me.UpdateDataset()
        End Try
    End Sub

    Public Sub RunQueryWidthParametersAndUpdate(Query As String, ErrorMsg As String, Image() As Byte)
        Try
            SQLControl.SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLControl.SQLCon)

            SQLCmd.Parameters.Add(New SqlParameter("@img", Image))

            SQLCmd.ExecuteNonQuery()
            SQLControl.SQLCon.Close()
        Catch ex As Exception
            SQLControl.SQLCon.Close()
            MsgBox(ErrorMsg & "', ['" & ex.Message & "']'")
        Finally
            Me.UpdateDataset()
        End Try
    End Sub

    Public Function CheckValueOfTheUniqueness(Query As String)
        Try
            SQLControl.SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLControl.SQLCon)
            Dim reader As SqlDataReader = SQLCmd.ExecuteReader()

            If reader.HasRows Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            SQLControl.SQLCon.Close()
        End Try
    End Function
End Class
