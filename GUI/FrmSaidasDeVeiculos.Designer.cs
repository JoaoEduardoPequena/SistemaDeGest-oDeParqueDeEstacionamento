namespace GUI
{
    partial class FrmSaidasDeVeiculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodEstaciona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorCobrado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraSaida = new System.Windows.Forms.TextBox();
            this.txtDataSaida = new System.Windows.Forms.TextBox();
            this.txtMatriculaVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdeSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Ticket / Código Estaciona";
            // 
            // txtCodEstaciona
            // 
            this.txtCodEstaciona.Location = new System.Drawing.Point(198, 23);
            this.txtCodEstaciona.Name = "txtCodEstaciona";
            this.txtCodEstaciona.Size = new System.Drawing.Size(85, 20);
            this.txtCodEstaciona.TabIndex = 1;
            this.txtCodEstaciona.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodEstaciona_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Valor  Cobrado";
            // 
            // txtValorCobrado
            // 
            this.txtValorCobrado.Location = new System.Drawing.Point(255, 97);
            this.txtValorCobrado.Name = "txtValorCobrado";
            this.txtValorCobrado.Size = new System.Drawing.Size(86, 20);
            this.txtValorCobrado.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hora de Saida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data de Saida";
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Location = new System.Drawing.Point(136, 97);
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.ReadOnly = true;
            this.txtHoraSaida.Size = new System.Drawing.Size(100, 20);
            this.txtHoraSaida.TabIndex = 19;
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Location = new System.Drawing.Point(19, 98);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.ReadOnly = true;
            this.txtDataSaida.Size = new System.Drawing.Size(100, 20);
            this.txtDataSaida.TabIndex = 18;
            // 
            // txtMatriculaVeiculo
            // 
            this.txtMatriculaVeiculo.Location = new System.Drawing.Point(367, 97);
            this.txtMatriculaVeiculo.Name = "txtMatriculaVeiculo";
            this.txtMatriculaVeiculo.Size = new System.Drawing.Size(131, 20);
            this.txtMatriculaVeiculo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Matrícula do Veiculo";
            // 
            // txtQtdeSaida
            // 
            this.txtQtdeSaida.Location = new System.Drawing.Point(521, 98);
            this.txtQtdeSaida.Name = "txtQtdeSaida";
            this.txtQtdeSaida.Size = new System.Drawing.Size(107, 20);
            this.txtQtdeSaida.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quandade de Saida";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 129);
            this.dataGridView1.TabIndex = 28;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(648, 94);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(78, 20);
            this.txtTotal.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(652, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Total ";
            // 
            // FrmSaidasDeVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 381);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQtdeSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatriculaVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorCobrado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.txtCodEstaciona);
            this.Controls.Add(this.label1);
            this.Name = "FrmSaidasDeVeiculos";
            this.Text = "SAIDA DE VEÍCULOS";
            this.Load += new System.EventHandler(this.FrmSaidasDeVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodEstaciona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorCobrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoraSaida;
        private System.Windows.Forms.TextBox txtDataSaida;
        private System.Windows.Forms.TextBox txtMatriculaVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdeSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
    }
}