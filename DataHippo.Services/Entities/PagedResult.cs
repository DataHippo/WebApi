using System.Collections.Generic;

namespace DataHippo.Services.Entities
{
    public class PagedResult<T>
    {     
        public PageValues Paging { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}
