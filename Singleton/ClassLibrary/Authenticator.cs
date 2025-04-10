using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public sealed class Authenticator
    {
        private static Authenticator _instance;
        private static object _lock = new object();

        private Authenticator()
        {
            Console.WriteLine("Authenticator was created!");
        }
        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }
        public void Authenticate(string username, string password)
        {
            Console.WriteLine($"Authenticating user {username}...");
        }
    }
}
