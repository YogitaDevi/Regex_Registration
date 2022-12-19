using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC2_LName
{
    public class Pattern
    {
        public static string LName = "^([A-Z]+?)([a-zA-Z]+)*?$";
        public bool validate_lname(string lname)
        {
            return Regex.IsMatch(lname, LName);
        }
    }
}
