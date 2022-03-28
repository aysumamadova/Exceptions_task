using System;
using System.Collections.Generic;
using System.Text;

namespace IAccount_task.Exceptions
{
   public class PasswordException:Exception
    {
        public PasswordException(string message) : base(message) { }
    }
}
