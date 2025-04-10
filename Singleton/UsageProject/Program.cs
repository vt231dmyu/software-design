using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => TestSingleton("User1"),
                () => TestSingleton("User2"),
                () => TestSingleton("User3")
            );
        }
        static void TestSingleton(string username)
        {
            Authenticator auth = Authenticator.GetInstance();
            auth.Authenticate(username, "password123");
            Console.WriteLine($"Instance's HashCode: {auth.GetHashCode()}");
        }
    }
}
