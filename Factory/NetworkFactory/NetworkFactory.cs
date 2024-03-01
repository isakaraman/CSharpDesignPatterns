using DesignPatterns.Factory.NetworkUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.NetworkFactory
{
    internal class NetworkFactory
    {
        public INetwork GetNetworkInstance(string type)
        {
            INetwork obj = null;
            if (type.ToLower().Equals("ping"))
            {
                obj = new Ping();
            }
            else if (type.ToLower().Equals("arp"))
            {
                obj = new ARP();
            }
            else if (type.ToLower().Equals("dns"))
            {
                obj = new DNS();
            }
            else
            {
                Console.WriteLine("Type not found");
            }
            return obj;
        }
    }
}
