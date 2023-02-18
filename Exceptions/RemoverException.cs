using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CS_TP1.Aula8.Exceptions
{
    public class RemoverException : Exception
    {
        public RemoverException()
        {
        }

        public RemoverException(string? message) : base(message)
        {
        }

        public RemoverException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RemoverException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
