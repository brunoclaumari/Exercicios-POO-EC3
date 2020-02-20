namespace POO_N1
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtIten = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtFatu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butNCad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(12, 59);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(89, 20);
            this.txtCod.TabIndex = 0;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(147, 59);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(89, 20);
            this.txtQtd.TabIndex = 1;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(269, 59);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(89, 20);
            this.txtPre.TabIndex = 2;
            // 
            // txtIten
            // 
            this.txtIten.Location = new System.Drawing.Point(12, 146);
            this.txtIten.Name = "txtIten";
            this.txtIten.Size = new System.Drawing.Size(89, 20);
            this.txtIten.TabIndex = 3;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(147, 146);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(211, 20);
            this.txtDescr.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código do Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(16, 204);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(172, 42);
            this.btn.TabIndex = 10;
            this.btn.Text = "Cadastrar Tarifa";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtFatu
            // 
            this.txtFatu.Location = new System.Drawing.Point(241, 226);
            this.txtFatu.Name = "txtFatu";
            this.txtFatu.Size = new System.Drawing.Size(117, 20);
            this.txtFatu.TabIndex = 12;
            this.txtFatu.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tarifa Total";
            this.label6.Visible = false;
            // 
            // butNCad
            // 
            this.butNCad.Location = new System.Drawing.Point(16, 274);
            this.butNCad.Name = "butNCad";
            this.butNCad.Size = new System.Drawing.Size(147, 36);
            this.butNCad.TabIndex = 14;
            this.butNCad.Text = "Adicionar a lista";
            this.butNCad.UseVisualStyleBackColor = true;
            this.butNCad.Click += new System.EventHandler(this.butNCad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 373);
            this.Controls.Add(this.butNCad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFatu);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.txtIten);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtCod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtIten;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtFatu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butNCad;
    }
}

