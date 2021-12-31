using System;
using System.Text.RegularExpressions;

/*
As a User need to follow pre-defined Mobile Format
- E.g. 91 9919819801
- Country code follow by space and 10 digit number
*/

namespace UserRegistrationRegex
{
    public class UC4MobileFormate
    {
        public static string REGEX_MobileNo = "^[0-9]{1,3}[ ][6789][0-9]{9}$"; // 91 9919819801

        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, REGEX_MobileNo);
        }
    }
}
