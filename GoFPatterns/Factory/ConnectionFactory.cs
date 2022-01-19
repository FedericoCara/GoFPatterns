namespace GoFPatterns.Factory {

	public class ConnectionFactory {

		public IConnection GetConnection(DBConnectionType engine = DBConnectionType.EMPTY) {
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
	}
}