using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mod1b_SWmockup
{
    public partial class FormCadastro : Form
    {
        public BindingList<MU> mus = new BindingList<MU>();

        private int nextID = 1; // Começa do 1
        public List<int> meusIDs = new List<int>();
        private UdpClient socketUDP = new UdpClient(0); // Cria na porta disponível
        private IPEndPoint ipDestino = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 12345);
        private Mutex mutex = new Mutex();

        public FormCadastro()
        {
            InitializeComponent();
            AtualizarIDAtual();
        }

        private void AtualizarLista()
        {
            MUs_cadastrados.DataSource = null;
            MUs_cadastrados.DataSource = mus;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MUs_cadastrados.SelectedItem is MU muSelecionado)
            {
                mus.Remove(muSelecionado);
                meusIDs.Remove(muSelecionado.ID);
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Selecione um MU para remover.");
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (MUs_cadastrados.Items.Count >= 10)
            {
                MessageBox.Show("Limite máximo de 10 MUs atingido.");
                return;
            }
            if (textBoxCurto.Text != "")
            {
                int idAtual = nextID;
                string apelido = string.IsNullOrWhiteSpace(textBoxApelido.Text) ? $"MU {idAtual}" : textBoxApelido.Text;
                string descricao = textBoxDescricao.Text;
                double valorCurto = double.Parse(textBoxCurto.Text);
                double tensao = double.Parse(textBoxTensao.Text);
                double corrente = double.Parse(textBoxCorrente.Text);
                int estado = 0;

                MU novoMU = new MU(socketUDP, ipDestino, mutex, nextID, corrente, tensao, apelido, descricao, valorCurto, estado);
                meusIDs.Add(idAtual);
                mus.Add(novoMU);

                nextID++;
                AtualizarLista();
                AtualizarIDAtual();
            }
        }

        private void AtualizarIDAtual()
        {
            labelId.Text = $"ID atual: {nextID}";
        }
        public BindingList<MU> GetMUs()
        {
            return mus;
        }

        private void textBoxCorrente_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }

}


