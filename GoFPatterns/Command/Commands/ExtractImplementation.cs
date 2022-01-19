using GoFPatterns.Shared;

namespace GoFPatterns.Command {
	public class ExtractImplementation : IOperation {

		private Account account;
		private double amount;

		public ExtractImplementation(Account account, double amount) {
			this.account = account;
			this.amount = amount;
		}

		public void Execute() {
			account.Extract(amount);
		}

	}
}