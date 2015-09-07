using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{

	public class SubmitTipRequest : IRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SubmitTipRequest"/> class.
		/// </summary>
		/// <param name="currency">The currency symbol.</param>
		/// <param name="activeMin">The minutes the user must have been active in to receive tip.</param>
		/// <param name="amount">The total amount of coins to spend (amount will be divided equally amongst the active users).</param>
		public SubmitTipRequest(string currency, int activeMin, decimal amount)
		{
			Currency = currency;
			ActiveMin = activeMin;
			Amount = amount;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SubmitTipRequest"/> class.
		/// </summary>
		/// <param name="currencyId">The currency identifier.</param>
		/// <param name="activeMin">The minutes the user must have been active in to receive tip.</param>
		/// <param name="amount">The total amount of coins to spend (amount will be divided equally amongst the active users).</param>
		public SubmitTipRequest(int currencyId, int activeMin, decimal amount)
		{
			CurrencyId = currencyId;
			ActiveMin = activeMin;
			Amount = amount;
		}

		/// <summary>
		/// Gets or sets the total amount of coins to spend (amount will be divided equally amongst the active users).
		/// </summary>
		public decimal Amount { get; set; }

		/// <summary>
		/// Gets or sets the currency.
		/// </summary>
		public string Currency { get; set; }

		/// <summary>
		/// Gets or sets the currency identifier.
		/// </summary>
		public int? CurrencyId { get; set; }

		/// <summary>
		/// Gets or sets the minutes the user must have been active in to receive tip.
		/// </summary>
		public int ActiveMin { get; set; }
	}
}
