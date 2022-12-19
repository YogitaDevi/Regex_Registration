using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC4_MobileNumber
{
    public class Pattern
    {
        public static string MobileNumber = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}";
        public bool validate_Number(string Number)
        {
            return Regex.IsMatch(Number, MobileNumber);
        }
    }
}
