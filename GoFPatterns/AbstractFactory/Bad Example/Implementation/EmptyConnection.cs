using System;

namespace GoFPatterns.AbstractFactory.BadExample { 

	public class EmptyConnection : IDBConnection{

		public void Connect() {
			Console.WriteLine("CONNECTING WITHOUT A DB DEFINED");		
		}

		public void Disconnect() {
			Console.WriteLine("DISCONNECTING WITHOUT A DB DEFINED");		
		}

	}
}