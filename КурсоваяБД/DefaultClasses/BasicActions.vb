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
        Return Table.Rows(Table.CurrentCell.RowIndex).Cells(Number).Value.ToString()
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

    Public Sub SearchTable(Text As String)
        Dim a As Boolean = False
        Dim Row As DataGridViewRow
        For Each Row In Table.Rows

            For index As Integer = 0 To Row.Cells.Count - 1
                If (Row.Cells(index).Value.ToString().Contains(Text)) Then
                    Table.CurrentCell = Row.Cells(1)
                    Table.Rows(Row.Index).Selected = True
                    a = True
                End If
            Next

        Next
        If a = False Then MsgBox("Не найден", 32, "Поиск")
    End Sub


End Class
