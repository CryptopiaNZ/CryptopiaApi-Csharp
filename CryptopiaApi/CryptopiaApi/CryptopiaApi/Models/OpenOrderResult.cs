using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Models
{
	public class OpenOrderResult
	{
		public int OrderId { get; set; }
		public int TradePairId { get; set; }
		public string Market { get; set; }
		public string Type { get; set; }
		public decimal Rate { get; set; }
		public decimal Amount { get; set; }
		public decimal Total { get; set; }
		public decimal Remaining { get; set; }
		public DateTime TimeStamp { get; set; }
	}
}
