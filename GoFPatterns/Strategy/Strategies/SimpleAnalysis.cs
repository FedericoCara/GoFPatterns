namespace GoFPatterns.Strategy {
	public abstract class SimpleAnalysis : IStrategy {

		public void Analyze() {
			Init();
			SkipZip();
			Stop();
		}

		protected abstract void Init();

		protected abstract void SkipZip();

		protected abstract void Stop();
	}
}