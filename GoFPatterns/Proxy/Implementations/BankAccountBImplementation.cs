using System;

namespace GoFPatterns.Proxy {

	public class BankAccountBImplementation : IAccount {

		public Account ExtractMoney(Account cuenta, double monto) {
			double currentBalance = cuenta.Balance - monto;
			cuenta.Balance = currentBalance;
			Console.WriteLine("Current balance: " + cuenta.Balance);
			return cuenta;
		}

		public Account DepositMoney(Account account, double monto) {
			double currentBalance = account.Balance + monto + 0.20;
			account.Balance = currentBalance;
			Console.WriteLine("Current balance: " + account.Balance);
			return account;
		}

		public void ShowBalance(Account account) {
			Console.WriteLine("Current balance: " + account.Balance);
		}

	}
}