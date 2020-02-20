namespace BRUNO_EX20
{
    partial class Form1
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
            this.txtVelocidadeLimpador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAcionaLimpador = new System.Windows.Forms.Button();
            this.btnAbrirPortas = new System.Windows.Forms.Button();
            this.btnPagarPedagio = new System.Windows.Forms.Button();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDescarregar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEmpinar = new System.Windows.Forms.Button();
            this.txtCarregar = new System.Windows.Forms.TextBox();
            this.txtPesqVeiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQtdeEixos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCriarCaminhao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCilindradas = new System.Windows.Forms.TextBox();
            this.Cilindradas = new System.Windows.Forms.Label();
            this.btnCriarMoto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckUtilizaReboque = new System.Windows.Forms.CheckBox();
            this.txtQtdePortas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCarro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVelocidadeLimpador
            // 
            this.txtVelocidadeLimpador.Location = new System.Drawing.Point(594, 12);
            this.txtVelocidadeLimpador.Name = "txtVelocidadeLimpador";
            this.txtVelocidadeLimpador.Size = new System.Drawing.Size(51, 20);
            this.txtVelocidadeLimpador.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Velocidade limpador";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 298);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(688, 183);
            this.txtOutput.TabIndex = 42;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAcionaLimpador);
            this.groupBox4.Controls.Add(this.btnAbrirPortas);
            this.groupBox4.Controls.Add(this.btnPagarPedagio);
            this.groupBox4.Controls.Add(this.btnAcelerar);
            this.groupBox4.Controls.Add(this.cbOpcoes);
            this.groupBox4.Controls.Add(this.btnListar);
            this.groupBox4.Controls.Add(this.btnDescarregar);
            this.groupBox4.Controls.Add(this.btnCarregar);
            this.groupBox4.Controls.Add(this.btnPesquisar);
            this.groupBox4.Controls.Add(this.btnEmpinar);
            this.groupBox4.Controls.Add(this.txtCarregar);
            this.groupBox4.Controls.Add(this.txtPesqVeiculo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(15, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 153);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ações";
            // 
            // btnAcionaLimpador
            // 
            this.btnAcionaLimpador.Location = new System.Drawing.Point(421, 105);
            this.btnAcionaLimpador.Name = "btnAcionaLimpador";
            this.btnAcionaLimpador.Size = new System.Drawing.Size(147, 23);
            this.btnAcionaLimpador.TabIndex = 24;
            this.btnAcionaLimpador.Text = "Acionar limpador de todos";
            this.btnAcionaLimpador.UseVisualStyleBackColor = true;
            this.btnAcionaLimpador.Click += new System.EventHandler(this.btnAcionaLimpador_Click);
            // 
            // btnAbrirPortas
            // 
            this.btnAbrirPortas.Location = new System.Drawing.Point(295, 105);
            this.btnAbrirPortas.Name = "btnAbrirPortas";
            this.btnAbrirPortas.Size = new System.Drawing.Size(115, 23);
            this.btnAbrirPortas.TabIndex = 23;
            this.btnAbrirPortas.Text = "Abrir Porta de todos";
            this.btnAbrirPortas.UseVisualStyleBackColor = true;
            this.btnAbrirPortas.Click += new System.EventHandler(this.btnAbrirPortas_Click);
            // 
            // btnPagarPedagio
            // 
            this.btnPagarPedagio.Location = new System.Drawing.Point(453, 57);
            this.btnPagarPedagio.Name = "btnPagarPedagio";
            this.btnPagarPedagio.Size = new System.Drawing.Size(115, 23);
            this.btnPagarPedagio.TabIndex = 22;
            this.btnPagarPedagio.Text = "Pagar pedágio";
            this.btnPagarPedagio.UseVisualStyleBackColor = true;
            this.btnPagarPedagio.Click += new System.EventHandler(this.btnPagarPedagio_Click);
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(362, 57);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 23);
            this.btnAcelerar.TabIndex = 21;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Items.AddRange(new object[] {
            "Tudo",
            "Carro",
            "Moto",
            "Caminhão"});
            this.cbOpcoes.Location = new System.Drawing.Point(96, 107);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(170, 21);
            this.cbOpcoes.TabIndex = 20;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(6, 105);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnDescarregar
            // 
            this.btnDescarregar.Location = new System.Drawing.Point(281, 57);
            this.btnDescarregar.Name = "btnDescarregar";
            this.btnDescarregar.Size = new System.Drawing.Size(75, 23);
            this.btnDescarregar.TabIndex = 13;
            this.btnDescarregar.Text = "Descarregar";
            this.btnDescarregar.UseVisualStyleBackColor = true;
            this.btnDescarregar.Click += new System.EventHandler(this.btnDescarregar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(6, 57);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 11;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(191, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEmpinar
            // 
            this.btnEmpinar.Location = new System.Drawing.Point(200, 57);
            this.btnEmpinar.Name = "btnEmpinar";
            this.btnEmpinar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpinar.TabIndex = 3;
            this.btnEmpinar.Text = "Empinar";
            this.btnEmpinar.UseVisualStyleBackColor = true;
            this.btnEmpinar.Click += new System.EventHandler(this.btnEmpinar_Click);
            // 
            // txtCarregar
            // 
            this.txtCarregar.Location = new System.Drawing.Point(87, 59);
            this.txtCarregar.Name = "txtCarregar";
            this.txtCarregar.Size = new System.Drawing.Size(51, 20);
            this.txtCarregar.TabIndex = 14;
            // 
            // txtPesqVeiculo
            // 
            this.txtPesqVeiculo.Location = new System.Drawing.Point(59, 17);
            this.txtPesqVeiculo.Name = "txtPesqVeiculo";
            this.txtPesqVeiculo.Size = new System.Drawing.Size(122, 20);
            this.txtPesqVeiculo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Veículo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQtdeEixos);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnCriarCaminhao);
            this.groupBox3.Location = new System.Drawing.Point(389, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 95);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caminhão";
            // 
            // txtQtdeEixos
            // 
            this.txtQtdeEixos.Location = new System.Drawing.Point(111, 24);
            this.txtQtdeEixos.Name = "txtQtdeEixos";
            this.txtQtdeEixos.Size = new System.Drawing.Size(51, 20);
            this.txtQtdeEixos.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Qtde de Eixos";
            // 
            // btnCriarCaminhao
            // 
            this.btnCriarCaminhao.Location = new System.Drawing.Point(63, 65);
            this.btnCriarCaminhao.Name = "btnCriarCaminhao";
            this.btnCriarCaminhao.Size = new System.Drawing.Size(91, 23);
            this.btnCriarCaminhao.TabIndex = 1;
            this.btnCriarCaminhao.Text = "Criar Caminhão";
            this.btnCriarCaminhao.UseVisualStyleBackColor = true;
            this.btnCriarCaminhao.Click += new System.EventHandler(this.btnCriarCaminhao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCilindradas);
            this.groupBox2.Controls.Add(this.Cilindradas);
            this.groupBox2.Controls.Add(this.btnCriarMoto);
            this.groupBox2.Location = new System.Drawing.Point(183, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moto";
            // 
            // txtCilindradas
            // 
            this.txtCilindradas.Location = new System.Drawing.Point(113, 20);
            this.txtCilindradas.Name = "txtCilindradas";
            this.txtCilindradas.Size = new System.Drawing.Size(51, 20);
            this.txtCilindradas.TabIndex = 10;
            // 
            // Cilindradas
            // 
            this.Cilindradas.AutoSize = true;
            this.Cilindradas.Location = new System.Drawing.Point(30, 23);
            this.Cilindradas.Name = "Cilindradas";
            this.Cilindradas.Size = new System.Drawing.Size(58, 13);
            this.Cilindradas.TabIndex = 9;
            this.Cilindradas.Text = "Cilindradas";
            // 
            // btnCriarMoto
            // 
            this.btnCriarMoto.Location = new System.Drawing.Point(59, 65);
            this.btnCriarMoto.Name = "btnCriarMoto";
            this.btnCriarMoto.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMoto.TabIndex = 2;
            this.btnCriarMoto.Text = "Criar Moto";
            this.btnCriarMoto.UseVisualStyleBackColor = true;
            this.btnCriarMoto.Click += new System.EventHandler(this.btnCriarMoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckUtilizaReboque);
            this.groupBox1.Controls.Add(this.txtQtdePortas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCarro);
            this.groupBox1.Location = new System.Drawing.Point(15, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 98);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carro";
            // 
            // ckUtilizaReboque
            // 
            this.ckUtilizaReboque.AutoSize = true;
            this.ckUtilizaReboque.Location = new System.Drawing.Point(16, 45);
            this.ckUtilizaReboque.Name = "ckUtilizaReboque";
            this.ckUtilizaReboque.Size = new System.Drawing.Size(96, 17);
            this.ckUtilizaReboque.TabIndex = 9;
            this.ckUtilizaReboque.Text = "Utiliza reboque";
            this.ckUtilizaReboque.UseVisualStyleBackColor = true;
            // 
            // txtQtdePortas
            // 
            this.txtQtdePortas.Location = new System.Drawing.Point(96, 19);
            this.txtQtdePortas.Name = "txtQtdePortas";
            this.txtQtdePortas.Size = new System.Drawing.Size(51, 20);
            this.txtQtdePortas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtde de portas";
            // 
            // btnCarro
            // 
            this.btnCarro.Location = new System.Drawing.Point(37, 68);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(75, 23);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Criar Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Kg";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(377, 12);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(51, 20);
            this.txtCapacidade.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Capacidade";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 20);
            this.txtNome.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 490);
            this.Controls.Add(this.txtVelocidadeLimpador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVelocidadeLimpador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAcionaLimpador;
        private System.Windows.Forms.Button btnAbrirPortas;
        private System.Windows.Forms.Button btnPagarPedagio;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDescarregar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEmpinar;
        private System.Windows.Forms.TextBox txtCarregar;
        private System.Windows.Forms.TextBox txtPesqVeiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtQtdeEixos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCriarCaminhao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCilindradas;
        private System.Windows.Forms.Label Cilindradas;
        private System.Windows.Forms.Button btnCriarMoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckUtilizaReboque;
        private System.Windows.Forms.TextBox txtQtdePortas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}

