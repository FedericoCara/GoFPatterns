using System;

namespace GoFPatterns.AbstractFactory.BadExample {

	public class SQLServerConnection : IDBConnection {

		private string host;
		private string port;
		private string user;
		private string password;

		public SQLServerConnection() {
			this.host = "localhost";
			this.port = "1433";
			this.user = "postgres";
			this.password = "123";
		}

		
		public void Connect() {
			
			Console.WriteLine("Connected to SQLServer");

		}

		
		public void Disconnect() {
			Console.WriteLine("Disconnected from SQLServer");
		}

		public override string ToString() {
			return $"SQLServer Connection [host={host}, port={port}, user={user}, password={password}]";
		}

	}
}