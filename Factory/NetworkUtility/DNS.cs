using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkUtility
{
    internal class DNS: INetwork
    {
        public void SendRequest(string ip, int timesSent)
        {
            Console.WriteLine("DNS request sent to " + ip + " " + timesSent + " times");
        }
    }
}
