namespace BRUNO_EX13_INTERF
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
            this.txtCodigoF = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPNomeFun = new System.Windows.Forms.TextBox();
            this.txtNomeF = new System.Windows.Forms.TextBox();
            this.btnPesqFuncNome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPNomeProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesqProdNome = new System.Windows.Forms.Button();
            this.txtPrecoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.btnSalvaFunc = new System.Windows.Forms.Button();
            this.btnSalvaProduto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoF
            // 
            this.txtCodigoF.Location = new System.Drawing.Point(10, 47);
            this.txtCodigoF.Name = "txtCodigoF";
            this.txtCodigoF.Size = new System.Drawing.Size(82, 20);
            this.txtCodigoF.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSalvaFunc);
            this.groupBox1.Controls.Add(this.txtPNomeFun);
            this.groupBox1.Controls.Add(this.txtNomeF);
            this.groupBox1.Controls.Add(this.btnPesqFuncNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoF);
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtPNomeFun
            // 
            this.txtPNomeFun.Location = new System.Drawing.Point(10, 293);
            this.txtPNomeFun.Name = "txtPNomeFun";
            this.txtPNomeFun.Size = new System.Drawing.Size(209, 20);
            this.txtPNomeFun.TabIndex = 5;
            // 
            // txtNomeF
            // 
            this.txtNomeF.Location = new System.Drawing.Point(10, 116);
            this.txtNomeF.Name = "txtNomeF";
            this.txtNomeF.Size = new System.Drawing.Size(219, 20);
            this.txtNomeF.TabIndex = 2;
            // 
            // btnPesqFuncNome
            // 
            this.btnPesqFuncNome.Location = new System.Drawing.Point(10, 240);
            this.btnPesqFuncNome.Name = "btnPesqFuncNome";
            this.btnPesqFuncNome.Size = new System.Drawing.Size(142, 37);
            this.btnPesqFuncNome.TabIndex = 4;
            this.btnPesqFuncNome.Text = "Pesquisar Nome";
            this.btnPesqFuncNome.UseVisualStyleBackColor = true;
            this.btnPesqFuncNome.Click += new System.EventHandler(this.btnPesqFuncNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalvaProduto);
            this.groupBox2.Controls.Add(this.txtPNomeProd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnPesqProdNome);
            this.groupBox2.Controls.Add(this.txtPrecoP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNomeP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCodigoP);
            this.groupBox2.Location = new System.Drawing.Point(364, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 359);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // txtPNomeProd
            // 
            this.txtPNomeProd.Location = new System.Drawing.Point(6, 305);
            this.txtPNomeProd.Name = "txtPNomeProd";
            this.txtPNomeProd.Size = new System.Drawing.Size(209, 20);
            this.txtPNomeProd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Preço";
            // 
            // btnPesqProdNome
            // 
            this.btnPesqProdNome.Location = new System.Drawing.Point(38, 252);
            this.btnPesqProdNome.Name = "btnPesqProdNome";
            this.btnPesqProdNome.Size = new System.Drawing.Size(142, 37);
            this.btnPesqProdNome.TabIndex = 6;
            this.btnPesqProdNome.Text = "Pesquisar Nome";
            this.btnPesqProdNome.UseVisualStyleBackColor = true;
            this.btnPesqProdNome.Click += new System.EventHandler(this.btnPesqProdNome_Click);
            // 
            // txtPrecoP
            // 
            this.txtPrecoP.Location = new System.Drawing.Point(10, 152);
            this.txtPrecoP.Name = "txtPrecoP";
            this.txtPrecoP.Size = new System.Drawing.Size(133, 20);
            this.txtPrecoP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(10, 97);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(133, 20);
            this.txtNomeP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Codigo";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(10, 47);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(82, 20);
            this.txtCodigoP.TabIndex = 4;
            // 
            // btnSalvaFunc
            // 
            this.btnSalvaFunc.Location = new System.Drawing.Point(10, 165);
            this.btnSalvaFunc.Name = "btnSalvaFunc";
            this.btnSalvaFunc.Size = new System.Drawing.Size(142, 37);
            this.btnSalvaFunc.TabIndex = 7;
            this.btnSalvaFunc.Text = "Salvar Dados";
            this.btnSalvaFunc.UseVisualStyleBackColor = true;
            this.btnSalvaFunc.Click += new System.EventHandler(this.btnSalvaFunc_Click);
            // 
            // btnSalvaProduto
            // 
            this.btnSalvaProduto.Location = new System.Drawing.Point(38, 178);
            this.btnSalvaProduto.Name = "btnSalvaProduto";
            this.btnSalvaProduto.Size = new System.Drawing.Size(142, 37);
            this.btnSalvaProduto.TabIndex = 8;
            this.btnSalvaProduto.Text = "Salvar Dados";
            this.btnSalvaProduto.UseVisualStyleBackColor = true;
            this.btnSalvaProduto.Click += new System.EventHandler(this.btnSalvaProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Button btnSalvaFunc;
        private System.Windows.Forms.Button btnPesqFuncNome;
        private System.Windows.Forms.TextBox txtPNomeFun;
        private System.Windows.Forms.TextBox txtPNomeProd;
        private System.Windows.Forms.Button btnPesqProdNome;
        private System.Windows.Forms.Button btnSalvaProduto;
    }
}

