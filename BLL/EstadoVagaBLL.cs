using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class EstadoVagaBLL
    {
        AcessoBancoDados bd;

        public void InserirPatioBLL(EstadoVagaDTO dto)
        {
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO tb_estadovaga(estado) VALUES('"+dto.descr_estadoVaga+"')";
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

        public DataTable SelecionarEstadoVaga()
        {
            DataTable dt = new DataTable();
            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * FROM tb_estadovaga");
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
    }
}
