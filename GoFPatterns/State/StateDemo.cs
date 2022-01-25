using GoFPatterns.Shared;
using System;

namespace GoFPatterns.State {
    public class StateDemo : IGoFPatternDemo {

        public void Run() {
            Switch switchInstance = new Switch();
            Console.WriteLine($"New switch created with state: {switchInstance.State}");

            switchInstance.Press();
            switchInstance.Press();
            switchInstance.Press();
            switchInstance.Press();
            switchInstance.Press();
            switchInstance.Press();
        }
    }
}
