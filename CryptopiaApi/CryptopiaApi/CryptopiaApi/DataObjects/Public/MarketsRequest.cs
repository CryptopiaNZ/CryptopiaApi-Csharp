using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cryptopia.API.Implementation;

namespace Cryptopia.API.DataObjects
{
	public class MarketsRequest : IRequest
	{
		public MarketsRequest(int? hours = null)
		{
			Hours = hours;
		}
		public int? Hours { get; set; }
	}
}
