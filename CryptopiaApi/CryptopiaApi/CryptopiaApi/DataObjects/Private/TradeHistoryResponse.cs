using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class TradeHistoryResponse : IResponse
	{
		/// <summary>
		/// Gets or sets a value indicating whether this response was successful.
		/// </summary>
		public bool Success { get; set; }

		/// <summary>
		/// Gets or sets the error if the response is not successful.
		/// </summary>
		public string Error { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		public List<TradeHistoryResult> Data { get; set; }
	}
}
