using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonLib
{
    public static class Util
    {
        public const int SYSMSG = 0;
        public const int FILEINFOMSG = 1;
        public const int FILESTOPMSG = 2;
        public const int USERMSG = 3;
        public const int PORTMSG = 4;
        public const int FILESENDOK = 5;

        private static int port = 1030;
        private static List<Thread> threadList = new List<Thread>();
        public static Boolean checkIP(String ip, String port)
        {
            int portInt = Int32.Parse(port);
            if (portInt >= 65535 || portInt < 1024) return false;
            String[] tempIp = ip.Split('.');
            foreach (String s in tempIp)
            {
                int i = Int32.Parse(s.Trim());
                if (i < 0 || i > 255) return false;
            }
            return true;
        }
        public static Thread newThread(ThreadStart st)
        {
            Thread t = new Thread(st);
            t.Start();
            threadList.Add(t);
            return t;
        }
        public static void killThread(Thread t)
        {
            t.Abort();
        }
        public static void killAllThread()
        {
            List<Thread>.Enumerator it=threadList.GetEnumerator();
            while (it.MoveNext())
            {
                Thread t = it.Current;
                if (t != null && t.IsAlive) t.Abort();
            }
            threadList = null;
        }
        public static int randomPort()
        {
            Random r = new Random(port);
            port = r.Next(1030,65530);
            return port;
        }

    }
}
