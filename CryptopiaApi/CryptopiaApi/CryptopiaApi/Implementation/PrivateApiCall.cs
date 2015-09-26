using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Implementation
{
	public enum PrivateApiCall
	{
		CancelTrade,
		GetTradeHistory,
		GetOpenOrders,
		GetBalance,
		SubmitTrade,
		GetTransactions,
		SubmitTip,
		GetDepositAddress,
		SubmitWithdraw
	}
}
