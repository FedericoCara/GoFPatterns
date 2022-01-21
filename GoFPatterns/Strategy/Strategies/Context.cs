namespace GoFPatterns.Strategy {

	public class Context {

		private IStrategy strategy;

		//Dependency Injection
		public Context(IStrategy strategy) {
			this.strategy = strategy;
		}

		public void Execute() {
			strategy.Analyze();
		}

	}
}