using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace SocketSysOticaClient
{
    public partial class Socket_Client___DSD_MELO : Form
    {

        TcpClient tcpClient;
        NetworkStream networkStream;
        Thread thInteraction;


        public Socket_Client___DSD_MELO()
        {
            InitializeComponent();
        }

        private void connect()
        {

            try
            {
                tcpClient = new TcpClient();
                setMsg("## Estabelecendo Conexão...");
                tcpClient.Connect("127.0.0.1", 8000);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void disconnect()
        {
            try
            {
                if (thInteraction != null)
                {
                    if (thInteraction.ThreadState == ThreadState.Running)
                        thInteraction.Abort();
                }

                tcpClient.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void enviarMsg(string mensagem)
        {
            try
            {
                if (networkStream.CanWrite)
                {
                    byte[] sendBytes = Encoding.ASCII.GetBytes(mensagem);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        delegate void delSetMsg(string mensagem);
        private void setMsg(string mensagem)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new delSetMsg(setMsg), mensagem);
                }
                else
                {
                    rtbConversa.Text = "Eu: " + mensagem + " \n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        delegate void delGetMsg(string mensagem);
        private void GetMsg(string mensagem)
        {

            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new delGetMsg(GetMsg), mensagem);
                }
                else
                {
                    rtbConversa.Text = "Server: " + mensagem + " \n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rtbMensagem_KeyDown(object sender, KeyEventArgs e)
        {


            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (networkStream.CanWrite)
                    {
                        string mensagem = rtbMensagem.Text;
                        enviarMsg(mensagem);
                        setMsg(mensagem);
                    }
                    else
                    {
                        setMsg("## Não é possível enviar dados ao servidor...");
                        disconnect();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rtbMensagem_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    rtbMensagem.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void interaction()
        {
            try
            {
                do
                {
                    networkStream = tcpClient.GetStream();
                    if (networkStream.CanRead)
                    {
                        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(tcpClient.ReceiveBufferSize));

                        string returnData = Encoding.ASCII.GetString(bytes);
                        GetMsg(returnData);
                    }
                    else
                    {
                        setMsg("## Não é possível ler os dados  . . . ");
                        disconnect();
                    }

                } while (tcpClient.Connected);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Socket_Client___DSD_MELO_Load(object sender, EventArgs e)
        {
            try
            {
                connect();

                thInteraction = new Thread(new ThreadStart(interaction));
                thInteraction.IsBackground = true;
                thInteraction.Priority = ThreadPriority.Highest;
                thInteraction.Name = "thInteraction";
                thInteraction.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Socket_Client___DSD_MELO_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                disconnect();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}
