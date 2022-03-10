using System;

namespace RegxDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //FOR FIRST NAME
            FirstName firstName = new FirstName();
            Console.WriteLine("Enter First Name");
            string value = Console.ReadLine();
            bool match = firstName.validateFirstName(value);
            if (match)
                Console.WriteLine("First Name Matched");
            else
                Console.WriteLine("First Name Not Matched");

            ///FOR LAST NAME
            //LastName lastName = new LastName();
            //Console.WriteLine("Enter Last Name");
            //string value = Console.ReadLine();
            //bool match = lastName.validateLastName(value);
            //if (match)
            //    Console.WriteLine("Last Name Matched");
            //else
            //    Console.WriteLine("Last Name Not Matched");

            ////FOR Email Id
            //EmailId emailId = new EmailId();
            //Console.WriteLine("Enter EmailId");
            //string value = Console.ReadLine();
            //bool match = emailId.validateEmailId(value);
            //if (match)
            //    Console.WriteLine("Email ID Matched");
            //else
            //    Console.WriteLine("Email ID Not Matched");

            ////FOR PHONE NUMBER
            //PhoneNumber phoneNumber = new PhoneNumber();
            //Console.WriteLine("Enter Phone Number");
            //string value=Console.ReadLine();
            //bool match = phoneNumber.validatePhoneNumber(value);
            //if (match)
            //    Console.WriteLine("Phone Number Matched");
            //else
            //    Console.WriteLine("Phone Number Not Matched");

            ////FOR PASSWORD RULE 1
            //PasswordRule1 passwordRule1 = new PasswordRule1();
            //Console.WriteLine("Enter Password");
            //string value = Console.ReadLine();
            //bool match = passwordRule1.validatePasswordRule1(value);
            //if (match)
            //    Console.WriteLine("Password Matched");
            //else
            //    Console.WriteLine("Password Not Matched");

            ////FOR PASSWORD RULE 2
            //PasswordRule2 passwordRule2 = new PasswordRule2();
            //Console.WriteLine("Enter Password");
            //string value = Console.ReadLine();
            //bool match = passwordRule2.validatePasswordRule2(value);
            //if (match)
            //    Console.WriteLine("Password Matched");
            //else
            //    Console.WriteLine("Password Not Matched");

            ////FOR PASSWORD RULE 3
            //PasswordRule3 passwordRule3 = new PasswordRule3();
            //Console.WriteLine("Enter Password");
            //string value = Console.ReadLine();
            //bool match = passwordRule3.validatePasswordRule3(value);
            //if (match)
            //    Console.WriteLine("Password Matched");
            //else
            //    Console.WriteLine("Password Not Matched");

            ////FOR PASSWORD RULE 4
            //PasswordRule4 passwordRule4 = new PasswordRule4();
            //Console.WriteLine("Enter Password");
            //string value = Console.ReadLine();
            //bool match = passwordRule4.validatePasswordRule4(value);
            //if (match)
            //    Console.WriteLine("Password Matched");
            //else
            //    Console.WriteLine("Password Not Matched");

            ////For PINCODE
            //Patterns patterns = new Patterns();
            //Console.WriteLine("Enter Pincode");
            //string value = Console.ReadLine();
            //bool match = patterns.validatePinCode(value);
            //if (match)
            //    Console.WriteLine("Pattern Matched");
            //else
            //    Console.WriteLine("Pattern Not Matched");


        }
    }
}