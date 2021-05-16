using System.Collections.Specialized;
using System.Web;

namespace FinancialModelingPrepApi.Core.Http
{
    public class QueryStringBuilder
    {
        private readonly NameValueCollection queryParams;

        public QueryStringBuilder()
        {
            queryParams = HttpUtility.ParseQueryString(string.Empty);
        }

        public void Add(string key, object value)
        {
            if (string.IsNullOrEmpty(key))
            {
                return;
            }

            var valueToAdd = value?.ToString().Trim();
            queryParams.Add(key, valueToAdd);
        }

        public override string ToString()
        {
            if (queryParams.Count == 0)
            {
                return string.Empty;
            }

            return $"?{queryParams}";
        }
    }
}
