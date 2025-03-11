using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace APU_Printing_Management_System
{
   
    public partial class AdminEditUsersProfile : Form
    {
        // Define SqlConnection object to connect to the database
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
        SqlCommand cmd;

        // Define public variables to hold user information
        public User this_user;
        public List<User> all_user = new List<User>();
        public User chosen_user;

        // Constructor for the usersProfileTab form
        public AdminEditUsersProfile(User admin_u)
        {
            InitializeComponent();
            this_user = admin_u;
            usernameTextBox.Text = this_user._FullName;
        }

        //removing selected user (the details)
        private void removeButton_Click(object sender, EventArgs e)
        {
            con.Open();
            
            SqlCommand cmd = new SqlCommand("DELETE FROM UserProfile where UserID=@UserID", con);
            cmd.Parameters.AddWithValue("@userId", registeredUserIdComboBox.Text);
            cmd.ExecuteNonQuery();
            InitializeComponent();

            MessageBox.Show("Deleted Succesfully");

            con.Close();
            
        }

        //loading the details of the selected user
        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                chosen_user = all_user.Find(x => x._UserID == registeredUserIdComboBox.Text);
            }
            catch
            {
                chosen_user= null;
            }



            if (chosen_user == null)
            {
                try
                {

                    // Create SQL command to search for the user
                    string sqlQuery = "SELECT * FROM UserProfile WHERE  UserID= @username";
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");

                    // Open database connection
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        // Add parameter for username
                        cmd.Parameters.AddWithValue("@username", registeredUserIdComboBox.Text);
                        cmd.ExecuteNonQuery();
                        // Execute SQL command
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Check if any rows were returned
                        if (reader.Read())
                        {
                            // User found, populate TextBoxes with user information
                            chosen_user = new User(reader["UserID"].ToString(), reader["Password"].ToString(), reader["UserRole"].ToString(), reader["FullName"].ToString(), reader["PhoneNumber"].ToString());
                            userIdTextBox.Text = reader["UserID"].ToString();
                            passwordTextBox.Text = reader["Password"].ToString();
                            fullNameTextBox.Text = reader["FullName"].ToString();
                            phoneNumTextBox.Text = reader["PhoneNumber"].ToString();
                            roleComboBox.Text = reader["UserRole"].ToString();
                            passwordTextBox2.Text = reader["Password"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Please Select the User ID");
                            // Optionally, clear TextBoxes or perform any other actions if the user is not found
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Ensure the database connection is always closed
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

                all_user.Add(chosen_user);
            }
            
        }
        
        //going to yearly report form
        private void yearlyReportButton_Click(object sender, EventArgs e)
        {
            AdminYearlyReports form = new AdminYearlyReports(this_user);
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.ShowDialog();
        }

        //going to service request form
        private void serviceRequestReportButton_Click(object sender, EventArgs e)
        {
            AdminServiceReqReport form = new AdminServiceReqReport(this_user);
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.ShowDialog();
        }

        // Method to populate registeredUserIdComboBox with user IDs from the database
        private void userIdSource()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from UserProfile WHERE NOT UserID = @UserID";
            cmd.Parameters.AddWithValue("@UserID", this_user._UserID);
            cmd.ExecuteNonQuery();

            // Initialize the SqlDataAdapter object with the SqlCommand object
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                registeredUserIdComboBox.Items.Add(dr["UserID"].ToString());
            }

            con.Close();
        }

        //for logging out will ask for confirmation whether want to log out or not
        private void logOutButton_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you want to log out?";
            string caption = "Confirm Service";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            //If the no button was pressed ...
            if (result == DialogResult.No)
            {
                return;
            }

            else
            {
                Login logout_nextform = new Login(true);
                logout_nextform.Closed += (s, args) => this.Close();
                this.Hide();
                logout_nextform.ShowDialog();
            }
        }

        //will keep changing accordingly based on the password that is being entered (Password Validation)
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length < 8)
            {
                lbl_requirement1.ForeColor = Color.Red;
            }
            else
            {
                lbl_requirement1.ForeColor = Color.Black;
            }

            bool condition1 = passwordTextBox.Text.Any(char.IsUpper);
            bool condition2 = passwordTextBox.Text.Any(char.IsLower);
            bool condition3 = passwordTextBox.Text.Any(char.IsLetterOrDigit);
            if (!(condition1 && condition2 && condition3))
            {
                lbl_requirement2.ForeColor = Color.Red;
            }
            else
            {
                lbl_requirement2.ForeColor = Color.Black;
            }

            if (passwordTextBox.Text != passwordTextBox2.Text)
            {
                lbl_requirement3.ForeColor = Color.Red;
            }
            else
            {
                lbl_requirement3.ForeColor = Color.Black;
            }
        }


        //to update details of the selected user, prevent any empty value of the details that are needed to update User
        private void updateButton_Click(object sender, EventArgs e)
        {
            bool valid1 = (lbl_requirement1.ForeColor == Color.Black) && (lbl_requirement2.ForeColor == Color.Black) && (lbl_requirement3.ForeColor == Color.Black);
            bool valid2 = true;

            if (String.IsNullOrEmpty(passwordTextBox2.Text))
            {
                passwordTextBox2.Focus();
                valid2 = false;
            }

            if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordTextBox.Focus();
                valid2 = false;
            }

            if (String.IsNullOrEmpty(phoneNumTextBox.Text))
            {
                phoneNumTextBox.Focus();
                valid2 = false;
            }

            if (String.IsNullOrEmpty(fullNameTextBox.Text))
            {
                fullNameTextBox.Focus();
                valid2 = false;
            }

            if (valid1 && valid2)
            {
                
                string message = "Update the Details?";
                string caption = "Confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                //If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    return;
                }
                chosen_user.Update_user(fullNameTextBox.Text, phoneNumTextBox.Text, passwordTextBox.Text);


            }

            if (!(valid1))
            {
                string message = "Password requirements are not satisfied. Please try again!";
                string caption = "Invalid Password Change";
                MessageBox.Show(message, caption);
            }

            if (!(valid2))
            {
                string message = "All input fields must be filled in. Please try again!";
                string caption = "Empty Input Field(s)";
                MessageBox.Show(message, caption);
            }

        }

        //to add the new user
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Please Fill in the Neccessary Details");
            }
            else
            {
                User new_user = new User(userIdTextBox.Text, passwordTextBox.Text, roleComboBox.Text, fullNameTextBox.Text, phoneNumTextBox.Text);
                all_user.Add(new_user);
                chosen_user = new_user;

                new_user.New_user();
                passwordTextBox.Text = "";
                passwordTextBox2.Text = "";
                fullNameTextBox.Text = "";
                phoneNumTextBox.Text = "";
                roleComboBox.Text = "";
            }
        }

        //will enable all the neccesary toolbox and disable the unneccessary ones
        private void editRadioBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            userIdSource();
            roleComboBox.Enabled = false;
            userIdTextBox.Enabled = false;
            passwordTextBox.ReadOnly = false;
            passwordTextBox2.ReadOnly = false;
            fullNameTextBox.ReadOnly = false;
            phoneNumTextBox.ReadOnly = false;
            addButton.Enabled = false;
            updateButton.Enabled = true;
            registeredUserIdComboBox.Enabled = true;
            loadButton.Enabled = true;
            removeButton.Enabled = true;    
        }

        //will enable all the neccesary toolbox and disable the unneccessary ones
        private void registerRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
            loadButton.Enabled = false;
            removeButton.Enabled = false;
            registeredUserIdComboBox.Items.Clear();
            registeredUserIdComboBox.Enabled = false;
            userIdTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            passwordTextBox2.Text = string.Empty;
            fullNameTextBox.Text = string.Empty;
            phoneNumTextBox.Text = string.Empty;
            roleComboBox.Text = string.Empty;
            userIdTextBox.Enabled = true;
            userIdTextBox.ReadOnly = false;
            passwordTextBox.ReadOnly = false;
            fullNameTextBox.ReadOnly = false;
            phoneNumTextBox.ReadOnly = false;
            roleComboBox.Enabled = true;
            updateButton.Enabled = false;
            addButton.Enabled = true;
            passwordTextBox2.ReadOnly = false;
        }

        //(must be same with the Password) (Password Confirmation)
        private void passwordTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != passwordTextBox2.Text)
            {
                lbl_requirement3.ForeColor = Color.Red;
            }
            else
            {
                lbl_requirement3.ForeColor = Color.Black;
            }
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            Profile profile_form = new Profile(this_user);
            profile_form.Location = new Point(this.Left + 300, this.Top + 50);
            profile_form.ShowDialog();
            usernameTextBox.Text = this_user._FullName;


        }
    }
}
