using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns
{
    public abstract class GoFPatternDemo
    {
        public void Run() {
            Console.WriteLine($"Running {this.GetType()}");
            OnRun();
            Console.WriteLine();
        }

        protected abstract void OnRun();
        
    }
}
