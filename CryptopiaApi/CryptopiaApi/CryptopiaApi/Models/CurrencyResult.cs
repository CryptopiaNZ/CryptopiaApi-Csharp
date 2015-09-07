using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Models
{
	public class CurrencyResult
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Symbol { get; set; }
		public string Algorithm { get; set; }
	}
}
