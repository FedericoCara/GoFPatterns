using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.TemplateMethod {
    public abstract class Verifications {
        protected Client client;

        public string[] Verify() {
            var msg = new List<string>();
            msg.Add($"Verifying Loan for {client.Name}");
            msg.Add(VerifyShares());
            msg.Add(VerifyBalance());
            msg.Add(VerifyCredits());
            msg.Add(VerifyIncome());

            return msg.ToArray();
        }

        protected abstract string VerifyShares();
        protected abstract string VerifyBalance();
        protected abstract string VerifyCredits();
        protected abstract string VerifyIncome();
    }
}