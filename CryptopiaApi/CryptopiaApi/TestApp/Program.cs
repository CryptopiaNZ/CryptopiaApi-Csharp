using Cryptopia.API;
using Cryptopia.API.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			MainAsync().Wait();
		}

		static async Task MainAsync()
		{
			using (var client = new CryptopiaApiPublic())
			{
				var resultGetMarketOrders = await client.GetMarketOrders(new MarketOrdersRequest(100,10));
			}
		}
	}
}
