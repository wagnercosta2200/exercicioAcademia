namespace Segundo_Formulário
{
    partial class frmAutomovel
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
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.tb_ModeloCarro = new System.Windows.Forms.TextBox();
            this.lbl_ModeloCarro = new System.Windows.Forms.Label();
            this.lbl_FabricanteDoCarro = new System.Windows.Forms.Label();
            this.tb_FabricanteCarro = new System.Windows.Forms.TextBox();
            this.lbl_Opcionais = new System.Windows.Forms.Label();
            this.lb_Opcionais = new System.Windows.Forms.CheckedListBox();
            this.cmb_Portas = new System.Windows.Forms.ComboBox();
            this.lbl_QtdPortas = new System.Windows.Forms.Label();
            this.dgAutomoveis = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Freio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Portas = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Salvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Salvar.Location = new System.Drawing.Point(128, 289);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(94, 43);
            this.btn_Salvar.TabIndex = 0;
            this.btn_Salvar.Text = "SALVAR";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Limpar.Location = new System.Drawing.Point(243, 289);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(95, 43);
            this.btn_Limpar.TabIndex = 1;
            this.btn_Limpar.Text = "LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // tb_ModeloCarro
            // 
            this.tb_ModeloCarro.Location = new System.Drawing.Point(128, 12);
            this.tb_ModeloCarro.Name = "tb_ModeloCarro";
            this.tb_ModeloCarro.Size = new System.Drawing.Size(210, 23);
            this.tb_ModeloCarro.TabIndex = 2;
            // 
            // lbl_ModeloCarro
            // 
            this.lbl_ModeloCarro.AutoSize = true;
            this.lbl_ModeloCarro.Location = new System.Drawing.Point(12, 20);
            this.lbl_ModeloCarro.Name = "lbl_ModeloCarro";
            this.lbl_ModeloCarro.Size = new System.Drawing.Size(80, 15);
            this.lbl_ModeloCarro.TabIndex = 3;
            this.lbl_ModeloCarro.Text = "Modelo Carro";
            // 
            // lbl_FabricanteDoCarro
            // 
            this.lbl_FabricanteDoCarro.AutoSize = true;
            this.lbl_FabricanteDoCarro.Location = new System.Drawing.Point(12, 65);
            this.lbl_FabricanteDoCarro.Name = "lbl_FabricanteDoCarro";
            this.lbl_FabricanteDoCarro.Size = new System.Drawing.Size(111, 15);
            this.lbl_FabricanteDoCarro.TabIndex = 4;
            this.lbl_FabricanteDoCarro.Text = "Fabricante do Carro";
            this.lbl_FabricanteDoCarro.Click += new System.EventHandler(this.lbl_FabricanteDoCarro_Click);
            // 
            // tb_FabricanteCarro
            // 
            this.tb_FabricanteCarro.Location = new System.Drawing.Point(128, 57);
            this.tb_FabricanteCarro.Name = "tb_FabricanteCarro";
            this.tb_FabricanteCarro.Size = new System.Drawing.Size(210, 23);
            this.tb_FabricanteCarro.TabIndex = 5;
            // 
            // lbl_Opcionais
            // 
            this.lbl_Opcionais.AutoSize = true;
            this.lbl_Opcionais.Location = new System.Drawing.Point(12, 107);
            this.lbl_Opcionais.Name = "lbl_Opcionais";
            this.lbl_Opcionais.Size = new System.Drawing.Size(60, 15);
            this.lbl_Opcionais.TabIndex = 6;
            this.lbl_Opcionais.Text = "Opcionais";
            // 
            // lb_Opcionais
            // 
            this.lb_Opcionais.FormattingEnabled = true;
            this.lb_Opcionais.Items.AddRange(new object[] {
            "Ar Condicionado",
            "Direção Hidraulica",
            "Freios Abs",
            "Air bag",
            "Vidros Elétricos"});
            this.lb_Opcionais.Location = new System.Drawing.Point(128, 106);
            this.lb_Opcionais.Name = "lb_Opcionais";
            this.lb_Opcionais.Size = new System.Drawing.Size(210, 94);
            this.lb_Opcionais.TabIndex = 7;
            // 
            // cmb_Portas
            // 
            this.cmb_Portas.FormattingEnabled = true;
            this.cmb_Portas.Items.AddRange(new object[] {
            "2 Portas",
            "3 Portas",
            "4 Portas",
            "5 Portas"});
            this.cmb_Portas.Location = new System.Drawing.Point(128, 206);
            this.cmb_Portas.Name = "cmb_Portas";
            this.cmb_Portas.Size = new System.Drawing.Size(210, 23);
            this.cmb_Portas.TabIndex = 8;
            // 
            // lbl_QtdPortas
            // 
            this.lbl_QtdPortas.AutoSize = true;
            this.lbl_QtdPortas.Location = new System.Drawing.Point(23, 213);
            this.lbl_QtdPortas.Name = "lbl_QtdPortas";
            this.lbl_QtdPortas.Size = new System.Drawing.Size(63, 15);
            this.lbl_QtdPortas.TabIndex = 9;
            this.lbl_QtdPortas.Text = "Qtd Portas";
            // 
            // dgAutomoveis
            // 
            this.dgAutomoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomoveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DH,
            this.Freio,
            this.VE,
            this.AB,
            this.Portas});
            this.dgAutomoveis.Location = new System.Drawing.Point(359, 12);
            this.dgAutomoveis.Name = "dgAutomoveis";
            this.dgAutomoveis.RowTemplate.Height = 25;
            this.dgAutomoveis.Size = new System.Drawing.Size(429, 320);
            this.dgAutomoveis.TabIndex = 10;
            this.dgAutomoveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // Ac
            // 
            this.Ac.HeaderText = "Ar Condicionado";
            this.Ac.Name = "Ac";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fabricante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 10F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ar";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.Width = 30;
            // 
            // DH
            // 
            this.DH.FillWeight = 20F;
            this.DH.HeaderText = "DH";
            this.DH.Name = "DH";
            this.DH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DH.Width = 30;
            // 
            // Freio
            // 
            this.Freio.FillWeight = 20F;
            this.Freio.HeaderText = "Abs";
            this.Freio.Name = "Freio";
            this.Freio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Freio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Freio.Width = 30;
            // 
            // VE
            // 
            this.VE.FillWeight = 20F;
            this.VE.HeaderText = "VE";
            this.VE.Name = "VE";
            this.VE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VE.Width = 30;
            // 
            // AB
            // 
            this.AB.FillWeight = 20F;
            this.AB.HeaderText = "Ab";
            this.AB.Name = "AB";
            this.AB.Width = 30;
            // 
            // Portas
            // 
            this.Portas.FillWeight = 30F;
            this.Portas.HeaderText = "Portas";
            this.Portas.Name = "Portas";
            this.Portas.Width = 50;
            // 
            // frmAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgAutomoveis);
            this.Controls.Add(this.lbl_QtdPortas);
            this.Controls.Add(this.cmb_Portas);
            this.Controls.Add(this.lb_Opcionais);
            this.Controls.Add(this.lbl_Opcionais);
            this.Controls.Add(this.tb_FabricanteCarro);
            this.Controls.Add(this.lbl_FabricanteDoCarro);
            this.Controls.Add(this.lbl_ModeloCarro);
            this.Controls.Add(this.tb_ModeloCarro);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Salvar);
            this.Name = "frmAutomovel";
            this.Text = "Cadastrar Automovel";
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomoveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Salvar;
        private Button btn_Limpar;
        private TextBox tb_ModeloCarro;
        public Label lbl_ModeloCarro;
        private Label lbl_FabricanteDoCarro;
        private TextBox tb_FabricanteCarro;
        private Label lbl_Opcionais;
        private CheckedListBox lb_Opcionais;
        private ComboBox cmb_Portas;
        private Label lbl_QtdPortas;
        private DataGridView dgAutomoveis;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Fabricante;
        private DataGridViewTextBoxColumn Ac;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn DH;
        private DataGridViewCheckBoxColumn Freio;
        private DataGridViewCheckBoxColumn VE;
        private DataGridViewCheckBoxColumn AB;
        private DataGridViewButtonColumn Portas;
    }
}