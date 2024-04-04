using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ChatNetMQ;
using ChatNetMQ.Sockets;

namespace ChatNetMQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chatSourceServer = new ChatSourceServer();
            var chatSourceClient = new ChatSourceClient();

            chatSourceServer.ReceiveMessage("Hello");
            chatSourceClient.ReceiveMessage("Hello");
        }
    }
}

