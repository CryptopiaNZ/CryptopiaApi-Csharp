using Cryptopia.API.Implementation;
using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cryptopia.API.DataObjects
{
	public class MarketResponse : IResponse
	{
		public bool Success { get; set; }
		public string Error { get; set; }
		public MarketResult Data { get; set; }
	}
}
