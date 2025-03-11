using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace APU_Printing_Management_System
{
    public class User
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
        public string _Phone
        { get; set; }

        public string _UserID
        { get; set; }

        public string _Password
        { get; set; }

        public string _FullName
        { get; set; }

        public string _Role
        { get; set; }

        public User(string UserID, string Password, string Role, string FullName, string Phone)
        {
            _UserID = UserID;
            _Password = Password;
            _Role = Role;
            _FullName = FullName;
            _Phone = Phone;
        }


        public void New_user() 
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO UserProfile ([UserID], [Password], [FullName], [PhoneNumber], [UserRole]) " + " VALUES (@UserID, @Password, @FullName, @PhoneNumber, @UserRole)", conn);

                cmd.Parameters.AddWithValue("@UserID", _UserID);
                cmd.Parameters.AddWithValue("@Password", _Password);
                cmd.Parameters.AddWithValue("@FullName", _FullName);
                cmd.Parameters.AddWithValue("@PhoneNumber", _Phone);
                cmd.Parameters.AddWithValue("@UserRole", _Role);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");

                conn.Close();
            }

            catch
            {
                conn.Close();
                MessageBox.Show("This UserID is already existed.");

            }
            
        }

        public void Update_user(string name, string phone, string pass) 
        {
            _FullName = name;
            _Phone = phone;
            _Password = pass;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[UserProfile] SET [Password] = @pass, [FullName] = @name, [PhoneNumber] = @phone WHERE [UserID] = @UserID", con);

            cmd.Parameters.AddWithValue("@pass", _Password);
            cmd.Parameters.AddWithValue("@name", _FullName);
            cmd.Parameters.AddWithValue("@phone", _Phone);
            cmd.Parameters.AddWithValue("@UserID", _UserID);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show($"Update {_FullName}'s profile.",
                $"User {_UserID}");
        }

    }
}
