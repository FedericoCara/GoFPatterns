namespace GoFPatterns.Proxy {

	public interface IAccount {

		Account ExtractMoney(Account cuenta, double monto);
		Account DepositMoney(Account cuenta, double monto);
		void ShowBalance(Account cuenta);
	}
}