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
    public partial class ManagerDashboard : Form
    {
        User userProfile;
        public ManagerDashboard(User UserProfile)
        {
            InitializeComponent();

            lblManagerName.Text = UserProfile._FullName;

            InitializeAssignedRequestTable();

            // Connect to database 
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog=PrintingService; Integrated Security=True");
            conn.Open();

            // SQL Command for Request Summary
            SqlCommand RequestSummaryCmd = new SqlCommand("SELECT " +
                "(SELECT COUNT(RequestID) FROM Request WHERE RequestStatus = 'Completed') AS Completed, " +
                "(SELECT COUNT(RequestID) FROM Request WHERE RequestStatus = 'Work In Progress') AS WorkInProgress,(SELECT COUNT(RequestID) FROM Request WHERE RequestStatus = 'Assigned') AS Assigned, " +
                "(SELECT COUNT(RequestID) FROM Request WHERE RequestStatus = 'New') AS New;", conn);


            SqlDataAdapter RequestSummarySda = new SqlDataAdapter(RequestSummaryCmd);

            // Data Table for Request Summary 
            DataTable RequestSummaryDt = new DataTable("RequestSummary");

            // Fill Data into Request Summary Table
            RequestSummarySda.Fill(RequestSummaryDt);

            conn.Close();

            string CompletedCount = RequestSummaryDt.Rows[0]["Completed"].ToString();
            string WorkInProgressCount = RequestSummaryDt.Rows[0]["WorkInProgress"].ToString();
            string AssignedCount = RequestSummaryDt.Rows[0]["Assigned"].ToString();
            string NewCount = RequestSummaryDt.Rows[0]["New"].ToString();

            lblCompletedCount.Text = CompletedCount;
            lblWorkInProgressCount.Text = WorkInProgressCount;
            lblAssignedCount.Text = AssignedCount;
            lblNewCount.Text = NewCount;

            if (int.TryParse(NewCount, out int newcount))
            {
                if (newcount > 0)
                {
                    lblNewCount.ForeColor = Color.Red;
                }
            }

            userProfile = UserProfile;

        }

        private void InitializeAssignedRequestTable()
        {
            // Connect to database 
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog=PrintingService; Integrated Security=True");
            conn.Open();

            // SQL Command for Assigned Request Data Grid View
            SqlCommand AssignedRequestsCmd = new SqlCommand("SELECT Request.RequestID, Request.DateOfCreation, Request.DateofAssignment, Request.RequestStatus, Request.Priority, CustomerProfile.FullName AS CustomerName, WorkerProfile.FullName AS WorkerName FROM Request " +
                "INNER JOIN UserProfile AS CustomerProfile ON CustomerProfile.UserID = Request.CustomerID " +
                "INNER JOIN UserProfile AS WorkerProfile ON WorkerProfile.UserID = Request.WorkerID" +
                " WHERE NOT Request.RequestStatus = 'New';", conn);

            // AND Request.ManagerID = @Manager

            // AssignedRequestsCmd.Parameters.AddWithValue("@Manager", userProfile._UserID);

            SqlDataAdapter AssignedRequestsSda = new SqlDataAdapter(AssignedRequestsCmd);

            // Data Table for Assigned Request Data Grid View
            DataTable AssignedRequestDt = new DataTable("AssignedRequests");

            // Fill Data into Assigned Request Data Table
            AssignedRequestsSda.Fill(AssignedRequestDt);

            dgvAssignedRequests.AutoGenerateColumns = false;
            dgvAssignedRequests.DataSource = AssignedRequestDt;

            conn.Close();
        }

        private void btnNewJobs_Click(object sender, EventArgs e)
        {
            ManagerNewRequests NewJobsPage = new ManagerNewRequests(userProfile);
            NewJobsPage.Closed += (s, args) => this.Close();
            this.Hide();
            NewJobsPage.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime SearchDateCreate = DateTime.Now;
            DateTime SearchDateAssign = DateTime.Now;
            string SearchKeyword;
            string SearchStatus;
            int SearchPriority;
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

            string.IsNullOrEmpty(SearchKeyword);
            String.IsNullOrEmpty(SearchKeyword);

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
                // Retrieve Creation Date for Search
                if (dateTimePickerCreation.Checked)
                {
                    SearchDateCreate = dateTimePickerCreation.Value;
                }

                // Retrieve Assignment Date for Search
                if (dateTimePickerAssign.Checked)
                {
                    SearchDateAssign = dateTimePickerAssign.Value;
                }

                // Retrieve Status for Search
                if (radioButtonCompleted.Checked)
                {
                    SearchStatus = "Completed";
                }
                else if (radioButtonAssigned.Checked)
                {
                    SearchStatus = "Assigned";
                }
                else if (radioButtonWorkInProgress.Checked)
                {
                    SearchStatus = "Work In Progress";
                }
                else if (radioButtonAll.Checked)
                {
                    SearchStatus = null;
                }
                else
                {
                    SearchStatus = null;
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
                    SqlCondition = " AND CustomerProfile.FullName LIKE @Keyword";
                }
                else if (comboBoxSearchColumn.SelectedIndex == 2 && !String.IsNullOrEmpty(SearchKeyword))
                {
                    SqlCondition = " AND WorkerProfile.FullName LIKE @Keyword";
                }
                
                // Add SQL Condition for Search Using Status
                if (!String.IsNullOrEmpty(SearchStatus))
                {
                    SqlCondition += " AND Request.RequestStatus = @Status";
                }

                // Add SQL Condition for Search Using Priority
                if (SearchPriority != -1)
                {
                    SqlCondition += " AND Request.Priority = @Priority";
                }

                // Add SQL Condition for Search Using Creation Date 
                if (dateTimePickerCreation.Checked)
                {
                    SqlCondition += " AND Request.DateOfCreation = @CreateDate";
                }

                // Add SQL Condition for Search Using Assignment Date
                if (dateTimePickerAssign.Checked)
                {
                    SqlCondition += " AND Request.DateOfAssignment = @AssignDate";
                }

                // Search in Database
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog=PrintingService; Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Request.RequestID, Request.DateOfCreation, Request.DateofAssignment, Request.RequestStatus, Request.Priority, CustomerProfile.FullName AS CustomerName, WorkerProfile.FullName AS WorkerName FROM Request " +
                    "INNER JOIN UserProfile AS CustomerProfile ON CustomerProfile.UserID = Request.CustomerID " +
                    "INNER JOIN UserProfile AS WorkerProfile ON WorkerProfile.UserID = Request.WorkerID WHERE NOT Request.RequestStatus = 'New'" + SqlCondition + " ;", conn);


                if (SearchPriority != -1)
                {
                    cmd.Parameters.AddWithValue("@Priority", SearchPriority);
                }

                if (comboBoxSearchColumn.SelectedIndex != -1)
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + SearchKeyword + "%");
                }

                if (!String.IsNullOrEmpty(SearchStatus))
                {
                    cmd.Parameters.AddWithValue("@Status", SearchStatus);
                }

                if (dateTimePickerCreation.Checked)
                {
                    cmd.Parameters.AddWithValue("@CreateDate", SearchDateCreate.ToString("yyyy-MM-dd"));
                }

                if (dateTimePickerAssign.Checked)
                {
                    cmd.Parameters.AddWithValue("@AssignDate", SearchDateAssign.ToString("yyyy-MM-dd"));
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable("AssingedRequests");
                sda.Fill(dt);


                dgvAssignedRequests.AutoGenerateColumns = false;
                dgvAssignedRequests.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Request Found");
                }

                conn.Close();

            }

        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login LoginPage = new Login(false);
            LoginPage.Closed += (s, args) => this.Close();
            this.Hide();
            LoginPage.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxSearchColumn.SelectedIndex = -1;
            textBoxKeyword.Text = String.Empty;
            radioButtonAssigned.Checked = false;
            radioButtonCompleted.Checked = false;
            radioButtonWorkInProgress.Checked = false;
            radioButtonAll.Checked = true;
            radioButtonPriorityTrue.Checked = false;
            radioButtonPriorityFalse.Checked = false;
            radioButtonPriorityAll.Checked = true;
            dateTimePickerCreation.Checked = false;
            dateTimePickerAssign.Checked = false;

            InitializeAssignedRequestTable();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile_form = new Profile(userProfile);
            profile_form.Location = new Point(this.Left + 300, this.Top + 50);
            profile_form.ShowDialog();
            lblManagerName.Text = userProfile._FullName;
        }
    }
}
