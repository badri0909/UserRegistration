using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class FirstName
    {
        public static string Regex_Pattern = "^[A-Z]{1}[a-z]{3,}$";
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, Regex_Pattern);
        }
    }
}