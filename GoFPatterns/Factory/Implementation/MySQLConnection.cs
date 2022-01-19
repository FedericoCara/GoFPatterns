using System;

namespace GoFPatterns.Factory { 

	public class MySQLConnection : IConnection {

		private string host;
		private string port;
		private string user;
		private string password;

		public MySQLConnection() {
			this.host = "localhost";
			this.port = "3306";
			this.user = "root";
			this.password = "123";
		}

		public void Connect() {
			Console.WriteLine("Connected to MySQL");
		}

		public void Disconnect() {
			Console.WriteLine("Disconnecting from MySQL");
		}

		public override string ToString() {
			return $"MySQL Connection [host={host}, port={port}, user={user}, password={password}]";
		}
	}
}