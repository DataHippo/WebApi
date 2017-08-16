using System;

namespace DataHippo.Services.Exceptions
{
    public class DataBaseConnectionException : Exception
    {
        public DataBaseConnectionException(string message)
            : base(message)
        {
        }
    }
}


