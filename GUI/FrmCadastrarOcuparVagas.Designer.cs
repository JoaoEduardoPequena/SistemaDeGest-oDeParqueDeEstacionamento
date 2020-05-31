namespace GUI
{
    partial class FrmCadastrarOcuparVagas
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
            this.comboBox_EscolherNumeroMatriculaVeiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_EscolherNumeroVagaOcupar = new System.Windows.Forms.ComboBox();
            this.txtCodigoVaga = new System.Windows.Forms.TextBox();
            this.dataGridView_EstadoDaVaga = new System.Windows.Forms.DataGridView();
            this.btOcuparVaga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_EstacionarCarros = new System.Windows.Forms.DataGridView();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.checkBox_AtivoCarroParque = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.btFinalizarEntradas = new System.Windows.Forms.Button();
            this.cod_estaciona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_estadoVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EstadoDaVaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EstacionarCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_EscolherNumeroMatriculaVeiculo
            // 
            this.comboBox_EscolherNumeroMatriculaVeiculo.FormattingEnabled = true;
            this.comboBox_EscolherNumeroMatriculaVeiculo.Location = new System.Drawing.Point(28, 85);
            this.comboBox_EscolherNumeroMatriculaVeiculo.Name = "comboBox_EscolherNumeroMatriculaVeiculo";
            this.comboBox_EscolherNumeroMatriculaVeiculo.Size = new System.Drawing.Size(207, 21);
            this.comboBox_EscolherNumeroMatriculaVeiculo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolhe O numero da Matricula do Veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escolhe o Número da Vaga Para Ocupar";
            // 
            // comboBox_EscolherNumeroVagaOcupar
            // 
            this.comboBox_EscolherNumeroVagaOcupar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EscolherNumeroVagaOcupar.FormattingEnabled = true;
            this.comboBox_EscolherNumeroVagaOcupar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_EscolherNumeroVagaOcupar.Location = new System.Drawing.Point(28, 146);
            this.comboBox_EscolherNumeroVagaOcupar.Name = "comboBox_EscolherNumeroVagaOcupar";
            this.comboBox_EscolherNumeroVagaOcupar.Size = new System.Drawing.Size(207, 21);
            this.comboBox_EscolherNumeroVagaOcupar.TabIndex = 2;
            this.comboBox_EscolherNumeroVagaOcupar.SelectedIndexChanged += new System.EventHandler(this.comboBox_EscolherNumeroVagaOcupar_SelectedIndexChanged);
            // 
            // txtCodigoVaga
            // 
            this.txtCodigoVaga.Location = new System.Drawing.Point(74, 19);
            this.txtCodigoVaga.Name = "txtCodigoVaga";
            this.txtCodigoVaga.ReadOnly = true;
            this.txtCodigoVaga.Size = new System.Drawing.Size(85, 20);
            this.txtCodigoVaga.TabIndex = 5;
            // 
            // dataGridView_EstadoDaVaga
            // 
            this.dataGridView_EstadoDaVaga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EstadoDaVaga.Location = new System.Drawing.Point(425, 17);
            this.dataGridView_EstadoDaVaga.Name = "dataGridView_EstadoDaVaga";
            this.dataGridView_EstadoDaVaga.Size = new System.Drawing.Size(376, 164);
            this.dataGridView_EstadoDaVaga.TabIndex = 6;
            // 
            // btOcuparVaga
            // 
            this.btOcuparVaga.Location = new System.Drawing.Point(74, 202);
            this.btOcuparVaga.Name = "btOcuparVaga";
            this.btOcuparVaga.Size = new System.Drawing.Size(100, 36);
            this.btOcuparVaga.TabIndex = 9;
            this.btOcuparVaga.Text = "Ocupar Vaga";
            this.btOcuparVaga.UseVisualStyleBackColor = true;
            this.btOcuparVaga.Click += new System.EventHandler(this.btOcuparVaga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código ";
            // 
            // dataGridView_EstacionarCarros
            // 
            this.dataGridView_EstacionarCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EstacionarCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_estaciona,
            this.num_matricula,
            this.num_lugar,
            this.descr_estadoVaga,
            this.dt_entrada,
            this.hs_entrada,
            this.preco,
            this.ativo});
            this.dataGridView_EstacionarCarros.Location = new System.Drawing.Point(12, 247);
            this.dataGridView_EstacionarCarros.Name = "dataGridView_EstacionarCarros";
            this.dataGridView_EstacionarCarros.Size = new System.Drawing.Size(875, 150);
            this.dataGridView_EstacionarCarros.TabIndex = 10;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(217, 216);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.ReadOnly = true;
            this.txtDataEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrada.TabIndex = 11;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(341, 216);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.ReadOnly = true;
            this.txtHoraEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtHoraEntrada.TabIndex = 12;
            // 
            // checkBox_AtivoCarroParque
            // 
            this.checkBox_AtivoCarroParque.AutoSize = true;
            this.checkBox_AtivoCarroParque.Location = new System.Drawing.Point(465, 219);
            this.checkBox_AtivoCarroParque.Name = "checkBox_AtivoCarroParque";
            this.checkBox_AtivoCarroParque.Size = new System.Drawing.Size(152, 17);
            this.checkBox_AtivoCarroParque.TabIndex = 13;
            this.checkBox_AtivoCarroParque.Text = "Saiu do Parque: SIM/NÃO";
            this.checkBox_AtivoCarroParque.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hora de Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor  Pago";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(639, 218);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(86, 20);
            this.txtValorPago.TabIndex = 16;
            // 
            // btFinalizarEntradas
            // 
            this.btFinalizarEntradas.Location = new System.Drawing.Point(615, 409);
            this.btFinalizarEntradas.Name = "btFinalizarEntradas";
            this.btFinalizarEntradas.Size = new System.Drawing.Size(111, 31);
            this.btFinalizarEntradas.TabIndex = 18;
            this.btFinalizarEntradas.Text = "Finalizar Entradas";
            this.btFinalizarEntradas.UseVisualStyleBackColor = true;
            this.btFinalizarEntradas.Click += new System.EventHandler(this.btFinalizarEntradas_Click);
            // 
            // cod_estaciona
            // 
            this.cod_estaciona.DataPropertyName = "cod_estaciona";
            this.cod_estaciona.HeaderText = "Código Estaciona";
            this.cod_estaciona.Name = "cod_estaciona";
            // 
            // num_matricula
            // 
            this.num_matricula.DataPropertyName = "num_matricula";
            this.num_matricula.HeaderText = "Matricula ";
            this.num_matricula.Name = "num_matricula";
            // 
            // num_lugar
            // 
            this.num_lugar.DataPropertyName = "num_lugar";
            this.num_lugar.HeaderText = "Vaga";
            this.num_lugar.Name = "num_lugar";
            this.num_lugar.Width = 96;
            // 
            // descr_estadoVaga
            // 
            this.descr_estadoVaga.DataPropertyName = "descr_estadoVaga";
            this.descr_estadoVaga.HeaderText = "Estado da Vaga";
            this.descr_estadoVaga.Name = "descr_estadoVaga";
            this.descr_estadoVaga.Width = 150;
            // 
            // dt_entrada
            // 
            this.dt_entrada.DataPropertyName = "dt_entrada";
            this.dt_entrada.HeaderText = "Data Entrada";
            this.dt_entrada.Name = "dt_entrada";
            // 
            // hs_entrada
            // 
            this.hs_entrada.DataPropertyName = "hs_entrada";
            this.hs_entrada.HeaderText = "Hora Entrada";
            this.hs_entrada.Name = "hs_entrada";
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "Valor Cobrado";
            this.preco.Name = "preco";
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Activo";
            this.ativo.Name = "ativo";
            this.ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ativo.Width = 98;
            // 
            // FrmCadastrarOcuparVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 457);
            this.Controls.Add(this.btFinalizarEntradas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_AtivoCarroParque);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.dataGridView_EstacionarCarros);
            this.Controls.Add(this.btOcuparVaga);
            this.Controls.Add(this.dataGridView_EstadoDaVaga);
            this.Controls.Add(this.txtCodigoVaga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_EscolherNumeroVagaOcupar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_EscolherNumeroMatriculaVeiculo);
            this.Name = "FrmCadastrarOcuparVagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela De Ocupação De Vagas";
            this.Load += new System.EventHandler(this.FrmCadastrarOcuparVagas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EstadoDaVaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EstacionarCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_EscolherNumeroMatriculaVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_EscolherNumeroVagaOcupar;
        private System.Windows.Forms.TextBox txtCodigoVaga;
        private System.Windows.Forms.DataGridView dataGridView_EstadoDaVaga;
        private System.Windows.Forms.Button btOcuparVaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_EstacionarCarros;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtHoraEntrada;
        private System.Windows.Forms.CheckBox checkBox_AtivoCarroParque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Button btFinalizarEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_estaciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_estadoVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativo;
    }
}