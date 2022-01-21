using System;

namespace GoFPatterns.Observer {

	public class PataconObserver : BalanceChangedObserver {

		public PataconObserver(Subject subject) : base(subject) {
			currencyValue = 19.07f;
		}

		public override void Update() {
			Console.WriteLine("Patacon: " + GetBalanceAsString());
		}


	}
}