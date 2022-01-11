using System;
using System.Text.RegularExpressions;

/*
As a User need to enter a valid First Name
- First name starts with Cap and has minimum 3 characters
*/

namespace UserRegistrationRegex
{
    public class UC1FirstName
    {
        
        public bool ValidateFirstName(string fName)
        {
            string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

            return Regex.IsMatch(fName, FIRST_NAME_REGEX);
        }
    }
}
