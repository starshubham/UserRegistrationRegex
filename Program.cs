﻿using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            UC1FirstName firstName = new UC1FirstName(); ;
            Console.WriteLine("Please Enter your first name");
            var check = firstName.ValidateFirstName(Console.ReadLine());
            Console.WriteLine(check);

            //UC2
            UC2LastName lastName = new UC2LastName();
            Console.WriteLine("Please Enter your last name");
            var check2 = lastName.ValidateFirstName(Console.ReadLine());
            Console.WriteLine(check2);
        }
    }
}
