using System;

namespace GoFPatterns.DependencyInjection {
	public class MySQLConnection : IConnection {

		private string userName;
		private string password;
		private string host;

		public MySQLConnection(string userName, string password, string host) {
			this.userName = userName;
			this.password = password;
			this.host = host;
		}

		public void Connect() {
			Console.WriteLine("Connecting to MySQL");
		}
		public override string ToString() {
			return "MySQL{" + $"username={userName}|host={host}" + "}";
		}
	} 
}
