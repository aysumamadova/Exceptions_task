using System;
using System.Text.RegularExpressions;
using IAccount_task.Models;
using IAccount_task.Exceptions;

namespace IAccount_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "";
            string password = "";
            string email = "";
            int key;
            do
            {
                Start:
                try
                {
                    Console.WriteLine($"Reqem daxil edin\n1.IAccount yaradin\n2.Sonlandirin");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalniz reqem daxil edilmelidir");
                    goto Start;
                }

                switch (key)
                {
                    case 1:
                        
                        ChangeFullname(ref fullname);
                        ChangeEmail(ref email);
                        Console.WriteLine(User.EmailChecker(email));
                        ChangePassword(ref password);
                        Console.WriteLine(User.PasswordChecker(password));
                        User u = new User(email, password, fullname);
                        u.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("End");
                        break;
                    default:
                        Console.WriteLine("Sehv daxil olundu");
                        break;
                }


            } while (key != 2);

             static void ChangeFullname(ref string fullname)
            {
                    Console.WriteLine("Fullname daxil edin");
                    fullname = Console.ReadLine();
            }
            static void ChangeEmail(ref string email)
            {
                Console.WriteLine("Email daxil edin");
                email = Console.ReadLine();
            }
            static void ChangePassword(ref string password)
            {
                Console.WriteLine("Sifre daxil edin");
                password = Console.ReadLine();

            }

        }    
    }
}
         
    

