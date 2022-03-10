using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class PhoneNumber
    {
        public static string Regex_Pattern = "^[+91]{3}[' ']*[7-9]{1}[0-9]{9}$";
        public bool validatePhoneNumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, Regex_Pattern);
        }
    }
}