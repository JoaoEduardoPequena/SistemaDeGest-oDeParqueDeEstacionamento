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
    public partial class FrmSaidasDeVeiculos : Form
    {
        SaidaBLL saidaBLL = new SaidaBLL();
        SaidaDTO saidaDTO = new SaidaDTO();

        public FrmSaidasDeVeiculos()
        {
            InitializeComponent();
        }


        private void PesquisarVeiculoPorCodigoEstaciona()  
        {
            OleDbDataReader dr;
            int cod_estaciona = (int.Parse(txtCodEstaciona.Text));
            dr= saidaBLL.PesquisarVeiculoPorCodEstaciona(cod_estaciona);
            dr.Read();

            if (!dr.HasRows)
            {
                MessageBox.Show("O Código Informados Não Existe");
                return;
            }

            else
            {
                while (dr.Read())
                {
                    double preco = Convert.ToDouble(dr["preco"].ToString());
                    txtValorCobrado.Text = preco.ToString();
                    txtMatriculaVeiculo.Text = dr["num_matricula"].ToString();
                }
                
            }
           

        }

        private void txtCodEstaciona_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodEstaciona.Text!= String.Empty) 
            {    
                PesquisarVeiculoPorCodigoEstaciona();
            }
        }

        private void FrmSaidasDeVeiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
