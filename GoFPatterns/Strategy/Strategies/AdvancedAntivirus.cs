using System;
using System.Threading;

namespace GoFPatterns.Strategy {

	public class AdvancedAntivirus : AdvancedAnalysis {

		public AdvancedAntivirus(bool hasDelay) {
			this.HasDelay = hasDelay;
		}

		public bool HasDelay {get; set;}

		protected override void Init() {
			Console.WriteLine("Advanced Antivirus - Advanced analysis started");
		}

		protected override void AnalyzeMemory() {
			Console.WriteLine("Analyzing RAM...");
			Thread.Sleep(HasDelay ? 1000 : 0);
		}

		protected override void AnalyzeKeyloggers() {
			Console.WriteLine("Searching for Keyloggers...");
			Thread.Sleep(HasDelay ? 1000 : 0);
		}

		protected override void AnalyzeRootKits() {
			Console.WriteLine("Searching for RootKits...");
			Thread.Sleep(HasDelay ? 1500 : 0);
		}

		protected override void AnalyzeZipFiles() {
			Console.WriteLine("Analyzing zip file...");
			Thread.Sleep(HasDelay ? 2000 : 0);
		}

		protected override void Stop() {
			Console.WriteLine("Advanced Antivirus - Advanced analysis completed");
		}

	}
}