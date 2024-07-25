using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAppDemoOne.Entity.Users
{
    public class ChangePassowords
    {
        public string oldPassword { get; set; }
        public string password { get; set; }
        public string passwordConfirmation { get; set; }
    }
}
