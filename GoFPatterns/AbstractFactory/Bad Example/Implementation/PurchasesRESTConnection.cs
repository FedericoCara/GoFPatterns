using System;

namespace GoFPatterns.AbstractFactory.BadExample { 

	public class PurchasesRESTConnection : IRESTConnection {

		
		public void ReadURL(string url) {		
			Console.WriteLine($"Connecting to {url}");
		}

	}
}