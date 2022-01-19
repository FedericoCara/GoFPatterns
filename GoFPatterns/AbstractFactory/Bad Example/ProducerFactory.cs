using System;

namespace GoFPatterns.AbstractFactory.BadExample {

	public class ProducerFactory {

		public static AbstractFactory GetFactory(FactoryType factoryType) {

			switch (factoryType) {
				case FactoryType.DB:
					return new ConnectionDBFactory();
				case FactoryType.REST:
					return new ConnectionRESTFactory();
				default:
					return null;
			}
		}

	}
}