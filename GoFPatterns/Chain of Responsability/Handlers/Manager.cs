using System;

namespace GoFPatterns.ChainOfResponsability {
    public class Manager : Handler {
        public override void Process(Purchase purchase) {
            if (purchase.Price <= 1000) {
                Console.WriteLine(string.Format("Purchase aproved by {0}", this.GetType().Name));
            } else {
                next.Process(purchase);
            }
        }
    }
}