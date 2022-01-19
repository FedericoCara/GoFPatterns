using System;

namespace GoFPatterns.AbstractFactory.BadExample { 

	public class PostgreSQLConnection : IDBConnection {

		private string host;
		private string port;
		private string user;
		private string password;

		public PostgreSQLConnection() {
			this.host = "localhost";
			this.port = "5433";
			this.user = "postgres";
			this.password = "123";
		}

		public void Connect() {
			Console.WriteLine("Connected to PostgreSQL");
		}

		public void Disconnect() {
			Console.WriteLine("Disconnected from PostgreSQL");
		}

		public override string ToString() {
			return $"PostgreSQL Connection [host={host}, port={port}, user={user}, password={password}]";
		}

	}
}