using GoFPatterns.Shared;

namespace GoFPatterns.Command {

	public class DepositImplementation : IOperation {

		private Account account;
		private double amount;

		public DepositImplementation(Account account, double amount) {
			this.account = account;
			this.amount = amount;
		}

		public void Execute() {
			account.Deposit(amount);
		}

	}
}