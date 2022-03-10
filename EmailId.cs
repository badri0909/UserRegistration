using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class EmailId
    {
        public static string Regex_Pattern = "^[a-z]{3,}[.]*[a-z]{0,}[@][a-z 1-9]{1,}[.][a-z]{2,}[.]*[a-z]{0,}";
        public bool validateEmailId(string emailid)
        {
            return Regex.IsMatch(emailid, Regex_Pattern);
        }
    }
}