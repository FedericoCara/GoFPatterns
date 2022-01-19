using GoFPatterns.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.Singleton
{
    public class SingletonPatternDemo : IGoFPatternDemo {

        public void Run() {
            Connection connection = Connection.Instance;
            connection.Connect();
            connection.Disconnect();

            bool isConnection = connection is Connection;
            Console.WriteLine($"connection variable is an instance of Connection? {isConnection}");
        }
    }
}
