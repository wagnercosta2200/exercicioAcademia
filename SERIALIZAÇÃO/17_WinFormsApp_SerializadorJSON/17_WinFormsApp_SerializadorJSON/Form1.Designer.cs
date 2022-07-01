namespace _17_WinFormsApp_SerializadorJSON
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
            this.textBox_conteudoArquivo = new System.Windows.Forms.TextBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Serializar = new System.Windows.Forms.Button();
            this.btn_Deserializar = new System.Windows.Forms.Button();
            this.textBox_nomePaciente = new System.Windows.Forms.TextBox();
            this.textBox_dataNascimento = new System.Windows.Forms.TextBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // textBox_conteudoArquivo
            // 
            this.textBox_conteudoArquivo.Location = new System.Drawing.Point(60, 220);
            this.textBox_conteudoArquivo.Multiline = true;
            this.textBox_conteudoArquivo.Name = "textBox_conteudoArquivo";
            this.textBox_conteudoArquivo.Size = new System.Drawing.Size(676, 218);
            this.textBox_conteudoArquivo.TabIndex = 3;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(57, 140);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(122, 51);
            this.btn_Gravar.TabIndex = 4;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Serializar
            // 
            this.btn_Serializar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Serializar.Location = new System.Drawing.Point(334, 140);
            this.btn_Serializar.Name = "btn_Serializar";
            this.btn_Serializar.Size = new System.Drawing.Size(122, 51);
            this.btn_Serializar.TabIndex = 5;
            this.btn_Serializar.Text = "Serializar";
            this.btn_Serializar.UseVisualStyleBackColor = true;
            this.btn_Serializar.Click += new System.EventHandler(this.btn_Serializar_Click);
            // 
            // btn_Deserializar
            // 
            this.btn_Deserializar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Deserializar.Location = new System.Drawing.Point(614, 140);
            this.btn_Deserializar.Name = "btn_Deserializar";
            this.btn_Deserializar.Size = new System.Drawing.Size(122, 51);
            this.btn_Deserializar.TabIndex = 6;
            this.btn_Deserializar.Text = "Deserializar";
            this.btn_Deserializar.UseVisualStyleBackColor = true;
            this.btn_Deserializar.Click += new System.EventHandler(this.btn_Deserializar_Click);
            // 
            // textBox_nomePaciente
            // 
            this.textBox_nomePaciente.Location = new System.Drawing.Point(154, 32);
            this.textBox_nomePaciente.Name = "textBox_nomePaciente";
            this.textBox_nomePaciente.Size = new System.Drawing.Size(220, 23);
            this.textBox_nomePaciente.TabIndex = 7;
            // 
            // textBox_dataNascimento
            // 
            this.textBox_dataNascimento.Location = new System.Drawing.Point(154, 62);
            this.textBox_dataNascimento.Name = "textBox_dataNascimento";
            this.textBox_dataNascimento.Size = new System.Drawing.Size(220, 23);
            this.textBox_dataNascimento.TabIndex = 8;
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.Location = new System.Drawing.Point(154, 92);
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(220, 23);
            this.textBox_cpf.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_cpf);
            this.Controls.Add(this.textBox_dataNascimento);
            this.Controls.Add(this.textBox_nomePaciente);
            this.Controls.Add(this.btn_Deserializar);
            this.Controls.Add(this.btn_Serializar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.textBox_conteudoArquivo);
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
        private TextBox textBox_conteudoArquivo;
        private Button btn_Gravar;
        private Button btn_Serializar;
        private Button btn_Deserializar;
        private TextBox textBox_nomePaciente;
        private TextBox textBox_dataNascimento;
        private TextBox textBox_cpf;
    }
}