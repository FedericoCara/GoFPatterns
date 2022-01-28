using System;

namespace GoFPatterns.TemplateMethod {
    public class MortgageLoan : Loan {
        public MortgageLoan(Client client) : base(client) {
        }

        protected override string VerifyShares() {
            return "Verifying shares to assign a mortgage loan";
        }

        protected override string VerifyBalance() {
            return "Verifying account balance for a mortgage loan";
        }

        protected override string VerifyCredits() {
            return "Verifying other credits for a mortgage loan";
        }

        protected override string VerifyIncome() {
            return "Verifying income to assign a mortgage loan";
        }
    }
}