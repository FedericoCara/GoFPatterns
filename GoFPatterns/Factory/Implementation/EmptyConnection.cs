using System;

namespace GoFPatterns.Factory { 

	public class EmptyConnection : IConnection{

		public void Connect() {
			Console.WriteLine("CONNECTING WITHOUT A DB DEFINED");		
		}

		public void Disconnect() {
			Console.WriteLine("DISCONNECTING WITHOUT A DB DEFINED");		
		}

	}
}