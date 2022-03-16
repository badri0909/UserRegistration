using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegxDemo
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        private readonly ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}