using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace APU_Printing_Management_System
{
    class Job
    {
        public string _JobID
        { get; set; }

        public string _ServiceID
        { get; set; }

        public string _RequestID
        { get; set; }

        public int _Quantity
        { get; set; }

        public double _NetPrice
        { get; set; }


        public Job(string JobID, string ServiceID, string RequestID, int Quantity, double price)
        {
            _JobID = JobID;
            _RequestID = RequestID;
            _ServiceID = ServiceID;
            _Quantity = Quantity;
            _NetPrice = price;
        }
    }
}
