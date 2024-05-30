using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Authenticator auth1 = Authenticator.Instance;
            Authenticator auth2 = Authenticator.Instance;

            Console.WriteLine(auth1 == auth2); // true

            bool isAuthenticated = auth1.Authenticate("admin", "password");
            Console.WriteLine($"Authentication successful: {isAuthenticated}"); // true
            Console.ReadKey();
        }
    }
}
