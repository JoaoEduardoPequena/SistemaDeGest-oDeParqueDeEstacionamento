
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using DTO;

namespace BLL
{
    public class PatioBLL
    {
        AcessoBancoDados bd;

        public void InserirPatioBLL(PatioDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_Patio(localizacao,capacidade) VALUES('"+dto.localizacao+ "','"+dto.capacidade+"')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Novo Patio.Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }

        public DataTable SelecionarPatio()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_Patio");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Pátio.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }


        public DataTable PesquisarPatioPorNome(string localizacao )
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_Patio WHERE localizacao LIKE '%" + localizacao + "%' ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Pesquisar Dados De Pátio.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

        public void AlterarPatioBLL(PatioDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE tb_Patio SET localizacao='" + dto.localizacao + "',capacidade='" + dto.capacidade+ "' Where cod_patio=" + dto.cod_patio+ "  ";
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

        public void ExcluirPatioBLL(PatioDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM tb_Patio  WHERE cod_patio=" + dto.cod_patio+ "  ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Tentar Excluir  Dado do Pátio.Detalhes:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }

    }
}
