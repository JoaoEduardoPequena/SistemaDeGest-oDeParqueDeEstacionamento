using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BLL;

namespace GUI
{
    public partial class FrmCadastroVeiculo : Form
    {
        ClienteBLL clienteBLL = new ClienteBLL();

        ModeloCarroBLL modeloCarroBLL = new ModeloCarroBLL();

        MarcaCarroDTO marcaCarroDTO = new MarcaCarroDTO();

        MarcaCarroBLL marcaCarroBLL = new MarcaCarroBLL();

        public FrmCadastroVeiculo()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodVeiculo.Text.Length==0)
            {
                marcaCarroDTO.num_matricula = txtNumeroMatriculaVeiculo.Text;
                marcaCarroDTO.cod_cli = int.Parse(comboBox_SeleccionarCliente.SelectedValue.ToString());
                marcaCarroDTO.cod_modelo = int.Parse(comboBox_SeleccionarModeloVeiculo.SelectedValue.ToString());
                marcaCarroDTO.cor_carro = txtCorVeiculo.Text;
                

                marcaCarroBLL.InserirVeiculoBLL(marcaCarroDTO);

                ActualizarGrid();
                LimparTela();
                MessageBox.Show("Veiculo Cadastrado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorVeiculo.Focus();
                return;
            }

            else
            {
                if (txtCodVeiculo.Text.Length > 0)
                {
                    marcaCarroDTO.cod_carro= int.Parse(txtCodVeiculo.Text);
                    marcaCarroDTO.num_matricula = txtNumeroMatriculaVeiculo.Text;
                    //marcaCarroDTO.cod_cli = int.Parse(comboBox_SeleccionarCliente.SelectedValue.ToString());
                    marcaCarroDTO.cod_modelo = int.Parse(comboBox_SeleccionarModeloVeiculo.SelectedValue.ToString());
                    marcaCarroDTO.cor_carro = txtCorVeiculo.Text;
                    marcaCarroDTO.cod_cli = int.Parse(comboBox_SeleccionarCliente.SelectedValue.ToString());
                    //marcaCarroDTO.marca = txtMarcaVeiculo.Text;
                    marcaCarroBLL.AlterarVeiculoBLL(marcaCarroDTO);

                    ActualizarGrid();
                    LimparTela();
                    MessageBox.Show("Informação de Veiculo Actualizado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorVeiculo.Focus();
                    return;
                }

                else
                {
                    MessageBox.Show("Deves seleccionar a informação que pretendes alterar","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }
            
        }

        private void CarregarComBox()
        {

            //Carregamento da ComBox de dados do Cliente

            comboBox_SeleccionarCliente.ValueMember = "cod_cli";
            comboBox_SeleccionarCliente.DisplayMember = "nome_cli";
            comboBox_SeleccionarCliente.DataSource = clienteBLL.SelecionarCliente();
            

            //Carregamento da ComBox de dados do Modelo de Veículos

            comboBox_SeleccionarModeloVeiculo.ValueMember = "cod_modelo";
            comboBox_SeleccionarModeloVeiculo.DisplayMember = "descr_modelo";
            comboBox_SeleccionarModeloVeiculo.DataSource = modeloCarroBLL.SelecionarModeloCarro();
        }

        private void ActualizarGrid()
        {
            dataGridView_CadastroVeiculo.DataSource = marcaCarroBLL.SelecionarVeiculo(); 
            
            CarregarComBox();
        }

        private void LimparTela() 
        {
            txtCodVeiculo.Clear();
            txtNumeroMatriculaVeiculo.Clear();
            comboBox_SeleccionarCliente.Text="";
            comboBox_SeleccionarModeloVeiculo.Text="";
            txtCorVeiculo.Clear();
            
        }

        private void FrmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodVeiculo.Text.Length> 0)
            {
                DialogResult resposta = MessageBox.Show("Tens Certeza que Deseja Apagar Esta Informção?", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta==DialogResult.Yes)
                {
                    marcaCarroDTO.cod_carro = int.Parse(txtCodVeiculo.Text);
                    marcaCarroBLL.ExcluirVeiculoBLL(marcaCarroDTO);
                    ActualizarGrid();
                    LimparTela();
                    MessageBox.Show("Informação Apagado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorVeiculo.Focus();
                    return;
                }

                else
                {
                    MessageBox.Show("Operção Cancelada Pelo Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTela();
                    CarregarComBox();
                    txtCorVeiculo.Focus();
                    return;
                }
            }

            else
            {
                MessageBox.Show("Deves selecccionar a informação que pretendes Apagar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dataGridView_CadastroVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodVeiculo.Text = dataGridView_CadastroVeiculo.CurrentRow.Cells["cod_carro"].Value.ToString();
            txtCorVeiculo.Text = dataGridView_CadastroVeiculo.CurrentRow.Cells["cor_carro"].Value.ToString();
            //txtMarcaVeiculo.Text = dataGridView_CadastroVeiculo.CurrentRow.Cells["marca"].Value.ToString();
            txtNumeroMatriculaVeiculo.Text = dataGridView_CadastroVeiculo.CurrentRow.Cells["num_matricula"].Value.ToString();
            comboBox_SeleccionarModeloVeiculo.Text = dataGridView_CadastroVeiculo.CurrentRow.Cells["descr_modelo"].Value.ToString();
            comboBox_SeleccionarCliente.Text = dataGridView_CadastroVeiculo.CurrentRow.Cells["nome_cli"].Value.ToString();
        }

        private void btInserirNovoCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
            frmCadastroClientes.Show();

        }

        private void btInserirNovoModelo_Click(object sender, EventArgs e)
        {
            FrmCadastroModeloCarro frmCadastroModeloCarro = new FrmCadastroModeloCarro();
            frmCadastroModeloCarro.Show();
        }

        private void txtPesquisarPorMarcaVeiculo_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarPorNomeModeloVeiculo.Text!= String.Empty)
            {
                dataGridView_CadastroVeiculo.DataSource = modeloCarroBLL.PesquisarVeiculoPorNomeModeloVeiculo(txtPesquisarPorNomeModeloVeiculo.Text);
            }

            else
            {
              ActualizarGrid();
            }
        }

        private void btLimparTela_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}
