using System;
using System.Text.RegularExpressions;

/*
Rule2 – Should have at least 1 Upper Case
*/

namespace UserRegistrationRegex
{
    public class UC6Password2
    {
        public static string REGEX_Password2 = "^[A-Z]{1}[A-Z a-z]{7,}$"; //Shubhamsth

        public bool ValidatePassword2(string password)
        {
            return Regex.IsMatch(password, REGEX_Password2);
        }
    }
}
