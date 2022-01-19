using System;

namespace GoFPatterns.Command {
	public class Account {

		private int id;
		private double balance;

		public Account(int id, double saldo) {
			this.id = id;
			this.balance = saldo;
		}

		public void Extract(double amount) {
			this.balance = this.balance - amount;
			Console.WriteLine($"[EXTRACT COMMAND] Account: {id}. Balance: {this.balance}");
		}

		public void Deposit(double amount) {
			this.balance = this.balance + amount;
			Console.WriteLine($"[DEPOSIT COMMAND] Account: {id}. Balance: {this.balance}");
		}

	}
}