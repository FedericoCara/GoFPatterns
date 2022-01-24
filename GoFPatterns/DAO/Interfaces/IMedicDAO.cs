using GoFPatterns.Shared;

namespace GoFPatterns.DAO {

	public interface IMedicDAO : IPersonDAO , ICRUD<Medic>{
		void Heal();
	}
}