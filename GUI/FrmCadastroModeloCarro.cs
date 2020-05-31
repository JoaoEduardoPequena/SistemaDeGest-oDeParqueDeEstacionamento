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
    public partial class FrmCadastroModeloCarro : Form
    {
        ModeloCarroBLL modeloCarroBLL = new ModeloCarroBLL();

        ModeloCarroDTO modeloCarroDTO = new ModeloCarroDTO();


        public FrmCadastroModeloCarro()
        {
            InitializeComponent();
        }

        private void FrmCadastroModeloCarro_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoModeloCarro.Text.Length == 0)
            {
                MessageBox.Show("Nenhum dado foi Seleccionado Para Excluisão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (txtCodigoModeloCarro.Text.Length > 0)
            {
                DialogResult resposta = MessageBox.Show("Tens Certeza que Deseja Excluir Este Dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    modeloCarroDTO.cod_modelo = int.Parse(txtCodigoModeloCarro.Text);
                    modeloCarroDTO.descr_modelo = txtNomeModeloCarro.Text;
                    modeloCarroBLL.ExcluirModeloCarroBLL(modeloCarroDTO);
                    ActualizarGrid();
                    LimparTela();
                    MessageBox.Show("Dados de Modelo do Veículo Excluido Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else if(resposta == DialogResult.No)
                {
                    LimparTela();
                    MessageBox.Show("Operação Cancelar Pelo Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeModeloCarro.Focus();
                    return;
                }
            }

        }

        private void ActualizarGrid()
        {
            dataGridView_ModeloCarro.DataSource = modeloCarroBLL.SelecionarModeloCarro();
        }

        private void LimparTela()
        {
            txtCodigoModeloCarro.Clear();
            txtNomeModeloCarro.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigoModeloCarro.Text.Length==0)
            {
                modeloCarroDTO.descr_modelo = txtNomeModeloCarro.Text;
                modeloCarroBLL.InserirModeloBLL(modeloCarroDTO);
                ActualizarGrid();
                LimparTela();
                MessageBox.Show("Novo Nome de Modelo de Carro Cadastrado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (txtCodigoModeloCarro.Text.Length > 0)
            {
                modeloCarroDTO.cod_modelo = int.Parse(txtCodigoModeloCarro.Text);
                modeloCarroDTO.descr_modelo = txtNomeModeloCarro.Text;
                modeloCarroBLL.AlterarModeloCarroBLL(modeloCarroDTO);
                ActualizarGrid();
                LimparTela();
                txtNomeModeloCarro.Focus();
                MessageBox.Show("Dados de Modelo do Veículo Actualizado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void dataGridView_ModeloCarro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoModeloCarro.Text = dataGridView_ModeloCarro.CurrentRow.Cells[0].Value.ToString();
            txtNomeModeloCarro.Text  = dataGridView_ModeloCarro.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtPesquisarModeloCarro_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarModeloCarro.Text!= String.Empty)
            {
               dataGridView_ModeloCarro.DataSource = modeloCarroBLL.PesquisarModeloCarroPorNome(txtPesquisarModeloCarro.Text);
            }

            else
            {
                ActualizarGrid();
            }

        }
    }
}
