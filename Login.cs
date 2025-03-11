using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Data.Common;
using System.Security.Cryptography;

namespace APU_Printing_Management_System
{
    public partial class Login : Form
    {
        public User this_user;

        public Login(bool log_out)
        {
            InitializeComponent();
            if (log_out)
            {
                lbl_title.Text = "Thank you";
                lbl_prompt.Text = "for using our system. Hope to see you soon!";
            }
            else
            {
                lbl_title.Text = "Hello!";
                lbl_prompt.Text = "Enter the credentials below to log into your account.";
            }
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [UserProfile] Where [UserID] = @UserID and [Password]=@Password", con);
            cmd.Parameters.AddWithValue("@UserID", txt_userID.Text);
            cmd.Parameters.AddWithValue("@Password", txt_password.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                // Call Read before accessing data.
                while (reader.Read())
                {
                    this_user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                }

                // Call Close when done reading.
                reader.Close();
                con.Close();
                lbl_invalid.Text = "Login Successfully.";
                lbl_invalid.ForeColor = Color.Lime;
                lbl_invalid.Visible = true;
                btn_logIn.Font = new Font(btn_logIn.Font, FontStyle.Bold);
                btn_logIn.Text = "•ᴗ•";
                // 😊
                btn_logIn.BackColor = Color.Lime;


                this.Refresh();
                Thread.Sleep(1000);

                this.Hide();

                switch (this_user._Role)
                {
                    case "Admin":
                        //admin form 
                        AdminEditUsersProfile admin_nextform = new AdminEditUsersProfile(this_user);
                        admin_nextform.Closed += (s, args) => this.Close();
                        this.Hide();
                        admin_nextform.ShowDialog();
                        break;

                    case "Customer":
                        //customer form
                        CustomerDashboard customer_nextform = new CustomerDashboard(this_user);
                        customer_nextform.Closed += (s, args) => this.Close();
                        this.Hide();
                        customer_nextform.ShowDialog();
                        break;

                    case "Manager":
                        //manager form
                        ManagerDashboard DashboardPage = new ManagerDashboard(this_user);
                        DashboardPage.Closed += (s, args) => this.Close();
                        this.Hide();
                        DashboardPage.ShowDialog();
                        break;

                    case "Worker":
                        //worker form
                        WorkerDashboard worker_nextform = new WorkerDashboard(this_user);
                        worker_nextform.Closed += (s, args) => this.Close();
                        this.Hide();
                        worker_nextform.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("No role defined for this user. Please try again with another userID and password!");
                        break;
                }

            }
            else
            {
                lbl_invalid.Text = "Invalid UserID or Password.\nPlease try again!";
                lbl_invalid.ForeColor = Color.Red;
                lbl_invalid.Visible = true;

            }
        }
    }
}
