using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hola_Mundo.SocketFiles
{
    

    public partial class Chat : Form
    {
        public Socket clientSocket;
        public string strName;
        private byte[] byteData = new byte[1024];
        Data msgToSend;
        Data msgReceived;

        public Chat()
        {
            InitializeComponent();
        }

        private void bStartHost_Click(object sender, EventArgs e)
        {
            try
            {
                SocketServer SS = new SocketServer();
                tStatus.Text = "Server started!";
                tStatus.ForeColor = Color.DarkGreen;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                strName = txtName.Text;
                this.Text = strName;
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress ipAddress = IPAddress.Parse(txtServerIP.Text);
                //Server is listening on port 1000
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 1000);

                //Connect to the server
                clientSocket.BeginConnect(ipEndPoint, new AsyncCallback(OnConnect), null);

                MessageBox.Show("Connected");

                msgToSend = new Data();
                msgToSend.cmdCommand = Command.List;
                msgToSend.strName = strName;
                msgToSend.strMessage = null;

                byteData = msgToSend.ToByte();

                clientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnSend), null);

                byteData = new byte[1024];

                //Start listening to the data asynchronously
                clientSocket.BeginReceive(byteData,
                                           0,
                                           byteData.Length,
                                           SocketFlags.None,
                                           new AsyncCallback(OnReceive),
                                           null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnSend(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSend(ar);
                strName = txtName.Text;
                DialogResult = DialogResult.OK;

                tStatus.Text = "Connected to Server!";
                tStatus.ForeColor = Color.DarkGreen;
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SGSclient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnConnect(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndConnect(ar);

                //We are connected so we login into the server
                msgToSend = new Data();
                msgToSend.cmdCommand = Command.Login;
                msgToSend.strName = txtName.Text;
                msgToSend.strMessage = null;

                byte[] b = msgToSend.ToByte();

                //Send the message to the server
                clientSocket.BeginSend(b, 0, b.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SGSclient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //clientSocket1.Send(txtMessage.Text.Trim());
                //txtMessage.Clear();

                try
                {
                    //Fill the info for the message to be send
                    msgToSend = new Data();

                    msgToSend.strName = strName;
                    msgToSend.strMessage = txtMessage.Text;
                    msgToSend.cmdCommand = Command.Message;

                    byte[] byteData = msgToSend.ToByte();

                    //Send it to the server
                    clientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnSend), null);

                    txtMessage.Text = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se puede enviar mensaje al Servidor.", "SGSclientTCP: " + strName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //Send a message to logout of the server
                msgToSend = new Data();
                msgToSend.cmdCommand = Command.Logout;
                msgToSend.strName = strName;
                msgToSend.strMessage = null;

                byte[] b = msgToSend.ToByte();
                clientSocket.Send(b, 0, b.Length, SocketFlags.None);
                clientSocket.Close();
            }
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "SGSclientTCP: " + strName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndReceive(ar);

                msgReceived = new Data(byteData);
                //Accordingly process the message received
                switch (msgReceived.cmdCommand)
                {
                    case Command.Login:
                        lstChatters.Items.Add(msgReceived.strName);
                        break;

                    case Command.Logout:
                        lstChatters.Items.Remove(msgReceived.strName);
                        break;

                    case Command.Message:
                        //TODO
                        break;

                    case Command.List:
                        
                        lstChatters.Items.AddRange(msgReceived.strMessage.Split('*'));
                        lstChatters.Items.RemoveAt(lstChatters.Items.Count - 1);
                        txtChatBox.Text += "<<<" + strName + " Ha entrado al Juego>>>\r\n";
                        break;
                }

                if (msgReceived.strMessage != null && msgReceived.cmdCommand != Command.List)
                    txtChatBox.Text += msgReceived.strMessage + "\r\n";

                byteData = new byte[1024];

                clientSocket.BeginReceive(byteData,
                                          0,
                                          byteData.Length,
                                          SocketFlags.None,
                                          new AsyncCallback(OnReceive),
                                          null);

            }
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SGSclientTCP: " + strName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
