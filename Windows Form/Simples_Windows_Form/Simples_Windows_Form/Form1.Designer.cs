namespace Simples_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.tbbairro = new System.Windows.Forms.TextBox();
            this.tbend = new System.Windows.Forms.TextBox();
            this.tbcpf = new System.Windows.Forms.TextBox();
            this.tbidade = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(66, 233);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(90, 41);
            this.btn_Salvar.TabIndex = 30;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(156, 186);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(236, 23);
            this.tbCidade.TabIndex = 22;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(156, 157);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(236, 23);
            this.tbCEP.TabIndex = 21;
            // 
            // tbbairro
            // 
            this.tbbairro.Location = new System.Drawing.Point(156, 128);
            this.tbbairro.Name = "tbbairro";
            this.tbbairro.Size = new System.Drawing.Size(236, 23);
            this.tbbairro.TabIndex = 20;
            // 
            // tbend
            // 
            this.tbend.Location = new System.Drawing.Point(156, 99);
            this.tbend.Name = "tbend";
            this.tbend.Size = new System.Drawing.Size(236, 23);
            this.tbend.TabIndex = 19;
            // 
            // tbcpf
            // 
            this.tbcpf.Location = new System.Drawing.Point(156, 70);
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(236, 23);
            this.tbcpf.TabIndex = 18;
            // 
            // tbidade
            // 
            this.tbidade.Location = new System.Drawing.Point(156, 41);
            this.tbidade.Name = "tbidade";
            this.tbidade.Size = new System.Drawing.Size(236, 23);
            this.tbidade.TabIndex = 17;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(156, 12);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(236, 23);
            this.tbNome.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.tbbairro);
            this.Controls.Add(this.tbend);
            this.Controls.Add(this.tbcpf);
            this.Controls.Add(this.tbidade);
            this.Controls.Add(this.tbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Salvar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbCidade;
        private TextBox tbCEP;
        private TextBox tbbairro;
        private TextBox tbend;
        private TextBox tbcpf;
        private TextBox tbidade;
        private TextBox tbNome;
    }
}