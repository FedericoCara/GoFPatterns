using GoFPatterns.Shared;

namespace GoFPatterns.Decorator {

	public class DecoratorDemo: IGoFPatternDemo {

        public void Run() {
			Account c = new Account(1, "MitoCode");

			IBankAccount account = new SavingsAccount();
			IBankAccount securityAccount = new SecurityDecorator(account);

			//account.OpenAccount(c);
			securityAccount.OpenAccount(c);
		}
    }
}