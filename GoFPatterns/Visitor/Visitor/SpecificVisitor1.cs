using System;

namespace GoFPatterns.Visitor {
    public class SpecificVisitor1 : IVisitor {
        public void Visitar(string serial) {
            Console.WriteLine(String.Format(" s/n {0}", serial));
        }

    }
}
