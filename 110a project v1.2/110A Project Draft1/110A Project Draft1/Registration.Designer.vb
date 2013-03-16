<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail1 = New System.Windows.Forms.TextBox()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDescription3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVerifyEmail = New System.Windows.Forms.Label()
        Me.lblVerifyPassword = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtSchool = New System.Windows.Forms.TextBox()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.GroupDatabaseDataSet = New _110A_Project_Draft1.GroupDatabaseDataSet()
        Me.StudentTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableTableAdapter = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.StudentTableTableAdapter()
        Me.TableAdapterManager = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.RecruiterDataTableAdapter = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.RecruiterDataTableAdapter()
        Me.RecruiterDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RaterDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RaterDataTableAdapter = New _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.RaterDataTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecruiterDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RaterDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(8, 164)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(165, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(202, 164)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(164, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtEmail1
        '
        Me.txtEmail1.Location = New System.Drawing.Point(8, 138)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(165, 20)
        Me.txtEmail1.TabIndex = 0
        '
        'txtEmail2
        '
        Me.txtEmail2.Location = New System.Drawing.Point(202, 138)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(164, 20)
        Me.txtEmail2.TabIndex = 1
        '
        'txtPassword1
        '
        Me.txtPassword1.Location = New System.Drawing.Point(8, 190)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(165, 20)
        Me.txtPassword1.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(129, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(255, 39)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Create an account"
        '
        'lblDescription3
        '
        Me.lblDescription3.BackColor = System.Drawing.Color.LightGray
        Me.lblDescription3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription3.Location = New System.Drawing.Point(8, 323)
        Me.lblDescription3.Name = "lblDescription3"
        Me.lblDescription3.Size = New System.Drawing.Size(357, 25)
        Me.lblDescription3.TabIndex = 16
        Me.lblDescription3.Text = "Description/Instruction"
        Me.lblDescription3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(24, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Student"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(123, 28)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Recruiter"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Location = New System.Drawing.Point(235, 28)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Rater"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(39, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(151, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(273, 360)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 16
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identify type of user by selecting the appropriate button "
        '
        'lblVerifyEmail
        '
        Me.lblVerifyEmail.AutoSize = True
        Me.lblVerifyEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifyEmail.Location = New System.Drawing.Point(388, 76)
        Me.lblVerifyEmail.Name = "lblVerifyEmail"
        Me.lblVerifyEmail.Size = New System.Drawing.Size(0, 18)
        Me.lblVerifyEmail.TabIndex = 18
        '
        'lblVerifyPassword
        '
        Me.lblVerifyPassword.AutoSize = True
        Me.lblVerifyPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifyPassword.Location = New System.Drawing.Point(366, 96)
        Me.lblVerifyPassword.Name = "lblVerifyPassword"
        Me.lblVerifyPassword.Size = New System.Drawing.Size(0, 18)
        Me.lblVerifyPassword.TabIndex = 19
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(201, 267)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(164, 20)
        Me.txtZip.TabIndex = 11
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(9, 267)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(164, 20)
        Me.txtState.TabIndex = 10
        '
        'txtSchool
        '
        Me.txtSchool.Location = New System.Drawing.Point(8, 216)
        Me.txtSchool.Name = "txtSchool"
        Me.txtSchool.Size = New System.Drawing.Size(164, 20)
        Me.txtSchool.TabIndex = 6
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(201, 216)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(164, 20)
        Me.txtMajor.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(201, 294)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(164, 20)
        Me.txtPhone.TabIndex = 13
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(9, 294)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(164, 20)
        Me.txtCompany.TabIndex = 12
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(9, 241)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(164, 20)
        Me.txtAddress.TabIndex = 8
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(201, 242)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(164, 20)
        Me.txtCity.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(392, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 122)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Please fill and complete the following textboxes below to register."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 46)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Provide educational background and set of skills. "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 56)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Narrow search results and filter future employees based on the student's ratings " & _
    "and information."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 46)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Rate recent graduates or fellow colleagues anonymously."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "-Student- "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(392, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 14)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "-Recruiter-"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(392, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 14)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "-Rater-"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(202, 189)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(164, 20)
        Me.txtPassword2.TabIndex = 5
        '
        'GroupDatabaseDataSet
        '
        Me.GroupDatabaseDataSet.DataSetName = "GroupDatabaseDataSet"
        Me.GroupDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableBindingSource
        '
        Me.StudentTableBindingSource.DataMember = "StudentTable"
        Me.StudentTableBindingSource.DataSource = Me.GroupDatabaseDataSet
        '
        'StudentTableTableAdapter
        '
        Me.StudentTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RaterDataTableAdapter = Nothing
        Me.TableAdapterManager.Ratings_Data_for_Design2TableAdapter = Nothing
        Me.TableAdapterManager.RecruiterDataTableAdapter = Me.RecruiterDataTableAdapter
        Me.TableAdapterManager.StudentTableTableAdapter = Me.StudentTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecruiterDataTableAdapter
        '
        Me.RecruiterDataTableAdapter.ClearBeforeFill = True
        '
        'RecruiterDataBindingSource
        '
        Me.RecruiterDataBindingSource.DataMember = "RecruiterData"
        Me.RecruiterDataBindingSource.DataSource = Me.GroupDatabaseDataSet
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
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(561, 397)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.txtSchool)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblVerifyPassword)
        Me.Controls.Add(Me.lblVerifyEmail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblDescription3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPassword1)
        Me.Controls.Add(Me.txtEmail2)
        Me.Controls.Add(Me.txtEmail1)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecruiterDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RaterDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblDescription3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblVerifyEmail As System.Windows.Forms.Label
    Friend WithEvents lblVerifyPassword As System.Windows.Forms.Label
    Friend WithEvents GroupDatabaseDataSet As _110A_Project_Draft1.GroupDatabaseDataSet
    Friend WithEvents StudentTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableTableAdapter As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.StudentTableTableAdapter
    Friend WithEvents TableAdapterManager As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecruiterDataTableAdapter As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.RecruiterDataTableAdapter
    Friend WithEvents RecruiterDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RaterDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RaterDataTableAdapter As _110A_Project_Draft1.GroupDatabaseDataSetTableAdapters.RaterDataTableAdapter
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtSchool As System.Windows.Forms.TextBox
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPassword2 As System.Windows.Forms.TextBox
End Class
