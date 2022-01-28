using GoFPatterns.ChainOfResponsability;
using GoFPatterns.Command;
using GoFPatterns.Composite;
using GoFPatterns.DAO;
using GoFPatterns.Decorator;
using GoFPatterns.DependencyInjection;
using GoFPatterns.Facade;
using GoFPatterns.Factory;
using GoFPatterns.Memento;
using GoFPatterns.Observer;
using GoFPatterns.Prototype;
using GoFPatterns.Proxy;
using GoFPatterns.Shared;
using GoFPatterns.Singleton;
using GoFPatterns.State;
using GoFPatterns.Strategy;
using GoFPatterns.TemplateMethod;
using GoFPatterns.Visitor;
using System;
using System.Collections.Generic;

namespace GoFPatterns
{
    class Program
    {
        static void Main(string[] args) {
            Invoker demosInvoker = new Invoker();
            demosInvoker.AddOperation(new DemoProxy(new SingletonPatternDemo()));
            demosInvoker.AddOperation(new DemoProxy(new AbstractFactory.BadExample.AbstractFactoryDemo()));
            demosInvoker.AddOperation(new DemoProxy(new AbstractFactory.GoodExample.AbstractFactoryDemo()));
            demosInvoker.AddOperation(new DemoProxy(new PrototypeDemo()));
            demosInvoker.AddOperation(new DemoProxy(new FacadeDemo()));
            demosInvoker.AddOperation(new DemoProxy(new ProxyDemo()));
            demosInvoker.AddOperation(new DemoProxy(new DecoratorDemo()));
            demosInvoker.AddOperation(new DemoProxy(new CommandDemo()));
            demosInvoker.AddOperation(new DemoProxy(new MementoDemo()));
            demosInvoker.AddOperation(new DemoProxy(new ObserverDemo()));
            demosInvoker.AddOperation(new DemoProxy(new StrategyDemo()));
            demosInvoker.AddOperation(new DemoProxy(new DAODemo()));
            demosInvoker.AddOperation(new DemoProxy(new DependencyInjectionDemo()));
            demosInvoker.AddOperation(new DemoProxy(new CompositeDemo()));
            demosInvoker.AddOperation(new DemoProxy(new StateDemo()));
            demosInvoker.AddOperation(new DemoProxy(new VisitorDemo()));
            demosInvoker.AddOperation(new DemoProxy(new ChainOfResponsabilityDemo()));
            demosInvoker.AddOperation(new DemoProxy(new TemplateMethodDemo()));

            demosInvoker.ExecuteAllOperations();
        }
    }
}
