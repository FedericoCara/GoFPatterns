using System;
using System.Collections.Generic;
using System.Text;
using GoFPatterns.Shared;

namespace GoFPatterns.TemplateMethod {
    class TemplateMethodDemo : IGoFPatternDemo {

        private List<Client> clients;
        private List<string> credits;

        public void Run() {
            FillData();

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Process(clients[i], credits[j]);
        }

        private void FillData() {
            clients = new List<Client>();
            clients.Add(new Client() { Name = "Roberto Gómez" });
            clients.Add(new Client() { Name = "Marta Sánchez" });

            credits = new List<string>();
            credits.Add("Personal");
            credits.Add("Mortgage");
        }

        private void Process(Client client, string creditString) {
            Loan Loan;
            switch (creditString) {
                case "Mortgage":
                    Loan = new MortgageLoan(client);
                    break;
                case "Personal":
                    Loan = new PersonalLoan(client);
                    break;
                default:
                    throw new Exception($"Loan {creditString} not managed");
            }
            PrintCreditVerified(client, creditString, Loan.Verify());
        }

        private void PrintCreditVerified(Client client, string loanType, string[] creditVerifiedLogs) {
            Console.WriteLine();
            Console.WriteLine($"{loanType} loan processed for client: {client.Name}");
            Console.WriteLine("Showing logs:");
            foreach (string log in creditVerifiedLogs) {
                Console.WriteLine(log);
            }
        }

    }
}
