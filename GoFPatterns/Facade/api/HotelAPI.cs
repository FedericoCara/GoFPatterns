using System;

namespace GoFPatterns.Facade {

	public class HotelAPI {

		public void SearchHotels(string checkInDate, string checkOutDate, string origin, string destination) {
			Console.WriteLine("==============================");
			Console.WriteLine("Found hotels:");
			Console.WriteLine("Check-in: " + checkInDate + " Check-out: " + checkOutDate);
			Console.WriteLine("A Hotel");
			Console.WriteLine("B Hotel");
			Console.WriteLine("C Hotel");
			Console.WriteLine("==============================");
		}

	}
}