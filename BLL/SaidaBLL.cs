using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DTO;
using DAL;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BLL
{
    public class SaidaBLL
    {
        AcessoBancoDados bd;

        public void InserirSaidaVeiculo(SaidaDTO dto)
        { 
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //string comando = "INSERT INTO tb_Patio(localizacao,capacidade) VALUES('" + dto.localizacao + "','" + dto.capacidade + "')";
                //bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Cadastrar Novas Saida de Veiculo.Detalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
        }

        public DataTable SelecionarSaidaVeiculo()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                String comandoSql = "SELECT tb_Estaciona.cod_estaciona, tb_MarcaCarro.num_matricula, tb_PosicaoVaga.num_lugar, tb_EstadoVaga.descr_estadoVaga, tb_Saida.dt_saida, tb_Saida.hs_saida, tb_Saida.qtd_saida, tb_Estaciona.preco, tb_Saida.total_saida, tb_Usuario.nome_usuario FROM tb_Usuario INNER JOIN ((tb_EstadoVaga INNER JOIN tb_PosicaoVaga ON tb_EstadoVaga.cod_estadoVaga = tb_PosicaoVaga.cod_estadoVaga) INNER JOIN (tb_MarcaCarro INNER JOIN (tb_Estaciona INNER JOIN tb_Saida ON tb_Estaciona.cod_estaciona = tb_Saida.cod_estaciona) ON tb_MarcaCarro.cod_carro = tb_Estaciona.cod_carro) ON tb_PosicaoVaga.cod_posicaoVaga = tb_Estaciona.cod_posicaoVaga) ON tb_Usuario.cod_usuario = tb_Saida.cod_usuario";
                dt = bd.RetDataTable(comandoSql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Seleccionar saida de Veiculo.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }


        public OleDbDataReader PesquisarVeiculoPorCodEstaciona(int cod_estaciona)
        {
            OleDbDataReader dr;
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //String comando = "SELECT tb_Estaciona.cod_estaciona, tb_MarcaCarro.num_matricula, tb_PosicaoVaga.num_lugar, tb_EstadoVaga.descr_estadoVaga, tb_Saida.dt_saida, tb_Saida.hs_saida, tb_Saida.qtd_saida, tb_Estaciona.preco, tb_Saida.total_saida, tb_Usuario.nome_usuario FROM tb_Usuario INNER JOIN ((tb_EstadoVaga INNER JOIN tb_PosicaoVaga ON tb_EstadoVaga.cod_estadoVaga = tb_PosicaoVaga.cod_estadoVaga) INNER JOIN (tb_MarcaCarro INNER JOIN (tb_Estaciona INNER JOIN tb_Saida ON tb_Estaciona.cod_estaciona = tb_Saida.cod_estaciona) ON tb_MarcaCarro.cod_carro = tb_Estaciona.cod_carro) ON tb_PosicaoVaga.cod_posicaoVaga = tb_Estaciona.cod_posicaoVaga) ON tb_Usuario.cod_usuario = tb_Saida.cod_usuario WHERE cod_estaciona ="+cod_estaciona+" ";
                String comando = " SELECT tb_MarcaCarro.num_matricula,tb_Estaciona.preco FROM tb_MarcaCarro INNER JOIN tb_Estaciona ON tb_Estaciona.cod_carro = tb_MarcaCarro.cod_carro WHERE tb_MarcaCarro.cod_carro=" + cod_estaciona + " ";
                dr = bd.RetDataReader(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Pesquisar Saida de Veiculo .Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dr;
        }
    }
}
