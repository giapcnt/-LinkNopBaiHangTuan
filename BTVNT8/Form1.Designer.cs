namespace BTVNT8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIpServer = new System.Windows.Forms.TextBox();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIpClient = new System.Windows.Forms.TextBox();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBoxChat = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.txtPortServer);
            this.groupBox1.Controls.Add(this.txtIpServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbIP);
            this.groupBox1.Location = new System.Drawing.Point(24, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.txtIpClient);
            this.groupBox2.Controls.Add(this.txtPortClient);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(455, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.txtMes);
            this.groupBox3.Controls.Add(this.txtBoxChat);
            this.groupBox3.Location = new System.Drawing.Point(24, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(835, 204);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Box Chat";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(29, 23);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(17, 13);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PORT";
            // 
            // txtIpServer
            // 
            this.txtIpServer.Location = new System.Drawing.Point(79, 23);
            this.txtIpServer.Name = "txtIpServer";
            this.txtIpServer.Size = new System.Drawing.Size(173, 20);
            this.txtIpServer.TabIndex = 1;
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(79, 67);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(173, 20);
            this.txtPortServer.TabIndex = 1;
            this.txtPortServer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(299, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 47);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "PORT";
            // 
            // txtIpClient
            // 
            this.txtIpClient.Location = new System.Drawing.Point(92, 20);
            this.txtIpClient.Name = "txtIpClient";
            this.txtIpClient.Size = new System.Drawing.Size(163, 20);
            this.txtIpClient.TabIndex = 1;
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(92, 67);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(163, 20);
            this.txtPortClient.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(283, 33);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 47);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBoxChat
            // 
            this.txtBoxChat.Location = new System.Drawing.Point(7, 20);
            this.txtBoxChat.Multiline = true;
            this.txtBoxChat.Name = "txtBoxChat";
            this.txtBoxChat.Size = new System.Drawing.Size(511, 178);
            this.txtBoxChat.TabIndex = 0;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(554, 19);
            this.txtMes.Multiline = true;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(256, 82);
            this.txtMes.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(645, 123);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 56);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Server_Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.TextBox txtIpServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIpClient;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtBoxChat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

