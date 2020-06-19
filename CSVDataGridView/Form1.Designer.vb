<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim lblEnvURL As System.Windows.Forms.Label
        Dim EnvNameLabel As System.Windows.Forms.Label
        Dim lblEnvUsername As System.Windows.Forms.Label
        Dim lblEnvPassword As System.Windows.Forms.Label
        Dim UserRoleLabel As System.Windows.Forms.Label
        Dim EnvTypeLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim LoadingTimeLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BtnExportToCSV = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxCustomer = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEnvType = New System.Windows.Forms.ComboBox()
        Me.txtboxEnvURL = New System.Windows.Forms.TextBox()
        Me.txtboxEnvName = New System.Windows.Forms.TextBox()
        Me.txtboxEnvUsername = New System.Windows.Forms.TextBox()
        Me.txtboxEnvPassword = New System.Windows.Forms.TextBox()
        Me.txtboxUserRole = New System.Windows.Forms.TextBox()
        Me.txtboxLoginLocation = New System.Windows.Forms.TextBox()
        Me.txtboxLoadingTime = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEncrypt = New System.Windows.Forms.Button()
        Me.BtnDecrypt = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        lblEnvURL = New System.Windows.Forms.Label()
        EnvNameLabel = New System.Windows.Forms.Label()
        lblEnvUsername = New System.Windows.Forms.Label()
        lblEnvPassword = New System.Windows.Forms.Label()
        UserRoleLabel = New System.Windows.Forms.Label()
        EnvTypeLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        LoadingTimeLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEnvURL
        '
        lblEnvURL.AutoSize = True
        lblEnvURL.Location = New System.Drawing.Point(16, 51)
        lblEnvURL.Name = "lblEnvURL"
        lblEnvURL.Size = New System.Drawing.Size(32, 13)
        lblEnvURL.TabIndex = 224
        lblEnvURL.Text = "URL:"
        '
        'EnvNameLabel
        '
        EnvNameLabel.AutoSize = True
        EnvNameLabel.Location = New System.Drawing.Point(16, 28)
        EnvNameLabel.Name = "EnvNameLabel"
        EnvNameLabel.Size = New System.Drawing.Size(38, 13)
        EnvNameLabel.TabIndex = 215
        EnvNameLabel.Text = "Name:"
        '
        'lblEnvUsername
        '
        lblEnvUsername.AutoSize = True
        lblEnvUsername.Location = New System.Drawing.Point(16, 80)
        lblEnvUsername.Name = "lblEnvUsername"
        lblEnvUsername.Size = New System.Drawing.Size(58, 13)
        lblEnvUsername.TabIndex = 217
        lblEnvUsername.Text = "Username:"
        '
        'lblEnvPassword
        '
        lblEnvPassword.AutoSize = True
        lblEnvPassword.Location = New System.Drawing.Point(291, 80)
        lblEnvPassword.Name = "lblEnvPassword"
        lblEnvPassword.Size = New System.Drawing.Size(56, 13)
        lblEnvPassword.TabIndex = 219
        lblEnvPassword.Text = "Password:"
        '
        'UserRoleLabel
        '
        UserRoleLabel.AutoSize = True
        UserRoleLabel.Location = New System.Drawing.Point(292, 132)
        UserRoleLabel.Name = "UserRoleLabel"
        UserRoleLabel.Size = New System.Drawing.Size(57, 13)
        UserRoleLabel.TabIndex = 248
        UserRoleLabel.Text = "User Role:"
        '
        'EnvTypeLabel
        '
        EnvTypeLabel.AutoSize = True
        EnvTypeLabel.Location = New System.Drawing.Point(291, 28)
        EnvTypeLabel.Name = "EnvTypeLabel"
        EnvTypeLabel.Size = New System.Drawing.Size(34, 13)
        EnvTypeLabel.TabIndex = 221
        EnvTypeLabel.Text = "Type:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(18, 106)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(80, 13)
        LocationLabel.TabIndex = 241
        LocationLabel.Text = "Login Location:"
        '
        'LoadingTimeLabel
        '
        LoadingTimeLabel.AutoSize = True
        LoadingTimeLabel.Location = New System.Drawing.Point(292, 106)
        LoadingTimeLabel.Name = "LoadingTimeLabel"
        LoadingTimeLabel.Size = New System.Drawing.Size(102, 13)
        LoadingTimeLabel.TabIndex = 210
        LoadingTimeLabel.Text = "Loading Time (Sec):"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(18, 132)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(54, 13)
        CustomerLabel.TabIndex = 216
        CustomerLabel.Text = "Customer:"
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
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        Me.txtString1.Location = New System.Drawing.Point(62, 215)
        Me.txtString1.Name = "txtString1"
        Me.txtString1.Size = New System.Drawing.Size(578, 20)
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
        'BtnExportToCSV
        '
        Me.BtnExportToCSV.Location = New System.Drawing.Point(174, 319)
        Me.BtnExportToCSV.Name = "BtnExportToCSV"
        Me.BtnExportToCSV.Size = New System.Drawing.Size(87, 23)
        Me.BtnExportToCSV.TabIndex = 9
        Me.BtnExportToCSV.Text = "Save"
        Me.BtnExportToCSV.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ComboBoxCustomer)
        Me.GroupBox4.Controls.Add(Me.ComboBoxEnvType)
        Me.GroupBox4.Controls.Add(lblEnvURL)
        Me.GroupBox4.Controls.Add(Me.txtboxEnvURL)
        Me.GroupBox4.Controls.Add(EnvNameLabel)
        Me.GroupBox4.Controls.Add(Me.txtboxEnvName)
        Me.GroupBox4.Controls.Add(lblEnvUsername)
        Me.GroupBox4.Controls.Add(Me.txtboxEnvUsername)
        Me.GroupBox4.Controls.Add(lblEnvPassword)
        Me.GroupBox4.Controls.Add(UserRoleLabel)
        Me.GroupBox4.Controls.Add(Me.txtboxEnvPassword)
        Me.GroupBox4.Controls.Add(Me.txtboxUserRole)
        Me.GroupBox4.Controls.Add(EnvTypeLabel)
        Me.GroupBox4.Controls.Add(Me.txtboxLoginLocation)
        Me.GroupBox4.Controls.Add(Me.txtboxLoadingTime)
        Me.GroupBox4.Controls.Add(LocationLabel)
        Me.GroupBox4.Controls.Add(LoadingTimeLabel)
        Me.GroupBox4.Controls.Add(CustomerLabel)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(573, 160)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Environment Details"
        '
        'ComboBoxCustomer
        '
        Me.ComboBoxCustomer.FormattingEnabled = True
        Me.ComboBoxCustomer.Items.AddRange(New Object() {"CHG", "EHG", "FORTIS NXT", "GXXX", "KAAUH", "KAMC", "KAMCJ", "KFMC", "KKESH", "MCHD", "MCME", "MEXX", "MHB", "NSH", "QP", "RHH", "SBAHC", "SFHD", "SFHM", "SGRH", "SQUH", "UHS"})
        Me.ComboBoxCustomer.Location = New System.Drawing.Point(105, 128)
        Me.ComboBoxCustomer.Name = "ComboBoxCustomer"
        Me.ComboBoxCustomer.Size = New System.Drawing.Size(151, 21)
        Me.ComboBoxCustomer.Sorted = True
        Me.ComboBoxCustomer.TabIndex = 7
        '
        'ComboBoxEnvType
        '
        Me.ComboBoxEnvType.AutoCompleteCustomSource.AddRange(New String() {"Config", "Non Config"})
        Me.ComboBoxEnvType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxEnvType.FormattingEnabled = True
        Me.ComboBoxEnvType.Items.AddRange(New Object() {"Config", "Non Config"})
        Me.ComboBoxEnvType.Location = New System.Drawing.Point(399, 24)
        Me.ComboBoxEnvType.Name = "ComboBoxEnvType"
        Me.ComboBoxEnvType.Size = New System.Drawing.Size(151, 21)
        Me.ComboBoxEnvType.TabIndex = 1
        '
        'txtboxEnvURL
        '
        Me.txtboxEnvURL.Location = New System.Drawing.Point(105, 50)
        Me.txtboxEnvURL.Name = "txtboxEnvURL"
        Me.txtboxEnvURL.Size = New System.Drawing.Size(446, 20)
        Me.txtboxEnvURL.TabIndex = 2
        '
        'txtboxEnvName
        '
        Me.txtboxEnvName.Location = New System.Drawing.Point(105, 24)
        Me.txtboxEnvName.Name = "txtboxEnvName"
        Me.txtboxEnvName.Size = New System.Drawing.Size(151, 20)
        Me.txtboxEnvName.TabIndex = 0
        '
        'txtboxEnvUsername
        '
        Me.txtboxEnvUsername.Location = New System.Drawing.Point(105, 76)
        Me.txtboxEnvUsername.Name = "txtboxEnvUsername"
        Me.txtboxEnvUsername.Size = New System.Drawing.Size(151, 20)
        Me.txtboxEnvUsername.TabIndex = 3
        '
        'txtboxEnvPassword
        '
        Me.txtboxEnvPassword.Location = New System.Drawing.Point(399, 77)
        Me.txtboxEnvPassword.Name = "txtboxEnvPassword"
        Me.txtboxEnvPassword.Size = New System.Drawing.Size(151, 20)
        Me.txtboxEnvPassword.TabIndex = 4
        Me.txtboxEnvPassword.UseSystemPasswordChar = True
        '
        'txtboxUserRole
        '
        Me.txtboxUserRole.Location = New System.Drawing.Point(400, 129)
        Me.txtboxUserRole.Name = "txtboxUserRole"
        Me.txtboxUserRole.Size = New System.Drawing.Size(151, 20)
        Me.txtboxUserRole.TabIndex = 8
        '
        'txtboxLoginLocation
        '
        Me.txtboxLoginLocation.Location = New System.Drawing.Point(104, 102)
        Me.txtboxLoginLocation.Name = "txtboxLoginLocation"
        Me.txtboxLoginLocation.Size = New System.Drawing.Size(151, 20)
        Me.txtboxLoginLocation.TabIndex = 5
        '
        'txtboxLoadingTime
        '
        Me.txtboxLoadingTime.Location = New System.Drawing.Point(400, 103)
        Me.txtboxLoadingTime.Name = "txtboxLoadingTime"
        Me.txtboxLoadingTime.Size = New System.Drawing.Size(151, 20)
        Me.txtboxLoadingTime.TabIndex = 6
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(267, 319)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(87, 23)
        Me.BtnDelete.TabIndex = 11
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEncrypt
        '
        Me.BtnEncrypt.Location = New System.Drawing.Point(360, 319)
        Me.BtnEncrypt.Name = "BtnEncrypt"
        Me.BtnEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.BtnEncrypt.TabIndex = 12
        Me.BtnEncrypt.Text = "Encrypt"
        Me.BtnEncrypt.UseVisualStyleBackColor = True
        '
        'BtnDecrypt
        '
        Me.BtnDecrypt.Location = New System.Drawing.Point(441, 319)
        Me.BtnDecrypt.Name = "BtnDecrypt"
        Me.BtnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.BtnDecrypt.TabIndex = 13
        Me.BtnDecrypt.Text = "Decrypt"
        Me.BtnDecrypt.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(522, 319)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(743, 39)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1411, 625)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnDecrypt)
        Me.Controls.Add(Me.BtnEncrypt)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnExportToCSV)
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
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnExportToCSV As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBoxCustomer As ComboBox
    Friend WithEvents ComboBoxEnvType As ComboBox
    Friend WithEvents txtboxEnvURL As TextBox
    Friend WithEvents txtboxEnvName As TextBox
    Friend WithEvents txtboxEnvUsername As TextBox
    Friend WithEvents txtboxEnvPassword As TextBox
    Friend WithEvents txtboxUserRole As TextBox
    Friend WithEvents txtboxLoginLocation As TextBox
    Friend WithEvents txtboxLoadingTime As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEncrypt As Button
    Friend WithEvents BtnDecrypt As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
