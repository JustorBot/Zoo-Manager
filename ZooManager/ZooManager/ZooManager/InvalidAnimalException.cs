using System;
using System.Runtime.Serialization;

namespace ZooManager
{
    [Serializable]
    internal class InvalidAnimalException : Exception
    {
        public InvalidAnimalException()
        {
        }

        public InvalidAnimalException(string message) : base(message)
        {
        }

        public InvalidAnimalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAnimalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}