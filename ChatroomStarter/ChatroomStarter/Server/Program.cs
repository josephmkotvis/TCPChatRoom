using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server1 = new Server("192.168.0.135");
            server1.Run();
            Console.ReadLine();
        }
    }
}
