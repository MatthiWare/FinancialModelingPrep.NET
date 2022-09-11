namespace MatthiWare.FinancialModelingPrep.Model
{
    public static class ApiResponse
    {
        public static ApiResponse<TReturn> FromError<TReturn>(string error) where TReturn : class
            => new()
            {
                Error = error
            };

        public static ApiResponse<TReturn> FromSuccess<TReturn>(TReturn data) where TReturn : class
            => new()
            {
                Data = data
            };
    }

    public class ApiResponse<T> where T : class
    {
        /// <summary>
        /// Error message if any occured
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// True if there was an error with the request otherwise false
        /// </summary>
        public bool HasError => !string.IsNullOrEmpty(Error);

        /// <summary>
        /// The FMP API response object <see cref="T"/>
        /// </summary>
        public T Data { get; set; }
    }
}
