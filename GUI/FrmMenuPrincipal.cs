
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace GUI
{
    public partial class FrmMenuPrincipal : Form
    {
        string nome_usuario;

        public FrmMenuPrincipal(string nome)
        {
            InitializeComponent();

            this.nome_usuario = nome.ToUpper();
            
        }

        private void ocuparVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarOcuparVagas frmCadastrarOcuparVagas = new FrmCadastrarOcuparVagas();
            
            frmCadastrarOcuparVagas.Show();
            
            //FrmCadastroOcuparVagas frmOcuparVags = new FrmCadastroOcuparVagas();
            //frmOcuparVags.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2_UsuarioLogado.Text = "Seja Bem Vindo Senhor (a): " +nome_usuario;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            frmCadastroUsuario.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            frmCadastroUsuario.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult resposta= MessageBox.Show("Pretendes Sair da Aplicação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta==DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada Pelo Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
            frmCadastroClientes.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
            frmCadastroClientes.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmCadastroModeloCarro frmCadastroModeloCarro = new FrmCadastroModeloCarro();
            frmCadastroModeloCarro.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroModeloCarro frmCadastroModeloCarro = new FrmCadastroModeloCarro();
            frmCadastroModeloCarro.Show();
        }

        private void patioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPatio frmCadastroPatio = new FrmCadastroPatio();
            frmCadastroPatio.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmCadastroVeiculo frmCadastroVeiculo = new FrmCadastroVeiculo();

            frmCadastroVeiculo.Show();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroVeiculo frmCadastroVeiculo = new FrmCadastroVeiculo();

            frmCadastroVeiculo.Show();
        }

        private void vagasNovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarNovasVaga frmCadastrarNovasVaga = new FrmCadastrarNovasVaga();

            frmCadastrarNovasVaga.Show();
        }

        private void saidaDeVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaidasDeVeiculos frmSaidasDeVeiculos = new FrmSaidasDeVeiculos();
            frmSaidasDeVeiculos.Show();
        } 

    }
}
