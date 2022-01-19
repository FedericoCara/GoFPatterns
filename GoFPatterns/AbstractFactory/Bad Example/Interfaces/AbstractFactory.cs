namespace GoFPatterns.AbstractFactory.BadExample {

	public interface AbstractFactory {

		IDBConnection GetBD(DBConnectionType engine = DBConnectionType.EMPTY);
		IRESTConnection GetREST(RESTConnectionType area = RESTConnectionType.EMPTY);
	}
}