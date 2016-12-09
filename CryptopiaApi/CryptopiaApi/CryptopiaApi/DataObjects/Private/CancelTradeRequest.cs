using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class CancelTradeRequest : IRequest
	{
	/// <summary>
		/// Initializes a new instance of the <see cref="CancelTradeRequest"/> class for an cancel all request.
		/// </summary>
		public CancelTradeRequest()
		{
			Type = CancelTradeType.All;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CancelTradeRequest"/> class for a specific trade cancel request.
		/// </summary>
		/// <param name="currency">The currency symbol of the trade order to cancel.</param>
		public CancelTradeRequest(int orderId)
		{
			OrderId = orderId;
			Type = CancelTradeType.Trade;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CancelTradeRequest"/> class for a specific tradepair cancel request.
		/// </summary>
		/// <param name="currencyId">The Cryptopia currency identifier tradepar to cancel.</param>
		public CancelTradeRequest(int tradePairId, CancelTradeType type = CancelTradeType.TradePair)
		{
			TradePairId = tradePairId;
			Type = CancelTradeType.TradePair;
		}
	
		/// <summary>
		/// Gets or sets the trade identifier.
		/// </summary>
		public int? OrderId { get; set; }

		/// <summary>
		/// Gets or sets the Cryptopia tradepair identifier.
		/// </summary>
		public int? TradePairId { get; set; }

		/// <summary>
		/// Gets or sets the type of cancel.
		/// </summary>
		public CancelTradeType Type { get; set; }
	}

	/// <summary>
	/// Trade Cancel Type
	/// </summary>
	public enum CancelTradeType
	{
		/// <summary>
		/// Single open order cancel
		/// </summary>
		Trade,

		/// <summary>
		/// Cancel all open orders for tradepair
		/// </summary>
		TradePair,

		/// <summary>
		/// Cancel All open orders
		/// </summary>
		All
	}
}
