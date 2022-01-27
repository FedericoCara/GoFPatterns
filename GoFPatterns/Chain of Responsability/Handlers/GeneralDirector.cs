using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoFPatterns.ChainOfResponsability;

namespace Patrones.Chain.Core {
    public class GeneralDirector : Handler {
        public override void Process(Purchase purchase) {
            Console.WriteLine(string.Format("Purchase aproved by {0}", this.GetType().Name));
        }
    }
}
