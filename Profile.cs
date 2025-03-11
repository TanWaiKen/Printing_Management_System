using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Printing_Management_System
{
    public partial class Profile : Form
    {
        public User this_user;
        public Profile(User user)
        {
            this_user = user;
            InitializeComponent();

            lbl_save.Visible = false;

            txt_userID.Text = this_user._UserID;
            txt_role.Text = this_user._Role;
            txt_name.Text = this_user._FullName;
            txt_phone.Text = this_user._Phone;
            txt_pass.Text = this_user._Password;
            txt_pass2.Text = txt_pass.Text;

            switch (this_user._Role)
            {
                case "Admin":
                    //admin color
                    panel1.BackColor = Color.Tomato;
                    lbl_save.BackColor = Color.Tomato;
                    break;

                case "Customer":
                    //customer color
                    panel1.BackColor = Color.YellowGreen;
                    lbl_save.BackColor = Color.YellowGreen;
                    break;

                case "Manager":
                    //manager color
                    panel1.BackColor = Color.MediumSlateBlue;
                    lbl_save.BackColor = Color.MediumSlateBlue;
                    break;

                case "Worker":
                    //worker color
                    panel1.BackColor = Color.Gold;
                    lbl_save.BackColor =   Color.Gold;
                    break;

                default:
                    MessageBox.Show("No role defined for this user. Color undefined.");
                    break;

            }

            panel2.BackColor = panel1.BackColor;
            btn_cancelProfile.BackColor = panel1.BackColor;
            btn_saveProfile.BackColor = panel1.BackColor;
        }

        private void btn_cancelProfile_Click(object sender, EventArgs e)
        {
            if (check_change())
            {
                string message = "You have made changes to your profile.\n " +
                    "Click \"OK\" to get back to the main page WITHOUT saving the changes made.\n " +
                    "Click \"Cancel\" to continue edit profile.";

                string caption = "Profile Page Closing";
                DialogResult result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }else
            {
                this.Close();
            }
            
        }

        private bool check_change()
        {
            if ((txt_name.Text != this_user._FullName) ||
                (txt_phone.Text != this_user._Phone) ||
                (txt_pass.Text != this_user._Password) ||
                (txt_pass2.Text != txt_pass.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text.Length < 8)
            {
                lbl_requirement1.ForeColor = Color.Red;
            }
            else
            {
                lbl_requirement1.ForeColor = Color.Black;
            }

            bool condition1 = txt_pass.Text.Any(char.IsUpper);
            bool condition2 = txt_pass.Text.Any(char.IsLower);
            bool condition3 = txt_pass.Text.Any(char.IsLetterOrDigit);
            if (!(condition1 && condition2 && condition3))
            {
                lbl_requirement2.ForeColor = Color.Red;
            }else
            {
                lbl_requirement2.ForeColor = Color.Black;
            }

            if (txt_pass.Text != txt_pass2.Text)
            {
                lbl_requirement3.ForeColor = Color.Red;
            }else
            {
                lbl_requirement3.ForeColor = Color.Black;
            }

        }

        private void txt_pass2_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text != txt_pass2.Text)
            {
                lbl_requirement3.ForeColor = Color.Red;
            }
            else
            {
                lbl_requirement3.ForeColor = Color.Black;
            }
        }

        private void btn_saveProfile_Click(object sender, EventArgs e)
        {
            if (check_change())
            {
                bool valid1 = (lbl_requirement1.ForeColor == Color.Black) && (lbl_requirement2.ForeColor == Color.Black) && (lbl_requirement3.ForeColor == Color.Black);
                bool valid2 = true;

                if (String.IsNullOrEmpty(txt_pass2.Text))
                {
                    txt_pass2.Focus();
                    valid2 = false;
                }

                if (String.IsNullOrEmpty(txt_pass.Text))
                {
                    txt_pass.Focus();
                    valid2 = false;
                }

                if (String.IsNullOrEmpty(txt_phone.Text))
                {
                    txt_phone.Focus();
                    valid2 = false;
                }

                if (String.IsNullOrEmpty(txt_name.Text))
                {
                    txt_name.Focus();
                    valid2 = false;
                }

                if (valid1 && valid2)
                {
                    this_user.Update_user(txt_name.Text, txt_phone.Text, txt_pass.Text);


                    lbl_save.Visible = true;
                    lbl_save.Text = "Changes Saved •ᴗ•";
                    this.Refresh();
                    Thread.Sleep(1000);
                    this.Close();
                }

                if (!(valid1))
                {
                    string message = "Password requirements are not satisfied. Please try again!";
                    string caption = "Invalid Password Change";
                    MessageBox.Show(message, caption);
                }

                if (!(valid2))
                {
                    string message = "All input fields must be filled in. Please try again!";
                    string caption = "Empty Input Field(s)";
                    MessageBox.Show(message, caption);
                }

                lbl_save.Visible = true;
                lbl_save.Text = "Changes Not Accepted •∩•";
            }
            else
            {
                lbl_save.Visible = true;
                lbl_save.Text = "No changes made •_•";
                this.Refresh();
                Thread.Sleep(1000);
                this.Close();
            }
            
        }

    }
}
