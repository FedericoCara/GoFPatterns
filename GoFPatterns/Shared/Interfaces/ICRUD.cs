using System.Collections.Generic;

namespace GoFPatterns.Shared {
	public interface ICRUD<T> {

		List<T> ListAll();
		T GetById(int id);
		void Register(T t);
		void Update(T t);
		void Delete(int id);
	}
}