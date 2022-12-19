using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC5_MinimumCharacter
{
    public class Pattern
    {
        public static string Password = @".{8,15}";
        public bool validate_pwd(string password)
        {
            return Regex.IsMatch(password, Password);
        }
    }
}
