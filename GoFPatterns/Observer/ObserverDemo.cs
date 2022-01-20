using GoFPatterns.Shared;
using System;

namespace GoFPatterns.Observer {

	public class ObserverDemo : IGoFPatternDemo {

        public void Run() {
			Subject subject = new Subject();

			new LecopObserver(subject);
			new LecorObserver(subject);
			new PataconObserver(subject);

			Console.WriteLine("Setting balance to : 10 usd");
			subject.State = 10;
			Console.WriteLine("-----------------");
			Console.WriteLine("Setting balance to : 100 usd");
			subject.State = 100;
		}
    }
}