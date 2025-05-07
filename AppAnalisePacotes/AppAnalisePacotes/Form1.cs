using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Diagnostics;


namespace AppAnalisePacotes
{
    public partial class Form1 : Form
    {
        private Thread receiveThread;
        private bool isReceiving = false;
        private UdpClient udpClient;
        private IPEndPoint remoteEndPoint;
        private BindingList<MU> mus = new BindingList<MU>();
        private Thread refreshThread;
        private bool isRefreshing = false;
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            dataGridView1.DataSource = mus;
        }

        private void buttonReceba_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isReceiving)
            {
                buttonReceba.Text = "Parar";
                IniciarReceptor(12345);
            }
            else
            {
                isReceiving = false;
                buttonReceba.Text = "Executar Recebimento";
            }
        }

        private void IniciarReceptor(int porta)
        {
            try
            {
                udpClient = new UdpClient();
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, porta));
                remoteEndPoint = new IPEndPoint(IPAddress.Any, porta);
                isReceiving = true;

                receiveThread = new Thread(ReceberDados);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar UDP: " + ex.Message);
            }
        }

        private void ReceberDados()
        {


            while (isReceiving)
            {
                sw.Start();
                try
                {
                    byte[] receivedBytes = udpClient.Receive(ref remoteEndPoint);
                    string mensagem = Encoding.ASCII.GetString(receivedBytes);
                    string jsonCorrigido = mensagem.Replace("'", "\"");

                    var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonCorrigido);

                    var timestampRaw = dict["timestamp"].GetInt64();

                    DateTime timestamp = DateTime.ParseExact(
                    timestampRaw.ToString("0000000000000000"),
                    "yyyyMMddHHmmssffff",
                    CultureInfo.InvariantCulture
                    );

                    MU mu = new MU
                    {
                        Object = dict.ContainsKey("object") ? dict["object"].GetInt32() : 0,
                        Resource = dict.ContainsKey("resource") ? dict["resource"].GetInt32() : 0,
                        ID = dict.ContainsKey("ied") ? dict["ied"].GetInt32() : 0,
                        Current = dict.ContainsKey("current") ? dict["current"].GetDouble() : 0,
                        Voltage = dict.ContainsKey("voltage") ? dict["voltage"].GetDouble() : 0,
                        Status = dict.ContainsKey("status") ? dict["status"].ToString() : "",
                        Message = dict.ContainsKey("message") ? dict["message"].ToString() : "",
                        Timestamp = timestamp,
                        LatencyMs = (DateTime.Now - timestamp).TotalMilliseconds
                    };

                    var existente = mus.FirstOrDefault(m => m.ID == mu.ID);

                    if (existente != null)
                    {
                        // Atualiza os dados
                        existente.Current = mu.Current;
                        existente.Voltage = mu.Voltage;
                        existente.Status = mu.Status;
                        existente.Message = mu.Message;
                        existente.Timestamp = mu.Timestamp;
                        existente.LatencyMs = mu.LatencyMs;
                    }
                    else
                    {
                        Invoke((MethodInvoker)(() => mus.Add(mu)));
                    }
                    sw.Stop();

                    textBox2.Text = $"Latência: {sw.Elapsed.TotalMilliseconds} ms";

                    dataGridView1.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro geral: " + ex.Message);
                }
            }
        }



        // Código para permitir mover a janela///////////////////////////////////////////////
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int WM_NCHITTEST = 0x84;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point cursor = PointToClient(Cursor.Position);

                int gripSize = 10; // Tamanho da "borda" para resize (ajuste se quiser)

                if (cursor.X >= Width - gripSize && cursor.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (cursor.X <= gripSize && cursor.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (cursor.X <= gripSize && cursor.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (cursor.X >= Width - gripSize && cursor.Y <= gripSize)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (cursor.X <= gripSize)
                    m.Result = (IntPtr)HTLEFT;
                else if (cursor.X >= Width - gripSize)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y <= gripSize)
                    m.Result = (IntPtr)HTTOP;
                else if (cursor.Y >= Height - gripSize)
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void foxLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}