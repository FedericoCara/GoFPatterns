using System;

namespace GoFPatterns.Decorator {

	public class CurrentAccount : IBankAccount {

		public void OpenAccount(Account account) {
			Console.WriteLine("-------------------------");
			Console.WriteLine("Current account opened");
			Console.WriteLine("Client: " + account.Client);
		}

	}
}