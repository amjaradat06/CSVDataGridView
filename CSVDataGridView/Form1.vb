Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Xml
Imports System.Security.Cryptography


Public Class Form1
    Dim index As Integer
    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform

    Public Sub ExportToCSV()
        'Create empty String
        Dim thecsvfile As String = String.Empty
        'get column headers
        For Each column As DataGridViewColumn In DataGridView1.Columns
            thecsvfile = thecsvfile & column.HeaderText & ","
        Next
        'trim the last comma
        thecsvfile = thecsvfile.TrimEnd(",")
        'add the line to the output
        thecsvfile = thecsvfile & vbCr & vbLf
        'get the rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            'get the cells
            For Each cell As DataGridViewCell In row.Cells
                thecsvfile = thecsvfile & cell.FormattedValue & ","
            Next
            'trim the last comma
            thecsvfile = thecsvfile.TrimEnd(",")
            'add the line to the output
            thecsvfile = thecsvfile & vbCr & vbLf
        Next
        'write the file
        'My.Computer.FileSystem.WriteAllText("export.csv", thecsvfile, False)
        My.Computer.FileSystem.WriteAllText("c:\TCLauncher\test.csv", thecsvfile, False)
    End Sub

    Public Sub LoadFromCSV()
        Dim fname As String = "c:\TCLauncher\test.csv"
        Dim colsexpected As Integer = 5
        Dim thereader As New StreamReader(fname, Encoding.Default)
        Dim sline As String = ""

        '.ReadLine() mentioned twice to skip the columns header
        sline = thereader.ReadLine()
        If sline Is Nothing Then Return

        Do
            sline = thereader.ReadLine()
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

    Private Sub BtnLoadFromCSV_Click(sender As Object, e As EventArgs) Handles BtnLoadFromCSV.Click
        LoadFromCSV()
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
        ExportToCSV()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim newDataRow As DataGridViewRow
        newDataRow = DataGridView1.Rows(index)
        newDataRow.Cells(0).Value = txtID.Text
        newDataRow.Cells(1).Value = txtString1.Text
        newDataRow.Cells(2).Value = txtName.Text
        newDataRow.Cells(3).Value = txtDate.Text
        newDataRow.Cells(4).Value = txtValue.Text
        ExportToCSV()
    End Sub

    Private Sub BtnExportToCSV_Click(sender As Object, e As EventArgs) Handles BtnExportToCSV.Click
        ExportToCSV()
    End Sub
    Private Sub EncryptionDetails()
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        Me.enc = New System.Text.UTF8Encoding
        Me.encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        Me.decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadFromCSV()
        EncryptionDetails()
    End Sub

    Private Sub Encrypt()
        Dim sPlainText As String = Me.txtString1.Text
        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(Me.enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            Me.txtString1.Text = Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        End If
    End Sub
    Private Sub Decrypt()
        Dim cypherTextBytes As Byte() = Convert.FromBase64String(Me.txtString1.Text)
        Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes(cypherTextBytes.Length) As Byte
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Me.txtString1.Text = Me.enc.GetString(plainTextBytes, 0, decryptedByteCount)
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure you want to delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            DataGridView1.Rows.RemoveAt(index)
        End If
    End Sub

    Private Sub BtnEncrypt_Click(sender As Object, e As EventArgs) Handles BtnEncrypt.Click
        Encrypt()
    End Sub

    Private Sub BtnDecrypt_Click(sender As Object, e As EventArgs) Handles BtnDecrypt.Click
        Decrypt()
    End Sub

    Private Sub txtString1_TextChanged(sender As Object, e As EventArgs) Handles txtString1.TextChanged
        'Decrypt() 
    End Sub
End Class
