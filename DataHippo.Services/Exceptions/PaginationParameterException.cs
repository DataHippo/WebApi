using System;

namespace DataHippo.Services.Exceptions
{
    public class PaginationParameterException : Exception
    {
        public PaginationParameterException(string message)
            : base(message)
        {
        }
    }
}


