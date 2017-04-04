using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace CommonLib
{
    public class UDPClient
    {
        private IPEndPoint remoteData;
        private String hostIP = "127.0.0.1";
        private int hostPort = 4096;

        private Socket hostData;
        public String remoteIP { get; }
        private int port;
        /*用作停止传输控制*/
        private volatile Boolean canSend = true;

        /*委托方法类型声明*/
        public delegate void AppengMsg();
        public delegate void ChangeProcessBar(int value);
        /*委托实际方法*/
        AppengMsg appendMsg;
        ChangeProcessBar changeProcessBar;
        ChangeProcessBar changlblSent;

        /*针对的文件*/
        public  String fileName { set; get; }
        public  String filePath { get; set; }

        public UDPClient(String remoteIP, int remotePort)
        {
            this.remoteIP = remoteIP;
            this.port = remotePort;
            /*校验 IP地址是否有效，除了越界还有 本机不是该IP的情况*/
            remoteData = new IPEndPoint(IPAddress.Parse(remoteIP), remotePort);
            initSocket(hostPort);
        }
        public UDPClient(String remoteIP, int remotePort,int hostPort,AppengMsg appendMsg,ChangeProcessBar changeProcessBar, ChangeProcessBar changlblSent)
        {
            this.appendMsg = appendMsg;
            this.changeProcessBar = changeProcessBar;
            this.changlblSent = changlblSent;
            this.remoteIP = remoteIP;
            this.port = remotePort;
            /*校验 IP地址是否有效，除了越界还有 本机不是该IP的情况*/
            remoteData = new IPEndPoint(IPAddress.Parse(remoteIP), remotePort);
            initSocket(hostPort);
        }
        public void initSocket(int port)
        {
            hostData = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            hostData.Bind(new IPEndPoint(IPAddress.Parse(hostIP), port));
            //hostMsg = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //hostMsg.Bind(new IPEndPoint(IPAddress.Parse(hostIP), hostPort - 1));
        }
        public void closeSocket()
        {
            hostData.Close();
            //hostMsg.Close();
        }
        public void sendFile()
        {
            System.Console.WriteLine(hostData.ToString()+remoteData.ToString());
            FileStream fs = new FileStream(filePath + fileName, FileMode.Open);

            byte[] byteArray = new byte[1024];
            long count = fs.Length;
            long length = 0;

            int delayOfView = 0;//用作委托界面更新的延迟
            while (byteArray.Length == fs.Read(byteArray, 0, byteArray.Length))
            {
                if (canSend)
                {
                    length += byteArray.Length;
                    sendData(byteArray);
                    Thread.Sleep(1);
                    fs.Seek(length, SeekOrigin.Begin);
                    delayOfView++;
                    if (delayOfView % 1000 == 0)
                    {
                        changeProcessBar((int)((double)length / (double)count * 100.0));
                        changlblSent((int)length);
                    }
                    
                }
                else break;
            }
            if (canSend)
            {
                sendData(byteArray);
                appendMsg();
                changlblSent((int)count);
                changeProcessBar(100);
            }
            //fs.Flush();
            fs.Close();
            Thread.CurrentThread.Abort();
        }
        public void stopSend()
        {
            canSend = false;
        }
        private void sendData(byte[] data)
        {
            hostData.SendTo(data, remoteData);
        }
    }
}
