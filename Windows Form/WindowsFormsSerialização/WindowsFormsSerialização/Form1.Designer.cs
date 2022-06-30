namespace WindowsFormsSerialização
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_dataNasimento = new System.Windows.Forms.TextBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.Btn_gravar = new System.Windows.Forms.Button();
            this.btn_serializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(115, 25);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(146, 23);
            this.textBox_Nome.TabIndex = 4;
            // 
            // textBox_dataNasimento
            // 
            this.textBox_dataNasimento.Location = new System.Drawing.Point(380, 25);
            this.textBox_dataNasimento.Name = "textBox_dataNasimento";
            this.textBox_dataNasimento.Size = new System.Drawing.Size(100, 23);
            this.textBox_dataNasimento.TabIndex = 5;
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.Location = new System.Drawing.Point(558, 25);
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(144, 23);
            this.textBox_cpf.TabIndex = 6;
            // 
            // Btn_gravar
            // 
            this.Btn_gravar.Location = new System.Drawing.Point(225, 170);
            this.Btn_gravar.Name = "Btn_gravar";
            this.Btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.Btn_gravar.TabIndex = 7;
            this.Btn_gravar.Text = "Gravar";
            this.Btn_gravar.UseVisualStyleBackColor = true;
            this.Btn_gravar.Click += new System.EventHandler(this.Btn_gravar_Click);
            // 
            // btn_serializar
            // 
            this.btn_serializar.Location = new System.Drawing.Point(428, 170);
            this.btn_serializar.Name = "btn_serializar";
            this.btn_serializar.Size = new System.Drawing.Size(75, 23);
            this.btn_serializar.TabIndex = 8;
            this.btn_serializar.Text = "Serializar";
            this.btn_serializar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_serializar);
            this.Controls.Add(this.Btn_gravar);
            this.Controls.Add(this.textBox_cpf);
            this.Controls.Add(this.textBox_dataNasimento);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Nome;
        private TextBox textBox_dataNasimento;
        private TextBox textBox_cpf;
        private Button Btn_gravar;
        private Button btn_serializar;
    }
}