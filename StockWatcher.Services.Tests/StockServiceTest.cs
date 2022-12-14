using System.Collections.Generic;
using System.Linq;
using StockWatcher.Models.Models.Models.ServiceProvidersEntities;
using StockWatcher.Services.Interfaces;
using System.Threading.Tasks;
// <copyright file="StockServiceTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using StockWatcher.Services.Services;

namespace StockWatcher.Services.Services.Tests
{
    [TestFixture]
    [PexClass(typeof(StockService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StockServiceTest
    {

        [PexMethod]
        public Task<bool> AddStockAsync([PexAssumeUnderTest] StockService target, string ticker)
        {
            Task<bool> result = target.AddStockAsync(ticker);
            return result;
            // TODO: add assertions to method StockServiceTest.AddStockAsync(StockService, String)
        }

        [PexMethod]
        public StockService Constructor(
            IAuthenticationService authenticationService,
            IDbService dbService,
            IDataProviderService yahooService
        )
        {
            StockService target = new StockService(authenticationService, dbService, yahooService);
            return target;
            // TODO: add assertions to method StockServiceTest.Constructor(IAuthenticationService, IDbService, IDataProviderService)
        }

        [PexMethod]
        public Task<bool> DeleteStockAsync([PexAssumeUnderTest] StockService target, string ticker)
        {
            Task<bool> result = target.DeleteStockAsync(ticker);
            return result;
            // TODO: add assertions to method StockServiceTest.DeleteStockAsync(StockService, String)
        }

        [PexMethod]
        public Task<IOrderedEnumerable<FormattedQuote>> GetHistoricalDataAsync01(
            [PexAssumeUnderTest] StockService target,
            string symbol,
            int numOfDays
        )
        {
            Task<IOrderedEnumerable<FormattedQuote>> result = target.GetHistoricalDataAsync(symbol, numOfDays);
            return result;
            // TODO: add assertions to method StockServiceTest.GetHistoricalDataAsync01(StockService, String, Int32)
        }

        [PexMethod]
        public Task<FormattedGeneralInformation> GetStockGeneralInformationAsync([PexAssumeUnderTest] StockService target, string symbol)
        {
            Task<FormattedGeneralInformation> result = target.GetStockGeneralInformationAsync(symbol);
            return result;
            // TODO: add assertions to method StockServiceTest.GetStockGeneralInformationAsync(StockService, String)
        }

        [PexMethod]
        public Task<IEnumerable<string>> GetUserStocks([PexAssumeUnderTest] StockService target)
        {
            Task<IEnumerable<string>> result = target.GetUserStocks();
            return result;
            // TODO: add assertions to method StockServiceTest.GetUserStocks(StockService)
        }
    }
}
