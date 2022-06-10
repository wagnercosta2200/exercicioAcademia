namespace _10_Form_Lista_Aquivos
{
    partial class Form_TelaPrincipal
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
            this.textBox_nomePessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cadatrar = new System.Windows.Forms.Button();
            this.button_Remover = new System.Windows.Forms.Button();
            this.textBox_ListadePessoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nomePessoa
            // 
            this.textBox_nomePessoa.Location = new System.Drawing.Point(187, 35);
            this.textBox_nomePessoa.Name = "textBox_nomePessoa";
            this.textBox_nomePessoa.Size = new System.Drawing.Size(222, 23);
            this.textBox_nomePessoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome de Pessoa";
            // 
            // button_Cadatrar
            // 
            this.button_Cadatrar.Location = new System.Drawing.Point(426, 23);
            this.button_Cadatrar.Name = "button_Cadatrar";
            this.button_Cadatrar.Size = new System.Drawing.Size(102, 35);
            this.button_Cadatrar.TabIndex = 2;
            this.button_Cadatrar.Text = "Cadastrar";
            this.button_Cadatrar.UseVisualStyleBackColor = true;
            this.button_Cadatrar.Click += new System.EventHandler(this.button_Cadatrar_Click);
            // 
            // button_Remover
            // 
            this.button_Remover.Location = new System.Drawing.Point(569, 23);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(102, 35);
            this.button_Remover.TabIndex = 3;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            this.button_Remover.Click += new System.EventHandler(this.button_Remover_Click_1);
            // 
            // textBox_ListadePessoa
            // 
            this.textBox_ListadePessoa.Enabled = false;
            this.textBox_ListadePessoa.Location = new System.Drawing.Point(80, 108);
            this.textBox_ListadePessoa.Multiline = true;
            this.textBox_ListadePessoa.Name = "textBox_ListadePessoa";
            this.textBox_ListadePessoa.Size = new System.Drawing.Size(591, 266);
            this.textBox_ListadePessoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de Pessoas Cadastradas";
            // 
            // Form_TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ListadePessoa);
            this.Controls.Add(this.button_Remover);
            this.Controls.Add(this.button_Cadatrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nomePessoa);
            this.Name = "Form_TelaPrincipal";
            this.Text = "Formulario Cadastro e Remoção de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_nomePessoa;
        private Label label1;
        private Button button_Cadatrar;
        private Button button_Remover;
        private TextBox textBox_ListadePessoa;
        private Label label2;
    }
}