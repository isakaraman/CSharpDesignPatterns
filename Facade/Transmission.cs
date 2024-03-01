using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    internal class Transmission
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public Transmission(string protocolName)
        {
            this.Name = protocolName;
        }
        public void SendTransmission()
        {
            Console.WriteLine("Send Transmission");
        }
    }
}
