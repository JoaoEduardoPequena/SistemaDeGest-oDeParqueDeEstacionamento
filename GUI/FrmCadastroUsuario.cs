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
    public partial class FrmCadastroUsuario : Form
    {
        UsuarioDTO usuarioDTO = new UsuarioDTO();

        UsuarioBLL usuarioBLL = new UsuarioBLL();

        public FrmCadastroUsuario()
        {
            InitializeComponent();
            ActualizarGrid();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigoUsuario.TextLength == 0)
            {
                usuarioDTO.nome_usuario = txtNomeUsuario.Text;
                usuarioDTO.senha_usuario = txtSenhaUsuario.Text;
                usuarioDTO.funcao_usuario = txtFuncaoUsuario.Text;
                usuarioBLL.InserirNovos_UsuariosBLL(usuarioDTO);
                ActualizarGrid();
                LimarTela();
                MessageBox.Show("Dados de Usuário Inseridos Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if(txtCodigoUsuario.TextLength > 0)
            {
                usuarioDTO.cod_usuario = int.Parse(txtCodigoUsuario.Text);
                usuarioDTO.nome_usuario = txtNomeUsuario.Text;
                usuarioDTO.senha_usuario = txtSenhaUsuario.Text;
                usuarioDTO.funcao_usuario = txtFuncaoUsuario.Text;
                usuarioBLL.AlterarUsuarioBLL(usuarioDTO);
                ActualizarGrid();
                LimarTela();
                MessageBox.Show("Dados de Usuário Actualizado Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

        private void ActualizarGrid() 
        {
            dataGridViewCadUsuario.DataSource = usuarioBLL.SelecionarUsuario();
        }

        private void LimarTela()
        {
           txtCodigoUsuario.Clear();
           txtNomeUsuario.Text="";
           txtSenhaUsuario.Text="";
           txtFuncaoUsuario.Text="";  
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoUsuario.TextLength==0)
            {
                MessageBox.Show("Para Excluir Selecciona Uma Linha no data Grid", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (txtCodigoUsuario.TextLength > 0)
            {
                   DialogResult resposta = MessageBox.Show("Tens Certeza que Deseja Excluir Este Dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   if (resposta==DialogResult.Yes)
                   {
                       usuarioDTO.cod_usuario = int.Parse(txtCodigoUsuario.Text);
                       usuarioBLL.ExcluirUsuarioBLL(usuarioDTO);
                       ActualizarGrid();
                       LimarTela();
                       MessageBox.Show("Dados de Usuário Excluído Com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       return;
                   }

                   else
                   {
                       LimarTela();
                       MessageBox.Show("Operação Cancelar Pelo Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       return;
                   }
                   
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text!= String.Empty)
            {
                 dataGridViewCadUsuario.DataSource = usuarioBLL.PesquisarUsuarioPorNome(txtPesquisar.Text);
            }

            else
            {
                ActualizarGrid();
            }
            
        }

        private void dataGridViewCadUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoUsuario.Text= dataGridViewCadUsuario.CurrentRow.Cells[0].Value.ToString();

            txtNomeUsuario.Text= dataGridViewCadUsuario.CurrentRow.Cells[1].Value.ToString();
           
            txtSenhaUsuario.Text=dataGridViewCadUsuario.CurrentRow.Cells[2].Value.ToString();

            txtFuncaoUsuario.Text = dataGridViewCadUsuario.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
