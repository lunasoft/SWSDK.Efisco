using System;
using System.Runtime.Serialization;

namespace SWSDK.Helpers
{
    public class ServicesException : Exception
    {
         public ServicesException()
        {
        }

        public ServicesException(string message) : base(message)
        {
        }

        public ServicesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServicesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
