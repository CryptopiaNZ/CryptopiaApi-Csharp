using Cryptopia.API.DataObjects;
using Cryptopia.API.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API
{
	public class CryptopiaApiPrivate : ICryptopiaApiPrivate
	{
		private HttpClient _client;
		private string _apiBaseAddress;

		public CryptopiaApiPrivate(string key, string secret, string apiBaseAddress = "https://www.cryptopia.co.nz")
		{
			_apiBaseAddress = apiBaseAddress;
			_client = HttpClientFactory.Create(new AuthDelegatingHandler(key, secret));
		}

		#region Api Calls

		public async Task<CancelTradeResponse> CancelTrade(CancelTradeRequest request)
		{
			return await GetResult<CancelTradeResponse, CancelTradeRequest>(PrivateApiCall.CancelTrade, request);
		}

		public async Task<SubmitTradeResponse> SubmitTrade(SubmitTradeRequest request)
		{
			return await GetResult<SubmitTradeResponse, SubmitTradeRequest>(PrivateApiCall.SubmitTrade, request);
		}

		public async Task<BalanceResponse> GetBalances(BalanceRequest request)
		{
			return await GetResult<BalanceResponse, BalanceRequest>(PrivateApiCall.GetBalance, request);
		}

		public async Task<OpenOrdersResponse> GetOpenOrders(OpenOrdersRequest request)
		{
			return await GetResult<OpenOrdersResponse, OpenOrdersRequest>(PrivateApiCall.GetOpenOrders, request);
		}

		public async Task<TradeHistoryResponse> GetTradeHistory(TradeHistoryRequest request)
		{
			return await GetResult<TradeHistoryResponse, TradeHistoryRequest>(PrivateApiCall.GetTradeHistory, request);
		}

		public async Task<TransactionResponse> GetTransactions(TransactionRequest request)
		{
			return await GetResult<TransactionResponse, TransactionRequest>(PrivateApiCall.GetTransactions, request);
		}

		public async Task<DepositAddressResponse> GetDepositAddress(DepositAddressRequest request)
		{
			return await GetResult<DepositAddressResponse, DepositAddressRequest>(PrivateApiCall.GetDepositAddress, request);
		}

		public async Task<SubmitTipResponse> SubmitTip(SubmitTipRequest request)
		{
			return await GetResult<SubmitTipResponse, SubmitTipRequest>(PrivateApiCall.SubmitTip, request);
		}

		public async Task<SubmitWithdrawResponse> SubmitWithdraw(SubmitWithdrawRequest request)
		{
			return await GetResult<SubmitWithdrawResponse, SubmitWithdrawRequest>(PrivateApiCall.SubmitWithdraw, request);
		}

		#endregion

		#region public Members

		public async Task<T> GetResult<T, U>(PrivateApiCall call, U requestData)
			where T : IResponse
			where U : IRequest
		{
			var response = await _client.PostAsJsonAsync<U>(string.Format("{0}/Api/{1}", _apiBaseAddress.TrimEnd('/'), call), requestData);
			return await response.Content.ReadAsAsync<T>();
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
