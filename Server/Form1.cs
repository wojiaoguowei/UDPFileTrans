using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLib;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        /*服务端*/
        SynchronizationContext m_SyncContext = null;
        public Form1()
        {
            InitializeComponent();

            mtbIP.Text = "127.0  .8  .5";
            tbPort.Text = "8848";

            m_SyncContext = SynchronizationContext.Current;
            btnStopTrans.Enabled = false;
            btnSendMsg.Enabled = false;
        }

        private FileRev fileRev = new FileRev();
        private MsgCtrl msg = null;
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
            String ip = mtbIP.Text.Trim().Replace(" ", "");
            String portStr = tbPort.Text.Trim();
            if (Util.checkIP(ip, portStr))
            {
                try
                {
                    msg = new MsgCtrl(ip, Int32.Parse(portStr), 0);
                }catch(Exception ex)
                {
                    MessageBox.Show("请输入有效IP");
                    return;
                }
                ThreadStart st = new ThreadStart(listenMsg);
                Util.newThread(st);

                btnSendMsg.Enabled = true;
            }
            else
            {
                MessageBox.Show("请输入有效地址和端口");
            }
            
        }
        private void listenMsg()
        {
            while (true)
            {
                String[] msgArray = msg.reciveMsg();
                int p = Int32.Parse(msgArray[0]);
                switch (p)
                {
                    case Util.SYS:
                        m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：" + msgArray[1]+ "\r\n");
                        break;
                    case Util.FILEINFO:
                        setAndStartFileinfo(msgArray[1]);
                        break;
                    case Util.USER:
                        m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n用户消息：" + msgArray[1]+ "\r\n");
                        break;
                    case Util.FILESTOP:
                        m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：文件传输终止"+ "\r\n");
                        m_SyncContext.Post(toggleBtnStopEnable, 0);
                        fileRev.stopSend();
                        break;
                    case Util.FILESENDOK:
                        m_SyncContext.Post(toggleBtnStopEnable, 0);
                        m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：文件传输完成" + "\r\n");
                        break;
                    case Util.SYSCONN:
                        m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：" + msgArray[1] + "\r\n");
                        msg.sendMsg("服务器已连接",Util.SYSCONNOK);
                        break;
                }
            }
        }
        private void setAndStartFileinfo(String fileInfo)
        {
            m_SyncContext.Post(toggleBtnStopEnable,0);

            String[] temp = fileInfo.Split('*');
            int randomPort = Util.randomPort();
            UDPServer serverTemp = new UDPServer(msg.hostIP, randomPort);
            msg.sendMsg(randomPort.ToString(),Util.PORT);
            Thread.Sleep(5);
            /*接收到的消息是文件名*文件长度，这里传参是文件名，文件长度*/
            fileRev.reciveFile(serverTemp,temp[0],long.Parse(temp[1]));
            m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：文件传输开始，文件名："+temp[0]+"\r\n");
        }

        private void btnStopTrans_Click(object sender, EventArgs e)
        {
            msg.sendMsg("stopSend", Util.FILESTOP);
            fileRev.stopSend();
            m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：文件传输终止\r\n");
            btnStopTrans.Enabled = false;
        }
        
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            String msgStr = tbMsg.Text.Trim();
            if (!msgStr.Equals(""))
            {
                tbMsg.Text = "";
                msg.sendMsg(msgStr,Util.USER);
                m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n用户消息："+msgStr+ "\r\n");
            }
        }
        /*用于其他线程修改控件*/
        private void appendMsg(object msg)
        {
            tbMsgHistory.Text += (String)msg;
        }
        private void toggleBtnStopEnable(object o)
        {
            if (btnStopTrans.Enabled)
            {
                btnStopTrans.Enabled = false;
            }
            else btnStopTrans.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
