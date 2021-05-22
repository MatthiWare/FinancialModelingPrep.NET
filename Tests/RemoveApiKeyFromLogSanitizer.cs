using Divergic.Logging.Xunit;
using Microsoft.Extensions.Logging;
using System;

namespace Tests
{
public class RemoveApiKeyFromLogSanitizer : ILogFormatter
{
    private const string RemovedApiKey = "apikey=************";

    private readonly string apiKeyToRemove;
    private readonly ILogFormatter formatter;

    public RemoveApiKeyFromLogSanitizer(string apiKeyToRemove, ILogFormatter formatter) 
    {
        this.formatter = formatter;
        this.apiKeyToRemove = $"apikey={apiKeyToRemove}";
    }

    public string Format(int scopeLevel, string name, LogLevel logLevel, EventId eventId, string message, Exception exception)
    {
        var formatted = formatter.Format(scopeLevel, name, logLevel, eventId, message, exception);

        var sanitized = formatted.Replace(apiKeyToRemove, RemovedApiKey);

        return sanitized;
    }
}
}
