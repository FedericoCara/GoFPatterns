using System.Collections.Generic;

namespace GoFPatterns.Memento {

	public class Caretaker {

		private List<Memento> mementos = new List<Memento>();

		public void AddMemento(Memento m) {
			mementos.Add(m);
		}

		public Memento GetMemento(int index) {
			return mementos[index];
		}
	}
}