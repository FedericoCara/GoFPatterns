namespace GoFPatterns.Memento {

	public class Memento {

		private Game state;
		public Game State => state;

		public Memento(Game state) {
			this.state = state;
		}

	}
}