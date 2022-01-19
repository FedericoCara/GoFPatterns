using System;

namespace GoFPatterns.Proxy {

	public class BankAccountAImplementation : IAccount {

		public Account ExtractMoney(Account account, double amount) {
			double currentBalance = account.Balance - amount;
			account.Balance = currentBalance;
			Console.WriteLine("Current balance: " + account.Balance);
			return account;
		}

		public Account DepositMoney(Account account, double amount) {
			double currentBalance = account.Balance + amount;
			account.Balance = currentBalance;
			Console.WriteLine("Current balance: " + account.Balance);
			return account;
		}

		public void ShowBalance(Account account) {
			Console.WriteLine("Current balance: " + account.Balance);
		}

	}
}