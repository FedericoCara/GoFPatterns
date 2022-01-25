using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFPatterns.Composite {
    public abstract class Component
    {
        private string name;
        public string Name => name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract int Size { get; }

        //Removed these methods from shared class, as they are not usable from File class, breaking Liskov Substitution Principle
        /*public abstract void AddChildComponent(Component component);
        public abstract IList<Component> GetChildrenComponents();*/
    }
}
    