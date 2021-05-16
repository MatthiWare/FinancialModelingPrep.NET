namespace FinancialModelingPrepApi.Model
{
    public static class ApiResponse
    {
        public static ApiResponse<TReturn> FromError<TReturn>(string error) where TReturn : class
            => new()
            {
                Error = error
            };

        public static ApiResponse<TReturn> FromSucces<TReturn>(TReturn data) where TReturn : class
            => new()
            {
                Data = data
            };
    }

    public class ApiResponse<T> where T : class
    {
        public string Error { get; set; }
        public bool HasError => !string.IsNullOrEmpty(Error);
        public T Data { get; set; }
    }
}
