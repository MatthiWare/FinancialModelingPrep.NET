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
    }
}
