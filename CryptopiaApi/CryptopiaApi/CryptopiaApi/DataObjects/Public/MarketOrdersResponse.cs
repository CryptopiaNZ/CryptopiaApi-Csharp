using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class MarketOrdersResponse : IResponse
	{
		public bool Success { get; set; }
		public string Error { get; set; }
		public MarketOrdersResult Data { get; set; }
	}
}
