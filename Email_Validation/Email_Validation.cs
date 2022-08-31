using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_Validation
{
    class Email_Validation
    {
        //pattern for email
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
