using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

using DTO;
using DAL;

//using MySql.Data.MySqlClient;

namespace BLL
{
    public class PosicaoVagaBLL
    {
        OleDbDataReader dr;

        AcessoBancoDados bd;

        public void OcuparVagaBLL(PosicaoVagaDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_PosicaoVaga(cod_estadoVaga,cod_carro) VALUES('"+dto.cod_estadoVaga+"','"+dto.cod_carro+"')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                //throw new Exception("Erro ao Inserir Paciente. Detalhe:"+ ex.Message);
                MessageBox.Show("Erro ao Inserir Nova Vaga.Detalhe:"   +ex.Message);
            }

            finally
            {
                bd = null;
            }
        }

        public DataTable SelecionarOcuparVagaPorNumeroBLL(int numero_lugar)
        {
            DataTable dt = new DataTable();  
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT tb_PosicaoVaga.cod_posicaoVaga,tb_PosicaoVaga.cod_estadoVaga,tb_posicaoVaga.num_lugar FROM tb_PosicaoVaga INNER JOIN tb_EstadoVaga ON tb_PosicaoVaga.cod_estadoVaga=tb_EstadoVaga.cod_estadoVaga WHERE cod_posicaoVaga=" + numero_lugar + " ");
                //dr = bd.RetDataReader("SELECT cod_posicaoVaga,cod_estadoVaga,num_lugar FROM tb_PosicaoVaga WHERE cod_posicaoVaga=" + numero_lugar + " ");
                //dt = bd.RetDataTable("SELECT cod_posicaoVaga,cod_estadoVaga,num_lugar FROM tb_PosicaoVaga WHERE cod_posicaoVaga=" + numero_lugar + " ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar ocupar vaga disponivel.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }

        public DataTable SelecionarOcuparVagaBLL( )
        {
            DataTable dt = new DataTable(); 
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT tb_PosicaoVaga.cod_posicaoVaga,tb_EstadoVaga.descr_estadoVaga,tb_PosicaoVaga.num_lugar FROM tb_PosicaoVaga INNER JOIN tb_EstadoVaga ON tb_PosicaoVaga.cod_estadoVaga=tb_EstadoVaga.cod_estadoVaga");
                //dt = bd.RetDataTable("SELECT tb_PosicaoVaga.cod_posicaoVaga,tb_EstadoVaga.descr_estadoVaga,tb_posicaoVaga.num_lugar,tb_MarcaCarro.num_matricula FROM tb_PosicaoVaga INNER JOIN tb_EstadoVaga ON tb_PosicaoVaga.cod_estadoVaga=tb_EstadoVaga.cod_estadoVaga INNER JOIN tb_MarcaCarro ON tb_Posicao.cod_carro=tb_MarcaCarro.cod_carro");
                //dt = bd.RetDataTable("SELECT cod_posicaoVaga,cod_estadoVaga,num_lugar FROM tb_PosicaoVaga");
               //dt = bd.RetDataTable("SELECT tb_PosicaoVaga.cod_posicaoVaga,tb_PosicaoVaga.num_lugar,tb_MarcaCarro.num_matricula,tb_EstadoVaga.descr_estadoVaga FROM tb_PosicaoVaga INNER JOIN tb_EstadoVaga ON tb_PosicaoVaga.cod_estadoVaga=tb_EstadoVaga.cod_estadoVaga INNER JOIN tb_MarcaCarro ON tb_PosicaoVaga.cod_carro=tb_PosicaoVaga.cod_carro ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar Seleccionar vaga disponivel.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
                
            }
            return dt;
        }

        public DataTable MostrarTodasrVagaBLL()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_PosicaoVaga");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar Seleccionar vaga disponivel.Datalhe:" + ex.Message);
            }

            finally
            {
                bd = null;
            }
            return dt;
        }


        public DataTable AlterarEstadoVagaBLL(PosicaoVagaDTO dto)
        {
            DataTable  dt= new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                //dt = bd.RetDataTable("UPDATE tb_PosicaoVaga SET cod_estadoVaga="+dto.cod_estadoVaga+", cod_carro ="+dto.cod_carro+", num_lugar="+dto.num_luagr+" WHERE cod_posicaoVaga=" +dto.cod_posicaoVaga+" ");
                dt = bd.RetDataTable("UPDATE tb_PosicaoVaga SET cod_estadoVaga="+dto.cod_estadoVaga+",num_lugar='"+dto.num_luagr+"' WHERE cod_posicaoVaga="+dto.cod_posicaoVaga+" ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar Alterar o Estado da Vaga disponivel.Datalhe:" + ex.Message);
            }

            finally
            {
                //SelecionarOcuparVagaBLL();
                bd = null;
            }
            return dt;
        }
        
    }
}
