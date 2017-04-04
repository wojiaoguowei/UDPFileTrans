namespace Server
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
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.MaskedTextBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.mtbIP = new System.Windows.Forms.MaskedTextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.gbMsg = new System.Windows.Forms.GroupBox();
            this.tbMsgHistory = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.gbFileTrans = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStopTrans = new System.Windows.Forms.Button();
            this.gbServer.SuspendLayout();
            this.gbMsg.SuspendLayout();
            this.gbFileTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.tbPort);
            this.gbServer.Controls.Add(this.btnStartServer);
            this.gbServer.Controls.Add(this.mtbIP);
            this.gbServer.Controls.Add(this.lblPort);
            this.gbServer.Controls.Add(this.lblIP);
            this.gbServer.Location = new System.Drawing.Point(12, 12);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(382, 112);
            this.gbServer.TabIndex = 7;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "启动服务器";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(74, 59);
            this.tbPort.Mask = "99999";
            this.tbPort.Name = "tbPort";
            this.tbPort.PromptChar = ' ';
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 6;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(284, 21);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "启动";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // mtbIP
            // 
            this.mtbIP.Location = new System.Drawing.Point(74, 27);
            this.mtbIP.Mask = "999.999.999.999";
            this.mtbIP.Name = "mtbIP";
            this.mtbIP.Size = new System.Drawing.Size(172, 20);
            this.mtbIP.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(25, 56);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(43, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "端口：";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(3, 26);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(65, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "服务器IP：";
            // 
            // gbMsg
            // 
            this.gbMsg.Controls.Add(this.tbMsgHistory);
            this.gbMsg.Controls.Add(this.btnSendMsg);
            this.gbMsg.Controls.Add(this.tbMsg);
            this.gbMsg.Location = new System.Drawing.Point(13, 131);
            this.gbMsg.Name = "gbMsg";
            this.gbMsg.Size = new System.Drawing.Size(381, 173);
            this.gbMsg.TabIndex = 8;
            this.gbMsg.TabStop = false;
            this.gbMsg.Text = "发送消息";
            // 
            // tbMsgHistory
            // 
            this.tbMsgHistory.Location = new System.Drawing.Point(7, 20);
            this.tbMsgHistory.Multiline = true;
            this.tbMsgHistory.Name = "tbMsgHistory";
            this.tbMsgHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMsgHistory.Size = new System.Drawing.Size(351, 118);
            this.tbMsgHistory.TabIndex = 2;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(283, 143);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "发送";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(7, 144);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(269, 20);
            this.tbMsg.TabIndex = 0;
            // 
            // gbFileTrans
            // 
            this.gbFileTrans.Controls.Add(this.btnExit);
            this.gbFileTrans.Controls.Add(this.btnStopTrans);
            this.gbFileTrans.Location = new System.Drawing.Point(13, 311);
            this.gbFileTrans.Name = "gbFileTrans";
            this.gbFileTrans.Size = new System.Drawing.Size(381, 56);
            this.gbFileTrans.TabIndex = 9;
            this.gbFileTrans.TabStop = false;
            this.gbFileTrans.Text = "文件传输";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(254, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStopTrans
            // 
            this.btnStopTrans.Location = new System.Drawing.Point(48, 20);
            this.btnStopTrans.Name = "btnStopTrans";
            this.btnStopTrans.Size = new System.Drawing.Size(75, 23);
            this.btnStopTrans.TabIndex = 0;
            this.btnStopTrans.Text = "停止传输";
            this.btnStopTrans.UseVisualStyleBackColor = true;
            this.btnStopTrans.Click += new System.EventHandler(this.btnStopTrans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(405, 375);
            this.Controls.Add(this.gbServer);
            this.Controls.Add(this.gbMsg);
            this.Controls.Add(this.gbFileTrans);
            this.Name = "Form1";
            this.Text = "服务端";
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.gbMsg.ResumeLayout(false);
            this.gbMsg.PerformLayout();
            this.gbFileTrans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.MaskedTextBox mtbIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.GroupBox gbMsg;
        private System.Windows.Forms.TextBox tbMsgHistory;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.GroupBox gbFileTrans;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStopTrans;
        private System.Windows.Forms.MaskedTextBox tbPort;
    }
}

