using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BLL;

namespace GUI
{
    public partial class FrmCadastrarNovasVaga : Form
    {
        EstadoVagaBLL estadoVagaBLL = new EstadoVagaBLL();

        public FrmCadastrarNovasVaga()
        {
            InitializeComponent();
        }

        private void FrmCadastrarNovasVaga_Load(object sender, EventArgs e)
        {
            CarregarCombox();
        }

        private void CarregarCombox()
        {
            //Carregar dados Tabela EstadoVaga do campo descr_estadoVaga
            comboBox_SeleccionarEstadoVaga.DataSource = estadoVagaBLL.SelecionarEstadoVaga();
            comboBox_SeleccionarEstadoVaga.DisplayMember = "descr_estadoVaga";
            comboBox_SeleccionarEstadoVaga.ValueMember = "cod_estadoVaga";
        }
    }
}
