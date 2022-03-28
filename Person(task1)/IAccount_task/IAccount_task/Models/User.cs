using IAccount_task.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace IAccount_task.Models
{

    class User 
    {
        private int _Id;
        private string _Fullname;
        private string _Email;
        private string _Password;

        public int Id { get; }

        public string Fullname
        {
            get { return _Fullname; }
            set
            {
                    _Fullname = value;
                
            }
        }
        public string Email
        {
            get { return _Email; }
            set
            {
                if (EmailChecker(value))
                {
                    _Email= value;
                }
            }
        }
        public string Password
        {
            get { return _Password; }
            set
            {
                if (PasswordChecker(value))
                {
                    _Password = value;
                }
             }
        }

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;

            if (PasswordChecker(password))
            {
                _Id++;
                Id = _Id;
            }
        }
        public User(string email, string password, string fullname) : this(email, password)
        {
            this.Fullname = fullname;
        }

        public static bool PasswordChecker(string password)
        {
            Regex r = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])+[a-zA-z0-9]{8,}$");
            Match m = r.Match(password);
            if (m.Success)
            {
                return true;
            }
            else
            {
                throw new PasswordException("Sifre sehv daxil edilib");
            }
        }

        public static bool EmailChecker(string email)
        {
            Regex r = new Regex(@"^([^\W])([a-z\d\.\-_]+)@([a-z\d\-]+\.)([a-z]{2,13})$");
            Match m = r.Match(email);
            if (m.Success)
            {
                return true;
            }
            else
            {
                throw new EmailException("Email sehv daxil edilib");
            }
        }
       
        public void ShowInfo()
        {
            Console.WriteLine($" ID->{Id}\n Fullname->{Fullname}\n Emil->{Email}\n Password->{Password}\n");
        }
       
    }
}
