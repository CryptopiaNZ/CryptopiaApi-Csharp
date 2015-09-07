using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Models
{
	public class MarketHistoryResult
	{
		public int TradePairId { get; set; }
		public string Label { get; set; }
		public string Type { get; set; }
		public decimal Price { get; set; }
		public decimal Amount { get; set; }
		public decimal Total { get; set; }
		public int Timestamp { get; set; }
	}
}
