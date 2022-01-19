using System;

namespace GoFPatterns.AbstractFactory.BadExample {

	public class ConnectionDBFactory : AbstractFactory {

		public IDBConnection GetBD(DBConnectionType engine) {
				switch (engine) {
					case DBConnectionType.MYSQL:
						return new MySQLConnection();
					case DBConnectionType.ORACLE:
						return new OracleConnection();
					case DBConnectionType.POSTGRE:
						return new PostgreSQLConnection();
					case DBConnectionType.SQLSERVER:
						return new SQLServerConnection();
					default:
						return new EmptyConnection();
				}
		}

        public IRESTConnection GetREST(RESTConnectionType area = RESTConnectionType.EMPTY) {
            throw new NotImplementedException();
        }
    }
}