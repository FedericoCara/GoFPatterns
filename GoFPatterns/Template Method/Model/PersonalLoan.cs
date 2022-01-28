using System;

namespace GoFPatterns.TemplateMethod {
    public class PersonalLoan : Loan {
        public PersonalLoan(Client client) : base(client) {
        }

        protected override string VerifyShares() {
            return "It's not neccessary to verify shares for a personal loan";
        }

        protected override string VerifyBalance() {
            return "Verifying account balance for a personal loan";
        }

        protected override string VerifyCredits() {
            return "Verifying other credits for a personal loan";
        }

        protected override string VerifyIncome() {
            return "Verifying income to asign a personal loan";
        }
    }
}