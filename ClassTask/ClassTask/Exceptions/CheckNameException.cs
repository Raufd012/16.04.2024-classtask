using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Exceptions
{
    internal class CheckNameException : Exception
    {
        public CheckNameException()
        {
        }


        public CheckNameException(string? message) : base(message)
        {
        }

        public CheckNameException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CheckNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
