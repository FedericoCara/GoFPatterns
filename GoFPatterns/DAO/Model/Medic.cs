using System;

namespace GoFPatterns.DAO {

	public class Medic : Person {
		public void Heal() {
			Console.WriteLine($"{FullName} is doing some magic healing");
		}
	}
}