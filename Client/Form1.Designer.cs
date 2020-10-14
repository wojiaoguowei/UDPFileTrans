namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.gbFileTrans = new System.Windows.Forms.GroupBox();
            this.btnStopSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblSentLen = new System.Windows.Forms.Label();
            this.lblSentLen2 = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFileSize2 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblFileName2 = new System.Windows.Forms.Label();
            this.gbMsg = new System.Windows.Forms.GroupBox();
            this.tbMsgHistory = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.tbIP = new System.Windows.Forms.MaskedTextBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.mtbIP = new System.Windows.Forms.MaskedTextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.gbFileTrans.SuspendLayout();
            this.gbMsg.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 21);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbFileTrans
            // 
            this.gbFileTrans.Controls.Add(this.btnStopSend);
            this.gbFileTrans.Controls.Add(this.btnSend);
            this.gbFileTrans.Controls.Add(this.progressBar1);
            this.gbFileTrans.Controls.Add(this.lblSentLen);
            this.gbFileTrans.Controls.Add(this.lblSentLen2);
            this.gbFileTrans.Controls.Add(this.lblFileSize);
            this.gbFileTrans.Controls.Add(this.lblFileSize2);
            this.gbFileTrans.Controls.Add(this.lblFileName);
            this.gbFileTrans.Controls.Add(this.lblFileName2);
            this.gbFileTrans.Location = new System.Drawing.Point(13, 121);
            this.gbFileTrans.Name = "gbFileTrans";
            this.gbFileTrans.Size = new System.Drawing.Size(381, 114);
            this.gbFileTrans.TabIndex = 8;
            this.gbFileTrans.TabStop = false;
            this.gbFileTrans.Text = "文件传输";
            // 
            // btnStopSend
            // 
            this.btnStopSend.Location = new System.Drawing.Point(205, 57);
            this.btnStopSend.Name = "btnStopSend";
            this.btnStopSend.Size = new System.Drawing.Size(92, 21);
            this.btnStopSend.TabIndex = 8;
            this.btnStopSend.Text = "停止传输";
            this.btnStopSend.UseVisualStyleBackColor = true;
            this.btnStopSend.Click += new System.EventHandler(this.btnStopSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(40, 57);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 21);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "选择文件并发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 14);
            this.progressBar1.TabIndex = 6;
            // 
            // lblSentLen
            // 
            this.lblSentLen.AutoSize = true;
            this.lblSentLen.Location = new System.Drawing.Point(87, 40);
            this.lblSentLen.Name = "lblSentLen";
            this.lblSentLen.Size = new System.Drawing.Size(0, 12);
            this.lblSentLen.TabIndex = 5;
            // 
            // lblSentLen2
            // 
            this.lblSentLen2.AutoSize = true;
            this.lblSentLen2.Location = new System.Drawing.Point(26, 40);
            this.lblSentLen2.Name = "lblSentLen2";
            this.lblSentLen2.Size = new System.Drawing.Size(53, 12);
            this.lblSentLen2.TabIndex = 4;
            this.lblSentLen2.Text = "已传输：";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(280, 18);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(0, 12);
            this.lblFileSize.TabIndex = 3;
            // 
            // lblFileSize2
            // 
            this.lblFileSize2.AutoSize = true;
            this.lblFileSize2.Location = new System.Drawing.Point(197, 18);
            this.lblFileSize2.Name = "lblFileSize2";
            this.lblFileSize2.Size = new System.Drawing.Size(65, 12);
            this.lblFileSize2.TabIndex = 2;
            this.lblFileSize2.Text = "文件大小：";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(87, 18);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 12);
            this.lblFileName.TabIndex = 1;
            // 
            // lblFileName2
            // 
            this.lblFileName2.AutoSize = true;
            this.lblFileName2.Location = new System.Drawing.Point(26, 18);
            this.lblFileName2.Name = "lblFileName2";
            this.lblFileName2.Size = new System.Drawing.Size(53, 12);
            this.lblFileName2.TabIndex = 0;
            this.lblFileName2.Text = "文件名：";
            // 
            // gbMsg
            // 
            this.gbMsg.Controls.Add(this.tbMsgHistory);
            this.gbMsg.Controls.Add(this.btnSendMsg);
            this.gbMsg.Controls.Add(this.tbMsg);
            this.gbMsg.Location = new System.Drawing.Point(408, 11);
            this.gbMsg.Name = "gbMsg";
            this.gbMsg.Size = new System.Drawing.Size(368, 254);
            this.gbMsg.TabIndex = 7;
            this.gbMsg.TabStop = false;
            this.gbMsg.Text = "发送消息";
            // 
            // tbMsgHistory
            // 
            this.tbMsgHistory.Location = new System.Drawing.Point(7, 18);
            this.tbMsgHistory.Multiline = true;
            this.tbMsgHistory.Name = "tbMsgHistory";
            this.tbMsgHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMsgHistory.Size = new System.Drawing.Size(351, 205);
            this.tbMsgHistory.TabIndex = 2;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(282, 229);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 21);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "发送";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(6, 230);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(269, 19);
            this.tbMsg.TabIndex = 0;
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.tbIP);
            this.gbServer.Controls.Add(this.btnStartServer);
            this.gbServer.Controls.Add(this.mtbIP);
            this.gbServer.Controls.Add(this.lblPort);
            this.gbServer.Controls.Add(this.lblIP);
            this.gbServer.Location = new System.Drawing.Point(12, 11);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(382, 103);
            this.gbServer.TabIndex = 6;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "连接服务器";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(75, 52);
            this.tbIP.Mask = "99999";
            this.tbIP.Name = "tbIP";
            this.tbIP.PromptChar = ' ';
            this.tbIP.Size = new System.Drawing.Size(100, 21);
            this.tbIP.TabIndex = 6;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(284, 19);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 21);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "启动";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // mtbIP
            // 
            this.mtbIP.Location = new System.Drawing.Point(74, 25);
            this.mtbIP.Mask = "999.999.999.999";
            this.mtbIP.Name = "mtbIP";
            this.mtbIP.Size = new System.Drawing.Size(172, 21);
            this.mtbIP.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(25, 52);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(41, 12);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "端口：";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(3, 24);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(65, 12);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "服务器IP：";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 276);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbFileTrans);
            this.Controls.Add(this.gbMsg);
            this.Controls.Add(this.gbServer);
            this.Name = "Form1";
            this.Text = "客户端";
            this.gbFileTrans.ResumeLayout(false);
            this.gbFileTrans.PerformLayout();
            this.gbMsg.ResumeLayout(false);
            this.gbMsg.PerformLayout();
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbFileTrans;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblSentLen;
        private System.Windows.Forms.Label lblSentLen2;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileSize2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileName2;
        private System.Windows.Forms.GroupBox gbMsg;
        private System.Windows.Forms.TextBox tbMsgHistory;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.MaskedTextBox mtbIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.MaskedTextBox tbIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnStopSend;
    }
}

