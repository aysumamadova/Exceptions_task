using System;
using System.Collections.Generic;
using System.Text;

namespace Person_task1_.Exceptions
{
    class Exceptions
    {
        public class NotAvailableException : Exception
        {
            public NotAvailableException(string message) : base(message) { }
        }

        public class NullEmptyWhiteSpaceException : Exception
        {
            public NullEmptyWhiteSpaceException(string message) : base(message) { }
        }
    }
}
