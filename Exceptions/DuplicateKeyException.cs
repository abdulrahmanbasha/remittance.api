using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace remittance.api.Exceptions
{
    [Serializable]
    internal class DuplicateKeyException : Exception
    {
        public DuplicateKeyException()
            : this("Duplicate key")
        {
        }

        public DuplicateKeyException(string message) : base(message)
        {
        }

        public DuplicateKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
