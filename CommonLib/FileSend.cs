using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonLib
{
    public class FileSend
    {
        private UDPClient client;
        public FileSend()
        {
        }
        public void sendFile(UDPClient client, String filePath, String fileName)
        {
            this.client = client;
            client.fileName = fileName;
            client.filePath = filePath;
            ThreadStart st = new ThreadStart(client.sendFile);
            Thread t = Util.newThread(st);
        }
        public void stopSend()
        {
            client.stopSend();
            client.closeSocket();
        }
    }
}
