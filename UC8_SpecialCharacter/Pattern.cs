using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC8_SpecialCharacter
{
    public class Pattern
    {
        public static string Password = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]";
        public bool validate_pwd(string password)
        {
            return Regex.IsMatch(password, Password);
        }
    }
}
