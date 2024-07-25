using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAppDemoOne.Entity
{
    public class UserGet
    {
        public class Root
        {
            public bool error { get; set; }
            public User user { get; set; }
        }

        public class User
        {
            public int id { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public object identity_number { get; set; }
            public object date_of_birth { get; set; }
            public object company { get; set; }
            public object tax_office { get; set; }
            public object tax_number { get; set; }
            public int status_id { get; set; }
        }
    }
}
