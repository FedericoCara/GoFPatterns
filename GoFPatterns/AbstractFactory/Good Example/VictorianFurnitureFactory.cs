using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class VictorianFurnitureFactory : IFurnitureFactory {
        public IChair CreateChair() {
            return new VictorianChair();
        }

        public ICoffeeTable CreateCoffeeTable() {
            return new VictorianCoffeeTable();
        }

        public ISofa CreateSofa() {
            return new VictorianSofa();
        }
    }
}
