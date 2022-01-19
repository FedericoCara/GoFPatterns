using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.AbstractFactory.GoodExample {
    public class AbstractFactoryDemo : GoFPatternDemo{

        protected override void OnRun() {
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
