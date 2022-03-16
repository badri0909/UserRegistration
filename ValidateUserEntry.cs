using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegxDemo
{
    class ValidateUserEntry
    {
        private string message;
        UserRegistration userRegistration = new UserRegistration();
        public ValidateUserEntry()
        {
        }
        public ValidateUserEntry(string message)
        {
            this.message = message;
        }
        public string checkForFirstName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Fails the Entry";
        }
        public string checkForLastName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Fails the Entry";
        }
        public string checkForEmail()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Fails the Entry";
        }
        public string checkForMobile()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Fails the Entry";
        }
        public string checkForPassword()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Fails the Entry";
        }
    }
}