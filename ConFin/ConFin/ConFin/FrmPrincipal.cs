using ConFin.Controlador;
using ConFin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void buttonConexao_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexao = Conexao.getConexao();
            if(conexao != null)
            {
                MessageBox.Show("Conexão OK");
            }
            conexao.Close();
        }

        private void buttonExecuta_Click(object sender, EventArgs e)
        {
            List<Estado> lista = EstadoDB.getEstados();
            richTextBox1.Clear();
            for(int i =0; i < lista.Count; i++)
            {
                Estado estado = lista[i];
                richTextBox1.AppendText("Sigla: " + estado.est_sigla +
                                        " Nome: " + estado.nome + "\n");
            }
        }

        private void buttonInclui_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado("TO", "Tocantins");
            bool efetuou = EstadoDB.setIncluiEstado(estado);
            if (efetuou)
            {
                MessageBox.Show("Estado incluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao incluir estado!");
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado("SC", "Santa Luzia");
            bool efetuou = EstadoDB.setAlteraEstado(estado);
            if (efetuou)
            {
                MessageBox.Show("Estado alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar o estado!");
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string sigla = "TO";
            bool efetuou = EstadoDB.setExcluiEstado(sigla);
            if (efetuou)
            {
                MessageBox.Show("Estado excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir o estado!");
            }
        }
    }
}
