using System;

namespace GoFPatterns.AbstractFactory.BadExample { 

	public class OracleConnection : IDBConnection {

		private string host;
		private string port;
		private string user;
		private string password;

		public OracleConnection() {
			this.host = "localhost";
			this.port = "1521";
			this.user = "admin";
			this.password = "123";
		}

		
		public void Connect() {
			Console.WriteLine("Connected to Oracle");
		}

		
		public void Disconnect() {
			Console.WriteLine("Disconnected from Oracle");
		}

		
		public override string ToString() {
			return $"Oracle Connection [host={host}, port={port}, user={user}, password={password}]";
		}

	}
}