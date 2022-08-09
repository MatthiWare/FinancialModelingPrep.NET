﻿using MatthiWare.FinancialModelingPrep.Abstractions.Crypto;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.StockMarket
{
    public class CryptoMarketTests : TestingBase
    {
        private readonly ICryptoMarketProvider api;

        public CryptoMarketTests(ITestOutputHelper testOutput) : base(testOutput)
        {
            api = ServiceProvider.GetRequiredService<ICryptoMarketProvider>();
        }

        [Fact]
        public async Task GetCryptocurrencyRealtime()
        {
            var result = await api.GetQuote("BTCUSD");

            result.AssertNoErrors();
            Assert.NotNull(result.Data);
            Assert.Equal("BTCUSD", result.Data[0].Symbol);
        }

        [Fact]
        public async Task GetAvailableCryptocurrencies()
        {
            var result = await api.GetAvilableCryptocurrencies();

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task GetDailyPrice()
        {
            var result = await api.GetDailyPrices("BTCUSD");

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data.HistoricalPrices);
        }

        [Fact]
        public async Task GetPeriodPriceData()
        {
            var result = await api.GetHistoricalPrices("BTCUSD", MatthiWare.FinancialModelingPrep.Model.HistoricalPricingPeriod.OneHour);

            result.AssertNoErrors();
            Assert.NotEmpty(result.Data);
        }
    }
}
