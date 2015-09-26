using Cryptopia.API.DataObjects;
using System;
using System.Threading.Tasks;

namespace Cryptopia.API.Implementation
{
	public interface ICryptopiaApiPrivate : IDisposable
	{
		Task<T> GetResult<T, U>(PrivateApiCall call, U requestData)
			where T : IResponse
			where U : IRequest;
		Task<CancelTradeResponse> CancelTrade(CancelTradeRequest request);
		Task<BalanceResponse> GetBalances(BalanceRequest request);
		Task<DepositAddressResponse> GetDepositAddress(DepositAddressRequest request);
		Task<OpenOrdersResponse> GetOpenOrders(OpenOrdersRequest request);
		Task<TradeHistoryResponse> GetTradeHistory(TradeHistoryRequest request);
		Task<TransactionResponse> GetTransactions(TransactionRequest request);
		Task<SubmitTipResponse> SubmitTip(SubmitTipRequest request);
		Task<SubmitTradeResponse> SubmitTrade(SubmitTradeRequest request);
		Task<SubmitWithdrawResponse> SubmitWithdraw(SubmitWithdrawRequest request);
	}
}
