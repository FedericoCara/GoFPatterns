using System;

namespace GoFPatterns.Observer {

	public class LecopObserver : BalanceChangedObserver {

		public LecopObserver(Subject subject) : base(subject) {
			currencyValue = 3.25f;
		}

		public override void Update() {
			Console.WriteLine("Lecop: " + GetBalanceAsString());
		}

	}

}