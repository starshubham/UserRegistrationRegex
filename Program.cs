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

            //UC5
            UC5Password1 password1 = new UC5Password1();
            Console.WriteLine("Please Enter your password to check");
            var check5 = password1.ValidatePassword1(Console.ReadLine());
            Console.WriteLine(check5);

            //UC6
            UC6Password2 password2 = new UC6Password2();
            Console.WriteLine("Please Enter your password to check");
            var check6 = password2.ValidatePassword2(Console.ReadLine());
            Console.WriteLine(check6);

            //UC7
            UC7Password3 password3 = new UC7Password3();
            Console.WriteLine("Please Enter your password to check");
            var check7 = password3.ValidatePassword3(Console.ReadLine());
            Console.WriteLine(check7);
        }
    }
}
