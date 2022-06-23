namespace Garagem2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Disponivel = new System.Windows.Forms.TextBox();
            this.textBox_TamanhoGaragem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Disponivel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_Sairam = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Saida = new System.Windows.Forms.Button();
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.maskedTextBox_Data = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Placa = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox_Hora = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ResumoSaida = new System.Windows.Forms.TextBox();
            this.textBox_ValorHora = new System.Windows.Forms.TextBox();
            this.textBox_Estacionados = new System.Windows.Forms.TextBox();
            this.textBox_Saida = new System.Windows.Forms.TextBox();
            this.listBox_Estacionados = new System.Windows.Forms.ListBox();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.Placa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Disponivel
            // 
            this.textBox_Disponivel.BackColor = System.Drawing.Color.Yellow;
            this.textBox_Disponivel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Disponivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox_Disponivel.Location = new System.Drawing.Point(716, 46);
            this.textBox_Disponivel.Name = "textBox_Disponivel";
            this.textBox_Disponivel.Size = new System.Drawing.Size(67, 25);
            this.textBox_Disponivel.TabIndex = 38;
            this.textBox_Disponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_TamanhoGaragem
            // 
            this.textBox_TamanhoGaragem.BackColor = System.Drawing.Color.Yellow;
            this.textBox_TamanhoGaragem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_TamanhoGaragem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox_TamanhoGaragem.Location = new System.Drawing.Point(716, 15);
            this.textBox_TamanhoGaragem.Name = "textBox_TamanhoGaragem";
            this.textBox_TamanhoGaragem.Size = new System.Drawing.Size(67, 25);
            this.textBox_TamanhoGaragem.TabIndex = 37;
            this.textBox_TamanhoGaragem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(634, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Valor Hora";
            // 
            // Disponivel
            // 
            this.Disponivel.AutoSize = true;
            this.Disponivel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Disponivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Disponivel.Location = new System.Drawing.Point(632, 51);
            this.Disponivel.Name = "Disponivel";
            this.Disponivel.Size = new System.Drawing.Size(74, 17);
            this.Disponivel.TabIndex = 35;
            this.Disponivel.Text = "Disponivel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(627, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total Vagas";
            // 
            // listBox_Sairam
            // 
            this.listBox_Sairam.FormattingEnabled = true;
            this.listBox_Sairam.ItemHeight = 15;
            this.listBox_Sairam.Location = new System.Drawing.Point(310, 192);
            this.listBox_Sairam.Name = "listBox_Sairam";
            this.listBox_Sairam.Size = new System.Drawing.Size(286, 214);
            this.listBox_Sairam.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(380, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Veiculos Que Sairam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(91, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Veiculos Estacionados";
            // 
            // btn_Saida
            // 
            this.btn_Saida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Saida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Saida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Saida.Location = new System.Drawing.Point(481, 67);
            this.btn_Saida.Name = "btn_Saida";
            this.btn_Saida.Size = new System.Drawing.Size(115, 47);
            this.btn_Saida.TabIndex = 29;
            this.btn_Saida.Text = "Saida Veiculo";
            this.btn_Saida.UseVisualStyleBackColor = false;
            this.btn_Saida.Click += new System.EventHandler(this.btn_Saida_Click);
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.BackColor = System.Drawing.Color.Green;
            this.btn_Entrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Entrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Entrada.Location = new System.Drawing.Point(481, 8);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(115, 47);
            this.btn_Entrada.TabIndex = 28;
            this.btn_Entrada.Text = "Entrada Veiculo";
            this.btn_Entrada.UseVisualStyleBackColor = false;
            this.btn_Entrada.Click += new System.EventHandler(this.btn_Entrada_Click);
            // 
            // maskedTextBox_Data
            // 
            this.maskedTextBox_Data.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Data.Location = new System.Drawing.Point(354, 9);
            this.maskedTextBox_Data.Mask = "00/00/0000";
            this.maskedTextBox_Data.Name = "maskedTextBox_Data";
            this.maskedTextBox_Data.Size = new System.Drawing.Size(98, 25);
            this.maskedTextBox_Data.TabIndex = 27;
            this.maskedTextBox_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Data.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_Placa
            // 
            this.maskedTextBox_Placa.BackColor = System.Drawing.Color.Silver;
            this.maskedTextBox_Placa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Placa.Location = new System.Drawing.Point(354, 82);
            this.maskedTextBox_Placa.Mask = "aaa-0000";
            this.maskedTextBox_Placa.Name = "maskedTextBox_Placa";
            this.maskedTextBox_Placa.Size = new System.Drawing.Size(98, 29);
            this.maskedTextBox_Placa.TabIndex = 26;
            this.maskedTextBox_Placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(311, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Placa";
            // 
            // maskedTextBox_Hora
            // 
            this.maskedTextBox_Hora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox_Hora.Location = new System.Drawing.Point(354, 43);
            this.maskedTextBox_Hora.Mask = "00:00";
            this.maskedTextBox_Hora.Name = "maskedTextBox_Hora";
            this.maskedTextBox_Hora.Size = new System.Drawing.Size(98, 25);
            this.maskedTextBox_Hora.TabIndex = 24;
            this.maskedTextBox_Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Hora.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(309, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(308, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data";
            // 
            // textBox_ResumoSaida
            // 
            this.textBox_ResumoSaida.BackColor = System.Drawing.Color.Silver;
            this.textBox_ResumoSaida.Location = new System.Drawing.Point(602, 191);
            this.textBox_ResumoSaida.Multiline = true;
            this.textBox_ResumoSaida.Name = "textBox_ResumoSaida";
            this.textBox_ResumoSaida.Size = new System.Drawing.Size(181, 214);
            this.textBox_ResumoSaida.TabIndex = 41;
            // 
            // textBox_ValorHora
            // 
            this.textBox_ValorHora.BackColor = System.Drawing.Color.Red;
            this.textBox_ValorHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_ValorHora.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_ValorHora.Location = new System.Drawing.Point(716, 76);
            this.textBox_ValorHora.Name = "textBox_ValorHora";
            this.textBox_ValorHora.Size = new System.Drawing.Size(67, 25);
            this.textBox_ValorHora.TabIndex = 42;
            this.textBox_ValorHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Estacionados
            // 
            this.textBox_Estacionados.Location = new System.Drawing.Point(33, 191);
            this.textBox_Estacionados.Multiline = true;
            this.textBox_Estacionados.Name = "textBox_Estacionados";
            this.textBox_Estacionados.Size = new System.Drawing.Size(261, 214);
            this.textBox_Estacionados.TabIndex = 43;
            // 
            // textBox_Saida
            // 
            this.textBox_Saida.Location = new System.Drawing.Point(310, 191);
            this.textBox_Saida.Multiline = true;
            this.textBox_Saida.Name = "textBox_Saida";
            this.textBox_Saida.Size = new System.Drawing.Size(286, 214);
            this.textBox_Saida.TabIndex = 44;
            // 
            // listBox_Estacionados
            // 
            this.listBox_Estacionados.FormattingEnabled = true;
            this.listBox_Estacionados.ItemHeight = 15;
            this.listBox_Estacionados.Location = new System.Drawing.Point(33, 190);
            this.listBox_Estacionados.Name = "listBox_Estacionados";
            this.listBox_Estacionados.Size = new System.Drawing.Size(261, 214);
            this.listBox_Estacionados.TabIndex = 45;
            // 
            // textBox_Total
            // 
            this.textBox_Total.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Total.ForeColor = System.Drawing.Color.Red;
            this.textBox_Total.Location = new System.Drawing.Point(616, 103);
            this.textBox_Total.Multiline = true;
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(167, 71);
            this.textBox_Total.TabIndex = 46;
            this.textBox_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Placa.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Placa.Location = new System.Drawing.Point(39, 174);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(35, 15);
            this.Placa.TabIndex = 47;
            this.Placa.Text = "Placa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(130, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Location = new System.Drawing.Point(230, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Hora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(318, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "Placa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(421, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 51;
            this.label12.Text = "Data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Location = new System.Drawing.Point(491, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 52;
            this.label13.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(545, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "Tempo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.textBox_Estacionados);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.listBox_Estacionados);
            this.Controls.Add(this.textBox_Saida);
            this.Controls.Add(this.textBox_ValorHora);
            this.Controls.Add(this.textBox_ResumoSaida);
            this.Controls.Add(this.textBox_Disponivel);
            this.Controls.Add(this.textBox_TamanhoGaragem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Disponivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox_Sairam);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox_Disponivel;
        private TextBox textBox_TamanhoGaragem;
        private Label label8;
        private Label Disponivel;
        private Label label6;
        private ListBox listBox_Sairam;
        private Label label5;
        private Label label4;
        private Button btn_Saida;
        private Button btn_Entrada;
        private MaskedTextBox maskedTextBox_Data;
        private MaskedTextBox maskedTextBox_Placa;
        private Label label3;
        private MaskedTextBox maskedTextBox_Hora;
        private Label label2;
        private Label label1;
        private TextBox textBox_ResumoSaida;
        private TextBox textBox_ValorHora;
        private TextBox textBox_Estacionados;
        private TextBox textBox_Saida;
        private ListBox listBox_Estacionados;
        private TextBox textBox_Total;
        private Label Placa;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label7;
        private PictureBox pictureBox1;
    }
}