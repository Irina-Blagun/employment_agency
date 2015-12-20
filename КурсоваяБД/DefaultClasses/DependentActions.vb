Imports System.Data.SqlClient

Public Class DependentActions
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet

    Dim Table As DataGridView
    Dim TableQueryLast As String

    ' *Contructor

    Public Sub New(Table As DataGridView)
        Me.Table = Table
    End Sub

    ' *Default methods

    Private Sub UpdateDataset()
        RenderDataset(TableQueryLast)
    End Sub

    Public Sub RenderDataset(Query As String)
        TableQueryLast = Query

        Try
            SQLControl.SQLCon.Open()

            SQLCmd = New SqlCommand(Query, SQLControl.SQLCon)
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

    Public Sub RunQueryAndUpdate(Query As String, SuccessMsg As String, ErrorMsg As String)
        Try
            SQLControl.SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLControl.SQLCon)
            SQLCmd.ExecuteNonQuery()
            SQLControl.SQLCon.Close()

            MsgBox(SuccessMsg)
        Catch ex As Exception
            SQLControl.SQLCon.Close()
            MsgBox(ErrorMsg & "', ['" & ex.Message & "']'")
        Finally
            Me.UpdateDataset()
        End Try
    End Sub

    ' *Default function

    Public Function getCellSelectedRow(Number As Integer) As String
        Return Table.Rows(Table.CurrentCell.RowIndex).Cells(Number).Value
    End Function

End Class
