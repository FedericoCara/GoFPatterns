using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class ModernSofa : ISofa {
        public int LegCount => 4;

        public float Coziness => 0.9f;

        public void SitOn() {
            Console.WriteLine("Sitting on a modern sofa");
        }
    }
}
