using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNetMQ
{
    public class ChatSourceClient : IMessageSourceClient
    {
        private readonly SubscriberSocket _socket;

        public ChatSourceClient()
        {
            _socket = new SabscriberSocket();
            _socket.Connect();
            _socket.Subscribe("");
            _socket.ReceiveReady += (sender, args) =>
            {
                string message = args.Socket.ReceiveFrameString();
                ReceiveMassage(massage);
            };
        }

        public void ReceiveMessage(string message)
        {
            _socket.SendFrame(message);
        }
    }
}
