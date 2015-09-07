using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class BalanceRequest : IRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BalanceRequest"/> class for an all balances request.
		/// </summary>
		public BalanceRequest()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BalanceRequest"/> class for a specific currency request.
		/// </summary>
		/// <param name="currency">The currency symbol of the balance to return.</param>
		public BalanceRequest(string currency)
		{
			Currency = currency;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BalanceRequest"/> class for a specific currency request.
		/// </summary>
		/// <param name="currencyId">The Cryptopia currency identifier balance to return.</param>
		public BalanceRequest(int currencyId)
		{
			CurrencyId = currencyId;
		}

		/// <summary>
		/// Gets or sets the currency symbol.
		/// </summary>
		public string Currency { get; set; }


		/// <summary>
		/// Gets or sets the Cryptopia currency identifier.
		/// </summary>
		public int? CurrencyId { get; set; }
	}
}
