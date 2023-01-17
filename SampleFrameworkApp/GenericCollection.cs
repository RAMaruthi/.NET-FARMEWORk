using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    class GenericCollection
    {
        static void Main(string[] args)
        {
            dictionaryExample();

        }
        static Dictionary<string, string> users = new Dictionary<string, string>();
        private static void signUp()
        {
        RETRY:
            var uname = Utilities.Prompt("Enter the Username");
            var pwd = Utilities.Prompt("Enter the Password");
            if (users.ContainsKey(uname))
            {
                Console.WriteLine("User already Registered");
                goto RETRY;
            }
            users.Add(uname, pwd);
        }

        private static void signIn()
        {
        RETRY:
            var uname = Utilities.Prompt("Enter the Username");
            var pwd = Utilities.Prompt("Enter the Password");
            if (users.ContainsKey(uname))
            {
                if (users[uname] == pwd)
                {
                    Console.WriteLine("Welcome User!!!");
                }
                else
                {
                    Console.WriteLine("Password is invalid");
                    goto RETRY;
                }
            }
            else
            {
                Console.WriteLine("User does not exist");
                goto RETRY;
            }
        }

        private static void dictionaryExample()
        {
            do
            {
                var choice = Utilities.Prompt("Press 1 to Sign In(Login) and 2 to Sign Up(Register)");
                if (choice == "1")
                {
                    signIn();
                }
                else if (choice == "2")
                {
                    signUp();
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (true);
        }

    }
}
