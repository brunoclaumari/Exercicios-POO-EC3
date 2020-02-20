namespace N1_BRUNO_JOAO
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataAum = new System.Windows.Forms.MaskedTextBox();
            this.txtExibir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorAum = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAumentoData = new System.Windows.Forms.Button();
            this.btnAumentoValor = new System.Windows.Forms.Button();
            this.btnExibe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(388, 61);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(129, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salario";
            // 
            // txtDataAum
            // 
            this.txtDataAum.Location = new System.Drawing.Point(51, 140);
            this.txtDataAum.Mask = "00/00/0000";
            this.txtDataAum.Name = "txtDataAum";
            this.txtDataAum.Size = new System.Drawing.Size(100, 20);
            this.txtDataAum.TabIndex = 4;
            this.txtDataAum.ValidatingType = typeof(System.DateTime);
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(214, 275);
            this.txtExibir.Multiline = true;
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.Size = new System.Drawing.Size(345, 144);
            this.txtExibir.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aumento por valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aumento por data de admissão";
            // 
            // txtValorAum
            // 
            this.txtValorAum.Location = new System.Drawing.Point(388, 140);
            this.txtValorAum.Name = "txtValorAum";
            this.txtValorAum.Size = new System.Drawing.Size(129, 20);
            this.txtValorAum.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(551, 49);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 32);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAumentoData
            // 
            this.btnAumentoData.Location = new System.Drawing.Point(48, 179);
            this.btnAumentoData.Name = "btnAumentoData";
            this.btnAumentoData.Size = new System.Drawing.Size(114, 32);
            this.btnAumentoData.TabIndex = 10;
            this.btnAumentoData.Text = "Aumentar por Data";
            this.btnAumentoData.UseVisualStyleBackColor = true;
            this.btnAumentoData.Click += new System.EventHandler(this.btnAumentoData_Click);
            // 
            // btnAumentoValor
            // 
            this.btnAumentoValor.Location = new System.Drawing.Point(388, 179);
            this.btnAumentoValor.Name = "btnAumentoValor";
            this.btnAumentoValor.Size = new System.Drawing.Size(114, 32);
            this.btnAumentoValor.TabIndex = 11;
            this.btnAumentoValor.Text = "Aumentar por valor";
            this.btnAumentoValor.UseVisualStyleBackColor = true;
            this.btnAumentoValor.Click += new System.EventHandler(this.btnAumentoValor_Click);
            // 
            // btnExibe
            // 
            this.btnExibe.Location = new System.Drawing.Point(94, 275);
            this.btnExibe.Name = "btnExibe";
            this.btnExibe.Size = new System.Drawing.Size(114, 32);
            this.btnExibe.TabIndex = 12;
            this.btnExibe.Text = "Exibir Dados";
            this.btnExibe.UseVisualStyleBackColor = true;
            this.btnExibe.Click += new System.EventHandler(this.btnExibe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 465);
            this.Controls.Add(this.btnExibe);
            this.Controls.Add(this.btnAumentoValor);
            this.Controls.Add(this.btnAumentoData);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtValorAum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.txtDataAum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDataAum;
        private System.Windows.Forms.TextBox txtExibir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorAum;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAumentoData;
        private System.Windows.Forms.Button btnAumentoValor;
        private System.Windows.Forms.Button btnExibe;
    }
}

