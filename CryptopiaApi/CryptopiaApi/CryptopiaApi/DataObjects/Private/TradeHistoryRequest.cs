using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class TradeHistoryRequest : IRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TradeHistoryRequest" /> class for an all trade history request.
		/// </summary>
		/// <param name="count">The count of records to return.</param>
		public TradeHistoryRequest(int? count = null)
		{
			Count = count;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TradeHistoryRequest"/> class for a market specific trade history request.
		/// </summary>
		/// <param name="market">The market symbol of the trade history to return.</param>
		/// <param name="count">The count of records to return.</param>
		public TradeHistoryRequest(string market, int? count = null)
		{
			Count = count;
			Market = market;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TradeHistoryRequest"/> class for a tradepair specific trade history request.
		/// </summary>
		/// <param name="tradePairId">The Cryptopia tradepair identifier trade history to return.</param>
		/// <param name="count">The count of records to return.</param>
		public TradeHistoryRequest(int tradePairId, int? count = null)
		{
			Count = count;
			TradePairId = tradePairId;
		}

		/// <summary>
		/// Gets or sets the cryptopia trade pair identifier.
		/// </summary>
		public int? TradePairId { get; set; }

		/// <summary>
		/// Gets or sets the market identifier.
		/// </summary>
		public string Market { get; set; }

		/// <summary>
		/// Gets or sets the record count.
		/// </summary>
		public int? Count { get; set; }
	}
}
