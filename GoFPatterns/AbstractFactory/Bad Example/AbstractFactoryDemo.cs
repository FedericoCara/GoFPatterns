using GoFPatterns.Shared;
using System;

namespace GoFPatterns.AbstractFactory.BadExample {

	public class AbstractFactoryDemo : IGoFPatternDemo {

        public void Run() {
			AbstractFactory dbFactory = ProducerFactory.GetFactory(FactoryType.DB);
			IDBConnection cxBD1 = dbFactory.GetBD(DBConnectionType.MYSQL);

			cxBD1.Connect();

			AbstractFactory restFactory = ProducerFactory.GetFactory(FactoryType.REST);
			IRESTConnection cxRS1 = restFactory.GetREST(RESTConnectionType.PURCHASES);

			cxRS1.ReadURL("https://www.youtube.com/subscription_center?add_user=mitocode");
		}
    }
}