using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLib;
using System.Threading;
using System.IO;

namespace Server
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /* 测试传输文件*/
            /*
            UDPServer c1 = new UDPServer("127.0.0.1", 2048);
            UDPClient c2 = new UDPClient("127.0.0.1", 2048);

            FileSend client = new FileSend(c2, @"I:/", "test1.zip");
            FileInfo fi = new FileInfo(@"I:\" + "test1.zip");
            FileRev server = new FileRev(c1, fi.Length, @"D:/", "test1.zip");
            ThreadStart ts1 = new ThreadStart(client.sendFile);

            ThreadStart ts2 = new ThreadStart(server.reciveFile);
            //Thread t2 = new Thread(ts2);
            Util.newThread(ts1);
            //Thread t1 = new Thread(ts1);
            //t2.Start();
            //t1.Start();
            //server.reciveFile();
            Util.newThread(ts2);
            */
        }
    }
}
