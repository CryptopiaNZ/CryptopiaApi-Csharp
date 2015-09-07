using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class MarketRequest : IRequest
	{
		public MarketRequest(int tradePair, int? hours = null)
		{
			TradePairId = tradePair;
			Hours = hours;
		}
		public int TradePairId { get; set; }
		public int? Hours { get; set; }
	}
}
