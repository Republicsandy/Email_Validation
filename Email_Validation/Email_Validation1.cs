using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Validation
{
    class Email_Validation1
    {
        //pattern for email check
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+[@][a-zA-Z0-9]+";
        public bool validateEmail1(string email1)
        {
            return Regex.IsMatch(email1, REGEX_EMAIL);
        }
    }
}
