namespace GUI
{
    partial class FrmRelatrioVaga_E_EstadoVaga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btExibirRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 41);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(794, 358);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btExibirRelatorio
            // 
            this.btExibirRelatorio.Location = new System.Drawing.Point(365, 3);
            this.btExibirRelatorio.Name = "btExibirRelatorio";
            this.btExibirRelatorio.Size = new System.Drawing.Size(169, 32);
            this.btExibirRelatorio.TabIndex = 1;
            this.btExibirRelatorio.Text = "Exibir Relatorio";
            this.btExibirRelatorio.UseVisualStyleBackColor = true;
            this.btExibirRelatorio.Click += new System.EventHandler(this.btExibirRelatorio_Click);
            // 
            // FrmRelatrioVaga_E_EstadoVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 403);
            this.Controls.Add(this.btExibirRelatorio);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmRelatrioVaga_E_EstadoVaga";
            this.Text = "FrmRelatrioVaga_E_EstadoVaga";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btExibirRelatorio;
    }
}