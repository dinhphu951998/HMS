using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HMS.Core.Exception
{
    public abstract class HMSException : System.Exception
    {
        public HMSException()
        {

        }
        public HMSException(string errorMessage) : base(errorMessage)
        {

        }

        public HMSException(string errorMessage, System.Exception innerException) : base(errorMessage, innerException)
        {

        }

        public void PrintStrackTrace()
        {
            Trace.WriteLine(this.StackTrace);
        }
    }
}
