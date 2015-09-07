using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Models
{
	public class TransactionResult
	{
		public int Id { get; set; }
		public string Currency { get; set; }
		public string TxId { get; set; }
		public string Type { get; set; }
		public decimal Amount { get; set; }
		public decimal Fee { get; set; }
		public string Status { get; set; }
		public int Confirmations { get; set; }
		public DateTime Timestamp { get; set; }
	}

}
