using System;

namespace GoFPatterns.AbstractFactory.BadExample { 

	public class NoAreaRESTConnection : IRESTConnection {

		public void ReadURL(string url) {
			Console.WriteLine("AREA NOT SELECTED");
		}

	}
}