namespace GoFPatterns.Strategy {
	public abstract class AdvancedAnalysis : IStrategy {

		public void Analyze() {
			Init();
			AnalyzeMemory();
			AnalyzeKeyloggers();
			AnalyzeRootKits();
			AnalyzeZipFiles();
			Stop();
		}

		protected abstract void Init();

		protected abstract void AnalyzeMemory();

		protected abstract void AnalyzeKeyloggers();

		protected abstract void AnalyzeRootKits();

		protected abstract void AnalyzeZipFiles();

		protected abstract void Stop();
	}
}