using System;

namespace GoFPatterns.Facade {
	public class FlightAPI {

		public void SearchFlights(string departureDate, string arrivalDate, string origin, string destination) {
			Console.WriteLine("==============================");
			Console.WriteLine($"Flights found for {destination} from {origin}");
			Console.WriteLine($"Departure date: {departureDate}. Arrival date: {arrivalDate}");
			Console.WriteLine("==============================");
		}

	}
}