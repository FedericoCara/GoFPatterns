using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.Shared {
    public class DemoProxy {

        private IGoFPatternDemo demo;

        public DemoProxy(IGoFPatternDemo demo) {
            this.demo = demo;
        }

        public void Run() {
            Console.WriteLine($"Running {demo.GetType()}");
            demo.Run();
            Console.WriteLine();
        }

    }
}
