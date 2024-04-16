using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{

    internal class ApiCLass
    {
        public string id { get; set; }
        public string total_price { get; set; }
        public string order_created_at { get; set; }
        public string order_start_date { get; set; }
        public string order_length_days { get; set; }
        public string order_end_date { get; set; }
        public string payment_due_date { get; set; }
        public string customer_name { get; set; }
        public string customer_phone_name { get; set; }
        public string customer_email { get; set;}
        public string order_status { get; set; }
        public string payment_resolved { get; set;}
        // public string contents { get; set;}
    }
}
