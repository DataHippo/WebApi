namespace DataHippo.WebApi.Filters
{
    public partial class ExceptionManagerFilter
    {
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
