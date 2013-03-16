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
        txtPassword1.UseSystemPasswordChar = False
        txtPassword1.Text = "Password"
        txtPassword2.ForeColor = Color.LightSlateGray
        txtPassword1.UseSystemPasswordChar = False
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
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub
    Private Sub TextBox2_Leave(sender As System.Object, e As System.EventArgs) Handles txtFirstName.Leave
        If txtFirstName.Text = Nothing Then
            txtFirstName.ForeColor = Color.LightSlateGray
            txtFirstName.Text = "First Name"
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As System.Object, e As System.EventArgs) Handles txtFirstName.Enter
        If txtFirstName.Focus = True Then
            lblDescription3.Text = "Please Enter First Name"
        End If
        If txtFirstName.Text = "First Name" Then
            txtFirstName.Text = Nothing
            txtFirstName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox3_Leave(sender As System.Object, e As System.EventArgs) Handles txtLastName.Leave
        If txtLastName.Text = Nothing Then
            txtLastName.ForeColor = Color.LightSlateGray
            txtLastName.Text = "Last Name"
        End If
    End Sub
    Private Sub TextBox3_Enter(sender As System.Object, e As System.EventArgs) Handles txtLastName.Enter
        If txtLastName.Focus = True Then
            lblDescription3.Text = "Please Enter Last Name"
        End If
        If txtLastName.Text = "Last Name" Then
            txtLastName.Text = Nothing
            txtLastName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox4_Leave(sender As System.Object, e As System.EventArgs) Handles txtEmail1.Leave
        If txtEmail1.Text = Nothing Then
            txtEmail1.ForeColor = Color.LightSlateGray
            txtEmail1.Text = "Email"
        End If
    End Sub
    Private Sub TextBox4_Enter(sender As System.Object, e As System.EventArgs) Handles txtEmail1.Enter
        If txtEmail1.Focus = True Then
            lblDescription3.Text = "Please Enter Email Address"
        End If
        If txtEmail1.Text = "Email" Then
            txtEmail1.Text = Nothing
            txtEmail1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox5_Leave(sender As System.Object, e As System.EventArgs) Handles txtEmail2.Leave
        If txtEmail2.Text = Nothing Then
            txtEmail2.ForeColor = Color.LightSlateGray
            txtEmail2.Text = "Confirm Email"
        End If
    End Sub
    Private Sub TextBox5_Enter(sender As System.Object, e As System.EventArgs) Handles txtEmail2.Enter
        If txtEmail2.Focus = True Then
            lblDescription3.Text = "Please Confirm Email Address"
        End If
        If txtEmail2.Text = "Confirm Email" Then
            txtEmail2.Text = Nothing
            txtEmail2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox6_Leave(sender As System.Object, e As System.EventArgs) Handles txtPassword1.Leave
        If txtPassword1.Text = Nothing Then
            txtPassword1.ForeColor = Color.LightSlateGray
            txtPassword1.Text = "Password"
            txtPassword1.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TextBox6_Enter(sender As System.Object, e As System.EventArgs) Handles txtPassword1.Enter
        If txtPassword1.Focus = True Then
            lblDescription3.Text = "Use at least 8 characters."
        End If

        If txtPassword1.Text = "Password" Then
            txtPassword1.Text = Nothing
            txtPassword1.ForeColor = Color.Black
            txtPassword1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox7_Leave(sender As System.Object, e As System.EventArgs) Handles txtPassword2.Leave
        If txtPassword2.Text = Nothing Then
            txtPassword2.Text = "Confirm Password"
            txtPassword2.UseSystemPasswordChar = False
            txtPassword2.ForeColor = Color.LightSlateGray
        End If
    End Sub

    Private Sub TextBox7_Enter(sender As System.Object, e As System.EventArgs) Handles txtPassword2.Enter
        If txtPassword2.Focus = True Then
            lblDescription3.Text = "Please confirm password"
        End If

        If txtPassword2.Text = "Confirm Password" Then
            txtPassword2.Text = Nothing
            txtPassword2.UseSystemPasswordChar = True
            txtPassword2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox8_Leave(sender As System.Object, e As System.EventArgs) Handles txtState.Leave
        If txtState.Text = Nothing Then
            txtState.ForeColor = Color.LightSlateGray
            txtState.Text = "State"
        End If
    End Sub

    Private Sub TextBox8_Enter(sender As System.Object, e As System.EventArgs) Handles txtState.Enter
        If txtState.Focus = True Then
            lblDescription3.Text = "Please enter your state"
        End If
        If txtState.Text = "State" Then
            txtState.Text = Nothing
            txtState.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox9_Leave(sender As System.Object, e As System.EventArgs) Handles txtZip.Leave
        If txtZip.Text = Nothing Then
            txtZip.ForeColor = Color.LightSlateGray
            txtZip.Text = "Zip"
        End If
    End Sub

    Private Sub TextBox9_Enter(sender As System.Object, e As System.EventArgs) Handles txtZip.Enter
        If txtZip.Focus = True Then
            lblDescription3.Text = "Please enter your zip code"
        End If
        If txtZip.Text = "Zip" Then
            txtZip.Text = Nothing
            txtZip.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox10_Leave(sender As System.Object, e As System.EventArgs) Handles txtSchool.Leave
        If txtSchool.Text = Nothing Then
            txtSchool.ForeColor = Color.LightSlateGray
            txtSchool.Text = "School"
        End If
    End Sub

    Private Sub TextBox10_Enter(sender As System.Object, e As System.EventArgs) Handles txtSchool.Enter
        If txtSchool.Focus = True Then
            lblDescription3.Text = "Please enter your school from the following list: San Jose State University, Stanford University, UC Berkeley, Santa Clara University"
        End If
        If txtSchool.Text = "School" Then
            txtSchool.Text = Nothing
            txtSchool.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox11_Leave(sender As System.Object, e As System.EventArgs) Handles txtMajor.Leave
        If txtMajor.Text = Nothing Then
            txtMajor.ForeColor = Color.LightSlateGray
            txtMajor.Text = "Major"
        End If
    End Sub

    Private Sub TextBox11_Enter(sender As System.Object, e As System.EventArgs) Handles txtMajor.Enter
        If txtMajor.Focus = True Then
            lblDescription3.Text = "Please enter your major from the following list: Software Engineering, Accounting, MIS, Electrical Engineering, Computer Science, Marketing, Finance"
        End If
        If txtMajor.Text = "Major" Then
            txtMajor.Text = Nothing
            txtMajor.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox12_Leave(sender As System.Object, e As System.EventArgs) Handles txtPhone.Leave
        If txtPhone.Text = Nothing Then
            txtPhone.ForeColor = Color.LightSlateGray
            txtPhone.Text = "Phone"
        End If
    End Sub

    Private Sub TextBox12_Enter(sender As System.Object, e As System.EventArgs) Handles txtPhone.Enter
        If txtPhone.Focus = True Then
            lblDescription3.Text = "Please enter your phone number"
        End If
        If txtPhone.Text = "Phone" Then
            txtPhone.Text = Nothing
            txtPhone.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox13_Leave(sender As System.Object, e As System.EventArgs) Handles txtCompany.Leave
        If txtCompany.Text = Nothing Then
            txtCompany.ForeColor = Color.LightSlateGray
            txtCompany.Text = "Company"
        End If
    End Sub

    Private Sub TextBox13_Enter(sender As System.Object, e As System.EventArgs) Handles txtCompany.Enter
        If txtCompany.Focus = True Then
            lblDescription3.Text = "Please enter your company"
        End If
        If txtCompany.Text = "Company" Then
            txtCompany.Text = Nothing
            txtCompany.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox14_Leave(sender As System.Object, e As System.EventArgs) Handles txtAddress.Leave
        If txtAddress.Text = Nothing Then
            txtAddress.ForeColor = Color.LightSlateGray
            txtAddress.Text = "Address"
        End If
    End Sub

    Private Sub TextBox14_Enter(sender As System.Object, e As System.EventArgs) Handles txtAddress.Enter
        If txtAddress.Focus = True Then
            lblDescription3.Text = "Please enter your address"
        End If
        If txtAddress.Text = "Address" Then
            txtAddress.Text = Nothing
            txtAddress.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox15_Leave(sender As System.Object, e As System.EventArgs) Handles txtCity.Leave
        If txtCity.Text = Nothing Then
            txtCity.ForeColor = Color.LightSlateGray
            txtCity.Text = "City"
        End If
    End Sub

    Private Sub TextBox15_Enter(sender As System.Object, e As System.EventArgs) Handles txtCity.Enter
        If txtCity.Focus = True Then
            lblDescription3.Text = "Please enter your city"
        End If
        If txtCity.Text = "City" Then
            txtCity.Text = Nothing
            txtCity.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Login.Show()
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
        txtPassword1.UseSystemPasswordChar = False
        txtPassword1.Text = "Password"
        txtPassword2.ForeColor = Color.LightSlateGray
        txtPassword2.UseSystemPasswordChar = False
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
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        'VALIDATING CODES - START
        Dim strEmail1, strEmail2, strZip, strStates, strUserInputForStates, strSchool, strUserInputForSchool, strMajor, _
            strUserInputForMajor, strCity, strUserInputForCity, strAddress, strFirstName, strLastName, strPhone, _
            strpassword1A, strpassword1B, strpassword2B, strEmail As String
        Dim intIndexOfAT1, intIndexOfDot1, intCount1, intCount2, NumberofRows1, NumberofRows2, NumberofRows3 As Integer
        Dim Password As String = String.Empty
        Dim Email As String = String.Empty

        'VALIDATING FIRST EMAIL TEXTBOX
        strEmail1 = txtEmail1.Text          'Store the email from the text box to a string variable
        intIndexOfAT1 = strEmail1.IndexOf("@")          'Find out the position of "@" sign
        If intIndexOfAT1 <> -1 Then     'If sign not found - give error message, select the entire text, and stay in the text box
            intIndexOfDot1 = strEmail1.IndexOf(".", intIndexOfAT1)  'If sign found, find out the position of "." starting after "@" sign
            If intIndexOfDot1 = -1 Then         'If "." not found - give error message, select the entire text, and stay in the text box
                MessageBox.Show("Invalid eMail Address - Please re-enter")
                txtEmail1.SelectAll()
            End If
        Else
            MessageBox.Show("Invalid eMail Address - Please re-enter")
            txtEmail1.SelectAll()
        End If

        'VALIDATING SECOND EMAIL TEXTBOX 
        strEmail2 = txtEmail2.Text         'Store the email from the text box to a string variable
        If txtEmail2.Text <> txtEmail1.Text Then    'Give error message if textbox input is not the same
            MessageBox.Show("Email does not match - Please re-enter confirmed email.")
            txtEmail2.SelectAll()
        End If

        'VALIDATING ZIP CODE TEXTBOX
        strZip = txtZip.Text    ' Store zip from the text box
        If Not IsNumeric(strZip) Then        'Find out if the text entered is numeric.
            MessageBox.Show("Invalid Zip Code - Please re-enter numbers only")
            txtZip.SelectAll()
        Else
            If strZip.Count() <> 5 Then        'If it is numeric, find out if there are 5 digits.
                MessageBox.Show("Invalid Zip Code - Please re-enter 5 digits only")
                txtZip.SelectAll()
            End If
        End If

        'VALIDATING STATE TEXTBOX
        strStates = "AL" & "AK" & "AZ" & "AR" & "CA" & "CO" & "CT" & "DE" & "FL" & "GA" & "HI" & _
            "ID" & "IL" & "IN" & "IA" & "KS" & "KY" & "LA" & "ME" & "MD" & "MA" & "MI" & "MN" & "MS" & _
            "MO" & "MT" & "NE" & "NV" & "NH" & "NJ" & "NM" & "NY" & "NC" & "ND" & "OH" & "OK" & "OR" & _
            "PA" & "RI" & "SC" & "SD" & "TN" & "TX" & "UT" & "VT" & "VA" & "WA" & "WV" & "WI" & "WY"
        strUserInputForStates = txtState.Text.ToUpper
        If strUserInputForStates.Count <> 2 Or _
            strStates.ToUpper.IndexOf(strUserInputForStates) = -1 Then   'Find out if 2 letters have been entered && find out if the 2 letters entered appear in the list of states
            If MessageBox.Show("Enter two digit abbreviation of the state", "Incorrect Input", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                txtState.SelectAll()   'If not, give the error message and keep the control at the text box.
            Else
                txtState.Clear()
            End If
        End If

        'VALIDATING SCHOOL TEXTBOX
        strSchool = "San Jose State University" & "Stanford University" & "UC Berkeley" & "Santa Clara University"
        strUserInputForSchool = txtSchool.Text.ToLower
        If strSchool.ToLower.IndexOf(strUserInputForSchool) = -1 Then 'Find out if school has been entered
            If MessageBox.Show("Enter a school from the list", "Incorrect Input", MessageBoxButtons.OKCancel) =
            Windows.Forms.DialogResult.OK Then         'If not, give the error message and keep the control at the text box.
                txtSchool.SelectAll()
            Else
                txtSchool.Clear()
            End If
        End If

        'VALIDATING MAJOR TEXTBOX
        strMajor = "Software Engineering" & "Accounting" & "MIS" & "Electrical Engineering" & "Computer Science" & "Marketing" & "Finance"
        strUserInputForMajor = txtMajor.Text.ToLower
        If strMajor.ToLower.IndexOf(strUserInputForMajor) = -1 Then
            If MessageBox.Show("Enter a major from the list", _
            "Incorrect Input", MessageBoxButtons.OKCancel) =
            Windows.Forms.DialogResult.OK Then
                txtMajor.SelectAll()
            Else
                txtMajor.Clear()
            End If
        End If

        'VALIDATING CITY TEXTBOX
        strCity = "San Jose" & "Palo Alto" & "Berkeley" & "Santa Clara" & "Oakland" & "Fremont" & "Union City" & "San Francisco" & "Hayward" & "Pleasanton "
        strUserInputForCity = txtCity.Text.ToLower
        If strCity.ToLower.IndexOf(strUserInputForCity) = -1 Then
            If MessageBox.Show("Enter a city from the list", _
            "Incorrect Input", MessageBoxButtons.OKCancel) =
            Windows.Forms.DialogResult.OK Then
                txtCity.SelectAll()
                txtCity.Focus()
            End If
        End If

        'VALIDATING ADDRESS TEXTBOX
        strAddress = txtSchool.Text.ToLower
        If strAddress = String.Empty Then
            MessageBox.Show("Please enter an address")
            txtAddress.SelectAll()
            txtAddress.Focus()
        End If

        'VALIDATING FIRST NAME TEXTBOX
        strFirstName = txtFirstName.Text
        intCount1 = txtFirstName.Text.Count
        If intCount1 = 0 Then
            If MessageBox.Show("Enter a name to proceed", _
            "Incorrect Input") Then
                txtFirstName.SelectAll()
            End If
        End If
        For x = 0 To intCount1 - 1
            If IsNumeric(strFirstName(x)) Then
                If MessageBox.Show("Name cannot contain numeric numbers", _
                "Incorrect Input") Then
                    txtFirstName.SelectAll()
                    Exit For
                Else
                    txtFirstName.SelectAll()
                End If
            End If
        Next

        'VALIDATING LAST NAME TEXTBOX
        strLastName = txtLastName.Text
        intCount2 = txtLastName.Text.Count
        If intCount2 = 0 Then
            If MessageBox.Show("Enter a name to proceed", _
            "Incorrect Input", MessageBoxButtons.OKCancel) =
            Windows.Forms.DialogResult.OK Then
                txtLastName.SelectAll()
            End If
        End If
        For x = 0 To intCount2 - 1
            If IsNumeric(strLastName(x)) Then
                If MessageBox.Show("Name cannot contain numeric numbers", _
                "Incorrect Input", MessageBoxButtons.OKCancel) =
                Windows.Forms.DialogResult.OK Then
                    txtLastName.SelectAll()
                    Exit For
                Else
                    txtLastName.Clear()
                End If
            End If
        Next

        'VALIDATING PHONE NUMBER TEXTBOX
        If txtPhone.Text = Nothing Then  'Check if nothing is entered
            MessageBox.Show("Please provide phone number information", _
            "Incorrect Input", MessageBoxButtons.OK)
            Exit Sub
        End If
        strPhone = txtPhone.Text         'Remove commonly used characters so that you standardize the phone number
        If strPhone.Substring(0, 1) = "1" Then
            strPhone = strPhone.Substring(1)
        End If
        'Format the phone number using standardized form
        strPhone = strPhone.Replace("(", "")
        strPhone = strPhone.Replace(")", "")
        strPhone = strPhone.Replace("-", "")
        strPhone = strPhone.Replace(" ", "")
        If strPhone.Count <> 10 Then 'Check to see if there are 10 digits
            If MessageBox.Show("Please enter a valid telephone number.", "Error", _
            MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                txtPhone.SelectAll()
                Exit Sub
            Else
                txtPhone.Clear()
            End If
        Else
            txtPhone.Text = "(" & strPhone.Substring(0, 3) & ") " _
            & strPhone.Substring(3, 3) & "-" _
            & strPhone.Substring(6)
        End If

        'VALIDATING PASSWORD1 TEXTBOX   
        strpassword1A = txtPassword1.Text
        If strpassword1A = Nothing Then
            MessageBox.Show("Please enter password", "Error")
        Else
            If (strpassword1A.Count > 15) Or (strpassword1A.Count < 6) Then
                ' if the character count doesn't meet the requirement, label will show error message
                MessageBox.Show("Password needs to have 6 to 15 characters long")
                txtPassword1.SelectAll()
            End If
        End If

        'VALIDATING PASSWORD2 TEXTBOX
        strpassword1B = txtPassword1.Text
        strpassword2B = txtPassword2.Text
        If strpassword2B = Nothing Then
            MessageBox.Show("Please confirm password")
        Else
            If strpassword1B <> strpassword2B Then
                MessageBox.Show("The passwords do not match", "Error")
                txtPassword2.SelectAll()
            End If
        End If

        'VALIDATING CODES- END

        'ENTER INFORMATION IN THE DATATBASE CODES
        blankcheck()
        If FormCheck = False Then
            MessageBox.Show("You have left blank fields in the form. Please fill the entire form.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail1.Focus()
            Exit Sub
        End If

        ''check if a radio button is checked before registering
        'If RadioButton1.Checked And RadioButton2.Checked And RadioButton3.Checked = False Then
        '    MessageBox.Show("Please select type of user")
        'End If

        'verifying all emails before inserting to student DB
        If RadioButton1.Checked = True Then
            NumberofRows1 = StudentTableTableAdapter.FillByEmail(GroupDatabaseDataSet.StudentTable, txtEmail1.Text)
            'if it finds an email, then email is used
            If NumberofRows1 = 1 Then
                MessageBox.Show("Email already in use")
                txtEmail1.SelectAll()
                txtEmail1.Focus()
                'ElseIf NumberofRows1 = -1 Then
            Else
                strEmail = StudentTableTableAdapter.InsertQueryStudentRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text, txtSchool.Text, txtMajor.Text)
                MessageBox.Show("Student Account Registered", "Success", MessageBoxButtons.OK)
                Me.Close()
                Login.Show()
                End If
            End If

        'verifying all emails before inserting to recruiter DB
        If RadioButton2.Checked = True Then
            NumberofRows2 = RecruiterDataTableAdapter.FillByEmail(GroupDatabaseDataSet.RecruiterData, txtEmail1.Text)
            'if it finds an email, then email is used
            If NumberofRows2 = 1 Then
                MessageBox.Show("Email already in use")
                txtEmail1.SelectAll()
                txtEmail1.Focus()
                'ElseIf NumberofRows2 = -1 Then
            Else
                strEmail = RecruiterDataTableAdapter.InsertQueryRecruiterRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text, txtCompany.Text)
                MessageBox.Show("Recruiter Account Registered", "Success", MessageBoxButtons.OK)
                Me.Close()
                Login.Show()
            End If
        End If

        'verify all emails before inserting to rater DB
        If RadioButton3.Checked = True Then
            NumberofRows3 = RaterDataTableAdapter.FillByEmail(GroupDatabaseDataSet.RaterData, txtEmail1.Text)
            'if it finds an email, then email is used
            If NumberofRows3 = 1 Then
                MessageBox.Show("Email already in use")
                txtEmail1.SelectAll()
                txtEmail1.Focus()
                'ElseIf NumberofRows3 = -1 Then
            Else
                strEmail = RaterDataTableAdapter.InsertQueryRaterRegistrationInformation(txtEmail1.Text, txtFirstName.Text, txtLastName.Text, txtPassword1.Text, txtPhone.Text)
                MessageBox.Show("Rater Account Registered", "Success", MessageBoxButtons.OK)
                Me.Close()
                Login.Show()
            End If
        End If
    End Sub

    Public FormCheck As Boolean

    Private Sub blankcheck()

        If RadioButton1.Checked = True Then
            If txtEmail1.Text = "" Or txtEmail2.Text = "" Or txtPassword1.Text = "" Or _
                txtPassword2.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtPhone.Text = "" Or _
                txtAddress.Text = "" Or txtCity.Text = "" Or txtState.Text = "" Or txtZip.Text = "" Or _
                txtMajor.Text = "" Or txtSchool.Text = "" Then
                FormCheck = False
            Else
                FormCheck = True
            End If
        ElseIf RadioButton3.Checked = True Then
            If txtEmail1.Text = "" Or txtEmail2.Text = "" Or txtPassword1.Text = "" Or _
                txtPassword2.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtPhone.Text = "" Or _
                txtAddress.Text = "" Or txtCity.Text = "" Or txtState.Text = "" Or txtZip.Text = "" Then
                FormCheck = False
            Else
                FormCheck = True
            End If
        ElseIf RadioButton2.Checked = True Then
            If txtEmail1.Text = "" Or txtEmail2.Text = "" Or txtPassword1.Text = "" Or _
     txtPassword2.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtPhone.Text = "" Or _
     txtAddress.Text = "" Or txtCity.Text = "" Or txtState.Text = "" Or txtZip.Text = "" Or txtCompany.Text = "" Then
                FormCheck = False
            Else
                FormCheck = True
            End If
        End If
    End Sub

    'Private Sub StudentTableBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
    '    Me.Validate()
    '    Me.StudentTableBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.GroupDatabaseDataSet)
    'End Sub

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