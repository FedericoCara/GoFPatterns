using GoFPatterns.Shared;
using System;

namespace GoFPatterns.DAO {

	public class DAODemo : IGoFPatternDemo {

        public void Run() {
			IPersonDAO peopleDao = new PersonDAOImpl();
			peopleDao.ShowNames();

			Person per = new Person();
			per.FullName = "Miti";
			per.Id = 3;
			peopleDao.Register(per);
			peopleDao.Delete(1);

			peopleDao.ShowNames();

			IMedicDAO medicDao = new MedicDAOImpl();
			medicDao.Heal();
		}
    }
}