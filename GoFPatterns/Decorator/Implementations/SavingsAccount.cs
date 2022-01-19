using System;

namespace GoFPatterns.Decorator {

	public class SavingsAccount : IBankAccount {

		public void OpenAccount(Account account) {
			Console.WriteLine("-------------------------");
			Console.WriteLine("Savings account opened");
			Console.WriteLine("Client: " + account.Client);		
		}

	}
}