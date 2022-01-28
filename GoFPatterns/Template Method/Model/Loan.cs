
namespace GoFPatterns.TemplateMethod {
    public abstract class Loan : Verifications {
        public Loan(Client client) {
            base.client = client;
        }

        protected abstract override string VerifyShares();
        protected abstract override string VerifyBalance();
        protected abstract override string VerifyIncome();
        protected abstract override string VerifyCredits();
    }
}