using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class MarketOrdersRequest : IRequest
	{
		public MarketOrdersRequest(int tradePair, int? orderCount = null)
		{
			TradePairId = tradePair;
			OrderCount = orderCount;
		}
		public int TradePairId { get; set; }
		public int? OrderCount { get; set; }
	}
}
