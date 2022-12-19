using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC3_Email
{
    public class Pattern
    {
        public static string Email = @"^[a-zA-Z0-9\._-|+]{3,25}.@.[a-z]{0,12}.(com|org|co\.in|net)";
        public bool validate_email(string email)
        {
            return Regex.IsMatch(email, Email);
        }
    }
}
