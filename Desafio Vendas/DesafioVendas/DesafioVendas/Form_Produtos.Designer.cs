namespace DesafioVendas
{
    partial class Form_Produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_IdProduto = new System.Windows.Forms.TextBox();
            this.textBox_NomeProduto = new System.Windows.Forms.TextBox();
            this.textBox_Estoque = new System.Windows.Forms.TextBox();
            this.maskedTextBox_Preco = new System.Windows.Forms.MaskedTextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.textBox_CodEAN = new System.Windows.Forms.TextBox();
            this.dG_Produtos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(587, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo EAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(423, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estoque";
            // 
            // textBox_IdProduto
            // 
            this.textBox_IdProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_IdProduto.Location = new System.Drawing.Point(84, 21);
            this.textBox_IdProduto.Name = "textBox_IdProduto";
            this.textBox_IdProduto.Size = new System.Drawing.Size(100, 23);
            this.textBox_IdProduto.TabIndex = 1;
            // 
            // textBox_NomeProduto
            // 
            this.textBox_NomeProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_NomeProduto.Location = new System.Drawing.Point(246, 21);
            this.textBox_NomeProduto.Name = "textBox_NomeProduto";
            this.textBox_NomeProduto.Size = new System.Drawing.Size(332, 23);
            this.textBox_NomeProduto.TabIndex = 3;
            // 
            // textBox_Estoque
            // 
            this.textBox_Estoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Estoque.Location = new System.Drawing.Point(486, 76);
            this.textBox_Estoque.Name = "textBox_Estoque";
            this.textBox_Estoque.Size = new System.Drawing.Size(90, 23);
            this.textBox_Estoque.TabIndex = 9;
            // 
            // maskedTextBox_Preco
            // 
            this.maskedTextBox_Preco.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Preco.Location = new System.Drawing.Point(632, 21);
            this.maskedTextBox_Preco.Mask = "$ 00,00";
            this.maskedTextBox_Preco.Name = "maskedTextBox_Preco";
            this.maskedTextBox_Preco.Size = new System.Drawing.Size(88, 23);
            this.maskedTextBox_Preco.TabIndex = 5;
            this.maskedTextBox_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_novo.ForeColor = System.Drawing.Color.Blue;
            this.btn_novo.Location = new System.Drawing.Point(148, 145);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(99, 33);
            this.btn_novo.TabIndex = 10;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Cadastrar.Location = new System.Drawing.Point(288, 145);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(99, 33);
            this.btn_Cadastrar.TabIndex = 11;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Excluir.ForeColor = System.Drawing.Color.Blue;
            this.btn_Excluir.Location = new System.Drawing.Point(426, 145);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(99, 33);
            this.btn_Excluir.TabIndex = 12;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Cancelar.Location = new System.Drawing.Point(564, 145);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 33);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // textBox_CodEAN
            // 
            this.textBox_CodEAN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_CodEAN.Location = new System.Drawing.Point(246, 76);
            this.textBox_CodEAN.Name = "textBox_CodEAN";
            this.textBox_CodEAN.Size = new System.Drawing.Size(100, 23);
            this.textBox_CodEAN.TabIndex = 7;
            // 
            // dG_Produtos
            // 
            this.dG_Produtos.AllowUserToAddRows = false;
            this.dG_Produtos.AllowUserToDeleteRows = false;
            this.dG_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Produtos.Location = new System.Drawing.Point(12, 201);
            this.dG_Produtos.Name = "dG_Produtos";
            this.dG_Produtos.ReadOnly = true;
            this.dG_Produtos.RowTemplate.Height = 25;
            this.dG_Produtos.Size = new System.Drawing.Size(732, 205);
            this.dG_Produtos.TabIndex = 14;
            // 
            // Form_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.dG_Produtos);
            this.Controls.Add(this.textBox_CodEAN);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.maskedTextBox_Preco);
            this.Controls.Add(this.textBox_Estoque);
            this.Controls.Add(this.textBox_NomeProduto);
            this.Controls.Add(this.textBox_IdProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dG_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_IdProduto;
        private TextBox textBox_NomeProduto;
        private TextBox textBox_Estoque;
        private MaskedTextBox maskedTextBox_Preco;
        private Button btn_novo;
        private Button btn_Cadastrar;
        private Button btn_Excluir;
        private Button btn_Cancelar;
        private TextBox textBox_CodEAN;
        private DataGridView dG_Produtos;
    }
}