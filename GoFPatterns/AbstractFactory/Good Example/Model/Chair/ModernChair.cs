using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class ModernChair : IChair {
        public bool HasLegs() {
            return false;
        }

        public void SitOn() {
            Console.WriteLine("Sitting on modern chair");
        }
    }
}
