using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Validation
{
    class Email_Validation3
    {
        //pattern check
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+([.+-_#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}$";
        public bool validateEmail3(string email3)
        {
            return Regex.IsMatch(email3, REGEX_EMAIL);
        }
    }
}
