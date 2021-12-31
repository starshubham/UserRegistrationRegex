using System;

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

            //UC3
            UC3CheckEmail email = new UC3CheckEmail();
            Console.WriteLine("Please Enter your email to check");
            var check3 = email.ValidateEMail(Console.ReadLine());
            Console.WriteLine(check3);

            //UC4
            UC4MobileFormate mobile = new UC4MobileFormate();
            Console.WriteLine("Please Enter your mobile no with country code");
            var check4 = mobile.ValidateMobileNo(Console.ReadLine());
            Console.WriteLine(check4);
        }
    }
}
