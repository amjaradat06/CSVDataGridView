Imports System.IO
Imports System.Text

Public Class Form1
    Dim index As Integer
    Private Sub BtnLoadFromCSV_Click(sender As Object, e As EventArgs) Handles BtnLoadFromCSV.Click

        Dim fname As String = "c:\TCLauncher\test.csv"
        Dim colsexpected As Integer = 5
        Dim thereader As New StreamReader(fname, Encoding.Default)
        Dim sline As String = ""
        Do
            sline = thereader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim words() As String = sline.Split(",")
            DataGridView1.Rows.Add("")
            If words.Length = colsexpected Then
                For ix As Integer = 0 To 4
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(ix).Value = words(ix)
                Next
            Else
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "error"
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Pink
            End If
        Loop
        thereader.Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        index = e.RowIndex
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtID.Text = row.Cells(0).Value.ToString
            txtString1.Text = row.Cells(1).Value.ToString
            txtName.Text = row.Cells(2).Value.ToString
            txtDate.Text = row.Cells(3).Value.ToString
            txtValue.Text = row.Cells(4).Value.ToString
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim r As Integer = DataGridView1.Rows.Count - 1
        DataGridView1.Rows(r).Cells(0).Value = txtID.Text()
        DataGridView1.Rows(r).Cells(1).Value = txtString1.Text()
        DataGridView1.Rows(r).Cells(2).Value = txtName.Text()
        DataGridView1.Rows(r).Cells(3).Value = txtDate.Text()
        DataGridView1.Rows(r).Cells(4).Value = txtValue.Text()
        DataGridView1.Rows.Add()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim newDataRow As DataGridViewRow
        newDataRow = DataGridView1.Rows(index)
        newDataRow.Cells(0).Value = txtID.Text
        newDataRow.Cells(1).Value = txtString1.Text
        newDataRow.Cells(2).Value = txtName.Text
        newDataRow.Cells(3).Value = txtDate.Text
        newDataRow.Cells(4).Value = txtValue.Text


    End Sub
End Class
