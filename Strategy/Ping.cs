using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal class Ping : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Sending ping!");
        }
    }
}
