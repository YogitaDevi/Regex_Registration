using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UC1_FName
{
    internal class Pattern
    {
        public static string FName = "^([A-Z]+?)([a-zA-Z]+)*?$";
        public bool validate_fname(string fname)
        {
            return Regex.IsMatch(fname, FName);
        }
    }
}
