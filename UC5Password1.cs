using System;
using System.Text.RegularExpressions;

/*
As a User need to follow pre-defined Password rules.
Rule1 – minimum 8Characters
- NOTE – All rules must be passed
*/

namespace UserRegistrationRegex
{
    public class UC5Password1
    {
        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$"; //shubhamsth, ShubhamSth

        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, REGEX_Password1);
        }
    }
}
