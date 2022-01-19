using GoFPatterns.Shared;
using System;

namespace GoFPatterns.Facade {

	public class FacadeDemo : IGoFPatternDemo {

        public void Run() {
			CheckFacade cliente1 = new CheckFacade();
			cliente1.Search("02/07/2018", "08/07/2018", "Lima", "Cancún");

			CheckFacade cliente2 = new CheckFacade();
			cliente2.Search("02/07/2018", "08/07/2018", "Lima", "Quito");
		}
    }
}