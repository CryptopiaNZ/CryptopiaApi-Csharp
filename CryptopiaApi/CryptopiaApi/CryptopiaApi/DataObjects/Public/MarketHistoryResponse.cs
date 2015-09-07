using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class MarketHistoryResponse : IResponse
	{
		public bool Success { get; set; }
		public string Error { get; set; }
		public List<MarketHistoryResult> Data { get; set; }
	}
}
