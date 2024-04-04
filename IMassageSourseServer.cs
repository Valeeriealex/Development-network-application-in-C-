using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatNetMQ
{
    public interface IMassageSourseServer
    {
        void SendMessage(string message);
    }
}
