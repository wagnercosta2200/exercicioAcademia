namespace windowaForm_BancodeDados
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
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxidGlicemia = new System.Windows.Forms.TextBox();
            this.textBoxValorGlicemia = new System.Windows.Forms.TextBox();
            this.textBoxdataMedicao = new System.Windows.Forms.TextBox();
            this.textBoxIdPaciente = new System.Windows.Forms.TextBox();
            this.btn_Adcionar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(23, 12);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(479, 232);
            this.listView_medidasGlicemias.TabIndex = 0;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idMedidaGlicemia";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicimeia";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Medição";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            this.columnHeader4.Width = 100;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(23, 250);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(223, 45);
            this.btn_Conectar.TabIndex = 1;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Glicemia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Glicemia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Medição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id Paqciente";
            // 
            // textBoxidGlicemia
            // 
            this.textBoxidGlicemia.Location = new System.Drawing.Point(146, 301);
            this.textBoxidGlicemia.Name = "textBoxidGlicemia";
            this.textBoxidGlicemia.Size = new System.Drawing.Size(100, 23);
            this.textBoxidGlicemia.TabIndex = 6;
            // 
            // textBoxValorGlicemia
            // 
            this.textBoxValorGlicemia.Location = new System.Drawing.Point(146, 328);
            this.textBoxValorGlicemia.Name = "textBoxValorGlicemia";
            this.textBoxValorGlicemia.Size = new System.Drawing.Size(100, 23);
            this.textBoxValorGlicemia.TabIndex = 7;
            // 
            // textBoxdataMedicao
            // 
            this.textBoxdataMedicao.Location = new System.Drawing.Point(146, 357);
            this.textBoxdataMedicao.Name = "textBoxdataMedicao";
            this.textBoxdataMedicao.Size = new System.Drawing.Size(100, 23);
            this.textBoxdataMedicao.TabIndex = 8;
            // 
            // textBoxIdPaciente
            // 
            this.textBoxIdPaciente.Location = new System.Drawing.Point(146, 386);
            this.textBoxIdPaciente.Name = "textBoxIdPaciente";
            this.textBoxIdPaciente.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdPaciente.TabIndex = 9;
            // 
            // btn_Adcionar
            // 
            this.btn_Adcionar.Location = new System.Drawing.Point(279, 336);
            this.btn_Adcionar.Name = "btn_Adcionar";
            this.btn_Adcionar.Size = new System.Drawing.Size(223, 44);
            this.btn_Adcionar.TabIndex = 10;
            this.btn_Adcionar.Text = "Adcionar";
            this.btn_Adcionar.UseVisualStyleBackColor = true;
            this.btn_Adcionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(279, 250);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(223, 45);
            this.btn_Remover.TabIndex = 11;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Adcionar);
            this.Controls.Add(this.textBoxIdPaciente);
            this.Controls.Add(this.textBoxdataMedicao);
            this.Controls.Add(this.textBoxValorGlicemia);
            this.Controls.Add(this.textBoxidGlicemia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView_medidasGlicemias;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btn_Conectar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxidGlicemia;
        private TextBox textBoxValorGlicemia;
        private TextBox textBoxdataMedicao;
        private TextBox textBoxIdPaciente;
        private Button btn_Adcionar;
        private Button btn_Remover;
    }
}