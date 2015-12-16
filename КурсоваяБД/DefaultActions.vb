Imports System.Data.SqlClient

Public Class DefaultActions
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet

    Dim Table As Object
    Dim TableQueryDefault As String

    Public Sub New(Table As Object, TableQueryDefault As String)
        Me.Table = Table
        Me.TableQueryDefault = TableQueryDefault
        Me.UpdateDataset()
    End Sub

    ' Default methods and function

    Public Function getCellSelectedRow(Number As Integer) As String
        Return Table.Rows(Table.CurrentCell.RowIndex).Cells(Number).Value.ToString()
    End Function

    Public Sub UpdateDataset()
        Try
            GlobalVariables.SQL.SQLCon.Open()

            SQLCmd = New SqlCommand(TableQueryDefault, GlobalVariables.SQL.SQLCon)
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataset = New DataSet
            SQLDA.Fill(SQLDataset)

            GlobalVariables.SQL.SQLCon.Close()

            If SQLDataset.Tables.Count > 0 Then
                Table.DataSource = SQLDataset.Tables(0)
            End If
        Catch ex As Exception
            GlobalVariables.SQL.SQLCon.Close()
        End Try
    End Sub

    Public Sub RunQueryAndUpdate(Query As String, SuccessMsg As String, ErrorMsg As String)
        Try
            GlobalVariables.SQL.SQLCon.Open()
            SQLCmd = New SqlCommand(Query, GlobalVariables.SQL.SQLCon)
            SQLCmd.ExecuteNonQuery()
            GlobalVariables.SQL.SQLCon.Close()

            MsgBox(SuccessMsg)
        Catch ex As Exception
            GlobalVariables.SQL.SQLCon.Close()
            MsgBox(ErrorMsg & "', ['" & ex.Message & "']'")
        Finally
            Me.updateDataset()
        End Try
    End Sub

    
End Class
