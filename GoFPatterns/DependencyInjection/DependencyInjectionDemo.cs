using GoFPatterns.Shared;

namespace GoFPatterns.DependencyInjection {

	public class DependencyInjectionDemo : IGoFPatternDemo {
        public void Run() {
			IConnection cx1 = new MySQLConnection("JavierC", "7482", "localhost");

			IConnection cx2 = new PostgreConnection("JorgeC", "7482", "192.168.1.1");

			IPersonDAO dao = new PersonDAOImpl();
			dao.SetConnection(cx1);

			dao.ShowNames();

			dao.SetConnection(cx2);

			dao.ShowNames();
		}
    }
}