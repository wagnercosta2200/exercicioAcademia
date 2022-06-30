namespace DesafioVendas
{
    partial class Form_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cad_Vendas = new System.Windows.Forms.Button();
            this.btn_Cad_Clientes = new System.Windows.Forms.Button();
            this.btn_Cad_Produtos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // btn_Cad_Vendas
            // 
            this.btn_Cad_Vendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cad_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cad_Vendas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cad_Vendas.ForeColor = System.Drawing.Color.Black;
            this.btn_Cad_Vendas.Image = global::DesafioVendas.Properties.Resources.BtnCad_Vendas;
            this.btn_Cad_Vendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cad_Vendas.Location = new System.Drawing.Point(28, 242);
            this.btn_Cad_Vendas.Name = "btn_Cad_Vendas";
            this.btn_Cad_Vendas.Size = new System.Drawing.Size(134, 88);
            this.btn_Cad_Vendas.TabIndex = 7;
            this.btn_Cad_Vendas.Text = "Cadastrar Vendas";
            this.btn_Cad_Vendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cad_Vendas.UseVisualStyleBackColor = true;
            this.btn_Cad_Vendas.Click += new System.EventHandler(this.btn_Cad_Vendas_Click);
            // 
            // btn_Cad_Clientes
            // 
            this.btn_Cad_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cad_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cad_Clientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cad_Clientes.ForeColor = System.Drawing.Color.Black;
            this.btn_Cad_Clientes.Image = global::DesafioVendas.Properties.Resources.BtnCad_clientes;
            this.btn_Cad_Clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cad_Clientes.Location = new System.Drawing.Point(28, 148);
            this.btn_Cad_Clientes.Name = "btn_Cad_Clientes";
            this.btn_Cad_Clientes.Size = new System.Drawing.Size(134, 88);
            this.btn_Cad_Clientes.TabIndex = 6;
            this.btn_Cad_Clientes.Text = "Cadastrar Clientes";
            this.btn_Cad_Clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cad_Clientes.UseVisualStyleBackColor = true;
            this.btn_Cad_Clientes.Click += new System.EventHandler(this.btn_Cad_Clientes_Click);
            // 
            // btn_Cad_Produtos
            // 
            this.btn_Cad_Produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cad_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cad_Produtos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cad_Produtos.ForeColor = System.Drawing.Color.Black;
            this.btn_Cad_Produtos.Image = global::DesafioVendas.Properties.Resources.BtnCad_Produto;
            this.btn_Cad_Produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cad_Produtos.Location = new System.Drawing.Point(28, 54);
            this.btn_Cad_Produtos.Name = "btn_Cad_Produtos";
            this.btn_Cad_Produtos.Size = new System.Drawing.Size(134, 88);
            this.btn_Cad_Produtos.TabIndex = 5;
            this.btn_Cad_Produtos.Text = "Cadastrar Produtos";
            this.btn_Cad_Produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cad_Produtos.UseVisualStyleBackColor = true;
            this.btn_Cad_Produtos.Click += new System.EventHandler(this.btn_Cad_Produtos_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DesafioVendas.Properties.Resources.logEstacionamento;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cad_Vendas);
            this.Controls.Add(this.btn_Cad_Clientes);
            this.Controls.Add(this.btn_Cad_Produtos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private Button btn_Cad_Vendas;
        private Button btn_Cad_Clientes;
        private Button btn_Cad_Produtos;
    }
}