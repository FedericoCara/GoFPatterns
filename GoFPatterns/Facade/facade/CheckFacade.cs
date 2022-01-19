namespace GoFPatterns.Facade {

	public class CheckFacade {

		private FlightAPI avionAPI;
		private HotelAPI hotelAPI;

		public CheckFacade() {
			avionAPI = new FlightAPI();
			hotelAPI = new HotelAPI();
		}

		public void Search(string fechaIda, string fechaVuelta, string origen, string destino) {
			avionAPI.SearchFlights(fechaIda, fechaVuelta, origen, destino);
			hotelAPI.SearchHotels(fechaIda, fechaVuelta, origen, destino);
		}
	}
}