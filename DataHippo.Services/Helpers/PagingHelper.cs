using DataHippo.Services.Entities;
using Microsoft.Extensions.Configuration;

namespace DataHippo.Services.Helpers
{
    public class PagingHelper
    {

        public static PageValues GetPagingValues(IConfiguration configuration, long totalElements, int page, int pageSize, string entityName)
        {
            var apiUrl = configuration["ApiConfiguration:Url"];
            var apiVersion = configuration["ApiConfiguration:Version"];

            var mod = totalElements % pageSize;
            var totalPagesCount = (totalElements / pageSize) + (mod == 0 ? 0 : 1);

            var nextPage = page < totalPagesCount ? $"{apiUrl}/{apiVersion}/{entityName}/?page={page + 1}&pageSize={pageSize}" : string.Empty;
            var previousPage = page > 1 ? $"{apiUrl}/{apiVersion}/{entityName}/?page={page - 1}&pageSize={pageSize}" : string.Empty;

            var pageValues = new PageValues
            {
                Next = nextPage,
                Previous = previousPage,
                First = $"{apiUrl}/{apiVersion}/{entityName}/?page=1&pageSize={pageSize}",
                Last = $"{apiUrl}/{apiVersion}/{entityName}/?page={totalPagesCount}&pageSize={pageSize}",
                TotalElements = (int)totalElements,
                TotalPages = (int)totalPagesCount
            };

            return pageValues;
        }

    }
}