﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Patterns
    {
        private string msg;

        public Patterns(string msg)
        {
            this.msg = msg;
        }

        public string FirstName(string name1)
        {
            string FirstName = "^[A-Za-z]\\w{1,10}$$";
            Regex regex = new Regex(FirstName);
            if (regex.IsMatch(name1))
            {
                Console.WriteLine(name1 + " is a valid first name");
                return "Valid";
            }
            else
            {
                Console.WriteLine(name1 + " is invalid. Please Enter First name start with capital letter and maximum 10 charactors");
                return "Invalid";
            }
        }

        public string LastName(string name2)
        {
            string LastName = "^[A-Za-z]\\w{1,10}$$";
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(name2))
            {
                Console.WriteLine(name2 + " is a valid last name");
                return "Valid";
            }
            else
            {
                Console.WriteLine(name2 + " is invalid. Please Enter Last name start with capital letter and maximum 10 charactors");
                return "Invalid";
            }
        }

        public string Email(string name3)
        {
            string Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(Email);
            if (regex.IsMatch(name3))
            {
                Console.WriteLine(name3 + " is a valid email");
                return "Valid";
            }
            else
            {
                Console.WriteLine(name3 + " is invalid.");
                return "Invalid";
            }
        }

        public string MobileNumber(string name4)
        {
            string MobileNumber = "(0|91)?[ ][6-9][0-9]{9}";
            Regex regex = new Regex(MobileNumber);
            if (regex.IsMatch(name4))
            {
                Console.WriteLine(name4 + " is a valid mobile number");
                return "Valid";
            }
            else
            {
                Console.WriteLine(name4 + " is invalid.");
                return "Invalid";
            }
        }

        public string Password(string name5)
        {
            string Password = "^.*(?=.{8,})(?=.*)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            Regex regex = new Regex(Password);
            if (regex.IsMatch(name5))
            {
                Console.WriteLine(name5 + " is a valid password.");
                return "Valid";
            }
            else
            {
                Console.WriteLine(name5 + " is invalid.");
                return "Invalid";
            }
        }
    }
}