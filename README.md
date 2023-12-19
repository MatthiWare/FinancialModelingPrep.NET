# FinancialModelingPrep.NET Extended
.NET 8 API Client For https://financialmodelingprep.com/ API written in C#. Extended edition based on MatthiWare's foundation -- see repo this is forked off of.

Actively maintained as part of a financial analysis project.

## Installation
```powershell
PM> Install-Package 1130Labs.FinancialModelingPrepExtended
```

# Quick Start

### Register FinancialModelingPrepApiClient in Dependency Injection provider
> You can find your API Key here https://financialmodelingprep.com/developer/docs/dashboard
``` csharp
using MatthiWare.FinancialModelingPrep;

Services.AddFinancialModelingPrepApiClient(new FinancialModelingPrepOptions() 
{
    ApiKey = "API-KEY-HERE"
});

var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

// do something with api like getting the latest Apple Stock Quote
var quoteResult = await api.CompanyValuation.GetQuoteAsync("AAPL");
```

### Create FMP API Client using Factory (without Dependency Injection)

```csharp
using MatthiWare.FinancialModelingPrep;

var api = FinancialModelingPrepApiClientFactory.CreateClient(new FinancialModelingPrepOptions());

// do something with api like getting the latest Apple Stock Quote
var quoteResult = await api.CompanyValuation.GetQuoteAsync("AAPL");
```

### Get Stock Price Quote

``` csharp
var response = await api.CompanyValuation.GetQuoteAsync("AAPL");

// Display Apple Stock Quote
Console.WriteLine($"$AAPL is currently trading at: {response.Data.Price}");
```

### All API Responses are wrapped in an `ApiResponse<T>` object.

``` csharp
public class ApiResponse<T>
{
    /// <summary>
    /// Error message if any occured
    /// </summary>
    public string Error { get; }

    /// <summary>
    /// True if there was an error with the request otherwise false
    /// </summary>
    public bool HasError { get; }

    /// <summary>
    /// The FMP API response object <see cref="T"/>
    /// </summary>
    public T Data { get; }
}
```

Example:

``` csharp
var response = await api.CompanyValuation.GetQuoteAsync("AAPL");

// Display Apple Stock Quote
if (!quoteResult.HasError)
{
   Console.WriteLine($"$AAPL is currently trading at: {response.Data.Price}");
} 
else 
{
   Console.WriteLine($"Error occured, message: {response.Error}");
}
```

### Covered Endpoints
- Company Valuation
- Advanced Data
- Insider Trading (Not yet covered)
- Calendars
- Instituational Fund
- Stock Time Series (Partially covered)
- Technical Indicators (Not yet covered)
- Stock Statistics (Partially covered)
- Market Indexes
- Alternative Data (Not yet covered)
- Commodities (Not yet covered)
- ETF (Not yet covered)
- Mutual Funds (Not yet covered)
- Euronext
- TSX
- Stock Market (Partially covered)
- Cryptocurrencies
- Forex

### Contribute
Create a PR where you add or improve an Endpoint

