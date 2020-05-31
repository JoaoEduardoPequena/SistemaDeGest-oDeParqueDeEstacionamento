namespace GUI
{
    partial class FrmCadastroModeloCarro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNomeModeloCarro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoModeloCarro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_ModeloCarro = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.txtPesquisarModeloCarro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cod_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ModeloCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeModeloCarro
            // 
            this.txtNomeModeloCarro.Location = new System.Drawing.Point(187, 61);
            this.txtNomeModeloCarro.Name = "txtNomeModeloCarro";
            this.txtNomeModeloCarro.Size = new System.Drawing.Size(285, 20);
            this.txtNomeModeloCarro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Modelo do Carro";
            // 
            // txtCodigoModeloCarro
            // 
            this.txtCodigoModeloCarro.Location = new System.Drawing.Point(187, 17);
            this.txtCodigoModeloCarro.Name = "txtCodigoModeloCarro";
            this.txtCodigoModeloCarro.ReadOnly = true;
            this.txtCodigoModeloCarro.Size = new System.Drawing.Size(64, 20);
            this.txtCodigoModeloCarro.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // dataGridView_ModeloCarro
            // 
            this.dataGridView_ModeloCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ModeloCarro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_modelo,
            this.descr_modelo});
            this.dataGridView_ModeloCarro.Location = new System.Drawing.Point(55, 152);
            this.dataGridView_ModeloCarro.MultiSelect = false;
            this.dataGridView_ModeloCarro.Name = "dataGridView_ModeloCarro";
            this.dataGridView_ModeloCarro.ReadOnly = true;
            this.dataGridView_ModeloCarro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ModeloCarro.Size = new System.Drawing.Size(386, 150);
            this.dataGridView_ModeloCarro.TabIndex = 8;
            this.dataGridView_ModeloCarro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ModeloCarro_CellClick);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(120, 317);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(89, 35);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(304, 317);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(89, 35);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // txtPesquisarModeloCarro
            // 
            this.txtPesquisarModeloCarro.Location = new System.Drawing.Point(55, 119);
            this.txtPesquisarModeloCarro.Name = "txtPesquisarModeloCarro";
            this.txtPesquisarModeloCarro.Size = new System.Drawing.Size(386, 20);
            this.txtPesquisarModeloCarro.TabIndex = 11;
            this.txtPesquisarModeloCarro.TextChanged += new System.EventHandler(this.txtPesquisarModeloCarro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Digita o Nome do Modelo do CarroPara Pesquisar";
            // 
            // cod_modelo
            // 
            this.cod_modelo.DataPropertyName = "cod_modelo";
            this.cod_modelo.HeaderText = "Código";
            this.cod_modelo.Name = "cod_modelo";
            this.cod_modelo.ReadOnly = true;
            this.cod_modelo.Width = 50;
            // 
            // descr_modelo
            // 
            this.descr_modelo.DataPropertyName = "descr_modelo";
            dataGridViewCellStyle2.NullValue = null;
            this.descr_modelo.DefaultCellStyle = dataGridViewCellStyle2;
            this.descr_modelo.HeaderText = "Nome Do Modelo Do Carro";
            this.descr_modelo.Name = "descr_modelo";
            this.descr_modelo.ReadOnly = true;
            this.descr_modelo.Width = 300;
            // 
            // FrmCadastroModeloCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 364);
            this.Controls.Add(this.txtPesquisarModeloCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dataGridView_ModeloCarro);
            this.Controls.Add(this.txtNomeModeloCarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoModeloCarro);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroModeloCarro";
            this.Text = "Tela De Cadastro Modelo De Carro";
            this.Load += new System.EventHandler(this.FrmCadastroModeloCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ModeloCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeModeloCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoModeloCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ModeloCarro;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox txtPesquisarModeloCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_modelo;
    }
}