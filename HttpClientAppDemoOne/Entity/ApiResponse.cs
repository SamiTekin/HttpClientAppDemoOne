using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAppDemoOne.Entity
{
    public class ApiResponse
    {
        public bool error { get; set; }
        public string message { get; set; }
        public User user { get; set; }
        public string token { get; set; }
        public string tokenType { get; set; }
    }
}
