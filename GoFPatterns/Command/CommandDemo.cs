using GoFPatterns.Shared;

namespace GoFPatterns.Command {

	public class CommandDemo : IGoFPatternDemo {

        public void Run() {
			Account cuenta = new Account(1, 200);

			DepositImplementation opDepositar = new DepositImplementation(cuenta, 100);
			ExtractImplementation opRetirar = new ExtractImplementation(cuenta, 50);

			Invoker ivk = new Invoker();
			ivk.AddOperation(opDepositar);
			ivk.AddOperation(opRetirar);

			ivk.ExecuteAllOperations();
		}
    }
}