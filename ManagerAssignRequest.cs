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
    public partial class ManagerAssignRequest : Form
    {
        string WorkerID;
        string requestid;
        User userProfile;

        // Define an event for when the form is closed
        public event EventHandler ManagerAssignRequestFormClosed;

        public ManagerAssignRequest(string RequestID, User UserProfile)
        {
            InitializeComponent();

            // Connect to database
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT UserID, FullName FROM UserProfile WHERE UserRole = 'Worker';", conn);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Worker");

            sda.Fill(dt);

            listBoxWorker.ValueMember = "UserID";
            listBoxWorker.DisplayMember = "FullName";
            listBoxWorker.DataSource = dt;

            conn.Close();

            requestid = RequestID;
            userProfile = UserProfile;

            this.FormClosed += ManagerAssignRequest_FormClosed;
        }

        // Confirm worker to assign request to
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(WorkerID))
            {
                MessageBox.Show("Please Select a Worker");
            }
            else
            {
                // Update Database

                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");

                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Request SET RequestStatus = 'Assigned', WorkerID = @Worker, ManagerID = @Manager, DateofAssignment = @Date WHERE RequestID = @Request;", conn);

                cmd.Parameters.AddWithValue("@Worker", WorkerID);
                cmd.Parameters.AddWithValue("@Manager", userProfile._UserID);
                cmd.Parameters.AddWithValue("@Request", requestid);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Request " + requestid + " has been assigned to Worker " + listBoxWorker.GetItemText(listBoxWorker.SelectedItem));

                this.Close();
            }
        }

        // Display the number of request assigned to the selected worker
        private void listBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxWorker.SelectedValue != null)
            {
                WorkerID = listBoxWorker.SelectedValue.ToString();

                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT (SELECT COUNT(RequestID) FROM Request WHERE RequestStatus = 'Completed' AND WorkerID = @Worker) AS Completed, (SELECT COUNT(RequestID) FROM Request WHERE RequestStatus = 'Work In Progress' AND WorkerID = @Worker) AS WorkInProgress, (SELECT COUNT(RequestID) FROM Request WHERE RequestStatus = 'Assigned' AND WorkerID = @Worker) AS Assigned;", conn);

                cmd.Parameters.AddWithValue("@Worker", WorkerID);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable("WorkerRequest");

                sda.Fill(dt);

                lblCompletedCount.Text = dt.Rows[0]["Completed"].ToString();
                lblAssignedCount.Text = dt.Rows[0]["Assigned"].ToString();
                lblWorkInProgressCount.Text = dt.Rows[0]["WorkInProgress"].ToString();
                txtWorkerName.Text = listBoxWorker.GetItemText(listBoxWorker.SelectedItem);

                conn.Close();
            }

        }

        // Event handler for the FormClosed event
        private void ManagerAssignRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerAssignRequestFormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
