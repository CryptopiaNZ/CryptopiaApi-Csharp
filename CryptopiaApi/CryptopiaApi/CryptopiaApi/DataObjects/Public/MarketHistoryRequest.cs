using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class MarketHistoryRequest : IRequest
	{
		public MarketHistoryRequest(int tradePair)
		{
			TradePairId = tradePair;
		}
		public int TradePairId { get; set; }
	}
}
