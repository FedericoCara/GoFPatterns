using System;

namespace GoFPatterns.Decorator {

	public class SecurityDecorator : AccountDecorator {

		public SecurityDecorator(IBankAccount decoratedAccount) : base(decoratedAccount){

		}

		public override void OpenAccount(Account account) {
			base.OpenAccount(account);
			AddSecurity(account);
		}

		public void AddSecurity(Account account) {		
			Console.WriteLine($"Security added to {account.Client}'s account ");
		}

	}
}