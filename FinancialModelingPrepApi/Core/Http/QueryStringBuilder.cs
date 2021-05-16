using System.Collections.Specialized;

namespace FinancialModelingPrepApi.Core.Http
{
    public class QueryStringBuilder
    {
        private readonly NameValueCollection queryParams;

        public QueryStringBuilder()
        {
            queryParams = new NameValueCollection();
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
