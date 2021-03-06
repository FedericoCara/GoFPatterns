using GoFPatterns.Shared;

namespace GoFPatterns.DAO {
	public interface IPersonDAO : ICRUD<Person> {
		void ShowNames();
	}
}