using System;
using System.Runtime.Serialization;

namespace Queues
{
    [Serializable]
    internal class InvalidOpeartionException : Exception
    {
        public InvalidOpeartionException()
        {
        }

        public InvalidOpeartionException(string message) : base(message)
        {
        }

        public InvalidOpeartionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidOpeartionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}