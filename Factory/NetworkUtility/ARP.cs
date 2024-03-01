using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkUtility
{
    internal class ARP : INetwork
    {
        public void SendRequest(string ip, int timesSent)
        {
            Console.WriteLine("ARP request sent to " + ip + " " + timesSent + " times");
        }
    }
}
