using System;

namespace GoFPatterns.ChainOfResponsability {
    public class Director : Handler {

        public override void Process(Purchase purchase) {

            if (purchase.Price < 5000)
                Console.WriteLine(string.Format("Purchase aproved by {0}", this.GetType().Name));
            else
                next.Process(purchase);
        }
    }
}