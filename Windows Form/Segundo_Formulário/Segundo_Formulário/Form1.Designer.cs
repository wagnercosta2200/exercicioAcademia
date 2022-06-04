namespace Segundo_Formulário
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
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.tb_ModeloCarro = new System.Windows.Forms.TextBox();
            this.lbl_ModeloCarro = new System.Windows.Forms.Label();
            this.lbl_FabricanteDoCarro = new System.Windows.Forms.Label();
            this.tb_FabricanteCarro = new System.Windows.Forms.TextBox();
            this.lbl_Opcionais = new System.Windows.Forms.Label();
            this.lb_Opcionais = new System.Windows.Forms.CheckedListBox();
            this.cmb_Portas = new System.Windows.Forms.ComboBox();
            this.lbl_QtdPortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Salvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Salvar.Location = new System.Drawing.Point(547, 316);
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
            this.btn_Limpar.Location = new System.Drawing.Point(682, 316);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Segundo Formulário";
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
    }
}