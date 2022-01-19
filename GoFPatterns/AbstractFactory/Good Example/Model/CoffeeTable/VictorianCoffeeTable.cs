using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class VictorianCoffeeTable : ICoffeeTable {
        public float Height => 0.5f;
        public void EatOn() {
            Console.WriteLine("Eating on a victorian coffee table");
        }
    }
}
