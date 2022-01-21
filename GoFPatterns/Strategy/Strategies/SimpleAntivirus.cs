using System;
using System.Threading;

namespace GoFPatterns.Strategy {

	public class SimpleAntivirus : SimpleAnalysis {

		public bool HasDelay { get; set; }

		public SimpleAntivirus(bool hasDelay) {
			this.HasDelay = hasDelay;
		}

		protected override void Init() {
			Console.WriteLine("Simple Antivirus - Simple analysis started");
		}


		protected override void SkipZip() {
			Console.WriteLine("Analyzing...");
			Thread.Sleep(HasDelay ? 2500 : 0);
			Console.WriteLine("Files with '.zip' extension could not be analyzed");
		}


		protected override void Stop() {
			Console.WriteLine("Simple Antivirus - Simple analysis completed");
		}

	}
}