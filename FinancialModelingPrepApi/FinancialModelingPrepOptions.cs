namespace MatthiWare.FinancialModelingPrep
{
    /// <summary>
    /// FMP Options
    /// </summary>
    public class FinancialModelingPrepOptions
    {
        /// <summary>
        /// Get or set the FMP API Key.
        /// You can find your API Key in the dashboard (https://financialmodelingprep.com/developer/docs/dashboard)
        /// By default it will use the 'demo' API Key that is limited and not all endpoints will work. 
        /// </summary>
        public string ApiKey { get; set; } = "demo";

        /// <summary>
        /// Gets or sets the maximum allowed of requests per second.
        /// By default the max allowed is 10. If you have a different rate limit you can configure it here.
        /// See Rate Limitation #15 https://financialmodelingprep.com/developer/docs/terms-of-service
        /// </summary>
        public int MaxRequestLimit { get; set; } = 10;
    }
}
