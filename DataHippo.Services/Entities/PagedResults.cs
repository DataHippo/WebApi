using System.Collections.Generic;

namespace DataHippo.Services.Entities
{
    public class PagedResults<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalNumberOfPages { get; set; }
        public int TotalNumberOfRecords { get; set; }
        public string LastPageUrl { get; set; }
        public string NextPageUrl { get; set; }
        public IEnumerable<T> Results { get; set; }
    }
}
