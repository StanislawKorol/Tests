using OpenQA.Selenium.DevTools.V117.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_specflow
{
    internal class UserLogin
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public UserLogin() { Name = ""; Password = ""; }
        public UserLogin(string name, string password) { Name = name; Password = password; }
    }
}
