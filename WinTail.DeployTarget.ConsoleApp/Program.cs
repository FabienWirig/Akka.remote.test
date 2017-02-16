using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Configuration;

namespace Wintail.DeployTarget.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var system = ActorSystem.Create("DeployTargetConsoleApp"))
            {
                Console.ReadKey();
            }
        }
    }
}
