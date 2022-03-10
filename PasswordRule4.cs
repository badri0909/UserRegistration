using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class PasswordRule4
    {
        public static string Regex_Pattern = "(^[a-z A-Z 0-9])([^.,:;'!@#$%^&*_+=]).{8,}$";
        public bool validatePasswordRule4(string passwordrule4)
        {
            return Regex.IsMatch(passwordrule4, Regex_Pattern);
        }
    }
}