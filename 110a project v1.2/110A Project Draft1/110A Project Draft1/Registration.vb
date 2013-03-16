Public Class Registration

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GroupDatabaseDataSet.RaterData' table. You can move, or remove it, as needed.
        Me.RaterDataTableAdapter.Fill(Me.GroupDatabaseDataSet.RaterData)
        'TODO: This line of code loads data into the 'GroupDatabaseDataSet.RecruiterData' table. You can move, or remove it, as needed.
        Me.RecruiterDataTableAdapter.Fill(Me.GroupDatabaseDataSet.RecruiterData)
        'TODO: This line of code loads data into the 'GroupDatabaseDataSet.StudentTable' table. You can move, or remove it, as needed.
        Me.StudentTableTableAdapter.Fill(Me.GroupDatabaseDataSet.StudentTable)
        txtFirstName.ForeColor = Color.LightSlateGray
        txtFirstName.Text = "First Name"
        txtLastName.ForeColor = Color.LightSlateGray
        txtLastName.Text = "Last Name"
        txtEmail1.ForeColor = Color.LightSlateGray
        txtEmail1.Text = "Email"
        txtEmail2.ForeColor = Color.LightSlateGray
        txtEmail2.Text = "Confirm Email"
        txtPassword1.ForeColor = Color.LightSlateGray
        txtPassword1.Text = "Password"
        txtPassword2.ForeColor = Color.LightSlateGray
        txtPassword2.Text = "Confirm Passowrd"
        txtState.ForeColor = Color.LightSlateGray
        txtState.Text = "State"
        txtZip.ForeColor = Color.LightSlateGray
        txtZip.Text = "Zip"
        txtSchool.ForeColor = Color.LightSlateGray
        txtSchool.Text = "School"
        txtMajor.ForeColor = Color.LightSlateGray
        txtMajor.Text = "Major"
        txtPhone.ForeColor = Color.LightSlateGray
        txtPhone.Text = "Phone"
        txtCompany.ForeColor = Color.LightSlateGray
        txtCompany.Text = "Company"
        txtAddress.ForeColor = Color.LightSlateGray
        txtAddress.Text = "Address"
        txtCity.ForeColor = Color.LightSlateGray
        txtCity.Text = "City"
        lblVerifyEmail.Hide()
        lblVerifyPassword.Hide()
        txtAddress.Hide()
        txtCity.Hide()
        txtCompany.Hide()
        txtEmail1.Hide()
        txtEmail2.Hide()
        txtFirstName.Hide()
        txtLastName.Hide()
        txtMajor.Hide()
        txtPassword1.Hide()
        txtPassword2.Hide()
        txtPhone.Hide() '
        txtSchool.Hide()
        txtState.Hide()
        txtZip.Hide()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        
        
    End Sub
    Private Sub TextBox2_Leave(sender As System.Object, e As System.EventArgs) Handles txtFirstName.Leave
        If txtFirstName.Text = "" Then
            txtFirstName.ForeColor = Color.LightSlateGray
            txtFirstName.Text = "First Name"
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As System.Object, e As System.EventArgs) Handles txtFirstName.Enter
        If txtFirstName.Focus = True Then
            lblDescription3.Text = "Please Enter First Name"
        End If
        If txtFirstName.Text = "First Name" Then
            txtFirstName.Text = ""
            txtFirstName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox3_Leave(sender As System.Object, e As System.EventArgs) Handles txtLastName.Leave
        If txtLastName.Text = "" Then
            txtLastName.ForeColor = Color.LightSlateGray
            txtLastName.Text = "Last Name"
        End If
    End Sub
    Private Sub TextBox3_Enter(sender As System.Object, e As System.EventArgs) Handles txtLastName.Enter
        If txtLastName.Focus = True Then
            lblDescription3.Text = "Please Enter Last Name"
        End If
        If txtLastName.Text = "Last Name" Then
            txtLastName.Text = ""
            txtLastName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox4_Leave(sender As System.Object, e As System.EventArgs) Handles txtEmail1.Leave
        If txtEmail1.Text = "" Then
            txtEmail1.ForeColor = Color.LightSlateGray
            txtEmail1.Text = "Email"
        End If
    End Sub
    Private Sub TextBox4_Enter(sender As System.Object, e As System.EventArgs) Handles txtEmail1.Enter
        If txtEmail1.Focus = True Then
            lblDescription3.Text = "Please Enter Email Address"
        End If
        If txtEmail1.Text = "Email" Then
            txtEmail1.Text = ""
            txtEmail1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox5_Leave(sender As System.Object, e As System.EventArgs) Handles txtEmail2.Leave
        If txtEmail2.Text = "" Then
            txtEmail2.ForeColor = Color.LightSlateGray
            txtEmail2.Text = "Confirm Email"
        End If
    End Sub
    Private Sub TextBox5_Enter(sender As System.Object, e As System.EventArgs) Handles txtEmail2.Enter
        If txtEmail2.Focus = True Then
            lblDescription3.Text = "Please Confirm Email Address"
        End If
        If txtEmail2.Text = "Confirm Email" Then
            txtEmail2.Text = ""
            txtEmail2.ForeColor = Color.Black
        End If

        If txtEmail1.Text = txtEmail2.Text Then

        End If
    End Sub
    Private Sub TextBox6_Leave(sender As System.Object, e As System.EventArgs) Handles txtPassword1.Leave
        If txtPassword1.Text = "" Then
            txtPassword1.ForeColor = Color.LightSlateGray
            txtPassword1.Text = "Password"
        End If
    End Sub

    Private Sub TextBox6_Enter(sender As System.Object, e As System.EventArgs) Handles txtPassword1.Enter
        If txtPassword1.Focus = True Then
            lblDescription3.Text = "Use at least 8 characters. Don’t use a password from another site, or something too obvious like your pet’s name"
        End If

        If txtPassword1.Text = "Password" Then
            txtPassword1.Text = ""
            txtPassword1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox7_Leave(sender As System.Object, e As System.EventArgs) Handles txtPassword2.Leave
        If txtPassword2.Text = "" Then
            txtPassword2.ForeColor = Color.LightSlateGray
            txtPassword2.Text = "Confirm Passowrd"
        End If
    End Sub


    Private Sub TextBox7_Enter(sender As System.Object, e As System.EventArgs) Handles txtPassword2.Enter
        If txtPassword2.Focus = True Then
            lblDescription3.Text = "Confirm Password"
        End If
        If txtPassword2.Text = "Confirm Passowrd" Then
            txtPassword2.Text = ""
            txtPassword2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox8_Leave(sender As System.Object, e As System.EventArgs) Handles txtState.Leave
        If txtState.Text = "" Then
            txtState.ForeColor = Color.LightSlateGray
            txtState.Text = "State"
        End If
    End Sub

    Private Sub TextBox8_Enter(sender As System.Object, e As System.EventArgs) Handles txtState.Enter
        If txtState.Focus = True Then
            lblDescription3.Text = "Please enter your state"
        End If
        If txtState.Text = "State" Then
            txtState.Text = ""
            txtState.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox9_Leave(sender As System.Object, e As System.EventArgs) Handles txtZip.Leave
        If txtZip.Text = "" Then
            txtZip.ForeColor = Color.LightSlateGray
            txtZip.Text = "Zip"
        End If
    End Sub

    Private Sub TextBox9_Enter(sender As System.Object, e As System.EventArgs) Handles txtZip.Enter
        If txtZip.Focus = True Then
            lblDescription3.Text = "Please enter your zip code"
        End If
        If txtZip.Text = "Zip" Then
            txtZip.Text = ""
            txtZip.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox10_Leave(sender As System.Object, e As System.EventArgs) Handles txtSchool.Leave
        If txtSchool.Text = "" Then
            txtSchool.ForeColor = Color.LightSlateGray
            txtSchool.Text = "School"
        End If
    End Sub

    Private Sub TextBox10_Enter(sender As System.Object, e As System.EventArgs) Handles txtSchool.Enter
        If txtSchool.Focus = True Then
            lblDescription3.Text = "Please enter your school"
        End If
        If txtSchool.Text = "School" Then
            txtSchool.Text = ""
            txtSchool.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox11_Leave(sender As System.Object, e As System.EventArgs) Handles txtMajor.Leave
        If txtMajor.Text = "" Then
            txtMajor.ForeColor = Color.LightSlateGray
            txtMajor.Text = "Major"
        End If
    End Sub

    Private Sub TextBox11_Enter(sender As System.Object, e As System.EventArgs) Handles txtMajor.Enter
        If txtMajor.Focus = True Then
            lblDescription3.Text = "Please enter your major"
        End If
        If txtMajor.Text = "Major" Then
            txtMajor.Text = ""
            txtMajor.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox12_Leave(sender As System.Object, e As System.EventArgs) Handles txtPhone.Leave
        If txtPhone.Text = "" Then
            txtPhone.ForeColor = Color.LightSlateGray
            txtPhone.Text = "Phone"
        End If
    End Sub

    Private Sub TextBox12_Enter(sender As System.Object, e As System.EventArgs) Handles txtPhone.Enter
        If txtPhone.Focus = True Then
            lblDescription3.Text = "Please enter your phone number"
        End If
        If txtPhone.Text = "Phone" Then
            txtPhone.Text = ""
            txtPhone.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox13_Leave(sender As System.Object, e As System.EventArgs) Handles txtCompany.Leave
        If txtCompany.Text = "" Then
            txtCompany.ForeColor = Color.LightSlateGray
            txtCompany.Text = "Company"
        End If
    End Sub

    Private Sub TextBox13_Enter(sender As System.Object, e As System.EventArgs) Handles txtCompany.Enter
        If txtCompany.Focus = True Then
            lblDescription3.Text = "Please enter your company"
        End If
        If txtCompany.Text = "Company" Then
            txtCompany.Text = ""
            txtCompany.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox14_Leave(sender As System.Object, e As System.EventArgs) Handles txtAddress.Leave
        If txtAddress.Text = "" Then
            txtAddress.ForeColor = Color.LightSlateGray
            txtAddress.Text = "Address"
        End If
    End Sub

    Private Sub TextBox14_Enter(sender As System.Object, e As System.EventArgs) Handles txtAddress.Enter
        If txtAddress.Focus = True Then
            lblDescription3.Text = "Please enter your address"
        End If
        If txtAddress.Text = "Address" Then
            txtAddress.Text = ""
            txtAddress.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox15_Leave(sender As System.Object, e As System.EventArgs) Handles txtCity.Leave
        If txtCity.Text = "" Then
            txtCity.ForeColor = Color.LightSlateGray
            txtCity.Text = "City"
        End If
    End Sub

    Private Sub TextBox15_Enter(sender As System.Object, e As System.EventArgs) Handles txtCity.Enter
        If txtCity.Focus = True Then
            lblDescription3.Text = "Please enter your city"
        End If
        If txtCity.Text = "City" Then
            txtCity.Text = ""
            txtCity.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtFirstName.ForeColor = Color.LightSlateGray
        txtFirstName.Text = "First Name"
        txtLastName.ForeColor = Color.LightSlateGray
        txtLastName.Text = "Last Name"
        txtEmail1.ForeColor = Color.LightSlateGray
        txtEmail1.Text = "Email"
        txtEmail2.ForeColor = Color.LightSlateGray
        txtEmail2.Text = "Confirm Email"
        txtPassword1.ForeColor = Color.LightSlateGray
        txtPassword1.Text = "Password"
        txtPassword2.ForeColor = Color.LightSlateGray
        txtPassword2.Text = "Confirm Password"
        txtState.ForeColor = Color.LightSlateGray
        txtState.Text = "State"
        txtZip.ForeColor = Color.LightSlateGray
        txtZip.Text = "Zip"
        txtSchool.ForeColor = Color.LightSlateGray
        txtSchool.Text = "School"
        txtMajor.ForeColor = Color.LightSlateGray
        txtMajor.Text = "Major"
        txtPhone.ForeColor = Color.LightSlateGray
        txtPhone.Text = "Phone"
        txtCompany.ForeColor = Color.LightSlateGray
        txtCompany.Text = "Company"
        txtAddress.ForeColor = Color.LightSlateGray
        txtAddress.Text = "Address"
        txtCity.ForeColor = Color.LightSlateGray
        txtCity.Text = "City"
        lblVerifyEmail.Hide()
        lblVerifyPassword.Hide()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        txtAddress.Hide()
        txtCity.Hide()
        txtCompany.Hide()
        txtEmail1.Hide()
        txtEmail2.Hide()
        txtFirstName.Hide()
        txtLastName.Hide()
        txtMajor.Hide()
        txtPassword1.Hide()
        txtPassword2.Hide()
        txtPhone.Hide() '
        txtSchool.Hide()
        txtState.Hide()
        txtZip.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        Dim NumberofRows As Integer
        Dim objEmail As Object
        Dim Password As String = String.Empty
        Dim Email As String = String.Empty
        'make sure a radio button must be clicked to register
        Try
            If RadioButton1.Checked And RadioButton2.Checked And RadioButton3.Checked = False Then
                MessageBox.Show("Please select type of user")
            End If
        Catch ex As Exception

        End Try

        'make sure all fields are filled

        'verifying all emails before inserting to student DB
        If RadioButton1.Checked = True Then
            NumberofRows = StudentTableTableAdapter.FillByEmail(GroupDatabaseDataSet.StudentTable, txtEmail1.Text)
            'if it finds an email, then email is used
            If NumberofRows = 1 Then
                MessageBox.Show("Email Already in Use")
                txtEmail1.Focus()
                Exit Sub
            End If
            objEmail = StudentTableTableAdapter.InsertQueryStudentRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text, txtSchool.Text, txtMajor.Text)
            MessageBox.Show("Student account registered")
        End If
        'verifying all emails before inserting to recruiter DB
        If RadioButton2.Checked = True Then
            NumberofRows = RecruiterDataTableAdapter.FillByEmail(GroupDatabaseDataSet.RecruiterData, txtEmail1.Text)
            'if it finds an email, then email is used
            If NumberofRows = 1 Then
                MessageBox.Show("Email Already in Use")
                txtEmail1.Focus()
                Exit Sub
            End If
            objEmail = RecruiterDataTableAdapter.InsertQueryRecruiterRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text, txtCompany.Text)
            MessageBox.Show("Recruiter account registered")
        End If
        If RadioButton3.Checked = True Then
            NumberofRows = RaterDataTableAdapter.FillByEmail(GroupDatabaseDataSet.RaterData, txtEmail1.Text)
            'if it finds an email, then email is used
            If NumberofRows = 1 Then
                MessageBox.Show("Email Already in Use")
                txtEmail1.Focus()
                Exit Sub
            End If
            objEmail = RaterDataTableAdapter.InsertQueryRaterRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text)
            MessageBox.Show("Rater account registered")
        End If
        Me.Close()
        Login.Show()












        '    Dim state As Integer = 0
        '    Dim objEmail As Object
        '    'check if emaisl are typed correctly
        '    While state = 0

        '        Try
        '            txtZip.Text = CInt(txtZip.Text)
        '        Catch ex As Exception
        '            MessageBox.Show("Invalid zip code")
        '        End Try
        '        If txtEmail1.Text <> txtEmail2.Text Then
        '            MessageBox.Show("Emails did not match")
        '            lblVerifyEmail.ForeColor = Color.Red
        '            lblVerifyEmail.Text = "X"
        '            txtEmail1.Focus()
        '            lblVerifyEmail.Show()
        '            Exit Sub
        '        Else
        '            lblVerifyEmail.Show()
        '            lblVerifyEmail.ForeColor = Color.Green
        '            lblVerifyEmail.Text = "O"
        '        End If
        '        'check if passwords are typed correctly
        '        If txtPassword1.Text <> txtPassword2.Text Then
        '            MessageBox.Show("Passwords do not match")
        '            lblVerifyPassword.ForeColor = Color.Red
        '            lblVerifyPassword.Text = "X"
        '            txtPassword1.Focus()
        '            lblVerifyEmail.Show()
        '            Exit Sub
        '        Else
        '            lblVerifyPassword.ForeColor = Color.Green
        '            lblVerifyPassword.Text = "O"
        '            lblVerifyEmail.Show()
        '        End If
        '        state = 1
        '    End While





        '    While state = 1
        '        If RadioButton1.Checked = True Then
        '            objEmail = StudentTableTableAdapter.FillByEmail(GroupDatabaseDataSet.StudentTable, txtEmail1.Text)
        '            If objEmail = 1 Then
        '                MessageBox.Show("Email Taken")
        '                txtEmail1.Focus()
        '                Exit Sub
        '            Else
        '                state = 2
        '            End If
        '        End If
        '    End While
        '    While state = 2
        '        If RadioButton2.Checked = True Then
        '            objEmail = RecruiterDataTableAdapter.FillByEmail(GroupDatabaseDataSet.RecruiterData, txtEmail1.Text)
        '            If objEmail = 1 Then
        '                MessageBox.Show("Email Taken")
        '                txtEmail1.Focus()
        '                Exit Sub
        '            Else
        '                state = 3
        '            End If
        '        End If
        '    End While
        '    While state = 3
        '        If RadioButton3.Checked = True Then
        '            objEmail = RaterDataTableAdapter.FillByEmail(GroupDatabaseDataSet.RaterData, txtEmail1.Text)
        '            If objEmail = 1 Then
        '                MessageBox.Show("Email Taken")
        '                txtEmail1.Focus()
        '                Exit Sub
        '            Else
        '                state = 4
        '            End If
        '        End If
        '    End While
        '    While state = 4
        '        If RadioButton1.Checked = True Then
        '            objEmail = StudentTableTableAdapter.InsertQueryStudentRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text, txtSchool.Text, txtMajor.Text)
        '            Me.Hide()
        '            Profile.Show()
        '            state = 5
        '        End If
        '        If RadioButton2.Checked = True Then
        '            objEmail = RecruiterDataTableAdapter.InsertQueryRecruiterRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text, txtCompany.Text)
        '            Me.Hide()
        '            Search.Show()
        '            state = 5
        '        End If
        '        If RadioButton3.Checked = True Then
        '            objEmail = RaterDataTableAdapter.InsertQueryRaterRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text)
        '            Me.Hide()
        '            Search.Show()
        '            state = 5
        '        End If
        '    End While
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        'student button
        If RadioButton1.Checked = True Then
            txtAddress.Show()
            txtCity.Show()
            txtEmail1.Show()
            txtEmail2.Show()
            txtFirstName.Show()
            txtLastName.Show()
            txtMajor.Show()
            txtPassword1.Show()
            txtPassword2.Show()
            txtSchool.Show()
            txtState.Show()
            txtPhone.Show()
            txtCompany.Hide()
            txtZip.Show()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        'recruiter button
        If RadioButton2.Checked = True Then
            txtAddress.Hide()
            txtCity.Hide()
            txtEmail1.Show()
            txtEmail2.Show()
            txtFirstName.Show()
            txtLastName.Show()
            txtMajor.Hide()
            txtPassword1.Show()
            txtPassword2.Show()
            txtSchool.Hide()
            txtState.Hide()
            txtPhone.Show()
            txtCompany.Show()
            txtZip.Hide()
        End If
        
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        'rater button
        If RadioButton3.Checked = True Then
            txtAddress.Hide()
            txtCity.Hide()
            txtEmail1.Show()
            txtEmail2.Show()
            txtFirstName.Show()
            txtLastName.Show()
            txtMajor.Hide()
            txtPassword1.Show()
            txtPassword2.Show()
            txtSchool.Hide()
            txtState.Hide()
            txtPhone.Show()
            txtCompany.Hide()
            txtZip.Hide()
        End If
    End Sub
End Class
