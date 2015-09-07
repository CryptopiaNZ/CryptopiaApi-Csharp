using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class TradePairsResponse : IResponse
	{
		public bool Success { get; set; }
		public string Error { get; set; }
		public List<TradePairResult> Data { get; set; }
	}
}
