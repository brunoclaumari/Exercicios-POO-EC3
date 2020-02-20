namespace BRUNO_EX10_OBJ
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
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.txtSaque = new System.Windows.Forms.NumericUpDown();
            this.txtDeposito = new System.Windows.Forms.NumericUpDown();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtAgencia = new System.Windows.Forms.NumericUpDown();
            this.txtProcConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgencia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(53, 253);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 1;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(30, 174);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 2;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(30, 110);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nº da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome Titular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo";
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(373, 140);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 6;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(374, 215);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 8;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // txtSaque
            // 
            this.txtSaque.DecimalPlaces = 2;
            this.txtSaque.Location = new System.Drawing.Point(374, 175);
            this.txtSaque.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(120, 20);
            this.txtSaque.TabIndex = 5;
            // 
            // txtDeposito
            // 
            this.txtDeposito.DecimalPlaces = 2;
            this.txtDeposito.Location = new System.Drawing.Point(374, 254);
            this.txtDeposito.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(120, 20);
            this.txtDeposito.TabIndex = 7;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(176, 174);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 3;
            this.btnCriar.Text = "Criar Conta";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(30, 50);
            this.txtAgencia.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(120, 20);
            this.txtAgencia.TabIndex = 0;
            // 
            // txtProcConta
            // 
            this.txtProcConta.Location = new System.Drawing.Point(373, 50);
            this.txtProcConta.Name = "txtProcConta";
            this.txtProcConta.Size = new System.Drawing.Size(99, 20);
            this.txtProcConta.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Conta para procurar";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(372, 80);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(134, 23);
            this.btnProcurar.TabIndex = 19;
            this.btnProcurar.Text = "Procurar Conta";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(223, 322);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(644, 134);
            this.listBox1.TabIndex = 20;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(43, 322);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(134, 23);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar Contas";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 493);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProcConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtSaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtSaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.NumericUpDown txtSaque;
        private System.Windows.Forms.NumericUpDown txtDeposito;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.NumericUpDown txtAgencia;
        private System.Windows.Forms.TextBox txtProcConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListar;
    }
}

