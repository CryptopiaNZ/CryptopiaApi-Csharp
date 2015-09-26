using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class SubmitWithdrawRequest : IRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SubmitWithdrawRequest"/> class.
		/// </summary>
		/// <param name="currency">The currency symbol.</param>
		/// <param name="amount">The total amount of coins to spend (amount will be divided equally amongst the active users).</param>
		/// <param name="address">The receiving address (address must belong in you Cryptopia Addressbook)..</param>
		public SubmitWithdrawRequest(string currency, decimal amount, string address)
		{
			Currency = currency;
			Address = address;
			Amount = amount;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SubmitWithdrawRequest"/> class.
		/// </summary>
		/// <param name="currencyId">The currency identifier.</param>
		/// <param name="amount">The total amount of coins to spend (amount will be divided equally amongst the active users).</param>
		/// <param name="address">The receiving address (address must belong in you Cryptopia Addressbook)..</param>
		public SubmitWithdrawRequest(int currencyId, decimal amount, string address)
		{
			CurrencyId = currencyId;
			Address = address;
			Amount = amount;
		}

		/// <summary>
		/// Gets or sets the total amount of coins to withdraw.
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
		/// Gets or sets the address (address must belong in you Cryptopia Addressbook).
		/// </summary>
		public string Address { get; set; }
	}
}
