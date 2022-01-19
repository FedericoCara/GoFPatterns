using GoFPatterns.Shared;

namespace GoFPatterns.Proxy {
	public class ProxyDemo : IGoFPatternDemo {

        public void Run() {
			Account account = new Account(1, "mitocode", 100);

			IAccount proxyAccount = new ProxyAccount(new BankAccountBImplementation());
			proxyAccount.ShowBalance(account);
			account = proxyAccount.DepositMoney(account, 50);
			account = proxyAccount.ExtractMoney(account, 20);
			proxyAccount.ShowBalance(account);
		}
    }
}