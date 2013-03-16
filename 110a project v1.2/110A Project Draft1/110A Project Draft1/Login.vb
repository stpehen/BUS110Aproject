Public Class Login

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GroupDatabaseDataSet.Ratings_Data_for_Design2' table. You can move, or remove it, as needed.
        Me.Ratings_Data_for_Design2TableAdapter.Fill(Me.GroupDatabaseDataSet.Ratings_Data_for_Design2)
        'TODO: This line of code loads data into the 'GroupDatabaseDataSet.RecruiterData' table. You can move, or remove it, as needed.
        Me.RecruiterDataTableAdapter.Fill(Me.GroupDatabaseDataSet.RecruiterData)
        'TODO: This line of code loads data into the 'GroupDatabaseDataSet.StudentTable' table. You can move, or remove it, as needed.
        Me.StudentTableTableAdapter.Fill(Me.GroupDatabaseDataSet.StudentTable)
        'TODO: This line of code loads data into the 'GroupDatabaseDataSet.RaterData' table. You can move, or remove it, as needed.
        Me.RaterDataTableAdapter.Fill(Me.GroupDatabaseDataSet.RaterData)
        txtUsername.ForeColor = Color.LightSlateGray
        txtUsername.Text = "Enter Username"
        txtPassword.Text = "Enter Password"
        txtPassword.UseSystemPasswordChar = False
        txtPassword.ForeColor = Color.LightSlateGray
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = Nothing Then
            txtUsername.ForeColor = Color.LightSlateGray
            txtUsername.Text = "Enter Username"
        End If
    End Sub

    Private Sub TextBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Enter Username" Then
            txtUsername.Text = Nothing
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = Nothing Then
            txtPassword.Text = "Enter Password"
            txtPassword.UseSystemPasswordChar = False
            txtPassword.ForeColor = Color.LightSlateGray
        End If
    End Sub
    Private Sub TextBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Enter Password" Then
            txtPassword.Text = Nothing
            txtPassword.UseSystemPasswordChar = True
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llRegister.LinkClicked
        'Redirect to registration form when clicked
        Registration.Show()
        Me.Hide()
    End Sub

    Private Sub RaterDataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RaterDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GroupDatabaseDataSet)

    End Sub

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        Dim NumberOfRows As Integer
        Dim RowData As Object
        Dim Password As String = String.Empty
        Dim userid As String = String.Empty
        Dim state As Integer = 1

        If txtUsername.Text = Nothing Then      'if txtUsername is empty show error message
            MessageBox.Show("Please enter username/email.", "Login Unsuccessful")
            txtUsername.SelectAll()
            txtUsername.Focus()
            txtPassword.Text = "Enter Password"
            txtPassword.ForeColor = Color.LightSlateGray
            txtPassword.UseSystemPasswordChar = False
        Else                                    'if its not empty execute state 1
            state = 1
            While state = 1
                NumberOfRows = StudentTableTableAdapter.FillByEmail(GroupDatabaseDataSet.StudentTable, txtUsername.Text)
                'if not empty
                If NumberOfRows = 1 Then
                    'for each row
                    RowData = StudentTableTableAdapter.GetDataByEmail(txtUsername.Text)(0)
                    Password = RowData.SPassword
                    userid = RowData.SEmail 'we can access this variable on another form like this LoginForm.RaterID
                    If Password <> txtPassword.Text Then    'if password is not the same go to error message
                        state = 4
                    ElseIf Password = txtPassword.Text Then
                        'MessageBox.Show("Login successful")
                        'Close login; open profile
                        Me.Hide()
                        'show profile page
                        Profile.Show()
                        Exit Sub
                    End If
                Else
                    state = 2
                End If
            End While
            While state = 2
                NumberOfRows = RaterDataTableAdapter.FillByEmail(GroupDatabaseDataSet.RaterData, txtUsername.Text)
                ' if not empty
                If NumberOfRows = 1 Then
                    'for each row
                    RowData = RaterDataTableAdapter.GetDataByEmail(txtUsername.Text)(0)
                    Password = RowData.RPassword
                    userid = RowData.REmail 'we can access this variable on another form like this LoginForm.RaterID
                    If Password <> txtPassword.Text Then    'if password is not the same go to error message
                        state = 4
                    ElseIf Password = txtPassword.Text Then
                        'MessageBox.Show("Login successful")
                        'Close login; open profile
                        Me.Hide()
                        'show profile page
                        Profile.Show()
                        Exit Sub
                    End If
                Else
                    state = 3
                End If
            End While
            While state = 3
                NumberOfRows = RecruiterDataTableAdapter.FillByEmail(GroupDatabaseDataSet.RecruiterData, txtUsername.Text)
                ' if not empty
                If NumberOfRows = 1 Then
                    'for each row
                    RowData = RecruiterDataTableAdapter.GetDataByEmail(txtUsername.Text)(0)
                    Password = RowData.RCPassword
                    userid = RowData.RCEmail 'we can access this variable on another form like this LoginForm.RaterID
                    If Password <> txtPassword.Text Then    'if password is not the same go to error message
                        state = 4
                    ElseIf Password = txtPassword.Text Then
                        'MessageBox.Show("Login successful")
                        'Close login; open profile
                        Me.Hide()
                        'show profile page
                        Profile.Show()
                        Exit Sub
                    End If
                Else
                    state = 4
                End If
            End While
            While state = 4
                MessageBox.Show("Please enter a valid username/email or password.", "Login Unsuccessful")
                txtUsername.SelectAll()
                txtUsername.Focus()
                txtPassword.Text = "Enter Password"
                txtPassword.ForeColor = Color.LightSlateGray
                txtPassword.UseSystemPasswordChar = False
                state = 5
            End While
        End If
    End Sub
End Class





