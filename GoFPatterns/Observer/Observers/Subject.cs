using System.Collections.Generic;

namespace GoFPatterns.Observer {

	public class Subject {

		private List<BalanceChangedObserver> observers = new List<BalanceChangedObserver>();
		private int state;
		public int State {
			get => state;
			set { 
				state = value;
				NotifyAllObservers();
			}
		}

		public void AddObserver(BalanceChangedObserver observador) {
			observers.Add(observador);
		}

		public void NotifyAllObservers() {
			observers.ForEach(x=>x.Update());
		}

	}
}