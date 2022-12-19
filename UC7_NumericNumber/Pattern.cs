using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC7_NumericNumber
{
    internal class Pattern
    {
        public static string Password = @"[0-9]+";
        public bool validate_pwd(string password)
        {
            return Regex.IsMatch(password, Password);
        }
    }
}
