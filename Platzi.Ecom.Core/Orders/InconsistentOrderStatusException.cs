using System;
using System.Runtime.Serialization;

namespace Platzi.Ecom.Core.Orders
{
    [Serializable]
    internal class InconsistentOrderStatusException : Exception
    {
        public InconsistentOrderStatusException()
        {
        }

        public InconsistentOrderStatusException(string message) : base(message)
        {
        }

        public InconsistentOrderStatusException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InconsistentOrderStatusException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}