using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_form_on_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Login Form!");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            // Check if the username and password are correct
            if (username == "admin" && password == "admin")
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }
            Console.ReadLine();


        }
    }
}
