namespace DesafioVendas
{
    partial class Form_Clientes
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
            this.dG_Clientes = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.maskedTextBox_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_NomeCliente = new System.Windows.Forms.TextBox();
            this.textBox_IdCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dG_Clientes
            // 
            this.dG_Clientes.AllowUserToAddRows = false;
            this.dG_Clientes.AllowUserToDeleteRows = false;
            this.dG_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Clientes.Location = new System.Drawing.Point(25, 205);
            this.dG_Clientes.Name = "dG_Clientes";
            this.dG_Clientes.ReadOnly = true;
            this.dG_Clientes.RowTemplate.Height = 25;
            this.dG_Clientes.Size = new System.Drawing.Size(751, 215);
            this.dG_Clientes.TabIndex = 29;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Cancelar.Location = new System.Drawing.Point(577, 154);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 33);
            this.btn_Cancelar.TabIndex = 28;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Excluir.ForeColor = System.Drawing.Color.Blue;
            this.btn_Excluir.Location = new System.Drawing.Point(439, 154);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(99, 33);
            this.btn_Excluir.TabIndex = 27;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Cadastrar.Location = new System.Drawing.Point(301, 154);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(99, 33);
            this.btn_Cadastrar.TabIndex = 26;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_novo.ForeColor = System.Drawing.Color.Blue;
            this.btn_novo.Location = new System.Drawing.Point(161, 154);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(99, 33);
            this.btn_novo.TabIndex = 25;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_Cpf
            // 
            this.maskedTextBox_Cpf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Cpf.Location = new System.Drawing.Point(634, 30);
            this.maskedTextBox_Cpf.Mask = "000000000-00";
            this.maskedTextBox_Cpf.Name = "maskedTextBox_Cpf";
            this.maskedTextBox_Cpf.Size = new System.Drawing.Size(142, 23);
            this.maskedTextBox_Cpf.TabIndex = 24;
            this.maskedTextBox_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox_Telefone
            // 
            this.maskedTextBox_Telefone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Telefone.Location = new System.Drawing.Point(98, 94);
            this.maskedTextBox_Telefone.Mask = "(99) 00000-0000";
            this.maskedTextBox_Telefone.Name = "maskedTextBox_Telefone";
            this.maskedTextBox_Telefone.Size = new System.Drawing.Size(139, 23);
            this.maskedTextBox_Telefone.TabIndex = 23;
            this.maskedTextBox_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Email.Location = new System.Drawing.Point(343, 94);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(433, 23);
            this.textBox_Email.TabIndex = 22;
            // 
            // textBox_NomeCliente
            // 
            this.textBox_NomeCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_NomeCliente.Location = new System.Drawing.Point(254, 30);
            this.textBox_NomeCliente.Name = "textBox_NomeCliente";
            this.textBox_NomeCliente.Size = new System.Drawing.Size(337, 23);
            this.textBox_NomeCliente.TabIndex = 21;
            // 
            // textBox_IdCliente
            // 
            this.textBox_IdCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_IdCliente.Location = new System.Drawing.Point(97, 30);
            this.textBox_IdCliente.Name = "textBox_IdCliente";
            this.textBox_IdCliente.Size = new System.Drawing.Size(100, 23);
            this.textBox_IdCliente.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(597, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id Cliente";
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dG_Clientes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.maskedTextBox_Cpf);
            this.Controls.Add(this.maskedTextBox_Telefone);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_NomeCliente);
            this.Controls.Add(this.textBox_IdCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dG_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dG_Clientes;
        private Button btn_Cancelar;
        private Button btn_Excluir;
        private Button btn_Cadastrar;
        private Button btn_novo;
        private MaskedTextBox maskedTextBox_Cpf;
        private MaskedTextBox maskedTextBox_Telefone;
        private TextBox textBox_Email;
        private TextBox textBox_NomeCliente;
        private TextBox textBox_IdCliente;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}