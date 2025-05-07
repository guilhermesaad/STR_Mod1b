using System;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Diagnostics;


namespace Mod1b_SWmockup
{
    public class MU
    {
        public int ID { get; set; }
        public string Apelido { get; set; }
        public string Descricao { get; set; }
        public double ValorCurto { get; set; }
        public double Corrente { get; set; }
        public double Tensao { get; set; }
        public int Estado { get; set; }
        public bool ParaEnvio { get; set; }
        public int ContadorPacotesEnviados { get; set; }
        public Mutex NossoMutex { get; set; }
        public UdpClient SocketConexaoUDP { get; set; }
        public IPEndPoint IpConexaoEnvioUDP { get; set; }
        Stopwatch sw = new Stopwatch();
        public event Action<double> LatenciaCalculada;

        // Construtor sem parâmetros
        public MU()
        {
            NossoMutex = new Mutex();
            SocketConexaoUDP = new UdpClient(0); // porta qualquer disponível
            IpConexaoEnvioUDP = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 12345);
            ID = 0;
            Corrente = 0.0;
            Tensao = 0.0;
            Apelido = "Novo MU";
            Descricao = "";
            ValorCurto = 0.0;
            Estado = 0;
            ContadorPacotesEnviados = 0;
            ParaEnvio = false;
        }

        // Construtor parametrizado 
        public MU(UdpClient p_SocketConexaoUDP, IPEndPoint p_IpConexaoEnvioUDP, Mutex p_NossoMutex, int p_ID, double p_Corrente, double p_Tensao, string p_Apelido, string p_Descricao, double p_ValorCurto, int p_Estado)
        {
            SocketConexaoUDP = p_SocketConexaoUDP;
            IpConexaoEnvioUDP = p_IpConexaoEnvioUDP;
            NossoMutex = p_NossoMutex;
            ID = p_ID;
            Corrente = p_Corrente;
            Tensao = p_Tensao;
            Apelido = p_Apelido;
            Descricao = p_Descricao;
            ValorCurto = p_ValorCurto;
            Estado = p_Estado;
            ContadorPacotesEnviados = 0;
            ParaEnvio = false;
        }

        public override string ToString()
        {
            return $"ID {ID} - {Apelido}";
        }

        public void EnviaPacote()
        {
            double valorCorrente = this.Corrente;
            double valorTensao = this.Tensao;
            this.ParaEnvio = false;

            string formatoPacote22_1;
            string formatoPacote22_2;
            string formatoPacote22_3;
            string formatoPacote23_1;
            string formatoPacote23_2;
            string tensao;
            string corrente;
            byte[] bytes;

            double ti = this.Tensao;
            double ci = this.Corrente;


            while (true)
            {
                sw.Start();
                Random rnd = new Random();
                this.Corrente = ci + rnd.Next(-25,26)/ rnd.Next(1, 11);
                this.Tensao = ti +  rnd.Next(-25, 26)/ rnd.Next(1, 11);
                if (this.Corrente <= 0)
                {
                    this.Corrente = 1;
                }
                
                if (this.Tensao <= 0)
                {
                    this.Tensao = 1;
                }
                tensao = Convert.ToString(this.Tensao);
                corrente = Convert.ToString(this.Corrente);
                ContadorPacotesEnviados = (ContadorPacotesEnviados + 1) % 65000;


                if (this.Corrente >= this.ValorCurto && Estado == 1)
                {
                    Estado = 2;
                }
                if (this.Corrente >= this.ValorCurto && Estado == 0)
                {
                    Estado = 1;
                }
                
                if (this.Corrente < this.ValorCurto && Estado == 1)
                {
                    Estado = 0;
                }
                switch (Estado)
                {
                    case 0:// Caso regular        (VERDE)
                        formatoPacote22_1 = "{'object':" + 22 +
                                        ",'resource':" + 1 +
                                        ",'ied':" + ID.ToString() +
                                        ",'current':" + corrente +
                                        ",'voltage':" + tensao +
                                        ",'timestamp':" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssffff") +
                                        ",'status':''" +
                                        ",'message':''"
                                        + "}";

                        bytes = Encoding.ASCII.GetBytes(formatoPacote22_1);

                        NossoMutex.WaitOne();
                        if (SocketConexaoUDP != null)
                            SocketConexaoUDP.Send(bytes, bytes.Length, IpConexaoEnvioUDP);
                        NossoMutex.ReleaseMutex();

                        if (ParaEnvio)
                            return;

                        Thread.Sleep(10);
                        break;

                    case 1:// Caso atenção        (AMARELO)
                        formatoPacote22_2 = "{'object':" + 22 +
                                        ",'resource':" + 2 +
                                        ",'ied':" + ID.ToString() +
                                        ",'current':" + corrente +
                                        ",'voltage':" + tensao +
                                        ",'timestamp':" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssffff") +
                                        ",'status':'alarm'" +
                                        ",'message':'Mudanca brusca de corrente detectada'" +
                                        "}";
                        bytes = Encoding.ASCII.GetBytes(formatoPacote22_2);

                        NossoMutex.WaitOne();
                        if (SocketConexaoUDP != null)
                            SocketConexaoUDP.Send(bytes, bytes.Length, IpConexaoEnvioUDP);
                        NossoMutex.ReleaseMutex();

                        if (ParaEnvio)
                            return;
                        Thread.Sleep(1);

                        break;
                    case 2:// Caso alarme         (VERMELHO)
                        formatoPacote22_3 = "{'object':" + 22 +
                                        ",'resource':" + 3 +
                                        ",'ied':" + ID.ToString() +
                                        ",'current':" + corrente +
                                        ",'voltage':" + tensao +
                                        ",'timestamp':" + DateTimeOffset.Now.ToString("yyyyMMddHHmmssffff") +
                                        ",'status':'change'" +
                                        ",'message':'Mudanca significativa detectada.'" +
                                        "}";
                        bytes = Encoding.ASCII.GetBytes(formatoPacote22_3);

                        NossoMutex.WaitOne();
                        if (SocketConexaoUDP != null)
                            SocketConexaoUDP.Send(bytes, bytes.Length, IpConexaoEnvioUDP);
                        NossoMutex.ReleaseMutex();

                        if (ParaEnvio)
                            return;
                        Thread.Sleep(1);
                        break;
                
                }
                sw.Stop();
                System.Diagnostics.Debug.WriteLine(sw.Elapsed.TotalMilliseconds);
            }
        }
    }
}
