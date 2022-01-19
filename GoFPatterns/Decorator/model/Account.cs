namespace GoFPatterns.Decorator {
	public class Account {

		private int id;
		public int Id => id;
		private string client;
		public string Client => client;

		public Account() {

		}

		public Account(int id, string client) {
			this.id = id;
			this.client = client;
		}

	}
}