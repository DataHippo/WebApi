using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DataHippo.WebApi.Filters
{
    public class ExceptionManagerFilter : ExceptionFilterAttribute
    {
        private readonly IDictionary<Type, HttpStatusCode> _mappings;

        public ExceptionManagerFilter()
        {
            _mappings = new Dictionary<Type, HttpStatusCode>
            {
                {typeof (NotImplementedException), HttpStatusCode.NotImplemented}
            };
        }

        public ExceptionManagerFilter(IDictionary<Type, HttpStatusCode> mappings)
            : this()
        {
            foreach (var mapping in mappings)
            {
                _mappings.Add(mapping);
            }
        }

        public override void OnException(ExceptionContext context)
        {
            if (context.Exception == null) return;

            var statusCode = HttpStatusCode.InternalServerError;

            var exceptionType = context.Exception.GetType();
            if (_mappings.ContainsKey(exceptionType))
            {
                statusCode = _mappings[exceptionType];
            }

            var response = new ErrorResponse(context.Exception.Message);

            context.Result = new ObjectResult(response)
            {
                StatusCode = (int)statusCode,
                DeclaredType = typeof(ErrorResponse)
            };

            base.OnException(context);
        }

        public class ErrorResponse
        {
            public string Message { get; set; }

            public ErrorResponse()
            {
            }

            public ErrorResponse(string message)
            {
                Message = message;
            }
        }
    }
}
