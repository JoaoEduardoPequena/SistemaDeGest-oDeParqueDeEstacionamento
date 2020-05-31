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
    public class ModeloCarroBLL
    {
        AcessoBancoDados bd;

        public void InserirModeloBLL(ModeloCarroDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_ModeloCarro(descr_modelo) VALUES('"+dto.descr_modelo+"')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Novo Modelo de Um Veiculo.Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }

        }
          public DataTable SelecionarModeloCarro()
          {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_ModeloCarro");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar modelo do veiculo.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

           
            public DataTable PesquisarModeloCarroPorNome(string nome)
            {
                DataTable dt = new DataTable();
                try
                {
                    bd = new AcessoBancoDados();
                    bd.Conectar();
                    dt = bd.RetDataTable("SELECT * FROM tb_ModeloCarro WHERE descr_modelo LIKE '%" + nome + "%' ");
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao Tentar Pesquisar  Modelo de Carro.Datalhe:" + ex.Message);
                }

                finally
                {
                    bd = null;
                }
                return dt;
            }

            public void AlterarModeloCarroBLL(ModeloCarroDTO dto)
            {
                try
                {
                    bd = new AcessoBancoDados();
                    bd.Conectar();
                    string comando = "UPDATE tb_ModeloCarro SET descr_modelo='"+dto.descr_modelo+"' Where cod_modelo="+dto.cod_modelo+"  ";
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

            public void ExcluirModeloCarroBLL(ModeloCarroDTO dto)
            {
                try
                {
                    bd = new AcessoBancoDados();
                    bd.Conectar();
                    string comando = "DELETE FROM tb_ModeloCarro  Where cod_modelo=" + dto.cod_modelo+ "  ";
                    bd.ExecutarComandoSQL(comando);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao Tentar Excluir  Dado do Modelo de Carro.Detalhes:" + ex.Message);
                }

                finally
                {
                    bd = null;
                }
            }


            public DataTable PesquisarVeiculoPorNomeModeloVeiculo(string nome_ModeloCarro)
            {
                DataTable dt = new DataTable();
                try
                {
                    bd = new AcessoBancoDados();
                    bd.Conectar();
                    String comando = "SELECT tb_MarcaCarro.cod_carro, tb_MarcaCarro.num_matricula, tb_ModeloCarro.descr_modelo, tb_MarcaCarro.cor_carro, tb_Cliente.nome_cli FROM tb_ModeloCarro INNER JOIN (tb_Cliente INNER JOIN tb_MarcaCarro ON tb_Cliente.cod_cli = tb_MarcaCarro.cod_cli) ON tb_ModeloCarro.cod_modelo = tb_MarcaCarro.cod_modelo WHERE tb_ModeloCarro.descr_modelo LIKE '%" + nome_ModeloCarro + "%' ORDER BY tb_MarcaCarro.cod_carro";
                    //dt = bd.RetDataTable("SELECT tb_MarcaCarro.cod_carro,tb_MarcaCarro.num_matricula,tb_ModeloCarro.descr_modelo,tb_MarcaCarro.cor_carro,tb_MarcaCarro.marca FROM tb_MarcaCarro INNER JOIN tb_ModeloCarro ON tb_MarcaCarro.cod_modelo=tb_ModeloCarro.cod_modelo WHERE tb_MarcaCarro.marca LIKE '%" +nome_ModeloCarro+ "%' ORDER BY tb_MarcaCarro.cod_carro");
                    dt = bd.RetDataTable(comando);
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

    }
}
