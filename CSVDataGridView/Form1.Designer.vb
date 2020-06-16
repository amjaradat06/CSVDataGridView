<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnLoadFromCSV = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtString1 = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLoadFromCSV
        '
        Me.BtnLoadFromCSV.Location = New System.Drawing.Point(12, 10)
        Me.BtnLoadFromCSV.Name = "BtnLoadFromCSV"
        Me.BtnLoadFromCSV.Size = New System.Drawing.Size(86, 23)
        Me.BtnLoadFromCSV.TabIndex = 0
        Me.BtnLoadFromCSV.Text = "Load from CSV"
        Me.BtnLoadFromCSV.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(628, 144)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "String 1"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Value"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(12, 189)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(628, 20)
        Me.txtID.TabIndex = 2
        '
        'txtString1
        '
        Me.txtString1.Location = New System.Drawing.Point(12, 215)
        Me.txtString1.Name = "txtString1"
        Me.txtString1.Size = New System.Drawing.Size(628, 20)
        Me.txtString1.TabIndex = 3
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(12, 267)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(628, 20)
        Me.txtDate.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 241)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(628, 20)
        Me.txtName.TabIndex = 4
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(12, 293)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(628, 20)
        Me.txtValue.TabIndex = 6
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(12, 319)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(93, 319)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 8
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtString1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnLoadFromCSV)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLoadFromCSV As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtString1 As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnUpdate As Button
End Class
