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

namespace SocketSysOtica
{
    public partial class Socket_Server___DSD_MELO : Form
    {

        int numeroPorta = 8000;
        TcpListener tcpListener;
        TcpClient tcpCliente;
        NetworkStream networkStream;
        Thread thInteraction;

        public Socket_Server___DSD_MELO()
        {
            InitializeComponent();
        }

        private bool connect()
        {
            bool retorno = false;
            try
            {
                tcpListener = new TcpListener(System.Net.IPAddress.Any, numeroPorta);
                tcpListener.Start();
                retorno = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        private void disconnect()
        {

            try
            {
                if (thInteraction != null)
                {
                    if (thInteraction.ThreadState == ThreadState.Running)
                    {
                        thInteraction.Abort();
                    }
                    if (tcpCliente != null)
                        tcpCliente.Client.Disconnect(true);

                    tcpListener.Stop();

                    setMsg("## Conexões perdidas: ...", true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void acceptConection()
        {
            try
            {
                tcpCliente = tcpListener.AcceptTcpClient();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void enviarMsg(string mensagem)
        {

            try
            {
                if (podeEscrever())
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


        private bool podeEscrever()
        {



            if (networkStream == null)
            {
                return false;
            }

            if (networkStream.CanWrite && tcpCliente != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        delegate void delSetMsg(string mensagem, bool burlar);
        private void setMsg(string mensagem, bool burlar)
        {

            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new delSetMsg(setMsg), mensagem, burlar);
                }
                else
                {
                    if (burlar == true || podeEscrever() == true)
                    {
                        rtbConversa.Text += "Eu: " + mensagem + " \n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        delegate void delGetMsg(string mensagem);
        private void getMsg(string mensagem)
        {


            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new delGetMsg(getMsg), mensagem);
                }
                else
                {
                    if (podeEscrever() == true)
                    {
                        rtbConversa.Text += "Cliente: " + mensagem + " \n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void start()
        {


            try
            {
                if (connect())
                {
                    setMsg("## Aguardando uma conexão...", true);
                }

                thInteraction = new Thread(new ThreadStart(interaction));
                thInteraction.IsBackground = true;
                thInteraction.Priority = ThreadPriority.Highest;
                thInteraction.Name = "thInteration";
                thInteraction.Start();
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
                acceptConection();
                setMsg("## Conexão aceita . . .", true);

                do
                {
                    networkStream = tcpCliente.GetStream();

                    if (networkStream.CanRead)
                    {
                        byte[] bytes = new byte[tcpCliente.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(tcpCliente.ReceiveBufferSize));

                        string clientData = Encoding.ASCII.GetString(bytes);

                        if (clientData.Replace("\0", "").Trim() != "")
                        {
                            getMsg(clientData);
                        }
                        else
                        {
                            tcpCliente = null;
                        }
                    }

                } while (tcpCliente != null);

                disconnect();
                start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Socket_Server___DSD_MELO_Load(object sender, EventArgs e)
        {

            try
            {
                start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Socket_Server___DSD_MELO_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                setMsg("## Encerrando conexão com o servidor", true);
                disconnect();
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
                    string mensagem = rtbMensagem.Text;
                    enviarMsg(mensagem);
                    setMsg(mensagem, false);
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
    }
}
