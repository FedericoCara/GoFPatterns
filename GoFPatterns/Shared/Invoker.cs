using System.Collections.Generic;

namespace GoFPatterns.Shared {

	public class Invoker {

		private List<IOperation> operations = new List<IOperation>();

		public void AddOperation(IOperation operacion) {
			operations.Add(operacion);
		}

		public void ExecuteAllOperations() {
			operations.ForEach(x=>x.Execute());
			operations.Clear();
		}

	}
}