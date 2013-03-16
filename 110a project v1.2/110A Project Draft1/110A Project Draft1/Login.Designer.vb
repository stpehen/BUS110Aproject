<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.llRegister = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupDatabaseDataSet = New _110A_Project_Draft1.GroupDatabaseDataSet()
        Me.RaterDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RaterDataTableAdapter = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.RaterDataTableAdapter()
        Me.TableAdapterManager = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StudentTableTableAdapter = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.StudentTableTableAdapter()
        Me.StudentTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecruiterDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecruiterDataTableAdapter = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.RecruiterDataTableAdapter()
        Me.Ratings_Data_for_Design2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ratings_Data_for_Design2TableAdapter = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.Ratings_Data_for_Design2TableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GroupDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaterDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecruiterDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ratings_Data_for_Design2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(41, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome to Raters Inc.!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(29, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(27, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username/Email"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.btnSignIn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(322, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log in"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(32, 86)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 23)
        Me.txtPassword.TabIndex = 1
        '
        'btnSignIn
        '
        Me.btnSignIn.Location = New System.Drawing.Point(188, 86)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(55, 23)
        Me.btnSignIn.TabIndex = 3
        Me.btnSignIn.Text = "&Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(32, 39)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(211, 23)
        Me.txtUsername.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(165, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 124)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Raters Inc. is a one stop tool for students and recruiters in selecting future ca" & _
    "reers and potential candidates in a dynamically changing workplace environment."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'llRegister
        '
        Me.llRegister.AutoSize = True
        Me.llRegister.LinkColor = System.Drawing.Color.MediumBlue
        Me.llRegister.Location = New System.Drawing.Point(517, 226)
        Me.llRegister.Name = "llRegister"
        Me.llRegister.Size = New System.Drawing.Size(70, 13)
        Me.llRegister.TabIndex = 4
        Me.llRegister.TabStop = True
        Me.llRegister.Text = "Register here"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(262, 36)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Please login with your designated username and/or email to begin."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 36)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Privacy: All users are verified. Rate recent graduates anonymously."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupDatabaseDataSet
        '
        Me.GroupDatabaseDataSet.DataSetName = "GroupDatabaseDataSet"
        Me.GroupDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RaterDataBindingSource
        '
        Me.RaterDataBindingSource.DataMember = "RaterData"
        Me.RaterDataBindingSource.DataSource = Me.GroupDatabaseDataSet
        '
        'RaterDataTableAdapter
        '
        Me.RaterDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RaterDataTableAdapter = Me.RaterDataTableAdapter
        Me.TableAdapterManager.Ratings_Data_for_Design2TableAdapter = Nothing
        Me.TableAdapterManager.RecruiterDataTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableTableAdapter = Me.StudentTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentTableTableAdapter
        '
        Me.StudentTableTableAdapter.ClearBeforeFill = True
        '
        'StudentTableBindingSource
        '
        Me.StudentTableBindingSource.DataMember = "StudentTable"
        Me.StudentTableBindingSource.DataSource = Me.GroupDatabaseDataSet
        '
        'RecruiterDataBindingSource
        '
        Me.RecruiterDataBindingSource.DataMember = "RecruiterData"
        Me.RecruiterDataBindingSource.DataSource = Me.GroupDatabaseDataSet
        '
        'RecruiterDataTableAdapter
        '
        Me.RecruiterDataTableAdapter.ClearBeforeFill = True
        '
        'Ratings_Data_for_Design2BindingSource
        '
        Me.Ratings_Data_for_Design2BindingSource.DataMember = "Ratings Data for Design2"
        Me.Ratings_Data_for_Design2BindingSource.DataSource = Me.GroupDatabaseDataSet
        '
        'Ratings_Data_for_Design2TableAdapter
        '
        Me.Ratings_Data_for_Design2TableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 124)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 177)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 47)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(325, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Click ""Register here"" to sign up."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(599, 255)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.llRegister)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GroupDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaterDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecruiterDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ratings_Data_for_Design2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents llRegister As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupDatabaseDataSet As _110A_Project_Draft1.GroupDatabaseDataSet
    Friend WithEvents RaterDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RaterDataTableAdapter As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.RaterDataTableAdapter
    Friend WithEvents TableAdapterManager As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentTableTableAdapter As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.StudentTableTableAdapter
    Friend WithEvents StudentTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecruiterDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecruiterDataTableAdapter As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.RecruiterDataTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ratings_Data_for_Design2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ratings_Data_for_Design2TableAdapter As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.Ratings_Data_for_Design2TableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox

End Class
