using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class VictorianChair : IChair {
        public bool HasLegs() {
            return true;
        }

        public void SitOn() {
            Console.WriteLine("Sitting on victorian chair");
        }
    }
}
