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
			return await GetResult<CurrenciesResponse, IRequest>(PublicApiCall.GetCurrencies, null);
		}

		public async Task<TradePairsResponse> GetTradePairs()
		{
			return await GetResult<TradePairsResponse, IRequest>(PublicApiCall.GetTradePairs, null);
		}

		public async Task<MarketsResponse> GetMarkets(MarketsRequest request)
		{
			return await GetResult<MarketsResponse, MarketsRequest>(PublicApiCall.GetMarkets, request);
		}

		public async Task<MarketResponse> GetMarket(MarketRequest request)
		{
			return await GetResult<MarketResponse, MarketRequest>(PublicApiCall.GetMarket, request);
		}

		public async Task<MarketHistoryResponse> GetMarketHistory(MarketHistoryRequest request)
		{
			return await GetResult<MarketHistoryResponse, MarketHistoryRequest>(PublicApiCall.GetMarketHistory, request);
		}

		public async Task<MarketOrdersResponse> GetMarketOrders(MarketOrdersRequest request)
		{
			return await GetResult<MarketOrdersResponse, MarketOrdersRequest>(PublicApiCall.GetMarketOrders, request);
		}

		#endregion

		#region public Members

		public async Task<T> GetResult<T, U>(PublicApiCall call, U requestData)
			where T : IResponse, new()
			where U : IRequest
		{
			var response = await _client.GetStringAsync(string.Format("{0}/Api/{1}", _apiBaseAddress, call));
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
