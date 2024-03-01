using DesignPatterns.Adapter.DataProccessor;
using DesignPatterns.Adapter.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class NetworkAdapter : INetworkClient
    {
        private readonly IDataProcessor _dataProcessor;

        public NetworkAdapter(IDataProcessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
        }
        public void SendRequest(string ipAddress)
        {
            var apiKey = "3232kskkdskqq";
            _dataProcessor.SendNetworkRequest(ipAddress, apiKey);
        }
    }
}
