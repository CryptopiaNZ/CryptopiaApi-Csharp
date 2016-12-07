using Cryptopia.API.DataObjects;
using System;
using System.Threading.Tasks;

namespace Cryptopia.API.Implementation
{
	public interface ICryptopiaApiPublic : IDisposable
	{
		Task<T> GetResult<T>(PublicApiCall call, string requestData) where T : IResponse, new();
		Task<CurrenciesResponse> GetCurrencies();
		Task<MarketResponse> GetMarket(MarketRequest request);
		Task<MarketHistoryResponse> GetMarketHistory(MarketHistoryRequest request);
		Task<MarketOrdersResponse> GetMarketOrders(MarketOrdersRequest request);
		Task<MarketsResponse> GetMarkets(MarketsRequest request);
		Task<TradePairsResponse> GetTradePairs();
	}
}
