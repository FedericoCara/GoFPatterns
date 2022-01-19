using GoFPatterns.Shared;

namespace GoFPatterns.Factory {

    public class FactoryPatternDemo : IGoFPatternDemo
    {

        public void Run() {
			ConnectionFactory fabrica = new ConnectionFactory();

			IConnection cx1 = fabrica.GetConnection(DBConnectionType.ORACLE);
			cx1.Connect();
			cx1.Disconnect();

			IConnection cx2 = fabrica.GetConnection(DBConnectionType.MYSQL);
			cx2.Connect();
			cx2.Disconnect();

			IConnection cx3 = fabrica.GetConnection();
			cx3.Connect();
			cx3.Disconnect();
		}
    }
}