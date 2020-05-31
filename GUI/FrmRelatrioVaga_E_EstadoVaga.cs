using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 
using CrystalDecisions.CrystalReports.Engine;

namespace GUI
{
    public partial class FrmRelatrioVaga_E_EstadoVaga : Form
    {
        public FrmRelatrioVaga_E_EstadoVaga()
        {
            InitializeComponent();
            ExibirRelatorio();
        }

        private void btExibirRelatorio_Click(object sender, EventArgs e)
        {
            ExibirRelatorio();
        }


        private void ExibirRelatorio()
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                string path_ = System.AppDomain.CurrentDomain.BaseDirectory;
                ////@"C:\Users\Mac\Documents\Visual Studio 2010\Projects\Crystal_MultiplasTabelas\Crystal_MultiplasTabelas\RelatoriosMultiplasTabelas.rpt";
                string caminho = path_ + "RelatoriosMultiplasTabela.rpt";
                cryRpt.Load(caminho);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException.ToString());
            }
        
        }
    }
}
