using GoFPatterns.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class AbstractFactoryDemo : IGoFPatternDemo{

        public void Run() {
            List<IFurnitureFactory> furnitureFactories = new List<IFurnitureFactory>{ 
                new ModernFurnitureFactory(),
                new VictorianFurnitureFactory() 
            };
            furnitureFactories.ForEach(furnitureFactory => { 
                furnitureFactory.CreateChair().SitOn();
                furnitureFactory.CreateCoffeeTable().EatOn();
                furnitureFactory.CreateSofa().SitOn();
            });
        }
    }
}
