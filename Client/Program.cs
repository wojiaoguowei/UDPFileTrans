using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLib;
using System.IO;
using System.Threading;

namespace Client
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
            /*
            UDPServer server = new UDPServer("127.0.1.1", 2048);
            UDPClient client = new UDPClient("127.0.1.1", 2048);

            FileSend fs = new FileSend(client, @"I:/", "22.png");
            FileInfo fi = new FileInfo(@"I:/22.png");
            FileRev fr = new FileRev(server, fi.Length, @"D:/", "22.png");
            //ThreadStart ts1 = new ThreadStart(fr.reciveFile);
            ThreadStart ts2 = new ThreadStart(fs.sendFile);
            //Thread t = new Thread(ts1);
            Thread tt = new Thread(ts2);
            //t.Start();
            tt.Start();
            fr.reciveFile();
            */

            

        }
    }
}
