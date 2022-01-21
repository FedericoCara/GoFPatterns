using System;

namespace GoFPatterns.Observer {

	public class LecorObserver : BalanceChangedObserver {

		public LecorObserver(Subject subject) : base(subject) {
			currencyValue = 5.59f;
		}

		public override void Update() {
            Console.WriteLine("Lecor: " + GetBalanceAsString());
        }
    }
}