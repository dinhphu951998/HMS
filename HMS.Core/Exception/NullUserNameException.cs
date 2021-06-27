using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Core.Exception
{
    public class NullUserNameException : HMSException
    {
        public NullUserNameException()
        {

        }

        public NullUserNameException(string errorMessage) : base(errorMessage)
        { 

        }
    }
}
