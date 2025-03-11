using APU_Printing_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Printing_Management_System
{
    public partial class CustomerOrderPage : Form
    {
        public User customer_u;
        Request req = new Request();
        public double totalSum;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
        public CustomerOrderPage(User user)
        {
            InitializeComponent();
            customer_u = user;
            lbl_customerName.Text = customer_u._FullName;
            DateTime_ctrl.MinDate = DateTime.Today;
            DisplayToPay();
            DisplayToReceive();
        }

        // Check column selected in each row is selected
        // Read the JobID
        public List<string> CheckSelected()
        {
            List<string> selectedJob = new List<string>();

            foreach (DataGridViewRow row in UnpaidRequestTable.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["Selected"] as DataGridViewCheckBoxCell;
                // Make sure the cells is there
                if (cell != null && cell.Value != null && Convert.ToBoolean(cell.Value))
                {
                    string jobId = row.Cells["JobID"].Value.ToString();
                    selectedJob.Add(jobId);
                }
            }
            return selectedJob;
        }


        // Get JobIDs from CheckSelected()
        // Add each item's total price together
        private void ShowTotalCost(List<string> jobIds)
        {
            double totalSum = 0;
            try
            {
                con.Open();
                foreach (string jobId in jobIds)
                {
                    SqlCommand cmd = new SqlCommand("SELECT NetPrice FROM Job WHERE JobID = @JobID", con);
                    cmd.Parameters.AddWithValue("@JobID", jobId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        totalSum += Convert.ToDouble(reader["NetPrice"]);
                    }
                    reader.Close();
                }
                con.Close();
            }
            catch { }

            // Check if the urgent checkbox is seleteced
            try
            {
                if (req._Urgent == true)
                {
                    totalSum *= 1.3;
                }
            }
            
            catch {}

            req._TotalCost = totalSum;
            Total_lbl.Text = $"RM {totalSum}"; ;
        }



        // Get JobIDs from CheckSelected() 
        // A new request merge selected items and being paid by customer
        private void UpdateItemsStatus(List<string> jobIds)
        {
            string requestID = "";
            con.Open();

            try
            {
                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Request" +
                            "([CustomerID], [Deadline], [Priority], [TotalCost], [PaymentStatus]) " +
                            " OUTPUT INSERTED.RequestID" +
                            " VALUES (@CustomerID, @Deadline, @Priority, @TotalCost, 'Paid')", con))
                {
                    insertCmd.Parameters.AddWithValue("@CustomerID", customer_u._UserID);
                    insertCmd.Parameters.AddWithValue("@Deadline", req._Deadline);
                    insertCmd.Parameters.AddWithValue("@Priority", req._Urgent);
                    insertCmd.Parameters.AddWithValue("@TotalCost", req._TotalCost);
                    requestID = insertCmd.ExecuteScalar().ToString();
                }

                
                foreach (string jobID in jobIds)
                {
                    using (SqlCommand updateCmd = new SqlCommand("UPDATE Job SET RequestID = @RequestID WHERE JobID = @JobID", con))
                    {
                        updateCmd.Parameters.AddWithValue("@RequestID", requestID);
                        updateCmd.Parameters.AddWithValue("@JobID", jobID);
                        updateCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Payment successful.");
                // Refresh the data grid view to show updated data
                DisplayToPay(); 
                DisplayToReceive();
            }
            finally
            {
                con.Close();
            }
        }


        // Get JobIDs from CheckSelected() 
        // Delete items based on JobID
        private void DeleteRequest(List<string> JobIds)
        {

            con.Open();

            foreach (string JobId in JobIds)
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Job WHERE JobID = @JobID", con))
                {
                    command.Parameters.AddWithValue("@JobID", JobId);
                    command.ExecuteNonQuery();
                }
            }

            con.Close();
            MessageBox.Show("Deleted successful.");
            // Refresh the data grid view to show updated data
            DisplayToPay(); 

        }


        // Show itmes that need to pay
        private void DisplayToPay()
        {

            string cmd = "Select J.JobID, S.ServiceType, S.FeePerUnit AS Price, J.Quantity, J.NetPrice AS Total" +
                          "\r\nFrom Job J" +
                          "\r\nLEFT JOIN Service S ON J.ServiceID = S.ServiceID" +
                          "\r\nWHERE CustomerID = @CustomerID AND RequestID IS NULL"; 


            SqlCommand command = new SqlCommand(cmd, con);
            command.Parameters.AddWithValue("@CustomerID", customer_u._UserID);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();

            //To make sure the data dosen't affected by user local settings
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);

            UnpaidRequestTable.DataSource = table;
            UnpaidRequestTable.Columns["JobID"].ReadOnly = true;
            UnpaidRequestTable.Columns["ServiceType"].ReadOnly = true;
            UnpaidRequestTable.Columns["Price"].ReadOnly = true;
            UnpaidRequestTable.Columns["Total"].ReadOnly = true;
        }


        // Show items that need to receive
        private void DisplayToReceive()
        {
            string cmd = "SELECT R.RequestID, S.ServiceType, R.Deadline, J.NetPrice AS Total, R.RequestStatus " +
                         "\n\rFROM Request R " +
                         "\n\rINNER JOIN Job J ON R.RequestID = J.RequestID " +
                         "\n\rINNER JOIN Service S ON J.ServiceID = S.ServiceID " +
                         "\n\rWHERE R.CustomerID = @CustomerID AND NOT R.RequestStatus = 'Completed' " +
                         "\n\rORDER BY R.RequestID ";
       


            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True"))
            {
                SqlCommand selectCommand = new SqlCommand(cmd, con);
                selectCommand.Parameters.AddWithValue("@CustomerID", customer_u._UserID);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                ToReceive_Table.DataSource = table;
            }

            
        }          

        private void cartPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingServiceDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.printingServiceDataSet.Job);
            // TODO: This line of code loads data into the 'printingServiceDataSet.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.printingServiceDataSet.Request);

        }

     
        private void Pay_btn_Click(object sender, EventArgs e)
        {

            List<string> selectedRequest = new List<string>();

            selectedRequest = CheckSelected();

            if (selectedRequest.Count > 0)
            {
                string message = $"Are you sure you want to pay this request?";
                string caption = "Confirm Service";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                //If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    if (req._Urgent == true)
                    {
                        req._Deadline = DateTime_ctrl.Value;
                    }
                    else
                    {
                        req._Deadline = DateTime.Today.AddDays(3);
                    }

                    MessageBox.Show($"The service will be provided before {req._Deadline}😍");
                    Total_lbl.Text = "RM 0";
                    req._PaymentStatus = "Paid";
                    UpdateItemsStatus(selectedRequest);
                }


                
            }
            else
            {
                MessageBox.Show("No items selected for payment.");
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

            List<string> selectedJob = new List<string>();

            selectedJob = CheckSelected();

            if (selectedJob.Count > 0)
            {
                string message = $"Are you sure you want to delete this request?";
                string caption = "Confirm Service";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                //If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    DeleteRequest(selectedJob);
                    Total_lbl.Text = "RM 0";
                }
            }
                
            else
            {
                MessageBox.Show("No items selected for payment.");
            }
        }


        private void UnpaidRequestTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            List<string> selectedRequest = CheckSelected();
            ShowTotalCost(selectedRequest);

        }



        private void UnpaidRequestTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UnpaidRequestTable.IsCurrentCellDirty)
            {
                UnpaidRequestTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            

        }

        private void UrgentRequest_cb_CheckedChanged(object sender, EventArgs e)
        {
            List<string> selectedRequest = new List<string>();

            req._Urgent = UrgentRequest_cb.Checked;
            selectedRequest = CheckSelected();

            if (UrgentRequest_cb.Checked == true)
            {
                ShowTotalCost((selectedRequest));
                DateTime_ctrl.Visible = true;
                notify_lbl.Visible = false;
                MessageBox.Show("You have check the for urgent request. Can request to due the work in anyday.");
            }

            else
            {

                ShowTotalCost((selectedRequest));
                DateTime_ctrl.Visible = false;
                notify_lbl.Visible = true;
                MessageBox.Show("You have uncheck the for urgent request.");
            }
        }


        private void History_btn_Click(object sender, EventArgs e)
        {
            CustomerHistoryPage history_nextform = new CustomerHistoryPage(customer_u);
            history_nextform.Closed += (s, args) => this.Close();
            this.Hide();
            history_nextform.ShowDialog();
        }
        private void CustomerProfile_btn_Click(object sender, EventArgs e)
        {
            Profile profile_form = new Profile(customer_u);
            profile_form.Location = new Point(this.Left + 300, this.Top + 50);
            profile_form.ShowDialog();
            lbl_customerName.Text = customer_u._FullName;
        }

        private void printingService_btn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customer_nextform = new CustomerDashboard(customer_u);
            customer_nextform.Closed += (s, args) => this.Close();
            this.Hide();
            customer_nextform.ShowDialog();

        }
 
        private void LogOut_btn_Click(object sender, EventArgs e)
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


    }
}
