using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAppDemoOne.Entity.Users
{
    public class UserAdd
    {
        public long identity_number { get; set; }
        public int tax_number { get; set; }
        public string tax_office { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int status_id { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string district { get; set; }
        public string street { get; set; }
        public string neighborhood { get; set; }
        public string postal_code { get; set; }
        public string note { get; set; }
    }
}
