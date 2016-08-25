using System;
using System.Runtime.Serialization;

namespace PlaceToPlay.Api.Infrastructure.Exceptions
{
    [Serializable]
    public class DomainOperationException : Exception
    {
        public DomainOperationException() : base("Invalid operation exception ocured")
        {

        }

        public DomainOperationException(string message) : base(message)
        {

        }

        public DomainOperationException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected DomainOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
