namespace CadastroUsuario
{
    partial class Frm_Login
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.tB_Usuario = new System.Windows.Forms.TextBox();
            this.tB_Senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OK.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_OK.Location = new System.Drawing.Point(39, 189);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(210, 81);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Cancelar
            // 
            this.lbl_Cancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Cancelar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_Cancelar.Location = new System.Drawing.Point(308, 189);
            this.lbl_Cancelar.Name = "lbl_Cancelar";
            this.lbl_Cancelar.Size = new System.Drawing.Size(210, 81);
            this.lbl_Cancelar.TabIndex = 1;
            this.lbl_Cancelar.Text = "Cancelar";
            this.lbl_Cancelar.UseVisualStyleBackColor = false;
            this.lbl_Cancelar.Click += new System.EventHandler(this.lbl_Cancelar_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.Location = new System.Drawing.Point(39, 47);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(81, 25);
            this.lbl_Usuario.TabIndex = 2;
            this.lbl_Usuario.Text = "Usuário";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Senha.Location = new System.Drawing.Point(39, 112);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(66, 25);
            this.lbl_Senha.TabIndex = 3;
            this.lbl_Senha.Text = "Senha";
            // 
            // tB_Usuario
            // 
            this.tB_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tB_Usuario.Location = new System.Drawing.Point(135, 47);
            this.tB_Usuario.Name = "tB_Usuario";
            this.tB_Usuario.Size = new System.Drawing.Size(383, 25);
            this.tB_Usuario.TabIndex = 4;
            // 
            // tB_Senha
            // 
            this.tB_Senha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tB_Senha.Location = new System.Drawing.Point(135, 112);
            this.tB_Senha.Name = "tB_Senha";
            this.tB_Senha.Size = new System.Drawing.Size(383, 25);
            this.tB_Senha.TabIndex = 5;
            this.tB_Senha.UseSystemPasswordChar = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 312);
            this.Controls.Add(this.tB_Senha);
            this.Controls.Add(this.tB_Usuario);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Cancelar);
            this.Controls.Add(this.btn_OK);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_OK;
        private Button lbl_Cancelar;
        private Label lbl_Usuario;
        private Label lbl_Senha;
        private TextBox tB_Usuario;
        private TextBox tB_Senha;
    }
}