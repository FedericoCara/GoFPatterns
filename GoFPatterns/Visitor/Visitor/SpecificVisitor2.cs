using System;

namespace GoFPatterns.Visitor {
    public class SpecificVisitor2 : IVisitor {
        public void Visitar(string serial) {
            Console.WriteLine(String.Format("Serial number is: {0}", serial));
        }
    }
}
