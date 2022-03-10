using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class LastName
    {
        public static string Regex_Pattern = "^[A-Z]{1}[a-z]{3,}$";
        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, Regex_Pattern);
        }
    }
}