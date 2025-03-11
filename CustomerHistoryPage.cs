using APU_Printing_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APU_Printing_Management_System
{
    public partial class CustomerHistoryPage : Form
    {
        public User customer_u;

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
        public CustomerHistoryPage(User user)
        {
            InitializeComponent();
            customer_u = user;
            lbl_customerName.Text = customer_u._FullName;
            Keywords_lbl.Text = "Keyword: ";
            TotalSpend_lbl.Text = "";
            TotalRequest_lbl.Text = "";
            TotalSpend();
            TotalRequest();
            AllRecord();
        }

        // Show all the available request with its jobs
        public void AllRecord()
        {
            SqlCommand cmd = new SqlCommand("SELECT R.RequestID, S.ServiceType AS ServiceName, R.Deadline, J.NetPrice AS Total, R.RequestStatus " +
                                            "\n\rFROM Request R " +
                                            "\n\rLEFT JOIN Job J ON R.RequestID = J.RequestID " +
                                            "\n\rLEFT JOIN Service S ON J.ServiceID = S.ServiceID " +
                                            "\n\rWHERE R.CustomerID = @CustomerID " +
                                            "\n\rORDER BY R.RequestID ", con);

            cmd.Parameters.Add(new SqlParameter("@CustomerID", customer_u._UserID));
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(dataAdapter);
            con.Close();

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            History_Table.DataSource = table;
        }
        

        // Present total spend that has made by the customer
        public void TotalSpend()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT SUM(TotalCost) AS TotalSpend FROM Request " +
                "WHERE CustomerID = @CustomerID AND PaymentStatus = 'Paid';", con))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customer_u._UserID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TotalSpend_lbl.Text = $"RM {reader["TotalSpend"].ToString()}";
                    con.Close();

                }
            }
        }

        // Present total request that has made by the customer
        public void TotalRequest()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(RequestID) AS TotalRequest FROM Request " +
                "WHERE CustomerID = @CustomerID AND PaymentStatus = 'Paid';", con))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customer_u._UserID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TotalRequest_lbl.Text = $"{reader["TotalRequest"].ToString()} records";
                    con.Close();

                }
            }
        }

        private void CustomerProfile_btn_Click(object sender, EventArgs e)
        {
            Profile profile_form = new Profile(customer_u);
            profile_form.Location = new Point(this.Left + 300, this.Top + 50);
            profile_form.ShowDialog();
            lbl_customerName.Text = customer_u._FullName;
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            CustomerOrderPage order_nextform = new CustomerOrderPage(customer_u);
            order_nextform.Closed += (s, args) => this.Close();
            this.Hide();
            order_nextform.ShowDialog();
        }

        private void PrintingService_btn_Click(object sender, EventArgs e)
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


        private void SearchArea_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            List<string> requestIDs = new List<string>();
            List<string> serviceType = new List<string>();
            switch (SearchArea_cb.SelectedItem.ToString())
            {
                case "All":
                    Keywords_lbl.Text = "Keyword: ";
                    Keywords_cb.DataSource = Enumerable.Empty<string>();
                    Keywords_cb.Text = "";
                    AllRecord();
                    break;


                case "RequestID":
                    Keywords_lbl.Text = "ID: ";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT RequestID FROM Request WHERE CustomerID = @CustomerID", con)){
         
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);

                        cmd.Parameters.AddWithValue("@CustomerID", customer_u._UserID);
                        
                        SqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            requestIDs.Add((string)reader["RequestID"]);
                            
                        }
                    }
                    con.Close();
                    Keywords_cb.DataSource = requestIDs;
                    break;

                case "RequestStatus":
                    Keywords_lbl.Text = "Status: ";
                    List<string> status = new List<string>();
                    status.AddRange(new[] { "New", "Assigned", "Work In Progress", "Completed" });

                    Keywords_cb.DataSource = status;
                    break;


                case "ServiceName":
                    Keywords_lbl.Text = "Name: ";
                    serviceType.Clear();
                    serviceType.AddRange(new[] {
                    "Printing– Black and White A4", "Printing – Color A4", "Binding – Comb Binding", "Binding – Thick Cover",
                    "Printing – Poster A0", "Printing – Poster A1", "Printing – Poster A2", "Printing – Poster A3"});

                    Keywords_cb.DataSource = serviceType;
                    break;

            }
        }


        // Change the table view when the keyword in the combo box is change
        private void Keywords_cb_SelectedValueChanged(object sender, EventArgs e)
        {

            string selectedArea = SearchArea_cb.SelectedItem.ToString();
            string cmd = "";

            switch (selectedArea)
            {
            

                case "RequestID":
                    cmd = "SELECT R.RequestID, S.ServiceType AS ServiceName, R.Deadline, J.NetPrice AS Total, R.RequestStatus " +
                         "\n\rFROM Request R " +
                         "\n\rINNER JOIN Job J ON R.RequestID = J.RequestID " +
                         "\n\rINNER JOIN Service S ON J.ServiceID = S.ServiceID " +
                         "\n\rWHERE R.CustomerID = @CustomerID AND R.RequestID = @Keyword " +
                         "\n\rORDER BY R.RequestID ";
                    break;

                case "RequestStatus":
                    cmd = "SELECT R.RequestID, S.ServiceType AS ServiceName, R.Deadline, J.NetPrice AS Total, R.RequestStatus " +
                         "\n\rFROM Request R " +
                         "\n\rINNER JOIN Job J ON R.RequestID = J.RequestID " +
                         "\n\rINNER JOIN Service S ON J.ServiceID = S.ServiceID " +
                         "\n\rWHERE R.CustomerID = @CustomerID AND R.RequestStatus = @Keyword " +
                         "\n\rORDER BY R.RequestID ";
                    break;

                case "ServiceName":
                    cmd = "SELECT R.RequestID, S.ServiceType AS ServiceName, R.Deadline, J.NetPrice AS Total, R.RequestStatus " +
                         "\n\rFROM Request R " +
                         "\n\rINNER JOIN Job J ON R.RequestID = J.RequestID " +
                         "\n\rINNER JOIN Service S ON J.ServiceID = S.ServiceID " +
                         "\n\rWHERE R.CustomerID = @CustomerID AND S.ServiceType = @Keyword " +
                         "\n\rORDER BY R.RequestID ";
                    break;
            }

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True"))
            {
                con.Open();
                SqlCommand selectCommand = new SqlCommand(cmd, con);
                selectCommand.Parameters.AddWithValue("@CustomerID", customer_u._UserID);
                selectCommand.Parameters.AddWithValue("@Keyword", Keywords_cb.SelectedItem.ToString());

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                con.Close();
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                History_Table.DataSource = table;

                if (table.Rows.Count == 0 && Keywords_cb.Text != "")
                {
                    MessageBox.Show("No Request Found");
                }
            }
        }

    }
}
