using System;
using System.Text.RegularExpressions;

/*
As a User need toenter a valid email
- E.g. abc.xyz@bl.co.in
- Email has 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions
*/

namespace UserRegistrationRegex
{
    public class UC3CheckEmail
    {
        public static string REGEX_EMail = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$"; //abc.xyz@bl.co.in

        public bool ValidateEMail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMail);
        }
    }
}
