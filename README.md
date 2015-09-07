This is a C# wapper for the Cryptopia Public and Private API's

Public Usage:

			using (var api = new CryptopiaApiPublic())
			{
				var response = await api.GetCurrencies();
				if (!response.Success)
				{
					Console.WriteLine(response.Error);
					return;
				}

				foreach (var currency in response.Data)
				{
					Console.WriteLine("Currency: {0}", currency.Name);
				}
			}


Private Usage:

			var _apiKey = "your cryptopia api key";
			var _apiSecret = "your cryptopia api secret";
			using (var api = new CryptopiaApiPrivate(_apiKey, _apiSecret))
			{
				var response = await api.SubmitTrade(new SubmitTradeRequest("DOT/BTC", TradeType.Buy, 60, 0.00000020M));
				if (!response.Success)
				{
					Console.WriteLine(response.Error);
					return;
				}
				Console.WriteLine("New Trade Submitted, OrderId: {0}", response.Data.OrderId);
			}
