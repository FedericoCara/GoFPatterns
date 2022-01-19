using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.Singleton
{
    public class SingletonPatternDemo : GoFPatternDemo {

        protected override void OnRun() {
            Connection connection = Connection.Instance;
            connection.Connect();
            connection.Disconnect();

            bool isConnection = connection is Connection;
            Console.WriteLine($"connection variable is an instance of Connection? {isConnection}");
        }
    }
}
