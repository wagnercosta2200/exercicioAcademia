namespace CadastroUsuario
{
    partial class frm_CadastroUsuario
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
            this.tB_nome = new System.Windows.Forms.TextBox();
            this.tB_Telefone = new System.Windows.Forms.TextBox();
            this.tB_Cpf = new System.Windows.Forms.TextBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(48, 80);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(57, 21);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Telefone.Location = new System.Drawing.Point(48, 131);
            this.lbl_Telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(76, 21);
            this.lbl_Telefone.TabIndex = 1;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cpf.Location = new System.Drawing.Point(48, 188);
            this.lbl_Cpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(38, 21);
            this.lbl_Cpf.TabIndex = 2;
            this.lbl_Cpf.Text = "CPF";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.Location = new System.Drawing.Point(44, 244);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(57, 21);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tipo.Location = new System.Drawing.Point(48, 294);
            this.lbl_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(44, 21);
            this.lbl_Tipo.TabIndex = 4;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // tB_nome
            // 
            this.tB_nome.BackColor = System.Drawing.SystemColors.Window;
            this.tB_nome.Location = new System.Drawing.Point(138, 72);
            this.tB_nome.Margin = new System.Windows.Forms.Padding(4);
            this.tB_nome.Name = "tB_nome";
            this.tB_nome.Size = new System.Drawing.Size(363, 29);
            this.tB_nome.TabIndex = 5;
            // 
            // tB_Telefone
            // 
            this.tB_Telefone.Location = new System.Drawing.Point(138, 123);
            this.tB_Telefone.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Telefone.Name = "tB_Telefone";
            this.tB_Telefone.Size = new System.Drawing.Size(363, 29);
            this.tB_Telefone.TabIndex = 6;
            // 
            // tB_Cpf
            // 
            this.tB_Cpf.Location = new System.Drawing.Point(138, 180);
            this.tB_Cpf.Margin = new System.Windows.Forms.Padding(4);
            this.tB_Cpf.Name = "tB_Cpf";
            this.tB_Cpf.Size = new System.Drawing.Size(363, 29);
            this.tB_Cpf.TabIndex = 7;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmb_tipo.Location = new System.Drawing.Point(138, 286);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(363, 29);
            this.cmb_tipo.TabIndex = 9;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.Location = new System.Drawing.Point(48, 368);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(223, 55);
            this.btn_Cadastrar.TabIndex = 10;
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(278, 368);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(223, 55);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmb_status.Location = new System.Drawing.Point(138, 236);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(363, 29);
            this.cmb_status.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CadastroUsuario.Properties.Resources.download__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(508, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 351);
            this.button1.TabIndex = 12;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1143, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.tB_Cpf);
            this.Controls.Add(this.tB_Telefone);
            this.Controls.Add(this.tB_nome);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_Nome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nome;
        private Label lbl_Telefone;
        private Label lbl_Cpf;
        private Label lbl_Status;
        private Label lbl_Tipo;
        private TextBox tB_nome;
        private TextBox tB_Telefone;
        private TextBox tB_Cpf;
        private ComboBox cmb_tipo;
        private Button btn_Cadastrar;
        private Button btn_Cancelar;
        private ComboBox cmb_status;
        private Button button1;
    }
}