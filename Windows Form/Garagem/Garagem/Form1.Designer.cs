namespace Garagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_Hora = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Placa = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_Data = new System.Windows.Forms.MaskedTextBox();
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.btn_Saida = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Estacionados = new System.Windows.Forms.ListBox();
            this.listBox_Sairam = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Disponivel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Vagas = new System.Windows.Forms.TextBox();
            this.textBox_Disponivel = new System.Windows.Forms.TextBox();
            this.maskedTextBox_ValorHora = new System.Windows.Forms.MaskedTextBox();
            this.btn_configuracao = new System.Windows.Forms.Button();
            this.textBox_ResumoSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora";
            // 
            // maskedTextBox_Hora
            // 
            this.maskedTextBox_Hora.Location = new System.Drawing.Point(235, 86);
            this.maskedTextBox_Hora.Mask = "00:00";
            this.maskedTextBox_Hora.Name = "maskedTextBox_Hora";
            this.maskedTextBox_Hora.Size = new System.Drawing.Size(71, 23);
            this.maskedTextBox_Hora.TabIndex = 3;
            this.maskedTextBox_Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Hora.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_Placa
            // 
            this.maskedTextBox_Placa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Placa.Location = new System.Drawing.Point(235, 3);
            this.maskedTextBox_Placa.Mask = "aaa-0000";
            this.maskedTextBox_Placa.Name = "maskedTextBox_Placa";
            this.maskedTextBox_Placa.Size = new System.Drawing.Size(71, 23);
            this.maskedTextBox_Placa.TabIndex = 5;
            this.maskedTextBox_Placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Placa";
            // 
            // maskedTextBox_Data
            // 
            this.maskedTextBox_Data.Location = new System.Drawing.Point(235, 43);
            this.maskedTextBox_Data.Mask = "00/00/0000";
            this.maskedTextBox_Data.Name = "maskedTextBox_Data";
            this.maskedTextBox_Data.Size = new System.Drawing.Size(71, 23);
            this.maskedTextBox_Data.TabIndex = 6;
            this.maskedTextBox_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Data.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.Location = new System.Drawing.Point(317, 3);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(99, 47);
            this.btn_Entrada.TabIndex = 7;
            this.btn_Entrada.Text = "Entrada";
            this.btn_Entrada.UseVisualStyleBackColor = true;
            this.btn_Entrada.Click += new System.EventHandler(this.btn_Entrada_Click);
            // 
            // btn_Saida
            // 
            this.btn_Saida.Location = new System.Drawing.Point(317, 62);
            this.btn_Saida.Name = "btn_Saida";
            this.btn_Saida.Size = new System.Drawing.Size(99, 47);
            this.btn_Saida.TabIndex = 8;
            this.btn_Saida.Text = "Saida";
            this.btn_Saida.UseVisualStyleBackColor = true;
            this.btn_Saida.Click += new System.EventHandler(this.btn_Saida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Veiculos Estacionados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Veiculos Que Sairam";
            // 
            // listBox_Estacionados
            // 
            this.listBox_Estacionados.FormattingEnabled = true;
            this.listBox_Estacionados.ItemHeight = 15;
            this.listBox_Estacionados.Location = new System.Drawing.Point(14, 151);
            this.listBox_Estacionados.Name = "listBox_Estacionados";
            this.listBox_Estacionados.Size = new System.Drawing.Size(261, 214);
            this.listBox_Estacionados.TabIndex = 13;
            // 
            // listBox_Sairam
            // 
            this.listBox_Sairam.FormattingEnabled = true;
            this.listBox_Sairam.ItemHeight = 15;
            this.listBox_Sairam.Location = new System.Drawing.Point(302, 151);
            this.listBox_Sairam.Name = "listBox_Sairam";
            this.listBox_Sairam.Size = new System.Drawing.Size(261, 214);
            this.listBox_Sairam.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Vagas";
            // 
            // Disponivel
            // 
            this.Disponivel.AutoSize = true;
            this.Disponivel.Location = new System.Drawing.Point(429, 40);
            this.Disponivel.Name = "Disponivel";
            this.Disponivel.Size = new System.Drawing.Size(62, 15);
            this.Disponivel.TabIndex = 16;
            this.Disponivel.Text = "Disponivel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "R$ Hora";
            // 
            // textBox_Vagas
            // 
            this.textBox_Vagas.Location = new System.Drawing.Point(496, 3);
            this.textBox_Vagas.Name = "textBox_Vagas";
            this.textBox_Vagas.Size = new System.Drawing.Size(67, 23);
            this.textBox_Vagas.TabIndex = 18;
            // 
            // textBox_Disponivel
            // 
            this.textBox_Disponivel.Location = new System.Drawing.Point(496, 32);
            this.textBox_Disponivel.Name = "textBox_Disponivel";
            this.textBox_Disponivel.Size = new System.Drawing.Size(67, 23);
            this.textBox_Disponivel.TabIndex = 19;
            // 
            // maskedTextBox_ValorHora
            // 
            this.maskedTextBox_ValorHora.Location = new System.Drawing.Point(496, 61);
            this.maskedTextBox_ValorHora.Mask = "$ 0 ,00";
            this.maskedTextBox_ValorHora.Name = "maskedTextBox_ValorHora";
            this.maskedTextBox_ValorHora.Size = new System.Drawing.Size(67, 23);
            this.maskedTextBox_ValorHora.TabIndex = 20;
            this.maskedTextBox_ValorHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_configuracao
            // 
            this.btn_configuracao.Location = new System.Drawing.Point(429, 87);
            this.btn_configuracao.Name = "btn_configuracao";
            this.btn_configuracao.Size = new System.Drawing.Size(134, 23);
            this.btn_configuracao.TabIndex = 21;
            this.btn_configuracao.Text = "Configuração";
            this.btn_configuracao.UseVisualStyleBackColor = true;
            this.btn_configuracao.Click += new System.EventHandler(this.btn_configuracao_Click);
            // 
            // textBox_ResumoSaida
            // 
            this.textBox_ResumoSaida.Location = new System.Drawing.Point(583, 145);
            this.textBox_ResumoSaida.Multiline = true;
            this.textBox_ResumoSaida.Name = "textBox_ResumoSaida";
            this.textBox_ResumoSaida.Size = new System.Drawing.Size(205, 220);
            this.textBox_ResumoSaida.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_ResumoSaida);
            this.Controls.Add(this.btn_configuracao);
            this.Controls.Add(this.maskedTextBox_ValorHora);
            this.Controls.Add(this.textBox_Disponivel);
            this.Controls.Add(this.textBox_Vagas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Disponivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox_Sairam);
            this.Controls.Add(this.listBox_Estacionados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Saida);
            this.Controls.Add(this.btn_Entrada);
            this.Controls.Add(this.maskedTextBox_Data);
            this.Controls.Add(this.maskedTextBox_Placa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox_Hora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox_Hora;
        private MaskedTextBox maskedTextBox_Placa;
        private Label label3;
        private MaskedTextBox maskedTextBox_Data;
        private Button btn_Entrada;
        private Button btn_Saida;
        private Label label4;
        private Label label5;
        private ListBox listBox_Estacionados;
        private ListBox listBox_Sairam;
        private Label label6;
        private Label Disponivel;
        private Label label8;
        private TextBox textBox_Vagas;
        private TextBox textBox_Disponivel;
        private MaskedTextBox maskedTextBox_ValorHora;
        private Button btn_configuracao;
        private TextBox textBox_ResumoSaida;
    }
}