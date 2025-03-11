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
using System.Windows.Forms.VisualStyles;

namespace APU_Printing_Management_System
{
    public partial class ManagerNewRequests : Form
    {
        User userProfile;

        public ManagerNewRequests(User UserProfile)
        {
            InitializeComponent();
            InitializeNewRequestTable();
            lblManagerName.Text = UserProfile._FullName;
            userProfile = UserProfile;
        }

        private void InitializeNewRequestTable()
        {
            // Connect to database
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Request.RequestID, Request.DateOfCreation, Request.RequestStatus, Request.Priority, UserProfile.FullName AS CustomerName " +
                "FROM Request " +
                "INNER JOIN UserProfile ON UserProfile.UserID = Request.CustomerID " +
                "WHERE Request.RequestStatus = 'New';", conn);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("NewRequests");
            sda.Fill(dt);

            dgvNewRequests.AutoGenerateColumns = false;
            dgvNewRequests.DataSource = dt;

            conn.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ManagerDashboard DashboardPage = new ManagerDashboard(userProfile);
            DashboardPage.Closed += (s, args) => this.Close();
            this.Hide();
            DashboardPage.ShowDialog();
        }


        private void dgvNewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Assign Button Clicked
            if (dgvNewRequests.Columns[e.ColumnIndex].Name == "AssignedTo")
            {
                string RequestID = dgvNewRequests.Rows[e.RowIndex].Cells["RequestID"].Value.ToString();

                ManagerAssignRequest WorkerPage = new ManagerAssignRequest(RequestID, userProfile);
                WorkerPage.ManagerAssignRequestFormClosed += ManagerAssignRequest_FormClosed;
                WorkerPage.ShowDialog();
            }

            // Job Detail Button Clicked
            if (dgvNewRequests.Columns[e.ColumnIndex].Name == "JobDetail")
            {
                string RequestID = dgvNewRequests.Rows[e.RowIndex].Cells["RequestID"].Value.ToString();

                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Job.JobID, Service.ServiceType, Job.Quantity FROM Job INNER JOIN Service ON Job.ServiceID = Service.ServiceID WHERE Job.RequestID = @Request;", conn);

                cmd.Parameters.AddWithValue("@Request", RequestID);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable("Job");

                sda.Fill(dt);

                dgvNewJobs.AutoGenerateColumns = false;
                dgvNewJobs.DataSource = dt;

                conn.Close();

                txtRequestID.Text = RequestID;

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime SearchDate = DateTime.Now;
            string SearchKeyword = null;
            int SearchPriority = -1;
            string SqlCondition = string.Empty;

            // Retrieve Keyword for Search
            if (String.IsNullOrEmpty(textBoxKeyword.Text))
            {
                SearchKeyword = null;
            }
            else
            {
                SearchKeyword = textBoxKeyword.Text;
            }

            // Check if Search Col is selected
            if (!String.IsNullOrEmpty(SearchKeyword) && (comboBoxSearchColumn.SelectedIndex == -1))
            {
                MessageBox.Show("Please Select a Search Column");
            }
            else if (String.IsNullOrEmpty(SearchKeyword) && (comboBoxSearchColumn.SelectedIndex != -1))
            {
                MessageBox.Show("Please Enter Keyword to Search");
            }
            else
            {
                // Retrieve Date for Search
                if (dateTimePicker.Checked)
                {
                    SearchDate = dateTimePicker.Value;
                }

                // Retrive Priority for Search
                if (radioButtonPriorityTrue.Checked)
                {
                    SearchPriority = 1;
                }
                else if (radioButtonPriorityFalse.Checked)
                {
                    SearchPriority = 0;
                }
                else
                {
                    SearchPriority = -1;
                }

                // Add SQL Condition for Search Using Keyword
                if (comboBoxSearchColumn.SelectedIndex == 0 && !String.IsNullOrEmpty(SearchKeyword))
                {
                    SqlCondition = " AND Request.RequestID LIKE @Keyword";
                }
                else if (comboBoxSearchColumn.SelectedIndex == 1 && !String.IsNullOrEmpty(SearchKeyword))
                {
                    SqlCondition = " AND UserProfile.FullName LIKE @Keyword";
                }

                // Add SQL Condition for Search Using Priority
                if (SearchPriority != -1)
                {
                    SqlCondition += " AND Request.Priority = @Priority";
                }

                // Add SQL Condition for Search Using Date
                if (dateTimePicker.Checked)
                {
                    SqlCondition += " AND Request.DateOfCreation = @Date";
                }

                // Search in Database
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Request.RequestID, Request.DateOfCreation, Request.RequestStatus, Request.Priority, UserProfile.FullName AS CustomerName FROM Request INNER JOIN UserProfile ON UserProfile.UserID = Request.CustomerID " +
                 "WHERE Request.RequestStatus = 'New'" + SqlCondition + " ;", conn);


                if (SearchPriority != -1)
                {
                    cmd.Parameters.AddWithValue("@Priority", SearchPriority);
                }

                if (comboBoxSearchColumn.SelectedIndex != -1)
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + SearchKeyword + "%");
                }

                if (dateTimePicker.Checked)
                {
                    cmd.Parameters.AddWithValue("@Date", SearchDate.ToString("yyyy-MM-dd"));
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable("AssingedRequests");
                sda.Fill(dt);


                dgvNewRequests.AutoGenerateColumns = false;
                dgvNewRequests.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Request Found");
                }

                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxSearchColumn.SelectedIndex = -1;
            textBoxKeyword.Text = String.Empty;
            radioButtonPriorityTrue.Checked = false;
            radioButtonPriorityFalse.Checked = false;
            radioButtonPriorityAll.Checked = true;
            dateTimePicker.Checked = false;

            InitializeNewRequestTable();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile_form = new Profile(userProfile);
            profile_form.Location = new Point(this.Left + 300, this.Top + 50);
            profile_form.ShowDialog();
            lblManagerName.Text = userProfile._FullName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login LoginPage = new Login(false);
            LoginPage.Closed += (s, args) => this.Close();
            this.Hide();
            LoginPage.ShowDialog();
        }

        // Event handler for when FormB is closed
        private void ManagerAssignRequest_FormClosed(object sender, EventArgs e)
        {
            InitializeNewRequestTable();
        }


    }
}
