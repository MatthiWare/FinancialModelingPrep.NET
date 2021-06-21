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
        public int MaxRequestPerSecond { get; set; } = 10;

        /// <summary>
        /// Gets or sets the maximum allowed API Calls per second.
        /// You can find the defaults on the pricing documentation. 
        /// By default we use the 300 "starter" limit.
        /// https://financialmodelingprep.com/developer/docs/pricing
        /// </summary>
        public int MaxAPICallsPerMinute { get; set; } = 300;
    }
}
