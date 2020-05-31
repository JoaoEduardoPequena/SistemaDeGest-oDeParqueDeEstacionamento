using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using DAL;

using System.Data;

namespace BLL
{
    public class MarcaCarroBLL
    {
         AcessoBancoDados bd;
        public void InserirVeiculoBLL(MarcaCarroDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_MarcaCarro(num_matricula,cod_cli,cod_modelo,cor_carro) VALUES('"+dto.num_matricula+"','"+dto.cod_cli+"','"+dto.cod_modelo+"','"+dto.cor_carro+"')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Novo Veiculo.Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }

        public DataTable SelecionarTodoVeiculo()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_MarcaCarro");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar o estado da vaga.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }
        public DataTable SelecionarVeiculo()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //dt = bd.RetDataTable("SELECT tb_MarcaCarro.cod_carro,tb_MarcaCarro.num_matricula,tb_ModeloCarro.descr_modelo,tb_MarcaCarro.marca,tb_MarcaCarro.cor_carro,tb_Cliente.nome_cli FROM tb_MarcaCarro INNER JOIN tb_ModeloCarro ON tb_MarcaCarro.cod_modelo=tb_ModeloCarro.cod_modelo");
                //string comando = "SELECT tb_MarcaCarro.cod_carro,tb_MarcaCarro.num_matricula,tb_Cliente.nome_cli,tb_ModeloCarro.descr_modelo,tb_MarcaCarro.cor_carro,tb_MarcaCarro.marca FROM tb_MarcaCarro INNER JOIN tb_Cliente ON tb_MarcaCarro.cod_cli=tb_Cliente.cod_cli INNER JOIN tb_ModeloCarro ON tb_MarcaCarro.cod_modelo=tb_ModeloCarro.cod_modelo";
                //string comando =" SELECT tb_MarcaCarro.cod_carro,tb_MarcaCarro.num_matricula,tb_ModeloCarro.descr_modelo,tb_MarcaCarro.cor_carro,tb_MarcaCarro.marca,tb_Cliente.nome_cli FROM tb_MarcaCarro INNER JOIN tb_ModeloCarro ON tb_MarcaCarro.cod_modelo=tb_ModeloCarro.cod_modelo INNER JOIN tb_Cliente ON tb_MarcaCarro.cod_cli=tb_Cliente.cod_cli ";
                //string comando="SELECT tb_MarcaCarro.cod_carro,tb_MarcaCarro.num_matricula,tb_ModeloCarro.descr_modelo,tb_MarcaCarro.cor_carro,tb_MarcaCarro.marca FROM tb_MarcaCarro INNER JOIN tb_ModeloCarro ON tb_MarcaCarro.cod_modelo=tb_ModeloCarro.cod_modelo ORDER BY tb_MarcaCarro.cod_carro";
                string comando="SELECT tb_MarcaCarro.cod_carro, tb_MarcaCarro.num_matricula,tb_ModeloCarro.descr_modelo, tb_MarcaCarro.cor_carro, tb_Cliente.nome_cli FROM tb_ModeloCarro INNER JOIN (tb_Cliente INNER JOIN tb_MarcaCarro ON tb_Cliente.cod_cli = tb_MarcaCarro.cod_cli) ON tb_ModeloCarro.cod_modelo = tb_MarcaCarro.cod_modelo ORDER BY tb_MarcaCarro.cod_carro";
                dt = bd.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao Seleccionar  Veículos.Datalhe:" + ex.Message);
                throw new Exception("Erro ao Seleccionar  Veículos.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }


        public DataTable PesquisarVeiculoPorNomeMarca(string nome_MarcaCarro)
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                
                dt = bd.RetDataTable("SELECT tb_MarcaCarro.cod_carro,tb_MarcaCarro.num_matricula,tb_ModeloCarro.descr_modelo,tb_MarcaCarro.cor_carro,tb_MarcaCarro.marca FROM tb_MarcaCarro INNER JOIN tb_ModeloCarro ON tb_MarcaCarro.cod_modelo=tb_ModeloCarro.cod_modelo WHERE tb_MarcaCarro.marca LIKE '%" + nome_MarcaCarro + "%' ORDER BY tb_MarcaCarro.cod_carro");
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

        public void AlterarVeiculoBLL(MarcaCarroDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando ="UPDATE tb_MarcaCarro SET cod_modelo='"+dto.cod_modelo+"',num_matricula='"+dto.num_matricula+"',cor_carro='"+dto.cor_carro+"', cod_cli='"+dto.cod_cli+"' Where cod_carro=" + dto.cod_carro+"  ";
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

        public void ExcluirVeiculoBLL(MarcaCarroDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM tb_MarcaCarro  Where cod_carro="+dto.cod_carro+"  ";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Tentar Excluir  Informação do Veículo.Detalhes:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }
    }
}
