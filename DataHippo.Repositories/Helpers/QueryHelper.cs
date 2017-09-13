using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataHippo.Repositories.Helpers
{
    public static class QueryHelper
    {
        public static string BuidlFieldsProjectionQuery(string fields)
        {
            var result = new StringBuilder();

            result.Append("{");

            if (!string.IsNullOrWhiteSpace(fields))
            {
                if (fields.Contains(","))
                {
                    List<string> fieldsProjectionValues = fields.Split(',').ToList();

                    foreach (var fieldValue in fieldsProjectionValues)
                    {
                        result.AppendFormat("{0}:1,", fieldValue);
                    }
                }
                else
                {
                    result.AppendFormat("{0}:1", fields);
                }
            }
            result.Append("}");

            return result.ToString();
        }
    }
}
