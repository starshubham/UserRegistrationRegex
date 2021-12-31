using System;
using System.Text.RegularExpressions;

/*
Rule3 – Should have at least 1 numeric number in the password
- NOTE – All rules must be passed
*/

namespace UserRegistrationRegex
{
    public class UC7Password3
    {
        public static string REGEX_Password3 = "^[A-Z]{1}[A-Z a-z]{7,}[0-9]{1,}$";  //Shubhamsth23

        public bool ValidatePassword3(string password)
        {
            return Regex.IsMatch(password, REGEX_Password3);
        }
    }
}
