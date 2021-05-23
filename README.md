# FinancialModelingPrep.NET
C# API Client For https://financialmodelingprep.com/ API written in .NET 5

## Installation
```powershell
PM> Install-Package MatthiWare.FinancialModelingPrep
```

# Quick Start

Register FinancialModelingPrepApiClient in Dependency Injection provider
> You can find your API Key here https://financialmodelingprep.com/developer/docs/dashboard
``` csharp
Services.AddFinancialModelingPrepApiClient(new FinancialModelingPrepOptions() 
{
    ApiKey = "API-KEY-HERE"
});
```

### Resolve FMP API Client

``` csharp
var api = ServiceProvider.GetRequiredService<IFinancialModelingPrepApiClient>();

// do something with apiClient like getting the latest Apple Stock Quote
var quoteResult = await api.CompanyValuation.GetQuoteAsync("AAPL");
```

### All API Responses are wrapped in an `ApiResponse<T>` object.

``` csharp
var quoteResult = await api.CompanyValuation.GetQuoteAsync("AAPL");

// Display Apple Stock Quote
if (!quoteResult.HasError)
{
   Console.WriteLine($"$AAPL is currently trading at: {quoteResult.Data.Price}");
} 
else 
{
   Console.WriteLine($"Error Message: {quoteResult.Error}");
}
```

