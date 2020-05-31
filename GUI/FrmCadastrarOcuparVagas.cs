using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using DTO;
using BLL;

namespace GUI
{
    public partial class FrmCadastrarOcuparVagas : Form
    {
        MarcaCarroBLL marcaCarroBLL = new MarcaCarroBLL();

        EstadoVagaBLL estadoVagaBLL = new EstadoVagaBLL();

        PosicaoVagaBLL posicaoVagaBLL = new PosicaoVagaBLL();

        PosicaoVagaDTO posicaoVagaDTO = new PosicaoVagaDTO();

        EstacionaBLL estacionaBLL = new EstacionaBLL();

        EstacionaDTO estacionaDTO = new EstacionaDTO();

        DateTime data_entrada, hora_entrada = DateTime.Now;
     
        public FrmCadastrarOcuparVagas()
        {
            InitializeComponent();
            dataGridView_EstacionarCarros.AutoGenerateColumns = false;
        }

        private void MostrarDataHora()
        {
            txtDataEntrada.Text = data_entrada.Date.ToString("dd/MM/yyyy");
            txtHoraEntrada.Text = hora_entrada.ToLocalTime().ToString();
        }
        
        private void CarrregarComBox()
        {
           // Carregar Dado da Tabela Veiculo (tb_MarcaCarro) do campo num_matricula 
            comboBox_EscolherNumeroMatriculaVeiculo.DataSource = marcaCarroBLL.SelecionarTodoVeiculo();
            comboBox_EscolherNumeroMatriculaVeiculo.DisplayMember = "num_matricula";
            comboBox_EscolherNumeroMatriculaVeiculo.ValueMember = "cod_carro";
            
            
            //Carregar dados Tabela EstadoVaga do campo descr_estadoVaga
            /*
            comboBox_SeleccionarEstadoVaga.DataSource = estadoVagaBLL.SelecionarEstadoVaga();
            comboBox_SeleccionarEstadoVaga.DisplayMember = "descr_estadoVaga";
            comboBox_SeleccionarEstadoVaga.ValueMember = "cod_estadoVaga";*/
            
        }

        private void CarregarListaVagas()
        {
            comboBox_EscolherNumeroVagaOcupar.DataSource = posicaoVagaBLL.MostrarTodasrVagaBLL();
            comboBox_EscolherNumeroVagaOcupar.DisplayMember = "num_lugar";
            comboBox_EscolherNumeroVagaOcupar.ValueMember = "cod_posicaoVaga";
            
        }

        private void ActualizarGrid()
        {
            dataGridView_EstadoDaVaga.DataSource = posicaoVagaBLL.SelecionarOcuparVagaBLL();

            //dataGridView_EstacionarCarros.DataSource = estacionaBLL.SelecionarEstaciona();
            
        }

        private void FrmCadastrarOcuparVagas_Load(object sender, EventArgs e)
        {
            MostrarDataHora();

            ActualizarGrid();

            CarrregarComBox();

            CarregarListaVagas();
        }

        private void CadastrarEntradasEstaciona()
        {
        
        }

        private bool ProcurarLugarLivre()
        {
            DataTable dt = new DataTable();

            int cod_posicao_vaga = Convert.ToInt32(comboBox_EscolherNumeroVagaOcupar.SelectedValue.ToString());
            dt = posicaoVagaBLL.SelecionarOcuparVagaPorNumeroBLL(cod_posicao_vaga);
            
            MessageBox.Show(dt.Rows[0]["cod_estadoVaga"].ToString());

            MessageBox.Show(dt.Rows[0]["num_lugar"].ToString());

            int cod_estadoVaga = int.Parse(dt.Rows[0]["cod_estadoVaga"].ToString());

            string  nome_vaga = dt.Rows[0]["num_lugar"].ToString();

            if (cod_estadoVaga == 1 && nome_vaga == dt.Rows[0]["num_lugar"].ToString()) // Condiçao Para Vaga Não Ocupadas
            {
                posicaoVagaDTO.cod_posicaoVaga = cod_posicao_vaga;

                posicaoVagaDTO.cod_estadoVaga = 2;// Troca Para Código 2 Para O Estado Ocupado Da Vaga
                posicaoVagaDTO.num_luagr = nome_vaga.ToString();

                posicaoVagaBLL.AlterarEstadoVagaBLL(posicaoVagaDTO);
                
                // Aqui Começa A Inserir Dados Na Tabela tb_Estaciona

                estacionaDTO.cod_posicaoVaga = posicaoVagaDTO.cod_posicaoVaga;
                estacionaDTO.cor_carro = int.Parse(comboBox_EscolherNumeroMatriculaVeiculo.SelectedValue.ToString());
                estacionaDTO.preco = float.Parse(txtValorPago.Text);
                estacionaDTO.dt_entrada = Convert.ToDateTime(txtDataEntrada.Text);
                estacionaDTO.hs_entrada = Convert.ToDateTime(txtHoraEntrada.Text);
                estacionaDTO.cod_estadoVaga = cod_estadoVaga;
                
                if (checkBox_AtivoCarroParque.Checked==true)
                {
                    estacionaDTO.ativo = 1;
                }

                estacionaBLL.InserirEstacionarBLL(estacionaDTO);
                dataGridView_EstacionarCarros.DataSource = estacionaBLL.SelecionarEstaciona();
                MessageBox.Show("Vaga Ocupada Com Sucesso");

                return true;
            }

            else // Condição Para Vaga Ocupadas
            {
                MessageBox.Show(dt.Rows[0]["cod_estadoVaga"].ToString());
                MessageBox.Show(dt.Rows[0]["num_lugar"].ToString());
                MessageBox.Show("O Lugar Seleccionado Está Ocupado Por Carro! Escolhe Outro Lugar");

                return false;
            }

            return true;
        }

        private void btOcuparVaga_Click(object sender, EventArgs e)
        {
            ProcurarLugarLivre();
            ActualizarGrid();
        }

        private void comboBox_EscolherNumeroVagaOcupar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btFinalizarEntradas_Click(object sender, EventArgs e)
        {
            dataGridView_EstacionarCarros.Rows.Clear();
        }

    }
}
