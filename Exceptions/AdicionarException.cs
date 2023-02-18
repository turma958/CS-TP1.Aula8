using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CS_TP1.Aula8.Exceptions
{
    public class AdicionarException : Exception
    {
        public AdicionarException()
        {
        }

        public AdicionarException(string? message) : base(message)
        {
        }

        public AdicionarException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AdicionarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
