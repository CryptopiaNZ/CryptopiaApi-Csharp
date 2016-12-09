using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Models
{
	public class TradePairResult
	{
		public int Id { get; set; }
		public string Label { get; set; }
		public string Currency { get; set; }
		public string Symbol { get; set; }
		public string BaseCurrency { get; set; }
		public string BaseSymbol { get; set; }
		public string Status { get; set; }
		public decimal MinimumBaseTrade { get; set; }
	}
}
