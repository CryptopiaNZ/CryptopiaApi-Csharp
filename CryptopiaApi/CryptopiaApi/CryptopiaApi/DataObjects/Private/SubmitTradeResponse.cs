using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{

	public class SubmitTradeResponse : IResponse
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
		public SubmitTradeData Data { get; set; }
	}

	public class SubmitTradeData
	{
		/// <summary>
		/// Gets or sets the created order identifier.
		/// </summary>
		public int? OrderId { get; set; }

		/// <summary>
		/// Gets or sets the list of any filled orders.
		/// </summary>
		public List<int> FilledOrders { get; set; }
	}
}
