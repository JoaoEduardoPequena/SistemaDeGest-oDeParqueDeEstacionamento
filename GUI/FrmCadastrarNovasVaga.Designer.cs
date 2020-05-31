namespace GUI
{
    partial class FrmCadastrarNovasVaga
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
            this.txtCodigoCadNovaVaga = new System.Windows.Forms.TextBox();
            this.txtNumeroVaga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_SeleccionarEstadoVaga = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigoCadNovaVaga
            // 
            this.txtCodigoCadNovaVaga.Location = new System.Drawing.Point(71, 9);
            this.txtCodigoCadNovaVaga.Name = "txtCodigoCadNovaVaga";
            this.txtCodigoCadNovaVaga.ReadOnly = true;
            this.txtCodigoCadNovaVaga.Size = new System.Drawing.Size(72, 20);
            this.txtCodigoCadNovaVaga.TabIndex = 1;
            // 
            // txtNumeroVaga
            // 
            this.txtNumeroVaga.Location = new System.Drawing.Point(36, 76);
            this.txtNumeroVaga.Name = "txtNumeroVaga";
            this.txtNumeroVaga.Size = new System.Drawing.Size(235, 20);
            this.txtNumeroVaga.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digita O Número da Vaga. Exemplo: Vaga Nº 01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selecciona O Estado Da Vaga";
            // 
            // comboBox_SeleccionarEstadoVaga
            // 
            this.comboBox_SeleccionarEstadoVaga.FormattingEnabled = true;
            this.comboBox_SeleccionarEstadoVaga.Location = new System.Drawing.Point(312, 76);
            this.comboBox_SeleccionarEstadoVaga.Name = "comboBox_SeleccionarEstadoVaga";
            this.comboBox_SeleccionarEstadoVaga.Size = new System.Drawing.Size(147, 21);
            this.comboBox_SeleccionarEstadoVaga.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 111);
            this.dataGridView1.TabIndex = 11;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(348, 162);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(149, 20);
            this.txtPesquisar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Digita O Número da Vaga Para Pesquisar. Exemplo: Vaga Nº 01";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(44, 310);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 39);
            this.btSalvar.TabIndex = 14;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastrarNovasVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 357);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_SeleccionarEstadoVaga);
            this.Controls.Add(this.txtNumeroVaga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoCadNovaVaga);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastrarNovasVaga";
            this.Text = "INCLUIR NOVAS VAGAS";
            this.Load += new System.EventHandler(this.FrmCadastrarNovasVaga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoCadNovaVaga;
        private System.Windows.Forms.TextBox txtNumeroVaga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_SeleccionarEstadoVaga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSalvar;
    }
}