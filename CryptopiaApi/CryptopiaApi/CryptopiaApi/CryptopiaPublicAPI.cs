using Cryptopia.API.DataObjects;
using Cryptopia.API.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API
{
	public class CryptopiaApiPublic : ICryptopiaApiPublic
	{
		private HttpClient _client;
		private string _apiBaseAddress;

		public CryptopiaApiPublic(string apiBaseAddress = "https://www.cryptopia.co.nz")
		{
			_apiBaseAddress = apiBaseAddress;
			_client = HttpClientFactory.Create();
		}

		#region Api Calls

		public async Task<CurrenciesResponse> GetCurrencies()
		{
			return await GetResult<CurrenciesResponse>(PublicApiCall.GetCurrencies, null);
		}

		public async Task<TradePairsResponse> GetTradePairs()
		{
			return await GetResult<TradePairsResponse>(PublicApiCall.GetTradePairs, null);
		}

		public async Task<MarketsResponse> GetMarkets(MarketsRequest request)
		{
			var query = request.Hours.HasValue ? $"/{request.Hours}" : null;
			return await GetResult<MarketsResponse>(PublicApiCall.GetMarkets, query);
		}

		public async Task<MarketResponse> GetMarket(MarketRequest request)
		{
			var query = request.Hours.HasValue ? $"/{request.TradePairId}/{request.Hours}" : $"/{request.TradePairId}";
			return await GetResult<MarketResponse>(PublicApiCall.GetMarket, query);
		}

		public async Task<MarketHistoryResponse> GetMarketHistory(MarketHistoryRequest request)
		{
			var query = $"/{request.TradePairId}";
			return await GetResult<MarketHistoryResponse>(PublicApiCall.GetMarketHistory, query);
		}

		public async Task<MarketOrdersResponse> GetMarketOrders(MarketOrdersRequest request)
		{
			var query = request.OrderCount.HasValue ? $"/{request.TradePairId}/{request.OrderCount}" : $"/{request.TradePairId}";
			return await GetResult<MarketOrdersResponse>(PublicApiCall.GetMarketOrders, query);
		}

		#endregion

		#region public Members

		public async Task<T> GetResult<T>(PublicApiCall call, string requestData)
			where T : IResponse, new()
		{
			var response = await _client.GetStringAsync(string.Format("{0}/Api/{1}{2}", _apiBaseAddress, call, requestData));
			if (string.IsNullOrEmpty(response))
			{
				return new T() { Success = false, Error = "No Response." };
			}
			return GetObject<T>(response);
		}

		private T GetObject<T>(string jsonData)
		{
			using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonData)))
			{
				var serializer = new DataContractJsonSerializer(typeof(T));
				return (T)(object)serializer.ReadObject(stream);
			}
		}

		public void Dispose()
		{
			if (_client != null)
			{
				_client.Dispose();
			}
		}

		#endregion
	}
}
