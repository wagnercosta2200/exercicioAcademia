namespace Usuario_Cadastro
{
    partial class frm_Cadastro
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_Telefone = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_Cadastar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(150, 35);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(336, 35);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(51, 15);
            this.lbl_Telefone.TabIndex = 1;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(150, 88);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(28, 15);
            this.lbl_Cpf.TabIndex = 2;
            this.lbl_Cpf.Text = "CPF";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(336, 88);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(39, 15);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(432, 88);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(30, 15);
            this.lbl_Tipo.TabIndex = 4;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(150, 53);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(180, 23);
            this.tb_nome.TabIndex = 5;
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(336, 53);
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(186, 23);
            this.tb_Telefone.TabIndex = 6;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(150, 107);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(180, 23);
            this.tb_cpf.TabIndex = 7;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmb_status.Location = new System.Drawing.Point(336, 107);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(90, 23);
            this.cmb_status.TabIndex = 8;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cmb_tipo.Location = new System.Drawing.Point(432, 107);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(90, 23);
            this.cmb_tipo.TabIndex = 9;
            // 
            // btn_Cadastar
            // 
            this.btn_Cadastar.Location = new System.Drawing.Point(150, 154);
            this.btn_Cadastar.Name = "btn_Cadastar";
            this.btn_Cadastar.Size = new System.Drawing.Size(180, 44);
            this.btn_Cadastar.TabIndex = 10;
            this.btn_Cadastar.Text = "Cadastrar";
            this.btn_Cadastar.UseVisualStyleBackColor = true;
            this.btn_Cadastar.Click += new System.EventHandler(this.btn_Cadastar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(342, 154);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(180, 44);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastar);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.tb_Telefone);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "frm_Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nome;
        private Label lbl_Telefone;
        private Label lbl_Cpf;
        private Label lbl_Status;
        private Label lbl_Tipo;
        private TextBox tb_nome;
        private TextBox tb_Telefone;
        private TextBox tb_cpf;
        private ComboBox cmb_status;
        private ComboBox cmb_tipo;
        private Button btn_Cadastar;
        private Button btn_Cancelar;
    }
}