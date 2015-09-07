using Cryptopia.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class TransactionRequest : IRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TransactionRequest"/> class fo returning Withdrwa/Deposit transactions.
		/// </summary>
		/// <param name="type">The type of transactions to return.</param>
		/// <param name="count">The count of records.</param>
		public TransactionRequest(TransactionType type, int? count = null)
		{
			Type = type;
			Count = count;
		}

		/// <summary>
		/// Gets or sets the type of transactions.
		/// </summary>
		public TransactionType Type { get; set; }

		/// <summary>
		/// Gets or sets the max count of records to return.
		/// </summary>
		public int? Count { get; set; }
	}

	public enum TransactionType
	{
		Deposit,
		Withdraw
	}
}
