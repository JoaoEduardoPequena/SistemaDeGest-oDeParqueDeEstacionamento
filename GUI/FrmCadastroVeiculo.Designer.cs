namespace GUI
{
    partial class FrmCadastroVeiculo
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
            this.txtCodVeiculo = new System.Windows.Forms.TextBox();
            this.comboBox_SeleccionarCliente = new System.Windows.Forms.ComboBox();
            this.comboBox_SeleccionarModeloVeiculo = new System.Windows.Forms.ComboBox();
            this.txtCorVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroMatriculaVeiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_CadastroVeiculo = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.txtPesquisarPorNomeModeloVeiculo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btInserirNovoCliente = new System.Windows.Forms.Button();
            this.btInserirNovoModelo = new System.Windows.Forms.Button();
            this.btLimparTela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CadastroVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodVeiculo
            // 
            this.txtCodVeiculo.Location = new System.Drawing.Point(73, 27);
            this.txtCodVeiculo.Name = "txtCodVeiculo";
            this.txtCodVeiculo.ReadOnly = true;
            this.txtCodVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtCodVeiculo.TabIndex = 1;
            // 
            // comboBox_SeleccionarCliente
            // 
            this.comboBox_SeleccionarCliente.FormattingEnabled = true;
            this.comboBox_SeleccionarCliente.Location = new System.Drawing.Point(357, 70);
            this.comboBox_SeleccionarCliente.Name = "comboBox_SeleccionarCliente";
            this.comboBox_SeleccionarCliente.Size = new System.Drawing.Size(245, 21);
            this.comboBox_SeleccionarCliente.TabIndex = 2;
            // 
            // comboBox_SeleccionarModeloVeiculo
            // 
            this.comboBox_SeleccionarModeloVeiculo.FormattingEnabled = true;
            this.comboBox_SeleccionarModeloVeiculo.Location = new System.Drawing.Point(356, 122);
            this.comboBox_SeleccionarModeloVeiculo.Name = "comboBox_SeleccionarModeloVeiculo";
            this.comboBox_SeleccionarModeloVeiculo.Size = new System.Drawing.Size(246, 21);
            this.comboBox_SeleccionarModeloVeiculo.TabIndex = 3;
            // 
            // txtCorVeiculo
            // 
            this.txtCorVeiculo.Location = new System.Drawing.Point(73, 75);
            this.txtCorVeiculo.Name = "txtCorVeiculo";
            this.txtCorVeiculo.Size = new System.Drawing.Size(145, 20);
            this.txtCorVeiculo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cor ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecciona o Nome do Cliênte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seleccionar o Modelo do Veículo";
            // 
            // txtNumeroMatriculaVeiculo
            // 
            this.txtNumeroMatriculaVeiculo.Location = new System.Drawing.Point(440, 18);
            this.txtNumeroMatriculaVeiculo.MaxLength = 12;
            this.txtNumeroMatriculaVeiculo.Name = "txtNumeroMatriculaVeiculo";
            this.txtNumeroMatriculaVeiculo.Size = new System.Drawing.Size(162, 20);
            this.txtNumeroMatriculaVeiculo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nº da Matricula";
            // 
            // dataGridView_CadastroVeiculo
            // 
            this.dataGridView_CadastroVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CadastroVeiculo.Location = new System.Drawing.Point(42, 242);
            this.dataGridView_CadastroVeiculo.MultiSelect = false;
            this.dataGridView_CadastroVeiculo.Name = "dataGridView_CadastroVeiculo";
            this.dataGridView_CadastroVeiculo.ReadOnly = true;
            this.dataGridView_CadastroVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CadastroVeiculo.Size = new System.Drawing.Size(662, 150);
            this.dataGridView_CadastroVeiculo.TabIndex = 12;
            this.dataGridView_CadastroVeiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CadastroVeiculo_CellClick);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(182, 408);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(101, 33);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(465, 408);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(101, 33);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // txtPesquisarPorNomeModeloVeiculo
            // 
            this.txtPesquisarPorNomeModeloVeiculo.Location = new System.Drawing.Point(303, 216);
            this.txtPesquisarPorNomeModeloVeiculo.Name = "txtPesquisarPorNomeModeloVeiculo";
            this.txtPesquisarPorNomeModeloVeiculo.Size = new System.Drawing.Size(336, 20);
            this.txtPesquisarPorNomeModeloVeiculo.TabIndex = 16;
            this.txtPesquisarPorNomeModeloVeiculo.TextChanged += new System.EventHandler(this.txtPesquisarPorMarcaVeiculo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Digita o Nome do Modelo Do Carro Para Pesquisar";
            // 
            // btInserirNovoCliente
            // 
            this.btInserirNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserirNovoCliente.Location = new System.Drawing.Point(622, 68);
            this.btInserirNovoCliente.Name = "btInserirNovoCliente";
            this.btInserirNovoCliente.Size = new System.Drawing.Size(169, 23);
            this.btInserirNovoCliente.TabIndex = 17;
            this.btInserirNovoCliente.Text = "Inserir Novo Cliênte ...";
            this.btInserirNovoCliente.UseVisualStyleBackColor = true;
            this.btInserirNovoCliente.Click += new System.EventHandler(this.btInserirNovoCliente_Click);
            // 
            // btInserirNovoModelo
            // 
            this.btInserirNovoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserirNovoModelo.Location = new System.Drawing.Point(622, 123);
            this.btInserirNovoModelo.Name = "btInserirNovoModelo";
            this.btInserirNovoModelo.Size = new System.Drawing.Size(169, 23);
            this.btInserirNovoModelo.TabIndex = 18;
            this.btInserirNovoModelo.Text = "Inserir Novo Modelo ...";
            this.btInserirNovoModelo.UseVisualStyleBackColor = true;
            this.btInserirNovoModelo.Click += new System.EventHandler(this.btInserirNovoModelo_Click);
            // 
            // btLimparTela
            // 
            this.btLimparTela.Location = new System.Drawing.Point(320, 408);
            this.btLimparTela.Name = "btLimparTela";
            this.btLimparTela.Size = new System.Drawing.Size(101, 33);
            this.btLimparTela.TabIndex = 19;
            this.btLimparTela.Text = "Limpar  Telar";
            this.btLimparTela.UseVisualStyleBackColor = true;
            this.btLimparTela.Click += new System.EventHandler(this.btLimparTela_Click);
            // 
            // FrmCadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 453);
            this.Controls.Add(this.btLimparTela);
            this.Controls.Add(this.btInserirNovoModelo);
            this.Controls.Add(this.btInserirNovoCliente);
            this.Controls.Add(this.txtPesquisarPorNomeModeloVeiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dataGridView_CadastroVeiculo);
            this.Controls.Add(this.txtNumeroMatriculaVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_SeleccionarModeloVeiculo);
            this.Controls.Add(this.comboBox_SeleccionarCliente);
            this.Controls.Add(this.txtCodVeiculo);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroVeiculo";
            this.Text = "Tela De Cadastro De Veiculo";
            this.Load += new System.EventHandler(this.FrmCadastroVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CadastroVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodVeiculo;
        private System.Windows.Forms.ComboBox comboBox_SeleccionarCliente;
        private System.Windows.Forms.ComboBox comboBox_SeleccionarModeloVeiculo;
        private System.Windows.Forms.TextBox txtCorVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroMatriculaVeiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_CadastroVeiculo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox txtPesquisarPorNomeModeloVeiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btInserirNovoCliente;
        private System.Windows.Forms.Button btInserirNovoModelo;
        private System.Windows.Forms.Button btLimparTela;
    }
}