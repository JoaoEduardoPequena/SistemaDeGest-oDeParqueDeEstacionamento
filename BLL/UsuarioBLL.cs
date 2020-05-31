
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DTO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BLL
{
    public class UsuarioBLL
    {
        AcessoBancoDados bd;
        int retorno;
        public void InserirNovos_UsuariosBLL(UsuarioDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_Usuario(nome_usuario,senha_usuario,funcao) VALUES('"+dto.nome_usuario+"','"+dto.senha_usuario+"', '"+dto.funcao_usuario+"')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Novo Usuario.Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }



        public void ExcluirUsuarioBLL(UsuarioDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM tb_Usuario WHERE cod_usuario=" + dto.cod_usuario + " ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Excluir o Usuário. Detalhes: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
        // Metodo Para os Usuários Entrarem No Sistema
        public int Login_UsuarioBLL(UsuarioDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "SELECT * FROM tb_Usuario WHERE (nome_usuario='" + dto.nome_usuario + "' AND senha_usuario='" + dto.senha_usuario + "' )";
                retorno = bd.RetDataTable_Id_Numerico(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Efectuar Login no Sistema.Datalhe:" + ex.Message);
                MessageBox.Show("Erro ao Efectuar Login no Sistema.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return retorno;

        }

        public OleDbDataReader LoginFuncionario(UsuarioDTO dto)
        {
            OleDbDataReader dr = null;
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "SELECT * FROM tb_Usuario WHERE (nome_usuario='" + dto.nome_usuario + "' AND senha_usuario='" + dto.senha_usuario + "' )";
                dr = bd.RetDataReader(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Efectuar Login no Sistema.Datalhe:" + ex.Message);
                MessageBox.Show("Erro ao Efectuar Login no Sistema.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dr;

        }

        public DataTable SelecionarUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_Usuario");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Usuários.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;

        }


        public DataTable PesquisarUsuarioPorCodigo(int codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_Usuario WHERE cod_usuario= " + codigo + " ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Dados do Usuário.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

        public DataTable PesquisarUsuarioPorNome(string nome)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_Usuario WHERE nome_usuario LIKE '%" + nome+ "%' ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Pesquisar Usuario.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

        public void AlterarUsuarioBLL(UsuarioDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE tb_Usuario SET nome_usuario='" + dto.nome_usuario + "',senha_usuario='" + dto.senha_usuario + "',funcao='" + dto.funcao_usuario + "' Where cod_usuario=" + dto.cod_usuario + " ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Tentar Alterar Dado de usuario.Detalhes:" + ex.Message);
            }

            finally
            {
                bd = null;
            }


        }
    }
}
