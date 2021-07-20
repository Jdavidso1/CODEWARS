using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _7KYU_RegexPinValidate
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
            //If the function is passed a valid PIN string, return true, else return false.
            //Ex: "1234"   -->  true / "12345"-- > false / "a234"-- > false

            Console.WriteLine(validatePIN("1234"));
        }
        public static bool validatePIN(string pin)
        {
            //bool valid = false;

            //if (!myRegex.IsMatch(pin))
            //{
            //    if (pin.Length == 4 || pin.Length == 6)
            //    {
            //        valid = true;
            //    }
            //}

            //return valid;

            var myRegex = new Regex(@"\D");

            return ((!myRegex.IsMatch(pin)) && (pin.Length == 4 || pin.Length == 6)) ? true : false;
        }
    }
}
