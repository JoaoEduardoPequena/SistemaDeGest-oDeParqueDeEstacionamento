using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;
using System.Windows.Forms;
using System.Data;

namespace BLL
{
    public class ClienteBLL
    {
        AcessoBancoDados bd;
        
        public void InserirClienteBLL(ClienteDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_cliente(nome_cli,telefone) VALUES('"+dto.nome_cli+"','"+dto.telef+"')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Novo Cliente.Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
          }

            public DataTable SelecionarCliente()
            {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_cliente");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Cliente.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
          }


            public DataTable PesquisarClientePorNome(string nome)
            {
                DataTable dt = new DataTable();
                try
                {
                    bd = new AcessoBancoDados();
                    bd.Conectar();
                    dt = bd.RetDataTable("SELECT * FROM tb_Cliente WHERE nome_cli LIKE '%" + nome + "%' ");
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao Pesquisar Cliente.Datalhe:" + ex.Message);
                }

                finally
                {
                    bd = null;
                }
                return dt;
            }

            public void AlterarClienteBLL(ClienteDTO dto)
            {
                try
                {
                    bd = new AcessoBancoDados();
                    bd.Conectar();
                    string comando = "UPDATE tb_Cliente SET nome_cli='"+dto.nome_cli+ "',telefone='" + dto.telef+"' Where cod_cli="+dto.cod_cli+"  ";
                    bd.ExecutarComandoSQL(comando);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao Tentar Alterar Dado de Cliente.Detalhes:" + ex.Message);
                }

                finally
                {
                    bd = null;
                }
            }

            public void ExcluirClienteBLL(ClienteDTO dto)
            {
                try
                {
                    bd = new AcessoBancoDados();
                    bd.Conectar();
                    string comando = "DELETE FROM tb_Cliente  Where cod_cli="+dto.cod_cli+"  ";
                    bd.ExecutarComandoSQL(comando);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao Tentar Excluir  Dado do Cliente.Detalhes:" +ex.Message);
                }

                finally
                {
                    bd = null;
                }
            }
    }
}
