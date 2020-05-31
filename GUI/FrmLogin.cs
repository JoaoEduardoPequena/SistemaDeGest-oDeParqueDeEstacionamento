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
    public partial class FrmLogin : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        UsuarioDTO usuarioDTO = new UsuarioDTO();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretendes Sair da Aplicação", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioDTO.nome_usuario = txtNome.Text;

            usuarioDTO.senha_usuario = txtSenha.Text;

            int retorno = usuarioBLL.Login_UsuarioBLL(usuarioDTO);
            
            if (retorno!=0)
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(usuarioDTO.nome_usuario);
                frmMenuPrincipal.Show();
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Nome ou Senha Inválido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Clear();
                txtSenha.Clear();
                txtNome.Focus();
            }
            
        }
    }
}
