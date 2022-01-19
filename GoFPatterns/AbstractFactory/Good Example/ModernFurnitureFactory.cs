using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class ModernFurnitureFactory : IFurnitureFactory {
        public IChair CreateChair() {
            return new ModernChair();
        }

        public ICoffeeTable CreateCoffeeTable() {
            return new ModernCoffeeTable();
        }

        public ISofa CreateSofa() {
            return new ModernSofa();
        }
    }
}
