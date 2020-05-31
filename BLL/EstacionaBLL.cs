using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class EstacionaBLL
    {
        AcessoBancoDados bd;
        
        public void InserirEstacionarBLL(EstacionaDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_Estaciona(cod_posicaoVaga,cod_carro,preco,dt_entrada,hs_entrada,ativo) VALUES('" + dto.cod_posicaoVaga + "','" + dto.cor_carro + "', '" + dto.preco + "','" + dto.dt_entrada + "','" + dto.hs_entrada + "','" + dto.ativo + "')";
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

           public DataTable SelecionarEstaciona()
           {
            DataTable dt = new DataTable();
            try
            {

             bd = new AcessoBancoDados();
             bd.Conectar();
             //String sql = "SELECT tb_Estaciona.cod_estaciona, tb_MarcaCarro.num_matricula, tb_PosicaoVaga.num_lugar, tb_EstadoVaga.descr_estadoVaga, tb_Estaciona.dt_entrada, tb_Estaciona.hs_entrada, tb_Estaciona.ativo, tb_Estaciona.preco, tb_Usuario.nome_usuario FROM tb_Usuario INNER JOIN (tb_MarcaCarro INNER JOIN ((tb_Estaciona INNER JOIN tb_EstadoVaga ON tb_Estaciona.cod_estadoVaga = tb_EstadoVaga.cod_estadoVaga) INNER JOIN tb_PosicaoVaga ON (tb_PosicaoVaga.cod_posicaoVaga = tb_Estaciona.cod_posicaoVaga) AND (tb_EstadoVaga.cod_estadoVaga = tb_PosicaoVaga.cod_estadoVaga)) ON (tb_MarcaCarro.cod_carro = tb_PosicaoVaga.cod_carro) AND (tb_MarcaCarro.cod_carro = tb_Estaciona.cod_carro)) ON tb_Usuario.cod_usuario = tb_Estaciona.cod_usuario";
             //String comando=" SELECT tb_Estaciona.cod_estaciona, tb_MarcaCarro.num_matricula, tb_PosicaoVaga.num_lugar, tb_Estaciona.dt_entrada, tb_Estaciona.hs_entrada, tb_Estaciona.ativo, tb_Estaciona.preco, tb_Usuario.nome_usuario FROM tb_Usuario INNER JOIN ((tb_MarcaCarro INNER JOIN tb_Estaciona ON tb_MarcaCarro.cod_carro = tb_Estaciona.cod_carro) INNER JOIN tb_PosicaoVaga ON (tb_MarcaCarro.cod_carro = tb_PosicaoVaga.cod_carro) AND (tb_PosicaoVaga.cod_posicaoVaga = tb_Estaciona.cod_posicaoVaga)) ON tb_Usuario.cod_usuario = tb_Estaciona.cod_usuario";
             String Sql = "SELECT tb_Estaciona.cod_estaciona, tb_MarcaCarro.num_matricula, tb_PosicaoVaga.num_lugar, tb_EstadoVaga.descr_estadoVaga, tb_Estaciona.dt_entrada, tb_Estaciona.hs_entrada, tb_Estaciona.preco, tb_Estaciona.ativo FROM tb_EstadoVaga INNER JOIN (tb_PosicaoVaga INNER JOIN (tb_MarcaCarro INNER JOIN tb_Estaciona ON tb_MarcaCarro.cod_carro = tb_Estaciona.cod_carro) ON tb_PosicaoVaga.cod_posicaoVaga = tb_Estaciona.cod_posicaoVaga) ON tb_EstadoVaga.cod_estadoVaga = tb_PosicaoVaga.cod_estadoVaga";
             dt = bd.RetDataTable(Sql);
             //dt = bd.RetDataTable("SELECT tb_Estaciona.cod_estaciona,tb_MarcaCarro.num_matricula,tb_PosicaoVaga.num_lugar,tb_Usuario.nome_usuario,tb_Estaciona.dt_entrada,tb_Estaciona.hs_entrada FROM tb_Estaciona INNER JOIN tb_MarcaCarro ON tb_Estaciona.cod_carro=tb_MarcaCarro.cod_carro INNER JOIN tb_Usuario ON tb_Estaciona.cod_usuario=tb_Usuario.cod_usuario INNER JOIN tb_PosicaoVaga ON tb_Estaciona.cod_posicao = tb_Posicao.cod_posicaoVaga ");
             //dt = bd.RetDataTable("SELECT tb_Estaciona.cod_estaciona,tb_MarcaCarro.num_matricula,tb_Estaciona.dt_entrada,tb_Estaciona.hs_entrada FROM tb_Estaciona INNER JOIN tb_MarcaCarro ON tb_Estaciona.cod_carro=tb_MarcaCarro.cod_carro");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar Estaciona.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
          }

           public DataTable PesquisarEstacionarCarroPorCodigo( int cod_estaciona)
           {
               DataTable dt = new DataTable();
               try
               {

                   bd = new AcessoBancoDados();
                   bd.Conectar();
                   String sql = "SELECT tb_Estaciona.cod_estaciona, tb_MarcaCarro.num_matricula, tb_PosicaoVaga.num_lugar, tb_EstadoVaga.descr_estadoVaga, tb_Estaciona.dt_entrada, tb_Estaciona.hs_entrada, tb_Estaciona.preco, tb_Estaciona.ativo FROM tb_EstadoVaga INNER JOIN (tb_PosicaoVaga INNER JOIN (tb_MarcaCarro INNER JOIN tb_Estaciona ON tb_MarcaCarro.cod_carro = tb_Estaciona.cod_carro) ON tb_PosicaoVaga.cod_posicaoVaga = tb_Estaciona.cod_posicaoVaga) ON tb_EstadoVaga.cod_estadoVaga = tb_PosicaoVaga.cod_estadoVaga";
                   //String comando = " SELECT tb_Estaciona.cod_estaciona, tb_MarcaCarro.num_matricula, tb_PosicaoVaga.num_lugar, tb_Estaciona.dt_entrada, tb_Estaciona.hs_entrada, tb_Estaciona.ativo, tb_Estaciona.preco, tb_Usuario.nome_usuario FROM tb_Usuario INNER JOIN ((tb_MarcaCarro INNER JOIN tb_Estaciona ON tb_MarcaCarro.cod_carro = tb_Estaciona.cod_carro) INNER JOIN tb_PosicaoVaga ON (tb_MarcaCarro.cod_carro = tb_PosicaoVaga.cod_carro) AND (tb_PosicaoVaga.cod_posicaoVaga = tb_Estaciona.cod_posicaoVaga)) ON tb_Usuario.cod_usuario = tb_Estaciona.cod_usuario WHERE cod_estaciona="+cod_estaciona+" ";
                   dt = bd.RetDataTable( sql);
                   //dt = bd.RetDataTable("SELECT tb_Estaciona.cod_estaciona,tb_MarcaCarro.num_matricula,tb_PosicaoVaga.num_lugar,tb_Usuario.nome_usuario,tb_Estaciona.dt_entrada,tb_Estaciona.hs_entrada FROM tb_Estaciona INNER JOIN tb_MarcaCarro ON tb_Estaciona.cod_carro=tb_MarcaCarro.cod_carro INNER JOIN tb_Usuario ON tb_Estaciona.cod_usuario=tb_Usuario.cod_usuario INNER JOIN tb_PosicaoVaga ON tb_Estaciona.cod_posicao = tb_Posicao.cod_posicaoVaga ");
                   //dt = bd.RetDataTable("SELECT tb_Estaciona.cod_estaciona,tb_MarcaCarro.num_matricula,tb_Estaciona.dt_entrada,tb_Estaciona.hs_entrada FROM tb_Estaciona INNER JOIN tb_MarcaCarro ON tb_Estaciona.cod_carro=tb_MarcaCarro.cod_carro");

               }
               catch (Exception ex)
               {
                   throw new Exception("Erro ao Seleccionar Estaciona.Datalhe:" + ex.Message);
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
                    string comando = "DELETE FROM tb_Cliente  Where cod_cli=" + dto.cod_cli + "  ";
                    bd.ExecutarComandoSQL(comando);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao Tentar Excluir  Dado do Cliente.Detalhes:" + ex.Message);
                }

                finally
                {
                    bd = null;
                }
            }
    }
}
