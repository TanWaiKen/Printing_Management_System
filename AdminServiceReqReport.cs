using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Printing_Management_System
{
    public partial class AdminServiceReqReport : Form
    {
        // Define public variable to hold user information
        public User this_user;

        // Constructor for the serviceReqReportTab form
        public AdminServiceReqReport(User admin_u)
        {
            InitializeComponent();
            this_user = admin_u;
            usernameTextBox.Text = admin_u._FullName;
            yearSource();
            monthSource();
        }

        //to go to user profile form
        private void usersProfileButton_Click(object sender, EventArgs e)
        {
            AdminEditUsersProfile form = new AdminEditUsersProfile(this_user);
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.ShowDialog();
        }
        
        //to go to yearlyreport form
        private void yearlyReportButton_Click(object sender, EventArgs e)
        {
            AdminYearlyReports form = new AdminYearlyReports(this_user);
            form.Closed += (s, args) => this.Close();
            this.Hide();
            form.ShowDialog();
        }

        //to ask for confirmation whether user want to log out or not, if yes, will logout from the system
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

        //enable neccessary functions for service request report and disable unneccessary functions
        private void serviceRequestRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            userIdTextBox.Enabled = false;
            loadButton.Enabled = true;
            yearComboBox.Enabled = true;
            monthComboBox.Enabled = true;
            
            
        }

        //enable neccessary functions for service request report and disable unneccessary functions
        private void customerReportRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            userIdTextBox.Enabled = true;
            yearComboBox.Enabled = true;
            monthComboBox.Enabled = true;
            loadButton.Enabled = true;
            userIdTextBox.ReadOnly = false;

        }

        //to show the report after load button has been clicked (some validation inside)
        private void loadButton_Click(object sender, EventArgs e)
        {
            if (serviceRequestRadioBtn.Checked == true)
            {
                if (yearComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please Select the Year");

                }
                else
                {
                    if (monthComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select the Month");

                    }
                    else
                    {
                        reportTableServiceReq();
                    }

                }


            }


            //to show the report after load button has been clicked (some validation inside)
            else
            {
                if (yearComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please Select the Year");
                }
                else
                {
                    if (monthComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select the Month");
                    }
                    else
                    {
                        if (userIdTextBox.Text == "")
                        {
                            MessageBox.Show("Please Type the User ID");
                        }

                        else
                        {
                            reportTableCustomer();
                        }
                    }
                }
            }

        }


        // Method to generate and display the service request report
        private void reportTableServiceReq()
        {
            //open the connection
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            SqlCommand cmd;

            con.Open();
            //running the command or query to the SQL
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select S.ServiceType, Count(J.RequestID) AS TotalRequest, SUM(J.NetPrice) AS TotalIncome\r\nFROM Service S" +
                "\r\nFULL OUTER JOIN Job J ON J.ServiceID = S.ServiceID" +
                "\r\nFULL OUTER JOIN Request R ON J.RequestID = R.RequestID" +
                "\r\nWHERE YEAR(R.DateOfCreation) = @Year AND MONTH(R.DateOfCreation) = @Month" +
                "\r\nGROUP BY S.ServiceType";

            //reading the data provided from the form (Year and Month), outputting details based on the selected year and month
            SqlCommand selectCommand = new SqlCommand(cmd.CommandText, con);
            selectCommand.Parameters.AddWithValue("@Year", Int32.Parse(yearComboBox.Text));
            selectCommand.Parameters.AddWithValue("@Month", Int32.Parse(monthComboBox.Text));
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            serviceReqReportDataGridView.DataSource = table;
            con.Close();
        }

        //Method to generate and display the customer report
        private void reportTableCustomer()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            SqlCommand cmd;

            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select S.ServiceType, Count(J.RequestID) AS TotalRequest, SUM(J.NetPrice) AS TotalIncome\r\nFROM Service S" +
        "\r\nFULL OUTER JOIN Job J ON J.ServiceID = S.ServiceID" +
        "\r\nFULL OUTER JOIN Request R ON J.RequestID = R.RequestID" +
        "\r\nWHERE YEAR(R.DateOfCreation) = @Year AND MONTH(R.DateOfCreation) = @Month" +
        "\r\nAND J.CustomerID = @UserID" +
        "\r\nGROUP BY S.ServiceType";

            SqlCommand selectCommand = new SqlCommand(cmd.CommandText, con);
            selectCommand.Parameters.AddWithValue("@Year", Int32.Parse(yearComboBox.Text));
            selectCommand.Parameters.AddWithValue("@Month", Int32.Parse(monthComboBox.Text));
            selectCommand.Parameters.AddWithValue("@UserID", userIdTextBox.Text); // Assuming userIdTextBox contains the UserID
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            serviceReqReportDataGridView.DataSource = table;
            
            con.Close();
        }

        // Method to populate yearComboBox with available years
        private void yearSource()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            SqlCommand cmd;

            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT YEAR(DateOfCreation) As [Year]\r\nFROM Request";

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

        // Method to populate monthComboBox with available month 
        private void monthSource()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            SqlCommand cmd;

            con.Open();

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT Month(DateOfCreation) As [Month]\r\nFROM Request";

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                monthComboBox.Items.Add(dr["Month"].ToString());
            }

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
