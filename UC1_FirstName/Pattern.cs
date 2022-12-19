using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC1_FirstName
{
    public class Pattern
    {
        public static string FName = "^([A-Z]+?)([a-zA-Z]+)*?$";
        public bool validate_fname(string fname)
        {
            return Regex.IsMatch(fname, FName);
        }
    }
}
