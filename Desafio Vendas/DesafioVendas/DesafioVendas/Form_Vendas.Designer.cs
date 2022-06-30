namespace DesafioVendas
{
    partial class Form_Vendas
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
            this.textBox_ValorTotal = new System.Windows.Forms.TextBox();
            this.textBox_IdVenda = new System.Windows.Forms.TextBox();
            this.textBox_Id_ItemVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IdProduto = new System.Windows.Forms.TextBox();
            this.textBox_ValorUnitario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dG_Clientes
            // 
            this.dG_Clientes.AllowUserToAddRows = false;
            this.dG_Clientes.AllowUserToDeleteRows = false;
            this.dG_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Clientes.Location = new System.Drawing.Point(25, 203);
            this.dG_Clientes.Name = "dG_Clientes";
            this.dG_Clientes.ReadOnly = true;
            this.dG_Clientes.RowTemplate.Height = 25;
            this.dG_Clientes.Size = new System.Drawing.Size(751, 217);
            this.dG_Clientes.TabIndex = 44;
            this.dG_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dG_Clientes_CellContentClick);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Cancelar.Location = new System.Drawing.Point(577, 154);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 33);
            this.btn_Cancelar.TabIndex = 43;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Excluir.ForeColor = System.Drawing.Color.Blue;
            this.btn_Excluir.Location = new System.Drawing.Point(439, 154);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(99, 33);
            this.btn_Excluir.TabIndex = 42;
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
            this.btn_Cadastrar.TabIndex = 41;
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
            this.btn_novo.TabIndex = 40;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // textBox_ValorTotal
            // 
            this.textBox_ValorTotal.BackColor = System.Drawing.Color.Yellow;
            this.textBox_ValorTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_ValorTotal.ForeColor = System.Drawing.Color.Red;
            this.textBox_ValorTotal.Location = new System.Drawing.Point(480, 55);
            this.textBox_ValorTotal.Multiline = true;
            this.textBox_ValorTotal.Name = "textBox_ValorTotal";
            this.textBox_ValorTotal.Size = new System.Drawing.Size(100, 59);
            this.textBox_ValorTotal.TabIndex = 37;
            this.textBox_ValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_IdVenda
            // 
            this.textBox_IdVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_IdVenda.Location = new System.Drawing.Point(271, 30);
            this.textBox_IdVenda.Name = "textBox_IdVenda";
            this.textBox_IdVenda.Size = new System.Drawing.Size(100, 23);
            this.textBox_IdVenda.TabIndex = 36;
            this.textBox_IdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Id_ItemVenda
            // 
            this.textBox_Id_ItemVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Id_ItemVenda.Location = new System.Drawing.Point(97, 30);
            this.textBox_Id_ItemVenda.Name = "textBox_Id_ItemVenda";
            this.textBox_Id_ItemVenda.Size = new System.Drawing.Size(100, 23);
            this.textBox_Id_ItemVenda.TabIndex = 35;
            this.textBox_Id_ItemVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(408, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Valor Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Valor Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(406, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id Venda";
            // 
            // textBox_IdProduto
            // 
            this.textBox_IdProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_IdProduto.Location = new System.Drawing.Point(480, 30);
            this.textBox_IdProduto.Name = "textBox_IdProduto";
            this.textBox_IdProduto.Size = new System.Drawing.Size(100, 23);
            this.textBox_IdProduto.TabIndex = 45;
            this.textBox_IdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ValorUnitario
            // 
            this.textBox_ValorUnitario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_ValorUnitario.Location = new System.Drawing.Point(271, 91);
            this.textBox_ValorUnitario.Name = "textBox_ValorUnitario";
            this.textBox_ValorUnitario.Size = new System.Drawing.Size(100, 23);
            this.textBox_ValorUnitario.TabIndex = 46;
            this.textBox_ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_ValorUnitario);
            this.Controls.Add(this.textBox_IdProduto);
            this.Controls.Add(this.dG_Clientes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.textBox_ValorTotal);
            this.Controls.Add(this.textBox_IdVenda);
            this.Controls.Add(this.textBox_Id_ItemVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Vendas";
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
        private TextBox textBox_ValorTotal;
        private TextBox textBox_IdVenda;
        private TextBox textBox_Id_ItemVenda;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_IdProduto;
        private TextBox textBox_ValorUnitario;
    }
}