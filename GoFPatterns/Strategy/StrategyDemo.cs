using GoFPatterns.Shared;
using System;

namespace GoFPatterns.Strategy {

	public class StrategyDemo : IGoFPatternDemo {

        public void Run() {
			Context context = new Context(new AdvancedAntivirus(false));
			context.Execute();
			Console.WriteLine();
			Context context2 = new Context(new SimpleAntivirus(false));
			context2.Execute();
		}
    }
}