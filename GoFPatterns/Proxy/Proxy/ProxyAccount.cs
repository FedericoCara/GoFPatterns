using Microsoft.Extensions.Logging;
using System;

namespace GoFPatterns.Proxy {

	public class ProxyAccount : IAccount {

		private IAccount realAccount;

		public ProxyAccount(IAccount realAccount) {
			this.realAccount = realAccount;
		}

		public Account ExtractMoney(Account account, double amount) {
			Console.WriteLine("----Proxy Account - Extract Money----");
			if (realAccount == null) {
				realAccount = new BankAccountAImplementation();
				return realAccount.ExtractMoney(account, amount);
			} else {
				return realAccount.ExtractMoney(account, amount);
			}
		}

		public Account DepositMoney(Account cuenta, double monto) {
			Console.WriteLine("----Proxy Account - Deposit Money----");
			if (realAccount == null) {
				realAccount = new BankAccountAImplementation();
				return realAccount.DepositMoney(cuenta, monto);
			} else {
				return realAccount.DepositMoney(cuenta, monto);
			}
		}

		public void ShowBalance(Account cuenta) {
			Console.WriteLine("----Proxy Account - Show Balance----");
			if (realAccount == null) {
				realAccount = new BankAccountAImplementation();
				realAccount.ShowBalance(cuenta);
			} else {
				realAccount.ShowBalance(cuenta);
			}
		}

	}
}