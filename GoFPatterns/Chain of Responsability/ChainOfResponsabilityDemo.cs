using GoFPatterns.Shared;
using Patrones.Chain.Core;
using System;

namespace GoFPatterns.ChainOfResponsability {
    class ChainOfResponsabilityDemo : IGoFPatternDemo {

        public void Run() {
            Handler buyer = new Buyer();
            Handler manager = new Manager();
            Handler director = new Director();
            Handler generalDirector = new GeneralDirector();

            director.AddNext(generalDirector);
            manager.AddNext(director);
            buyer.AddNext(manager);

            var c = new Purchase();
            double importe;
            Random random = new Random();
            for (int i = 0; i < 10; i++) {
                importe = i * i * 100 + random.Next(100);
                Console.WriteLine($"Making a purchase for {importe}");
                c.Price = importe;
                buyer.Process(c);
            }
        }
    }
}
