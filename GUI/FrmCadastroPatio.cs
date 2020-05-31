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
    public partial class FrmCadastroPatio : Form
    {
        PatioDTO patioDTO = new PatioDTO();

        PatioBLL patioBLL = new PatioBLL();

        public FrmCadastroPatio()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigoPatio.Text.Length== 0)
            {
                patioDTO.localizacao = txtLocalizacaoPatio.Text;
                patioDTO.capacidade = int.Parse(txtCapacidadePatio.Text);
                patioBLL.InserirPatioBLL(patioDTO);
                ActualizarGrid();
                LimparTela();
                MessageBox.Show("Dados Inseridos Com Sucesso"," Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else if(txtCodigoPatio.TextLength > 0 )
            {
                patioDTO.cod_patio= int.Parse(txtCodigoPatio.Text);
                patioDTO.localizacao = txtLocalizacaoPatio.Text;
                patioDTO.capacidade = int.Parse(txtCapacidadePatio.Text);
                patioBLL.AlterarPatioBLL(patioDTO);
                ActualizarGrid();
                LimparTela();
                MessageBox.Show("Dados Actualizado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void ActualizarGrid()
        {
            dataGridView_CadastroPatio.DataSource = patioBLL.SelecionarPatio();
        }

        private void LimparTela()
        {
          txtCodigoPatio.Clear();
          txtLocalizacaoPatio.Clear();
          txtCapacidadePatio.Clear();
        }

        private void dataGridView_CadastroPatio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPatio.Text = dataGridView_CadastroPatio.CurrentRow.Cells[0].Value.ToString();
            txtLocalizacaoPatio.Text = dataGridView_CadastroPatio.CurrentRow.Cells[1].Value.ToString();
            txtCapacidadePatio.Text = dataGridView_CadastroPatio.CurrentRow.Cells[2].Value.ToString();
        }

        private void FrmCadastroPatio_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void txtPesquisarPatio_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarPatio.Text!= String.Empty)
            {
               dataGridView_CadastroPatio.DataSource= patioBLL.PesquisarPatioPorNome(txtPesquisarPatio.Text);
            }

            else
            {
               ActualizarGrid();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoPatio.Text.Length>0)
            {
                 DialogResult resposta = MessageBox.Show("Tens Certeza que Deseja Excluir Este Dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (resposta==DialogResult.Yes)
                 {
                     patioDTO.cod_patio = int.Parse(txtCodigoPatio.Text);
                     patioBLL.ExcluirPatioBLL(patioDTO);
                     ActualizarGrid();
                     LimparTela();
                     MessageBox.Show("Dado Apagado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }

                 else
                 {
                     MessageBox.Show("Operação Cancelada Pelo Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     LimparTela();
                     txtLocalizacaoPatio.Focus();
                     return;
                 }
            }

            else if( txtCodigoPatio.Text.Length==0)
            {
                MessageBox.Show("Para Excluir Selecciona Uma Linha no data Grid", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        }
    }

