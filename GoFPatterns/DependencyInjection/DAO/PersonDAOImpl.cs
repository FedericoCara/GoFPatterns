using System;
using System.Collections.Generic;

namespace GoFPatterns.DependencyInjection {

	public class PersonDAOImpl : IPersonDAO {

		private IConnection connection;

		List<Person> peopleList;
		protected virtual List<Person> PeopleList => peopleList;

		public void SetConnection(IConnection connection) {
			this.connection = connection;
			Console.WriteLine($"Setting {connection} connection");
		}

		public PersonDAOImpl() {
			FillDB();
		}

		protected virtual void FillDB() {
			peopleList = new List<Person>();
			Person person = new Person();
			person.Id = 1;
			person.FullName = "Pérez";

			peopleList.Add(person);

			person = new Person();
			person.Id = 2;
			person.FullName = "José";

			peopleList.Add(person);

			Console.WriteLine("Loaded stub people DB with 2 people: Pérez and José");
		}

		public List<Person> ListAll() {
			this.connection.Connect();
			Console.WriteLine("Listing...");
			return PeopleList;
		}


		public Person GetById(int id) {
			this.connection.Connect();
			return PeopleList.Find(person => person.Id == id);
		}


		public void Register(Person person) {
			this.connection.Connect();
			Console.WriteLine($"{person.FullName} registered with id={person.Id}");
			PeopleList.Add(person);
		}


		public void Update(Person person) {
			this.connection.Connect();
			if (PeopleList.Contains(person)) {
				int personIndex = PeopleList.IndexOf(person);
				PeopleList[personIndex] = person;
				Console.WriteLine($"Updating {person.FullName} profile");
			} else {
				Console.WriteLine($"{person.FullName} couldn't be found");
			}
		}


		public void Delete(int id) {
			this.connection.Connect();
			if (PeopleList.Exists(person => person.Id == id)) {
				PeopleList.RemoveAll(person => person.Id == id);
				Console.WriteLine($"Deleting person with id={id}");
			} else {
				Console.WriteLine($"Person with id={id} couldn't be found");
			}
		}


		public void ShowNames() {
			this.connection.Connect();
			Console.WriteLine("Listing people's names and ids");
			PeopleList.ForEach(person => Console.WriteLine($"{person.FullName}-{person.Id}"));
		}

	}
}