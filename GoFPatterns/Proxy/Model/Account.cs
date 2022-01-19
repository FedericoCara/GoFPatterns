namespace GoFPatterns.Proxy {

	public class Account {

		private int accountId;
		public int AccountId => accountId;
		private string user;
		public string User => user;
		private double balance;
		public double Balance {
			get => balance;
			set => balance = value;
		}

		public Account(int idCuenta, string usuario, double initialBalance) {
			this.accountId = idCuenta;
			this.user = usuario;
			this.balance = initialBalance;
		}

	}
}