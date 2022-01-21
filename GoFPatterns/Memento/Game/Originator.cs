using System;

namespace GoFPatterns.Memento {

	public class Originator {

		private Game state;
		public Game State {
			get => state;
			set => state = value.CloneGame();
		}

		public Memento Save() {
			Console.WriteLine($"Saved at checkpoint {State.Checkpoint}");
			return new Memento(state);
		}

		public void Load(Memento memento) {
			state = memento.State;
			Console.WriteLine($"Loaded checkpoint {State.Checkpoint}");
		}
	}
}