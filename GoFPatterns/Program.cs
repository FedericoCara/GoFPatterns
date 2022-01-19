using GoFPatterns.Factory;
using GoFPatterns.Singleton;
using System;

namespace GoFPatterns
{
    class Program
    {
        static void Main(string[] args) {
            new SingletonPatternDemo().Run();
            new FactoryPatternDemo().Run();
            new AbstractFactory.BadExample.AbstractFactoryDemo().Run();
            new AbstractFactory.GoodExample.AbstractFactoryDemo().Run();
        }
    }
}
