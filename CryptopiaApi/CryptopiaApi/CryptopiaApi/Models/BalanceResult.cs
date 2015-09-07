using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Models
{
	public class BalanceResult
	{
		public int CurrencyId { get; set; }
		public string Symbol { get; set; }
		public decimal Total { get; set; }
		public decimal Available { get; set; }
		public decimal Unconfirmed { get; set; }
		public decimal HeldForTrades { get; set; }
		public decimal PendingWithdraw { get; set; }
		public string Address { get; set; }
		public string Status { get; set; }
		public string StatusMessage { get; set; }
	}
}
