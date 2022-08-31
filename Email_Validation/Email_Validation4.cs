using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Validation
{
    class Email_Validation4
    {
        //pattern for email check
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+([.+-_#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public bool validateEmail4(string email4)
        {
            return Regex.IsMatch(email4, REGEX_EMAIL);
        }
    }
}
