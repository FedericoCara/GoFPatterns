using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class ModernCoffeeTable : ICoffeeTable {
        public float Height => 0.65f;

        public void EatOn() {
            Console.WriteLine("Eating on a modern coffee table");
        }
    }
}
