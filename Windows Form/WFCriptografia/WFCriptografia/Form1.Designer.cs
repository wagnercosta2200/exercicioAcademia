namespace WFCriptografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCripto = new System.Windows.Forms.Label();
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.btn_Criptografia = new System.Windows.Forms.Button();
            this.lblDescripto = new System.Windows.Forms.Label();
            this.btn_Descriptografar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbChave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_CriptonEAS = new System.Windows.Forms.Button();
            this.btn_DescriptonEAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase";
            // 
            // lblCripto
            // 
            this.lblCripto.AutoSize = true;
            this.lblCripto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCripto.ForeColor = System.Drawing.Color.White;
            this.lblCripto.Location = new System.Drawing.Point(39, 155);
            this.lblCripto.Name = "lblCripto";
            this.lblCripto.Size = new System.Drawing.Size(114, 15);
            this.lblCripto.TabIndex = 1;
            this.lblCripto.Text = "Frase criptografada";
            // 
            // txbFrase
            // 
            this.txbFrase.Location = new System.Drawing.Point(108, 53);
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.Size = new System.Drawing.Size(481, 23);
            this.txbFrase.TabIndex = 2;
            // 
            // btn_Criptografia
            // 
            this.btn_Criptografia.BackColor = System.Drawing.Color.Yellow;
            this.btn_Criptografia.ForeColor = System.Drawing.Color.Blue;
            this.btn_Criptografia.Location = new System.Drawing.Point(39, 95);
            this.btn_Criptografia.Name = "btn_Criptografia";
            this.btn_Criptografia.Size = new System.Drawing.Size(87, 41);
            this.btn_Criptografia.TabIndex = 3;
            this.btn_Criptografia.Text = "Criptografia Assimetrica";
            this.btn_Criptografia.UseVisualStyleBackColor = false;
            this.btn_Criptografia.Click += new System.EventHandler(this.btn_Criptografia_Click);
            // 
            // lblDescripto
            // 
            this.lblDescripto.AutoSize = true;
            this.lblDescripto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripto.ForeColor = System.Drawing.Color.White;
            this.lblDescripto.Location = new System.Drawing.Point(39, 193);
            this.lblDescripto.Name = "lblDescripto";
            this.lblDescripto.Size = new System.Drawing.Size(135, 15);
            this.lblDescripto.TabIndex = 4;
            this.lblDescripto.Text = "Frase Descriptografada";
            // 
            // btn_Descriptografar
            // 
            this.btn_Descriptografar.BackColor = System.Drawing.Color.Yellow;
            this.btn_Descriptografar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Descriptografar.Location = new System.Drawing.Point(132, 95);
            this.btn_Descriptografar.Name = "btn_Descriptografar";
            this.btn_Descriptografar.Size = new System.Drawing.Size(113, 41);
            this.btn_Descriptografar.TabIndex = 5;
            this.btn_Descriptografar.Text = "Descriptografaria Assimetrica";
            this.btn_Descriptografar.UseVisualStyleBackColor = false;
            this.btn_Descriptografar.Click += new System.EventHandler(this.btn_Descriptografar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(251, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Criptografia Simetrico";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbChave
            // 
            this.txbChave.Location = new System.Drawing.Point(655, 53);
            this.txbChave.Name = "txbChave";
            this.txbChave.Size = new System.Drawing.Size(119, 23);
            this.txbChave.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chave";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(381, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Descriptografia Simetrico";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_CriptonEAS
            // 
            this.btn_CriptonEAS.BackColor = System.Drawing.Color.Yellow;
            this.btn_CriptonEAS.ForeColor = System.Drawing.Color.Blue;
            this.btn_CriptonEAS.Location = new System.Drawing.Point(511, 95);
            this.btn_CriptonEAS.Name = "btn_CriptonEAS";
            this.btn_CriptonEAS.Size = new System.Drawing.Size(124, 41);
            this.btn_CriptonEAS.TabIndex = 10;
            this.btn_CriptonEAS.Text = "Cripto EAS";
            this.btn_CriptonEAS.UseVisualStyleBackColor = false;
            // 
            // btn_DescriptonEAS
            // 
            this.btn_DescriptonEAS.BackColor = System.Drawing.Color.Yellow;
            this.btn_DescriptonEAS.ForeColor = System.Drawing.Color.Blue;
            this.btn_DescriptonEAS.Location = new System.Drawing.Point(650, 95);
            this.btn_DescriptonEAS.Name = "btn_DescriptonEAS";
            this.btn_DescriptonEAS.Size = new System.Drawing.Size(124, 41);
            this.btn_DescriptonEAS.TabIndex = 11;
            this.btn_DescriptonEAS.Text = "Descripto EAS";
            this.btn_DescriptonEAS.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DescriptonEAS);
            this.Controls.Add(this.btn_CriptonEAS);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbChave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Descriptografar);
            this.Controls.Add(this.lblDescripto);
            this.Controls.Add(this.btn_Criptografia);
            this.Controls.Add(this.txbFrase);
            this.Controls.Add(this.lblCripto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblCripto;
        private TextBox txbFrase;
        private Button btn_Criptografia;
        private Label lblDescripto;
        private Button btn_Descriptografar;
        private Button button1;
        private TextBox txbChave;
        private Label label3;
        private Button button2;
        private Button btn_CriptonEAS;
        private Button btn_DescriptonEAS;
    }
}