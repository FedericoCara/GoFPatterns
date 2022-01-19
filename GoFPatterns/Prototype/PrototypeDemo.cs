using GoFPatterns.Shared;
using System;

namespace GoFPatterns.Prototype {

	public class PrototypeDemo : IGoFPatternDemo {

        public void Run() {
			SavingsAccount savingsAccount = new SavingsAccount();
			savingsAccount.Amount = 200;

			SavingsAccount savingsAccount2 = new SavingsAccount();

			SavingsAccount clonedAccount = (SavingsAccount)savingsAccount.Clone();

			Console.WriteLine(savingsAccount);
			Console.WriteLine(savingsAccount2);
			Console.WriteLine(clonedAccount);
		}
    }
}