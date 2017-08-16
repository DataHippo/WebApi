using System;
using System.Collections.Generic;
using System.Net;
using DataHippo.Services.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace DataHippo.WebApi.Filters
{
    public class FilterConfig
    {
        public static void Configure(IMvcBuilder builder)
        {
            builder.AddMvcOptions(o => { o.Filters.Add(new ExceptionManagerFilter(BuildExceptionMappings())); });
        }

        private static IDictionary<Type, HttpStatusCode> BuildExceptionMappings()
        {
            return new Dictionary<Type, HttpStatusCode>() {
                {typeof(TestCustomException), HttpStatusCode.BadRequest},
                {typeof(DataBaseConnectionException), HttpStatusCode.InternalServerError }

            };
        }
    }
}
