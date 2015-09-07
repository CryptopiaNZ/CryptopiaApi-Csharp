using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Models
{
	public class MarketResult
	{
		public int TradePairId { get; set; }
		public string Label { get; set; }
		public decimal AskPrice { get; set; }
		public decimal BidPrice { get; set; }
		public decimal Low { get; set; }
		public decimal High { get; set; }
		public decimal Volume { get; set; }
		public decimal LastPrice { get; set; }
		public decimal LastVolume { get; set; }
		public decimal BuyVolume { get; set; }
		public decimal SellVolume { get; set; }
		public decimal Change { get; set; }
	}
}
