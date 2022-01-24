using GoFPatterns.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoFPatterns.DAO {

	public class MedicDAOImpl : PersonDAOImpl, IMedicDAO {

		List<Person> medicList;
        protected override List<Person> PeopleList => medicList;
        protected List<Medic> MedicList => PeopleList.Cast<Medic>().ToList();

		protected override void FillDB() {
			medicList = new List<Person>();
            Medic person = new Medic();
			person.Id = 3;
			person.FullName = "Raúl";

            medicList.Add(person);

            Console.WriteLine("Loaded stub medic DB with 1 medic: Raúl");
        }

		public void Heal() {
            MedicList.ForEach(medic => medic.Heal());
		}

        public void Register(Medic t) {
            base.Register(t);
        }

        public void Update(Medic t) {
            base.Update(t);
        }

        Medic ICRUD<Medic>.GetById(int id) {
            return (Medic)base.GetById(id);
        }

        List<Medic> ICRUD<Medic>.ListAll() {
            return MedicList;
        }
    }
}