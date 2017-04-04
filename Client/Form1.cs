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
using System.IO;

namespace Client
{
    public partial class Form1 : Form
    {
        /*客户端*/
        SynchronizationContext m_SyncContext = null;
        public Form1()
        {
            InitializeComponent();

            mtbIP.Text = "127.0  .8  .5";
            tbIP.Text = "8848";

            m_SyncContext = SynchronizationContext.Current;
            btnStopSend.Enabled = false;
        }
        
        private FileSend fileSend = new FileSend();
        private MsgCtrl msg;
        private String fileName;
        private String filePath;

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
            String ip = mtbIP.Text.Trim().Replace(" ", "");
            String portStr = tbIP.Text.Trim();
            if (Util.checkIP(ip,portStr))
            {
                msg = new MsgCtrl(ip, Int32.Parse(portStr),1);
                msg.sendMsg("客户端连接", Util.SYSMSG);
                ThreadStart ts = new ThreadStart(listenMsg);
                Util.newThread(ts);
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
                    case Util.SYSMSG:
                        m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：" + msgArray[1]+ "\r\n");
                        break;
                    case Util.USERMSG:
                        m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n用户消息：" + msgArray[1]+ "\r\n");
                        break;
                    case Util.PORTMSG:
                        UDPClient clientTemp = new UDPClient(msg.remoteIP, Int32.Parse(msgArray[1]),Util.randomPort()+10, appendMsgAsyc, changeProcessBarAsyc, changelblSentAsyc);
                        sendFile(clientTemp);
                        break;
                    case Util.FILESTOPMSG:
                        stopSend();
                        m_SyncContext.Post(toggleBtn, 0);
                        break;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                String fullPath = openFile.FileName;
                FileInfo f = new FileInfo(openFile.FileName);
                int point = fullPath.LastIndexOf('\\')+1;
                filePath = fullPath.Substring(0, point);
                fileName = fullPath.Substring(point,fullPath.Length-point);

                /*文件信息 文件名*文件长度*/
                msg.sendMsg(fileName + "*" + f.Length, Util.FILEINFOMSG);

                lblFileName.Text = fileName;
                lblFileSize.Text = f.Length.ToString();
                btnStopSend.Enabled = true;
                btnSend.Enabled = false;
            }
        }
        private void sendFile(UDPClient clientTemp)
        {
            fileSend .sendFile(clientTemp, filePath, fileName);
            //Thread.Sleep(99);
            m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：文件 " + fileName + " 传输开始\r\n");
        }
        private void btnStopSend_Click(object sender, EventArgs e)
        {
            stopSend();
            msg.sendMsg("stopSend", Util.FILESTOPMSG);
            toggleBtn(0);
        }
        private void stopSend()
        {
            fileSend.stopSend();
            m_SyncContext.Post(changelblSent, 0);
            m_SyncContext.Post(changeProcessBar, 0);
            m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n系统消息：文件传输终止\r\n");
        }
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            String msgStr = tbMsg.Text.Trim();
            if (!msgStr.Equals(""))
            {
                msg.sendMsg(msgStr, Util.USERMSG);
                //tbMsgHistory.Text +=  DateTime.Now + "\r\n用户消息：" + msg+ "\r\n";
                m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n用户消息：" + msgStr + "\r\n");
            }
        }
        /*用于其他线程修改消息历史控件*/
        private void appendMsg(object msg)
        {
            tbMsgHistory.Text += msg;
        }
        private void changeProcessBar(object value)
        {
            progressBar1.Value = (int)value;

        }
        private void changelblSent(object value)
        {
            lblSentLen.Text = value.ToString();
        }
        private void toggleBtn(object o)
        {
            if (btnStopSend.Enabled)
            {
                btnStopSend.Enabled = false;
            }
            else btnStopSend.Enabled = true;

            if (btnSend.Enabled)
            {
                btnSend.Enabled = false;
            }
            else btnSend.Enabled = true;
        }
        /*用于委托给底层做实时修改*/
        public void appendMsgAsyc()
        {
            String msgStr = "文件传输完成";
            m_SyncContext.Post(appendMsg, DateTime.Now + "\r\n"+msgStr+"\r\n");
            msg.sendMsg(msgStr, Util.FILESENDOK);
            m_SyncContext.Post(toggleBtn, 0);
        }
        /*用于委托给底层做实时修改*/
        public void changeProcessBarAsyc(int value)
        {
            m_SyncContext.Post(changeProcessBar, value);
        }
        public void changelblSentAsyc(int value)
        {
            m_SyncContext.Post(changelblSent, value);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Util.killAllThread();
        }
    }
}
