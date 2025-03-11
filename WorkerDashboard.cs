using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APU_Printing_Management_System.PrintingServiceDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace APU_Printing_Management_System
{
    public partial class WorkerDashboard : Form
    {
        public User worker_u;
        Request selected_req;
        public List<Request> worker_reqs = new List<Request>();
        public DataTable dt3;
        public BindingSource bs = new BindingSource();

        public string statusfil;
        public WorkerDashboard(User user)
        {
            worker_u = user;
            InitializeComponent();
            Fill_dgv_all();
            Fill_summary_calendar();
            lbl_workerName.Text = worker_u._FullName;
            combo_deadline.SelectedIndex = 0;
            combo_calendar.SelectedIndex = 0;
        }

        private void lbl_logOut_Click(object sender, EventArgs e)
        {
            /*
            Log out worker form
            */

            Login form_login = new Login(true);
            form_login.Closed += (s, args) => this.Close();
            this.Hide();
            form_login.ShowDialog();
        }

        private void lbl_profile_Click(object sender, EventArgs e)
        {
            /*
            Open profile form
            */

            Profile profile_form = new Profile(worker_u);
            profile_form.Location = new Point(this.Left+300, this.Top+50);
            profile_form.ShowDialog();
            lbl_workerName.Text = worker_u._FullName;
        }

        private void btn_clearfilter_Click(object sender, EventArgs e)
        {
            /*
            Clear search filter
            */

            bs.RemoveFilter();
            combo_deadline.SelectedIndex = 0;
            combo_calendar.SelectedIndex = 0;
            txt_search.Text = "";
            rb_assigned.Checked = false;
            rb_inProgress.Checked = false;
            rb_completed.Checked = false;
            rb_all.Checked = false;
            cb_priority.Checked = false;
            monthCalendar1.SetDate(DateTime.Today);
        }

        private void Fill_summary_calendar()
        {
            /*
            Load Work Summary and deadline(s) on Calendar from SQL database
            */

            // Calculate the number of incomplete tasks in this month
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True;");
            con.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT COUNT([RequestID]) FROM [Request] WHERE [WorkerID] = @WorkerID " +
                "AND ([RequestStatus] = 'Assigned' OR [RequestStatus] = 'Work In Progress') AND MONTH(DateOfCreation) = @month;", con);
            cmd1.Parameters.AddWithValue("@WorkerID", worker_u._UserID);
            cmd1.Parameters.AddWithValue("@month", DateTime.Now.Month);
            

            int incomplete = int.Parse(cmd1.ExecuteScalar().ToString());

            // Calculate the number of completed tasks in this month
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT([RequestID]) FROM [Request] WHERE [WorkerID] = @WorkerID " +
                "AND [RequestStatus] = 'Completed' AND MONTH(DateOfCreation) = @month;", con);
            cmd2.Parameters.AddWithValue("@WorkerID", worker_u._UserID);
            cmd2.Parameters.AddWithValue("@month", DateTime.Now.Month);

            int complete = int.Parse(cmd2.ExecuteScalar().ToString());

            // Calculate the number of total tasks in this month
            int total_req = incomplete + complete;

            // Find all the incomplete deadline(s) in the month
            // Populate the deadline(s) in calendar
            SqlCommand cmd3 = new SqlCommand("SELECT Deadline, COUNT(RequestID) FROM Request " +
                "WHERE WorkerID = @WorkerID AND " +
                "Deadline IS NOT NULL AND " +
                "(RequestStatus = 'Assigned' OR RequestStatus = 'Work In Progress') " +
                "GROUP BY Deadline;", con);
            cmd3.Parameters.AddWithValue("@WorkerID", worker_u._UserID);

            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);

            dt3 = new DataTable("Deadline");

            sda3.Fill(dt3);
            dt3.PrimaryKey = new DataColumn[] { dt3.Columns[0] };

            foreach (DataRow row in dt3.Rows)
            {
                monthCalendar1.AddBoldedDate(DateTime.Parse(row[0].ToString()));
            }

            con.Close();

            // Update the Work Summary date on UI
            txt_jobIncomplete.Text = incomplete.ToString();
            txt_jobCompleted.Text = complete.ToString();
            txt_totalJob.Text = total_req.ToString();
        }

        private void Fill_dgv_all()
        {
            /*
            Populate dgv_all with the all requests of this worker 
            */

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT RequestID, CustomerID, DateOfCreation, Deadline, Priority, TotalCost, RequestStatus, PaymentStatus, " +
                "ManagerID, DateOfAssignment FROM Request Where WorkerID= @WorkerID", con);
            cmd.Parameters.AddWithValue("@WorkerID", worker_u._UserID);

            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Request");

            sda1.Fill(dt);
            bs.DataSource = dt;
            dgv_all.DataSource = bs;

            con.Close();
        }

        private void Fill_dgv_selected(DataGridViewRow row)
        {
            /*
            Populate dgv_selected with the jobs of selected request 
            */

            // If this request is selected before, use the corresponding Request instance in worker_reqs list
            // Otherwise, retrieve the request from SQL database, create an associated Request instance, and store the instance in worker_reqs list 
            try
            {
                selected_req = worker_reqs.Find(x => x._RequestID == row.Cells[0].Value.ToString());
            }
            catch
            {
                selected_req = null;
            }



            if (selected_req == null)
            {
                selected_req = new Request(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(),
                    (DateTime.Parse(row.Cells[2].Value.ToString())).Date, (DateTime.Parse(row.Cells[3].Value.ToString())).Date, bool.Parse(row.Cells[4].Value.ToString()),
                    double.Parse(row.Cells[5].Value.ToString()), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(),
                    worker_u._UserID, row.Cells[8].Value.ToString(), (DateTime.Parse(row.Cells[9].Value.ToString())).Date);

                worker_reqs.Add(selected_req);
            }

            // Retrieve the jobs for this request from SQL database
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Job.JobID, Service.ServiceType, Job.Quantity, Job.NetPrice " +
                "FROM Job INNER JOIN Service ON (Job.ServiceID = Service.ServiceID) " +
                "WHERE Job.RequestID = @RequestID", con);
            cmd.Parameters.AddWithValue("@RequestID", selected_req._RequestID);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Job");

            sda.Fill(dt);
            dgv_selected.DataSource = dt;
            con.Close();

            // Disable the button for current RequestStatus
            switch (selected_req._RequestStatus)
            {
                case "Assigned":
                    btn_assigned.Enabled = false;
                    btn_inProgress.Enabled = true;
                    btn_completed.Enabled = true;
                    break;

                case "Work In Progress":
                    btn_inProgress.Enabled = false;
                    btn_assigned.Enabled = true;
                    btn_completed.Enabled = true;
                    break;

                case "Completed":
                    btn_completed.Enabled = false;
                    btn_assigned.Enabled = true;
                    btn_inProgress.Enabled = true;
                    break;

            }

            // Display Request Details on UI
            txt_requestID.Text = selected_req._RequestID;
            txt_cusID.Text = selected_req._CustomerID;
            txt_deadline.Text = selected_req._Deadline.ToString("d");
            txt_price.Text = selected_req._TotalCost.ToString();
            txt_status.Text = selected_req._RequestStatus;

        }

        private void dgv_all_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_all.Rows[e.RowIndex];
            Fill_dgv_selected(row);
        }

        private void btn_inProgress_Click(object sender, EventArgs e)
        {
            /*
            Update request status to "In Progress"
            */

            if (selected_req != null)
            {
                if (selected_req._RequestStatus == "Completed")
                {
                    // Update Work Summary
                    txt_jobCompleted.Text = (int.Parse(txt_jobCompleted.Text) - 1).ToString();
                    txt_jobIncomplete.Text = (int.Parse(txt_jobIncomplete.Text) + 1).ToString();

                    //Update deadline in calendar
                    DataRow row = dt3.Rows.Find(selected_req._Deadline);

                    if (row != null)
                    {
                        int count = int.Parse(row[1].ToString()) + 1;
                        row[1] = count;

                        if (count == 1)
                        {
                            monthCalendar1.AddBoldedDate(selected_req._Deadline);
                            monthCalendar1.UpdateBoldedDates();
                        }
                    }
                    else
                    {
                        dt3.Rows.Add(new Object[] { selected_req._Deadline, 1 });
                        monthCalendar1.AddBoldedDate(selected_req._Deadline);
                        monthCalendar1.UpdateBoldedDates();
                    }
                }

                // Update RequestStatus in this User instance
                selected_req.Update_Request_Status("Work In Progress");
                
                // Update Request Details and Controls on UI
                txt_status.Text = selected_req._RequestStatus;
                btn_inProgress.Enabled = false;
                btn_assigned.Enabled = true;
                btn_completed.Enabled = true;
                Fill_dgv_all();
            }
            else
            {
                MessageBox.Show("Please select one request to proceed!");
            }
            
        }

        private void btn_completed_Click(object sender, EventArgs e)
        {
            /*
            Update request status to "Completed"
            */

            if (selected_req != null)
            {
                // Update RequestStatus in this User instance
                selected_req.Update_Request_Status("Completed");

                // Update Request Details and Controls on UI
                txt_status.Text = selected_req._RequestStatus;
                btn_completed.Enabled = false;
                btn_assigned.Enabled = true;
                btn_inProgress.Enabled = true;
                Fill_dgv_all();

                // Update Work Summary
                txt_jobCompleted.Text = (int.Parse(txt_jobCompleted.Text)+1).ToString();
                txt_jobIncomplete.Text = (int.Parse(txt_jobIncomplete.Text) - 1).ToString();

                // Update deadline on Calendar
                DataRow row = dt3.Rows.Find(selected_req._Deadline);
                int count = int.Parse(row[1].ToString()) - 1;
                row[1] = count;

                if (count < 1)
                {
                    monthCalendar1.RemoveBoldedDate(selected_req._Deadline);
                    monthCalendar1.UpdateBoldedDates();
                }

            }
            else
            {
                MessageBox.Show("Please select one request to proceed!");
            }
        }

        private void btn_assigned_Click(object sender, EventArgs e)
        {
            /*
            Update request status to "Assigned"
            */

            if (selected_req != null)
            {
                if (selected_req._RequestStatus == "Completed")
                {
                    // Update Work Summary
                    txt_jobCompleted.Text = (int.Parse(txt_jobCompleted.Text) - 1).ToString();
                    txt_jobIncomplete.Text = (int.Parse(txt_jobIncomplete.Text) + 1).ToString();

                    // Update Calendar
                    DataRow row = dt3.Rows.Find(selected_req._Deadline);

                    if (row != null)
                    {
                        int count = int.Parse(row[1].ToString()) + 1;
                        row[1] = count;

                        if (count == 1)
                        {
                            monthCalendar1.AddBoldedDate(selected_req._Deadline);
                            monthCalendar1.UpdateBoldedDates();
                        }
                    }
                    else
                    {
                        dt3.Rows.Add(new Object[] { selected_req._Deadline, 1 });
                        monthCalendar1.AddBoldedDate(selected_req._Deadline);
                        monthCalendar1.UpdateBoldedDates();
                    }
                }

                // Update RequestStatus in this User instance
                selected_req.Update_Request_Status("Assigned");

                // Update Request Details and Controls on UI
                txt_status.Text = selected_req._RequestStatus;
                btn_assigned.Enabled = false;
                btn_completed.Enabled = true;
                btn_inProgress.Enabled = true;
                Fill_dgv_all();                
            }
            else
            {
                MessageBox.Show("Please select one request to proceed!");
            }
        }

        private void rb_assigned_CheckedChanged(object sender, EventArgs e)
        {
            /*
            Search Filter (RequestStatus == "Assigned")
            */

            string fil = $"RequestStatus LIKE '{rb_assigned.Text}'";
            if (rb_assigned.Checked == true)
            {
                // Add this search criteria
                if (string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter += fil;
                }
                else
                {
                    bs.Filter += $" AND {fil}";
                }
                statusfil = fil;
            }
            else
            {
                // Remove this search criteria
                if (!string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter = bs.Filter.Replace($" AND {fil}", "");
                    bs.Filter = bs.Filter.Replace($"{fil} AND ", "");
                    // MessageBox.Show(bs.Filter);
                    bs.Filter = bs.Filter.Replace($"{fil}", "");
                }
            }
        }

        private void rb_inProgress_CheckedChanged(object sender, EventArgs e)
        {
            /*
            Search Filter (RequestStatus == "In Progress")
            */
            string fil = $"RequestStatus LIKE '{rb_inProgress.Text}'";
            if (rb_inProgress.Checked == true)
            {
                if (string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter += fil;
                }
                else
                {
                    bs.Filter += $" AND {fil}";
                }
                statusfil = fil;
            }
            else
            {
                if (!string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter = bs.Filter.Replace($" AND {fil}", "");
                    bs.Filter = bs.Filter.Replace($"{fil} AND ", "");
                    bs.Filter = bs.Filter.Replace($"{fil}", "");
                }
            }
        }

        private void rb_completed_CheckedChanged(object sender, EventArgs e)
        {
            /*
            Search Filter (RequestStatus == "Completed")
            */

            string fil = $"RequestStatus LIKE '{rb_completed.Text}'";
            if (rb_completed.Checked == true)
            {
                if (string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter += fil;
                }
                else
                {
                    bs.Filter += $" AND {fil}";
                }
                statusfil = fil;
            }
            else
            {
                if (!string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter = bs.Filter.Replace($" AND {fil}", "");
                    bs.Filter = bs.Filter.Replace($"{fil} AND ", "");
                    // MessageBox.Show(bs.Filter);
                    bs.Filter = bs.Filter.Replace($"{fil}", "");
                }                
            }
            
        }

        private void cb_priority_CheckedChanged(object sender, EventArgs e)
        {
            /*
            Search Filter (Priority == true)
            */

            if (cb_priority.Checked == true)
            {
                if (string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter = $"Priority = 1";
                }
                else
                {
                    bs.Filter += $" AND Priority = 1";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter = bs.Filter.Replace(" AND Priority = 1", "");
                    bs.Filter = bs.Filter.Replace("Priority = 1 AND ", "");
                    bs.Filter = bs.Filter.Replace("Priority = 1", "");
                }
            }
        }

        public string last_text;
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            /*
            Search Filter (Textbox Input in [RequestID, CustomerID, ManagerID])
            */

            if (string.IsNullOrEmpty(txt_search.Text) == false)
            {
                string filtercom = $"(RequestID LIKE '%{txt_search.Text}%' OR " +
                $"CustomerID LIKE '%{txt_search.Text}%' OR " +
                $"ManagerID LIKE '%{txt_search.Text}%')";

                if (!string.IsNullOrEmpty(last_text))
                {
                    bs.Filter = bs.Filter.Replace($"{last_text}", filtercom);
                }
                else
                {
                    if (string.IsNullOrEmpty(bs.Filter))
                    {
                        bs.Filter += filtercom;
                    }
                    else
                    {
                        string fil = " AND " + filtercom;
                        bs.Filter += fil;
                    }
                }
                last_text = filtercom;
                    
            }
            else
            {
                if (!string.IsNullOrEmpty(bs.Filter))
                {
                    string fil = " AND " + last_text;
                    bs.Filter = bs.Filter.Replace(fil, "");
                    fil = last_text + " AND ";
                    bs.Filter = bs.Filter.Replace(fil, "");
                    //MessageBox.Show(bs.Filter);
                    bs.Filter = bs.Filter.Replace(last_text, "");
                }
                
                last_text = "";
            }

            
        }


        public string last_deadline = "";
        private void combo_deadline_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Search Filter (Deadline using combobox)
            */

            if (!string.IsNullOrEmpty(bs.Filter) && !string.IsNullOrEmpty(last_calendar))
            {
                monthCalendar1.SetDate(DateTime.Today);
                bs.Filter = bs.Filter.Replace($"AND {last_calendar}", "");
                bs.Filter = bs.Filter.Replace($"{last_calendar} AND ", "");
                bs.Filter = bs.Filter.Replace($"{last_calendar}", "");
                last_calendar = "";
            }
            

            string deadline = "";
            DateTime today = DateTime.Now.Date;
            DateTime day;

            switch (combo_deadline.SelectedItem.ToString())
            {
                case "Late":
                    deadline = $"Deadline < '{today}'";
                    break;

                case "In 1 day":
                    day = DateTime.Now.Date;
                    deadline = $"Deadline = '{today}'";
                    break;

                case "In 3 days":
                    day = DateTime.Now.AddDays(2).Date;
                    deadline = $"('{today}' <= Deadline AND Deadline <= '{day}')";
                    break;

                case "In 7 days":
                    day = DateTime.Now.AddDays(6).Date;
                    deadline = $"('{today}' <= Deadline AND Deadline <= '{day}')";
                    break;

                case "In 30 days":
                    day = DateTime.Now.AddDays(29).Date;
                    deadline = $"('{today} ' <= Deadline AND Deadline <= '{day}')";
                    break;

                case "None":
                    if (!string.IsNullOrEmpty(bs.Filter))
                    {
                        bs.Filter = bs.Filter.Replace($"AND {last_deadline}", "");
                        bs.Filter = bs.Filter.Replace($"{last_deadline} AND ", "");
                        bs.Filter = bs.Filter.Replace($"{last_deadline}", "");
                    }
                    deadline = "";
                    break;

                default:
                    break;
            }

            if (String.IsNullOrEmpty(last_deadline)){
                if (string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter += deadline;
                }
                else
                {
                    string fil = " AND " + deadline;
                    bs.Filter += fil;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter = bs.Filter.Replace($"{last_deadline}", $"{deadline}");
                }
                    
            }

            last_deadline = deadline;

        }

        public string last_calendar= "";
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            /*
            Search Filter (Date (range) on Calendar)
            */

            combo_deadline.SelectedIndex = 0;
            string filter_criteria = "";

            switch (combo_calendar.SelectedItem.ToString())
            {
                case "Deadline":
                    filter_criteria = "Deadline";
                    break;

                case "Date of Creation":
                    filter_criteria = "DateOfCreation";
                    break;

                case "Date of Assignment":
                    filter_criteria = "DateOfAssignment";
                    break;

                case "None":
                    filter_criteria = "None";
                    if (!string.IsNullOrEmpty(bs.Filter) && (!string.IsNullOrEmpty(last_calendar)))
                    {
                        bs.Filter = bs.Filter.Replace($"AND {last_calendar}", "");
                        bs.Filter = bs.Filter.Replace($"{last_calendar} AND ", "");
                        bs.Filter = bs.Filter.Replace($"{last_calendar}", "");
                    }
                    last_calendar = "";
                    break;

                default:
                    break;

            }

            if (filter_criteria != "None")
            {
                string calendar = $"('{e.Start.ToShortDateString()}' <= {filter_criteria} AND " +
                    $"{filter_criteria} <= '{e.End.ToShortDateString()}')";
                calendar_filter(calendar);
            }       
        }

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            /*
            Search Filter (Show Request of all RequestStatus)
            */

            if (!string.IsNullOrEmpty(bs.Filter))
            {
                bs.Filter = bs.Filter.Replace($" AND {statusfil}'", "");
                bs.Filter = bs.Filter.Replace($"{statusfil} AND ", "");
                bs.Filter = bs.Filter.Replace($"{statusfil}", "");
            }
        }

        private void calendar_filter(string calendar)
        {
            /*
            Search Filter (Date (range) on Calendar)
            */

            if (String.IsNullOrEmpty(last_calendar))
            {
                if (string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter += calendar;
                }
                else
                {
                    string fil = " AND " + calendar;
                    bs.Filter += fil;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(bs.Filter))
                {
                    bs.Filter = bs.Filter.Replace($"{last_calendar}", $"{calendar}");
                }

            }

            last_calendar = calendar;
        }

        private void combo_calendar_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Search Filter (What date type is filtered using Calendar)
            */

            string filter_criteria = "";

            switch (combo_calendar.SelectedItem.ToString())
            {
                case "Deadline":
                    filter_criteria = "Deadline";
                    break;

                case "Date of Creation":
                    filter_criteria = "DateOfCreation";
                    break;

                case "Date of Assignment":
                    filter_criteria = "DateOfAssignment";
                    break;

                case "None":
                    filter_criteria = "None";
                    if (!string.IsNullOrEmpty(bs.Filter) && !string.IsNullOrEmpty(filter_criteria))
                    {
                        bs.Filter = bs.Filter.Replace($"AND {last_calendar}", "");
                        bs.Filter = bs.Filter.Replace($"{last_calendar} AND ", "");
                        bs.Filter = bs.Filter.Replace($"{last_calendar}", "");
                    }
                    last_calendar = "";
                    break;

                default:
                    break;

            }

            if (filter_criteria != "None")
            {
                string calendar = $"('{monthCalendar1.SelectionStart}' <= {filter_criteria} AND " +
                    $"{filter_criteria} <= '{monthCalendar1.SelectionEnd}')";
                calendar_filter(calendar);

            }   
        }

        private void btn_clearPanel_Click_1(object sender, EventArgs e)
        {
            /*
            Clear the request selection
            */

            dgv_all.ClearSelection();
            dgv_selected.DataSource = null;
            selected_req = null;
            btn_assigned.Enabled = true;
            btn_inProgress.Enabled = true;
            btn_completed.Enabled = true;
            txt_requestID.Text = "";
            txt_cusID.Text = "";
            txt_deadline.Text = "";
            txt_price.Text = "";
            txt_status.Text = "";
        }

    }
}
