using System;

namespace DataHippo.Services.Exceptions
{
    public class TestCustomException : Exception
    {
        public TestCustomException(string message)
            : base(message)
        {
        }
    }
}


