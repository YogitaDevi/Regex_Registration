using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC6_UpperCase
{
    internal class Pattern
    {
        public static string Password = @"[A-Z]+";
        public bool validate_pwd(string password)
        {
            return Regex.IsMatch(password, Password);
        }
    }
}
