using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class SendPing : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request._Success == false)
            {
                Console.WriteLine("Send PING failed. Sending ARP");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send PING Success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            this.next = nextChain;
        }
    }
}
