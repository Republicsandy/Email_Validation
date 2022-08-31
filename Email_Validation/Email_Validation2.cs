using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Validation
{
    class Email_Validation2
    {
        //pattern for email check
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}$";
        public bool validateEmail2(string email2)
        {
            return Regex.IsMatch(email2, REGEX_EMAIL);
        }
    }
}
