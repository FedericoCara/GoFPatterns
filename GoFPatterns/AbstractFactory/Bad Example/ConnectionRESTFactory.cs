using System;

namespace GoFPatterns.AbstractFactory.BadExample {

	public class ConnectionRESTFactory : AbstractFactory {

		public IRESTConnection GetREST(RESTConnectionType area) {

			switch (area) {
				case RESTConnectionType.SALES:
					return new SalesRESTConnection();
				case RESTConnectionType.PURCHASES:
					return new PurchasesRESTConnection();
				default:
					return new NoAreaRESTConnection();
			}
		}

        public IDBConnection GetBD(DBConnectionType engine = DBConnectionType.EMPTY) {
            throw new NotImplementedException();
        }
    }
}