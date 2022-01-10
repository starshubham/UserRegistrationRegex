using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");

            Patterns p = new Patterns("msg");

            Console.WriteLine("Write your first name using 1st character should be Capital ");
            Console.Write("\n Enter First Name : ");
            string name1 = Console.ReadLine();
            p.FirstName(name1);

            Console.WriteLine("\n Write your last name using 1st character should be Capital ");
            Console.Write("\n Enter Last Name : ");
            string name2 = Console.ReadLine();
            p.LastName(name2);

            Console.WriteLine("\n Write your Email ex : example123@gmail.com your can write yahoo and any other mail ID.");
            Console.Write("\n Enter Email : ");
            string name3 = Console.ReadLine();
            p.Email(name3);

            Console.WriteLine("\n Write your Mobile Number ex : +91 7891235452 .");
            Console.Write("\n Enter Mobile Number : ");
            string name4 = Console.ReadLine();
            p.MobileNumber(name4);

            Console.WriteLine("\n Write your Password ex : Aa9@ length atleast 8 .");
            Console.Write("\n Enter Password : ");
            string name5 = Console.ReadLine();
            p.Password(name5);
        }
    }
}
