using System;

namespace GoFPatterns.Prototype {

	public interface ICuenta {

		string Category { get; set; }
		double Amount { get; set; }
		ICuenta Clone();
	}
}