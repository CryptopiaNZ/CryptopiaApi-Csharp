using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class SubmitTradeRequest : IRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SubmitTradeRequest"/> class.
		/// </summary>
		/// <param name="market">The Cryptopia market identifier.</param>
		/// <param name="type">The type of trade.</param>
		/// <param name="amount">The amount of coins.</param>
		/// <param name="rate">The price of the coins.</param>
		public SubmitTradeRequest(string market, TradeType type, decimal amount, decimal rate)
		{
			Market = market;
			Type = type;
			Amount = amount;
			Rate = rate;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SubmitTradeRequest"/> class.
		/// </summary>
		/// <param name="tradepairId">The Cryptopia tradepair identifier.</param>
		/// <param name="type">The type of trade.</param>
		/// <param name="amount">The amount of coins.</param>
		/// <param name="rate">The price of the coins.</param>
		public SubmitTradeRequest(int tradepairId, TradeType type, decimal amount, decimal rate)
		{
			TradePairId = tradepairId;
			Type = type;
			Amount = amount;
			Rate = rate;
		}

		/// <summary>
		/// Gets or sets the Cryptopia trade pair identifier.
		/// </summary>
		public int? TradePairId { get; set; }

		/// <summary>
		/// Gets or sets the market symbol.
		/// </summary>
		public string Market { get; set; }

		/// <summary>
		/// Gets or sets the trade type.
		/// </summary>
		public TradeType Type { get; set; }

		/// <summary>
		/// Gets or sets the rate/price.
		/// </summary>
		public decimal Rate { get; set; }

		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		public decimal Amount { get; set; }
	}

	public enum TradeType
	{
		Buy,
		Sell
	}
}
