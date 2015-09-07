using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Models
{
	public class MarketOrdersResult
	{
		public List<MarketOrderResult> Buy { get; set; }
		public List<MarketOrderResult> Sell { get; set; }
	}
}
