using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class NetworkModel
    {
        public string _IP {  get; set; }
        public bool _Success { get; set; }

        public NetworkModel(string IP,bool success)
        {
            _IP=IP;
            _Success = success;
        }
    }
}
