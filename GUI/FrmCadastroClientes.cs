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
    public partial class FrmCadastroClientes : Form
    {
        ClienteBLL clienteBLL = new ClienteBLL();

        ClienteDTO clienteDTO = new ClienteDTO();


        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dataGridView_Clientes.DataSource = clienteBLL.SelecionarCliente();
        }

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (txtCodigoCliente.Text== String.Empty)
            {
                // Código Para Inserir Novo Cliente
                clienteDTO.nome_cli = txtNomeCliente.Text;
                clienteDTO.telef = int.Parse(txtTelefoneCliente.Text);
                clienteBLL.InserirClienteBLL(clienteDTO);
                ActualizarGrid();
                LimparTela();
                MessageBox.Show("Dados de Cliente Cadastrado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }

            else if(txtCodigoCliente.Text.Length>0)
            {
                // Codigo Para Actualizar dados
                clienteDTO.cod_cli = int.Parse(txtCodigoCliente.Text);
                clienteDTO.nome_cli = txtNomeCliente.Text;
                clienteDTO.telef = int.Parse(txtTelefoneCliente.Text);
                clienteBLL.AlterarClienteBLL(clienteDTO);
                LimparTela();
                ActualizarGrid();
                MessageBox.Show("Dados de Cliente Actualizado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }
            
        }

        private void LimparTela()
        {
            txtCodigoCliente.Clear();
            txtNomeCliente.Clear();
            txtTelefoneCliente.Clear();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome;
            if (txtPesquisar.Text != String.Empty)
            {
                nome = txtPesquisar.Text;
                dataGridView_Clientes.DataSource=clienteBLL.PesquisarClientePorNome(nome);
            }

            else
            {
                ActualizarGrid();
            }

        }

        private void dataGridView_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoCliente.Text = dataGridView_Clientes.CurrentRow.Cells[0].Value.ToString();
            txtNomeCliente.Text = (string) dataGridView_Clientes.CurrentRow.Cells[1].Value;
            txtTelefoneCliente.Text= dataGridView_Clientes.CurrentRow.Cells[2].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text==String.Empty) // Verifica se existe caixa de texto txtCodigoCliente está vázio
            {
                MessageBox.Show("Para Excluir Selecciona Uma Linha no data Grid", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          
            // Se a caixa de texto txtCodigoCliente não tiver vazio executa o código abaixo para para Excluir a dado seleccionado no datagridview 
            else
            {
                DialogResult resposta = MessageBox.Show("Tens Certeza que Deseja Excluir Este Dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    clienteDTO.cod_cli = int.Parse(txtCodigoCliente.Text);
                    clienteBLL.ExcluirClienteBLL(clienteDTO);
                    ActualizarGrid();
                    LimparTela();
                    MessageBox.Show("Dados de Cliente Excluido Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else if (resposta == DialogResult.No)
                {
                    MessageBox.Show("Operação Cancelar Pelo Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTela();
                    txtNomeCliente.Focus();
                    return;
                }

                
            }
            
        }

    }
}
