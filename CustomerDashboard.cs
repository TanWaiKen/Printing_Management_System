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
using System.Xml.Linq;
using APU_Printing_Management_System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static APU_Printing_Management_System.CustomerDashboard;

namespace APU_Printing_Management_System
{

    public partial class CustomerDashboard : Form
    {
        // Passing User Information and make a empty request template
        Request req = new Request();
        public User customer_u;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");

        public CustomerDashboard(User user)
        {
            InitializeComponent();
            this.AutoScroll = false;
            customer_u = user;
            CustomerName_lbl.Text = customer_u._FullName;
            Notification();

        }

        
        // Notify how many items that have been paid in their cart
        public void Notification()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(JobID) AS TotalJob" +
                                                   "\n\rFROM Job" +
                                                   "\n\rWHERE CustomerID = @CustomerID AND RequestID IS NULL", con))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customer_u._UserID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Items_In_Cart.Text = reader["TotalJob"].ToString();
                    con.Close();

                }
                reader.Close();
            }

            // Only notify when items in cart is more than one
            if (Items_In_Cart.Text == "0")
            {
                Items_In_Cart.Visible = false;
            }

            else
            {
                Items_In_Cart.Visible = true;
            }
        }
        
        // Receive serviceID that transsfer from the click envent of each service button
        // Update the information of the clicked service
        private void UpdateServiceInfo(string serviceID)
        {

            req._ServiceID = serviceID;
            using (SqlCommand cmd = new SqlCommand("SELECT ServiceType, FeePerUnit, DiscountRate, MinQuantity FROM Service WHERE ServiceID = @ServiceID", con))
            {
                cmd.Parameters.AddWithValue("@ServiceID", serviceID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    req._ServiceType = reader["ServiceType"].ToString();
                    req._PricePerItem = double.Parse(reader["FeePerUnit"].ToString());

                    double discountRate;
                    double.TryParse(reader["DiscountRate"].ToString(), out discountRate);
                    req._DiscountRate = discountRate;

                    int minQuantity;
                    int.TryParse(reader["MinQuantity"].ToString(), out minQuantity);
                    req._MinQuantity = minQuantity;

                }
                reader.Close();
                con.Close();
            }

            // Output the respective services data from the selected textbox
            ItemName_lbl.Text = req._ServiceType;
            PricePerItem_lbl.Text = "RM" + req._PricePerItem.ToString();
            ShowTotalCost();

        }

        private void customerPage_Load(object sender, EventArgs e)
        {
            
        }

        // Button hower animation at the side panel
        // Simulate opacity change by lightening the color
        private void CustomerProfile_btn_MouseDown(object sender, MouseEventArgs e)
        {
            customerProfile_btn.BackColor = Color.FromArgb(180, customerProfile_btn.BackColor);

        }

        private void Order_btn_MouseDown(object sender, MouseEventArgs e)
        {
            cart_btn.BackColor = Color.FromArgb(180, cart_btn.BackColor);
        }




        private void SetBorderStyle(PictureBox pictureBox, BorderStyle style)
        {
            // Change mouse border style event when click the picturebox
            pictureBox.BorderStyle = style;
        }



        // Passing the serviceID to the UpdateServiceInfo() method
        private void A4BlackWhite_btn_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo("001");
        }

        private void A4Colorful_btn_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo("002");
        }

        private void CombBinding_btn_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo("003");
        }


        private void BindingThick_btn_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo("004");
        }

        private void A0PrintingPoster_btn_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo("005");
        }


        private void A1PrintingPoster_btn_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo("006");
        }

        private void A2PrintingPoster_btn_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo("007");
        }

        private void A3PrintingPoster_btn_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo("008");
        }

        private void A4BlackWhite_btn_MouseLeave(object sender, EventArgs e)
        {
            SetBorderStyle((PictureBox)sender, BorderStyle.None);
        }

        private void A4BlackWhite_btn_MouseDown(object sender, MouseEventArgs e)
        {
            SetBorderStyle((PictureBox)sender, BorderStyle.FixedSingle);
        }


        private void Add_btn_Click(object sender, EventArgs e)
        {
            req._Quantity = int.Parse(Quantity_Num.Text);
            if (req._Quantity == 0)
            {
                MessageBox.Show("Please enter a valid quantity.😡");
                return;
            }

            string message = $"Are you sure you want to add this request?";
            string caption = "Confirm Service";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            //If the no button was pressed ...
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Job" +
                        "([ServiceID], [Quantity], [NetPrice], [CustomerID] ) " +
                        " OUTPUT INSERTED.JobID" +
                        " VALUES (@ServiceID, @Quantity, @TotalCost, @CustomerID)", con))
                {

                    insertCmd.Parameters.AddWithValue("@ServiceID", req._ServiceID);
                    insertCmd.Parameters.AddWithValue("@Quantity", req._Quantity);
                    insertCmd.Parameters.AddWithValue("@TotalCost", req._TotalCost);
                    insertCmd.Parameters.AddWithValue("@CustomerID", customer_u._UserID);
                    con.Open();
                    insertCmd.ExecuteNonQuery();
                    con.Close();
                    Notification();

                }
            }

            catch
            {
                MessageBox.Show("Please Select One Service.");
                con.Close();
            }
            

        }

        // Call the method in clsss to callculate the total price
        private void ShowTotalCost()
        {

            req._Quantity = Int32.Parse(Quantity_Num.Value.ToString()); 
            req._TotalCost = req.Calculate_Price(req._ServiceID, req._PricePerItem, req._Quantity, req._Urgent);
            Total_lbl.Text = "RM" + req._TotalCost.ToString();

        }


        // Upadate total price when quantity is change
        private void Quantity_tbx_ValueChanged(object sender, EventArgs e)
        {
            ShowTotalCost();
        }


        private void logOut_btn_Click(object sender, EventArgs e)
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
            CustomerName_lbl.Text = customer_u._FullName;
        }

        // Change to the order page
        private void Order_btn_Click(object sender, EventArgs e)
        {
            CustomerOrderPage order_nextform = new CustomerOrderPage(customer_u);
            order_nextform.Closed += (s, args) => this.Close();
            this.Hide();
            order_nextform.ShowDialog();

        }


    }
}
