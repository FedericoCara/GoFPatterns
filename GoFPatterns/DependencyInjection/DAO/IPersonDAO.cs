using GoFPatterns.Shared;

namespace GoFPatterns.DependencyInjection {
	public interface IPersonDAO : ICRUD<Person> {

		void ShowNames();
		void SetConnection(IConnection connection);

	}
}