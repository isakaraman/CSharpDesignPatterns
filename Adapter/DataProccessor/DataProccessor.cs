using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.DataProccessor
{
    internal class DataProccessor : IDataProcessor
    {
        public bool DataProcess()
        {
            Console.WriteLine("Processed data");
            return true;
        }

        public void SendNetworkRequest(string ip, string apiKey)
        {
            Console.WriteLine("Send network request with IP adress that requires API key" + ip);
        }
    }
}
