using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptopia.API.Implementation
{
	public interface IResponse
	{
		/// <summary>
		/// Gets or sets a value indicating whether this response was successful.
		/// </summary>
		bool Success { get; set; }

		/// <summary>
		/// Gets or sets the error if the response is not successful.
		/// </summary>
		string Error { get; set; }
	}
}
