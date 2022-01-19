using GoFPatterns.Shared;
using System;

namespace GoFPatterns.Prototype {
	public class SavingsAccount : ICuenta {

		private string category;
		public string Category {
			get => category;
			set => category = value;
		}

		private double amount;
		public double Amount {
			get => amount;
			set => amount = value;
		}

		public SavingsAccount() {
			category = "SAVINGS";
		}

		public ICuenta Clone() {
			SavingsAccount cuenta = null;

			try {
				cuenta = (SavingsAccount) base.MemberwiseClone();
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}

			return cuenta;
		}

		public override string ToString() {
			return $"SavingsAccount [category={category}, amount={amount}]";
		}
    }
}