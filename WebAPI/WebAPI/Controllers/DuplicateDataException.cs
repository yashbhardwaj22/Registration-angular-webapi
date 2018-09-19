﻿using System;
using System.Runtime.Serialization;

namespace WebAPI.Controllers
{
    [Serializable]
    internal class DuplicateDataException : Exception
    {
        public DuplicateDataException()
        {
        }

        public DuplicateDataException(string message) : base(message)
        {

        }

        public DuplicateDataException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}