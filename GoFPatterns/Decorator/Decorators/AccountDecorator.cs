namespace GoFPatterns.Decorator {

	public abstract class AccountDecorator : IBankAccount {

		protected IBankAccount decoratedAccount;

		public AccountDecorator(IBankAccount decoratedAccount) {
			this.decoratedAccount = decoratedAccount;
		}

		public virtual void OpenAccount(Account account) {
			decoratedAccount.OpenAccount(account);
		}

	}
}