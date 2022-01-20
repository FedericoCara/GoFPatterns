namespace GoFPatterns.Observer {

	public abstract class BalanceChangedObserver {

		protected Subject subject;
		protected double currencyValue = 1;
		public abstract void Update();

		public BalanceChangedObserver(Subject subject) {
			this.subject = subject;
			subject.AddObserver(this);
		}
		protected string GetBalanceAsString() {
			return (subject.State * currencyValue).ToString("##.##");
		}

	}
}