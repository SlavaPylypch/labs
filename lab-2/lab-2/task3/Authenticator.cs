using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Authenticator
    {
        private static readonly Authenticator _instance = new Authenticator();

        private Authenticator()
        {
        }

        static Authenticator()
        {
        }

        public static Authenticator Instance
        {
            get
            {
                return _instance;
            }
        }

        public bool Authenticate(string username, string password)
        {
            return username == "admin" && password == "password";
        }
    }

}
