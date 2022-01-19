using GoFPatterns.Factory;
using GoFPatterns.Prototype;
using GoFPatterns.Shared;
using GoFPatterns.Singleton;
using System;
using System.Collections.Generic;

namespace GoFPatterns
{
    class Program
    {
        static void Main(string[] args) {
            List<DemoProxy> demos = new List<DemoProxy>();
            demos.Add(new DemoProxy(new SingletonPatternDemo()));
            demos.Add(new DemoProxy(new FactoryPatternDemo()));
            demos.Add(new DemoProxy(new AbstractFactory.BadExample.AbstractFactoryDemo()));
            demos.Add(new DemoProxy(new AbstractFactory.GoodExample.AbstractFactoryDemo()));
            demos.Add(new DemoProxy(new PrototypeDemo()));

            demos.ForEach(demo => demo.Run());
        }
    }
}
