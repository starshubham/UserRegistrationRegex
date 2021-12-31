using System;
using System.Text.RegularExpressions;

/*
Should clear all email samples provided separately
• A. Valid Emails
• 1. abc@yahoo.com,
• 2. abc-100@yahoo.com,
• 3. abc.100@yahoo.com
• 2. abc111@abc.com,
• 4. abc-100@abc.net,
• 5. abc.100@abc.com.au
• 6. abc@1.com,
• 7. abc@gmail.com.com
• 8. abc+100@gmail.com

B. Invalid Emails (TLD - Top Level Domains)
1. abc – must contains “@” symbol
2. abc@.com.my – tld can not start with dot “.”
3. abc123@gmail.a – “.a” is not a valid tld, last tld must contains at least two
characters
4. abc123@.com – tld can not start with dot “.”
5. abc123@.com.com – tld can not start with dot “.”
6. .abc@abc.com – email’s 1st character can not start with “.”
7. abc()*@gmail.com – email’s is only allow character, digit, underscore and dash
8. abc@%*.com – email’s tld is only allow character and digit
9. abc..2002@gmail.com – double dots “.” are not allow
10. abc.@gmail.com – email’s last character can not end with dot “.”
11. abc@abc@gmail.com – double “@” is not allow
12. abc@gmail.com.1a -email’s tld which has two characters can not contains digit
13. abc@gmail.com.aa.au - cannont have multiple email’s tld
*/

namespace UserRegistrationRegex
{
    public class UC9SampleEmails
    {
        public static string REGEX_SampleEmails = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_SampleEmails);
        }
    }
}
