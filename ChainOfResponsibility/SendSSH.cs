using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class SendSSH : IChain
    {
        private IChain next;
        public void SendRequest(NetworkModel request)
        {
            if (request._Success == false)
            {
                Console.WriteLine("Send SHH failed. Sending PING");
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Send SHH Success");
            }
        }

        public void SetNext(IChain nextChain)
        {
            this.next= nextChain;
        }
    }
}
