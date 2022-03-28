using System;
using System.Collections.Generic;
using System.Text;

namespace IAccount_task.Exceptions
{
    class EmailException:Exception
    {
        public EmailException(string message) : base(message) { }
        
    }
}
