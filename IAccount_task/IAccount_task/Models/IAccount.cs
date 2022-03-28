using System;
using System.Collections.Generic;
using System.Text;

namespace IAccount_task.Models
{
   interface IAccount
    {
      static  bool PasswordChecker(string password)
        {
            return true;
        }
        void ShowInfo();
    }
}
