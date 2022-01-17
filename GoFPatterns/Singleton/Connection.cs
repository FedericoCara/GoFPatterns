using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.Singleton
{
    public class Connection
    {
        private static Connection instance;

        private Connection() { }

        public static Connection Instance {
            get {
                if (instance == null)
                    instance = new Connection();
                return instance;
            }
        }

        public void Connect() {
            Console.WriteLine("Connected to DB");
        }

        public void Disconnect() {
            Console.WriteLine("Disconnected from DB");
        }

    }
}
