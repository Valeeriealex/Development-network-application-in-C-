using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNetMQ
{
    internal class ChatSourceServer : IMassageSourseServer
    {
        private readonly PublisherSocket _soket;

        public ChatSourceServer()
        {
            _soket = new PublisherSocket();
            _soket.Bind("адрес");
        }

        public void SendMessage(string message)
        {
            _soket.SendFrame(message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
