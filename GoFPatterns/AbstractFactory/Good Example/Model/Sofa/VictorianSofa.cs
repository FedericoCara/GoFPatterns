using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class VictorianSofa : ISofa {
        public int LegCount => 6;

        public float Coziness => 0.95f; 
        
        public void SitOn() {
            Console.WriteLine("Sitting on a victorian sofa");
        }
    }
}
