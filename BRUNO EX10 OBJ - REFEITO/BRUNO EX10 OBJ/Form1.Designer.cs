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
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 1;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(53, 189);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 2;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(53, 125);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nº da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome Titular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo";
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(376, 90);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 8;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(376, 186);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 9;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // txtSaque
            // 
            this.txtSaque.DecimalPlaces = 2;
            this.txtSaque.Location = new System.Drawing.Point(376, 137);
            this.txtSaque.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(120, 20);
            this.txtSaque.TabIndex = 13;            
            // 
            // txtDeposito
            // 
            this.txtDeposito.DecimalPlaces = 2;
            this.txtDeposito.Location = new System.Drawing.Point(376, 230);
            this.txtDeposito.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(120, 20);
            this.txtDeposito.TabIndex = 14;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(199, 189);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 15;
            this.btnCriar.Text = "Criar Conta";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(53, 65);
            this.txtAgencia.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(120, 20);
            this.txtAgencia.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

