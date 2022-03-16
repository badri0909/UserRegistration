﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class UserRegistration
    {
        public static string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAIL_PATTERN = "^[a-z]{3,}[1-9]{1,4}[@][a-z]{4,}[.][a-z]{3,}$";
        public static string MOBILENOFORMAT_PATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORD_PATTERN = "^[A-Z]{1}[a-z]{3,}[@][0-9]{1,}";

        public bool ValidateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, NAME_PATTERN);
        }

        public bool ValidateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, NAME_PATTERN);
        }

        public bool ValidateEmail(String email)
        {
            return Regex.IsMatch(email, EMAIL_PATTERN);
        }

        public bool ValidateMobileNoFormat(String phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, MOBILENOFORMAT_PATTERN);
        }

        public bool ValidatePassword(String password)
        {
            return Regex.IsMatch(password, PASSWORD_PATTERN);
        }

        // This is by using lambda expression for validating user entry.
        public Func<string, bool> IsValidFirstName = firstName => Regex.IsMatch(firstName, NAME_PATTERN);
        public Func<string, bool> IsValidLastName = lastName => Regex.IsMatch(lastName, NAME_PATTERN);
        public Func<string, bool> IsValidEmail = email => Regex.IsMatch(email, EMAIL_PATTERN);
        public Func<string, bool> IsValidMobileNumber = phoneNumber => Regex.IsMatch(phoneNumber, MOBILENOFORMAT_PATTERN);
        public Func<string, bool> IsValidPassword = Password => Regex.IsMatch(Password, PASSWORD_PATTERN);
    }
}