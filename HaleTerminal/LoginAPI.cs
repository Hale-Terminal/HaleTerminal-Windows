using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows;

namespace HaleTerminal
{
    public class LoginToken
    {
        public string token { get; set; }
    }

    public class UserLogin
    {
        public string username { get; set; }
        public string password { get; set; }
    }

  
}
