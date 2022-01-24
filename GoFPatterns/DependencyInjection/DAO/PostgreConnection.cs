using System;

namespace GoFPatterns.DependencyInjection {

	public class PostgreConnection : IConnection {

		private string userName;
		private string password;
		private string host;

		public PostgreConnection(string userName, string password, string host) {
			this.userName = userName;
			this.password = password;
			this.host = host;
		}

		public void Connect() {
			Console.WriteLine("Connecting to PostgreSQL");
		}

        public override string ToString() {
            return "Postgre{"+$"username={userName}|host={host}"+"}";
        }

    }
}