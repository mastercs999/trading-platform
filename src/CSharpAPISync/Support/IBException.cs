﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAPISync.Support
{
    [Serializable]
    public class IBException : Exception
    {
        public int Id { get; private set; }
        public int ErrorCode { get; private set; }

        public IBException() : base()
        {
        }

        public IBException(string message) : base(message)
        {
        }

        public IBException(string message, Exception inner) : base(message, inner)
        {
        }

        public IBException(string message, int id, int errorCode) : base(message)
        {
            Id = id;
            ErrorCode = errorCode;
        }

        protected IBException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
