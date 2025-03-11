using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Printing_Management_System
{
    public partial class AdminYearlyReports : Form
    {
        // Define SqlConnection object to connect to the database
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
        SqlCommand cmd;
        public User this_user;
        public AdminYearlyReports(User admin_u)
        {
            InitializeComponent();
            this_user = admin_u;
            usernameTextBox.Text = admin_u._FullName;
            yearSource();
        }

        //to go to user profile form
        private void usersProfileButton_Click(object sender, EventArgs e)
        {
            AdminEditUsersProfile form = new AdminEditUsersProfile(this_user);
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.ShowDialog();
        }

        //to go to service request form
        private void serviceRequestReportButton_Click(object sender, EventArgs e)
        {
            AdminServiceReqReport form = new AdminServiceReqReport(this_user);
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.ShowDialog();
        }

        //to ask for confirmation if user really want to log out or not, if confirmed, will logout from system
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

        private void yearlyReportsTab_Load(object sender, EventArgs e)
        {

        }

        //extracting year that has information in SQL and output only once per year to prevent duplicate

        private void yearSource()
        {
            // Define SqlConnection object to connect to the database
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            SqlCommand cmd;

            con.Open();
            //commmand to SQL
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT YEAR(DateOfCreation) As [Year]\r\nFROM Request";
            //Executing
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                yearComboBox.Items.Add(dr["Year"].ToString());
            }

            con.Close();
        }

        //to output the Grand Total of 12 months of the selected year
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select the Year");
            }
            else
            {
                con.Open();

                // Create SQL command to search for the total cost
                string sqlQuery = "SELECT SUM(TotalCost) AS TotalCost " +
                                  "FROM Request " +
                                  "WHERE YEAR(DateOfCreation) = @Year AND MONTH(DateOfCreation) = @Month";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    // Add parameters for year and month
                    cmd.Parameters.AddWithValue("@Year", Int32.Parse(yearComboBox.Text));
                    cmd.Parameters.AddWithValue("@Month", 1);

                    // Execute SQL command
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost
                        januaryValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader to allow for reusing the SqlCommand
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 2;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        februaryValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 3;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        marchValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 4;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        aprilValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    // Change the month parameter and execute the command again for February
                    cmd.Parameters["@Month"].Value = 5;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        mayValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 6;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        juneValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 7;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        julyValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 8;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        augustValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 9;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        septemberValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 10;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        octoberValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 11;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        novemberValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();

                    cmd.Parameters["@Month"].Value = 12;
                    reader = cmd.ExecuteReader();

                    // Check if any rows were returned
                    if (reader.Read())
                    {
                        // Populate TextBox with total cost for February
                        decemberValue.Text = reader["TotalCost"].ToString();
                    }

                    // Close the reader
                    reader.Close();
                }
            }
            

            // Close the connection
            con.Close();
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
