namespace GUI
{
    partial class FrmCadastroPatio
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
            this.txtCodigoPatio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacidadePatio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalizacaoPatio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_CadastroPatio = new System.Windows.Forms.DataGridView();
            this.txtPesquisarPatio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.cod_patio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CadastroPatio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoPatio
            // 
            this.txtCodigoPatio.Location = new System.Drawing.Point(112, 13);
            this.txtCodigoPatio.Name = "txtCodigoPatio";
            this.txtCodigoPatio.ReadOnly = true;
            this.txtCodigoPatio.Size = new System.Drawing.Size(85, 20);
            this.txtCodigoPatio.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Código";
            // 
            // txtCapacidadePatio
            // 
            this.txtCapacidadePatio.Location = new System.Drawing.Point(112, 81);
            this.txtCapacidadePatio.Name = "txtCapacidadePatio";
            this.txtCapacidadePatio.Size = new System.Drawing.Size(85, 20);
            this.txtCapacidadePatio.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Capacidade";
            // 
            // txtLocalizacaoPatio
            // 
            this.txtLocalizacaoPatio.Location = new System.Drawing.Point(112, 49);
            this.txtLocalizacaoPatio.Name = "txtLocalizacaoPatio";
            this.txtLocalizacaoPatio.Size = new System.Drawing.Size(288, 20);
            this.txtLocalizacaoPatio.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Localização";
            // 
            // dataGridView_CadastroPatio
            // 
            this.dataGridView_CadastroPatio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CadastroPatio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_patio,
            this.localizacao,
            this.capacidade});
            this.dataGridView_CadastroPatio.Location = new System.Drawing.Point(40, 198);
            this.dataGridView_CadastroPatio.Name = "dataGridView_CadastroPatio";
            this.dataGridView_CadastroPatio.Size = new System.Drawing.Size(496, 114);
            this.dataGridView_CadastroPatio.TabIndex = 21;
            this.dataGridView_CadastroPatio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CadastroPatio_CellClick);
            // 
            // txtPesquisarPatio
            // 
            this.txtPesquisarPatio.Location = new System.Drawing.Point(267, 168);
            this.txtPesquisarPatio.Name = "txtPesquisarPatio";
            this.txtPesquisarPatio.Size = new System.Drawing.Size(269, 20);
            this.txtPesquisarPatio.TabIndex = 23;
            this.txtPesquisarPatio.TextChanged += new System.EventHandler(this.txtPesquisarPatio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Digita a Localizção do Pátio Para Pesquisar";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(112, 325);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(81, 29);
            this.btSalvar.TabIndex = 24;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(309, 326);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(81, 29);
            this.btExcluir.TabIndex = 25;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // cod_patio
            // 
            this.cod_patio.DataPropertyName = "cod_patio";
            this.cod_patio.HeaderText = "Código";
            this.cod_patio.Name = "cod_patio";
            this.cod_patio.Width = 60;
            // 
            // localizacao
            // 
            this.localizacao.DataPropertyName = "localizacao";
            this.localizacao.HeaderText = "Localização";
            this.localizacao.Name = "localizacao";
            this.localizacao.Width = 300;
            // 
            // capacidade
            // 
            this.capacidade.DataPropertyName = "capacidade";
            this.capacidade.HeaderText = "Capacidade";
            this.capacidade.Name = "capacidade";
            this.capacidade.Width = 90;
            // 
            // FrmCadastroPatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(551, 369);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtPesquisarPatio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_CadastroPatio);
            this.Controls.Add(this.txtCodigoPatio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCapacidadePatio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocalizacaoPatio);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroPatio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela De Cadastro De Patio";
            this.Load += new System.EventHandler(this.FrmCadastroPatio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CadastroPatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoPatio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacidadePatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalizacaoPatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_CadastroPatio;
        private System.Windows.Forms.TextBox txtPesquisarPatio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_patio;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidade;
    }
}