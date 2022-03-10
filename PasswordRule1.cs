using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class PasswordRule1
    {
        public static string Regex_Pattern = "^[a-z]{8,}$";
        public bool validatePasswordRule1(string passwordrule1)
        {
            return Regex.IsMatch(passwordrule1, Regex_Pattern);
        }
    }
}