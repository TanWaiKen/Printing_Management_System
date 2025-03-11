using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace APU_Printing_Management_System
{
    
    public class Request
    {

        public string _ServiceID
        { get; set; }

        public double _PricePerItem
        { get; set; }

        public string _ServiceType
        { get; set; }

        public double _DiscountRate
        { get; set; }

        public int _MinQuantity
        { get; set; }

        public string _RequestID
        { get; set; }

        public string _CustomerID
        { get; set; }

        public DateTime _DateOfCreation
        { get; set; }

        public DateTime _Deadline
        { get; set; }

        public bool _Urgent
        { get; set; }

        public double _TotalCost
        { get; set; }

        public int _Quantity
        { get; set; }

        public string _PaymentStatus
        { get; set; }

        public bool _Priority
        { get; set; }


        public string _RequestStatus
        { get; set; }

        public string _WorkerID
        { get; set; }

        public string _ManagerID
        { get; set; }

        public DateTime _DateOfAssignment
        { get; set; }

        public Request()
        {
            // Create a new request record
            _ServiceType = string.Empty;
            _Quantity = 0;
            _DiscountRate = 0.1;
            _MinQuantity = 100;
            _Deadline = DateTime.Now;
            _Urgent = false;
            _TotalCost = 0;
            _PaymentStatus = "Not Paid";

        }

        public Request(string RequestID, string CustomerID, DateTime DateOfCreation, DateTime Deadline, bool Priority, double TotalCost, string RequestStatus, string PaymentStatus, string WorkerID, string ManagerID, DateTime DateOfAssignment)
        {
            _RequestID = RequestID;
            _CustomerID = CustomerID;
            _DateOfCreation = DateOfCreation;
            _Deadline = Deadline;
            _Priority = Priority;
            _TotalCost = TotalCost;
            _RequestStatus = RequestStatus;
            _PaymentStatus = PaymentStatus;
            _WorkerID = WorkerID;
            _ManagerID = ManagerID;
            _DateOfAssignment = DateOfAssignment;
        }

        public void IDgenerator()
        {
            //string role;
        }

        public void Update_Request_Status(string status)
        {
            _RequestStatus = status;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=PrintingService;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Request] SET [RequestStatus] = @ReqSta WHERE [RequestID] = @ReqID", con);

            //cmd.Parameters.AddWithValue("@CusID", _CustomerID);
            //cmd.Parameters.AddWithValue("@Creation", _DateOfCreation);
            //cmd.Parameters.AddWithValue("@Deadline", _Deadline);
            //cmd.Parameters.AddWithValue("@Priority", _Priority);
            //cmd.Parameters.AddWithValue("@Cost", _TotalCost);
            cmd.Parameters.AddWithValue("@ReqSta", _RequestStatus);
            //cmd.Parameters.AddWithValue("@PaySta", _PaymentStatus);
            //cmd.Parameters.AddWithValue("@WorkerID", _WorkerID);
            //cmd.Parameters.AddWithValue("@ManagerID", _ManagerID);
            //cmd.Parameters.AddWithValue("@AssignDate", _DateOfAssignment);
            cmd.Parameters.AddWithValue("@ReqID", _RequestID);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show($"Update status to \"{status}\".",
                $"Request {_RequestID}");
        }


        public double Calculate_Price(string ServiceID, double Price_Per_Unit, int Quantity, bool Urgent)
        {

            double Total = Price_Per_Unit * Quantity;

            if (ServiceID != "003" && ServiceID != "004")
            {
                if (Quantity >= _MinQuantity)
                {
                    Total *= (1 - _DiscountRate);
                }
            }

            return Total;

        }
    }




}
