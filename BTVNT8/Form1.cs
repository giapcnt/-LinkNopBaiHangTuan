using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace BTVNT8
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
                foreach(IPAddress address in localIP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIpServer.Text = address.ToString();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TcpListener lisener = new TcpListener(IPAddress.Any, int.Parse(txtPortServer.Text));
            lisener.Start();
            client = lisener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(txtIpClient.Text),int.Parse(txtPortClient.Text));
            try
            {
                client.Connect(ipEnd);
                if(client.Connected)
                {
                    txtBoxChat.AppendText("Hello," + txtIpClient.Text + " : " + txtPortClient.Text + "\n");
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.txtBoxChat.Invoke(new MethodInvoker(delegate ()
                    {
                        txtBoxChat.AppendText("You:" + recieve + "\n");
                    }
                    ));
                    recieve = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if(client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.txtBoxChat.Invoke(new MethodInvoker(delegate ()
                {
                    txtBoxChat.AppendText("Me:" + TextToSend + "\n");
                }
                ));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtMes.Text!="")
            {
                TextToSend = txtMes.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            txtMes.Text = "";
        }
    }
}
