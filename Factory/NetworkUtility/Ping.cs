using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkUtility
{
    internal class Ping: INetwork
    {
        public void SendRequest(string ip,int timesSent)
        {
            Console.WriteLine("Ping request sent to " + ip + " " + timesSent + " times");
        }
    }
}
