using GoFPatterns.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFPatterns.Visitor
{
    public class VisitorDemo : IGoFPatternDemo { 

        public void Run() {
            IVisitor visitor2 = new SpecificVisitor2();

            IVisitor visitor1 = new SpecificVisitor1();

            Componente hardDrive = new HardDrive("1231DSFFSD3-DR");
            Componente motherboard = new Motherboard("dkk3nndj12313-PB");
            Componente cpu = new CPU("9393SKKK4K3-P");


            hardDrive.Accept(visitor1);
            motherboard.Accept(visitor1);
            cpu.Accept(visitor1);


            hardDrive.Accept(visitor2);
            motherboard.Accept(visitor2);
            cpu.Accept(visitor2);
        }
    }
}
