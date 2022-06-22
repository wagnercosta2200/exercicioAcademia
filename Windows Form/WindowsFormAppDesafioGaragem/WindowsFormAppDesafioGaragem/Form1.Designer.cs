namespace WindowsFormAppDesafioGaragem
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSaidaVeiculo = new System.Windows.Forms.TextBox();
            this.label_dataSaida = new System.Windows.Forms.Label();
            this.textBoxEntradaVeiculo = new System.Windows.Forms.TextBox();
            this.button_Saida = new System.Windows.Forms.Button();
            this.button_Entrada = new System.Windows.Forms.Button();
            this.textBox_Placa = new System.Windows.Forms.TextBox();
            this.label_horaSaida = new System.Windows.Forms.Label();
            this.label_placa = new System.Windows.Forms.Label();
            this.label_dataEntrada = new System.Windows.Forms.Label();
            this.label_horaEntrada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtBox_placa = new System.Windows.Forms.MaskedTextBox();
            this.mtBox_dataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mtBox_dataSaida = new System.Windows.Forms.MaskedTextBox();
            this.mtBox_horaEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mtBox_horaSaida = new System.Windows.Forms.MaskedTextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(47, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(127, 94);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(684, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "HORA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(684, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "DATA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_data.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_data.Location = new System.Drawing.Point(68, 61);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(0, 16);
            this.label_data.TabIndex = 40;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_hora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_hora.Location = new System.Drawing.Point(68, 25);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(0, 16);
            this.label_hora.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Lista de veículos que saíram do estacionamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lista de Veículos que estão no estacionamento";
            // 
            // textBoxSaidaVeiculo
            // 
            this.textBoxSaidaVeiculo.Enabled = false;
            this.textBoxSaidaVeiculo.Location = new System.Drawing.Point(341, 149);
            this.textBoxSaidaVeiculo.Multiline = true;
            this.textBoxSaidaVeiculo.Name = "textBoxSaidaVeiculo";
            this.textBoxSaidaVeiculo.Size = new System.Drawing.Size(280, 269);
            this.textBoxSaidaVeiculo.TabIndex = 35;
            // 
            // label_dataSaida
            // 
            this.label_dataSaida.AutoSize = true;
            this.label_dataSaida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dataSaida.Location = new System.Drawing.Point(521, 9);
            this.label_dataSaida.Name = "label_dataSaida";
            this.label_dataSaida.Size = new System.Drawing.Size(74, 17);
            this.label_dataSaida.TabIndex = 33;
            this.label_dataSaida.Text = "Data Saida";
            // 
            // textBoxEntradaVeiculo
            // 
            this.textBoxEntradaVeiculo.Enabled = false;
            this.textBoxEntradaVeiculo.Location = new System.Drawing.Point(47, 149);
            this.textBoxEntradaVeiculo.Multiline = true;
            this.textBoxEntradaVeiculo.Name = "textBoxEntradaVeiculo";
            this.textBoxEntradaVeiculo.Size = new System.Drawing.Size(288, 269);
            this.textBoxEntradaVeiculo.TabIndex = 33;
            // 
            // button_Saida
            // 
            this.button_Saida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Saida.Location = new System.Drawing.Point(204, 89);
            this.button_Saida.Name = "button_Saida";
            this.button_Saida.Size = new System.Drawing.Size(100, 23);
            this.button_Saida.TabIndex = 32;
            this.button_Saida.Text = "Saida";
            this.button_Saida.UseVisualStyleBackColor = true;
            this.button_Saida.Click += new System.EventHandler(this.button_Saida_Click);
            // 
            // button_Entrada
            // 
            this.button_Entrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Entrada.Location = new System.Drawing.Point(204, 59);
            this.button_Entrada.Name = "button_Entrada";
            this.button_Entrada.Size = new System.Drawing.Size(100, 23);
            this.button_Entrada.TabIndex = 31;
            this.button_Entrada.Text = "Entrada";
            this.button_Entrada.UseVisualStyleBackColor = true;
            this.button_Entrada.Click += new System.EventHandler(this.button_Entrada_Click);
            // 
            // textBox_Placa
            // 
            this.textBox_Placa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Placa.Location = new System.Drawing.Point(197, 167);
            this.textBox_Placa.Name = "textBox_Placa";
            this.textBox_Placa.Size = new System.Drawing.Size(100, 25);
            this.textBox_Placa.TabIndex = 26;
            // 
            // label_horaSaida
            // 
            this.label_horaSaida.AutoSize = true;
            this.label_horaSaida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_horaSaida.Location = new System.Drawing.Point(521, 65);
            this.label_horaSaida.Name = "label_horaSaida";
            this.label_horaSaida.Size = new System.Drawing.Size(75, 17);
            this.label_horaSaida.TabIndex = 25;
            this.label_horaSaida.Text = "Hora Saída";
            // 
            // label_placa
            // 
            this.label_placa.AutoSize = true;
            this.label_placa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_placa.Location = new System.Drawing.Point(204, 9);
            this.label_placa.Name = "label_placa";
            this.label_placa.Size = new System.Drawing.Size(40, 17);
            this.label_placa.TabIndex = 24;
            this.label_placa.Text = "Placa";
            // 
            // label_dataEntrada
            // 
            this.label_dataEntrada.AutoSize = true;
            this.label_dataEntrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dataEntrada.Location = new System.Drawing.Point(375, 9);
            this.label_dataEntrada.Name = "label_dataEntrada";
            this.label_dataEntrada.Size = new System.Drawing.Size(88, 17);
            this.label_dataEntrada.TabIndex = 23;
            this.label_dataEntrada.Text = "Data Entrada";
            // 
            // label_horaEntrada
            // 
            this.label_horaEntrada.AutoSize = true;
            this.label_horaEntrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_horaEntrada.Location = new System.Drawing.Point(375, 65);
            this.label_horaEntrada.Name = "label_horaEntrada";
            this.label_horaEntrada.Size = new System.Drawing.Size(89, 17);
            this.label_horaEntrada.TabIndex = 22;
            this.label_horaEntrada.Text = "Hora Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(56, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(146, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Data Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(248, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Hora Entrada";
            // 
            // mtBox_placa
            // 
            this.mtBox_placa.Location = new System.Drawing.Point(206, 29);
            this.mtBox_placa.Mask = "aaa - 0000";
            this.mtBox_placa.Name = "mtBox_placa";
            this.mtBox_placa.Size = new System.Drawing.Size(98, 23);
            this.mtBox_placa.TabIndex = 46;
            this.mtBox_placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtBox_dataEntrada
            // 
            this.mtBox_dataEntrada.Location = new System.Drawing.Point(375, 31);
            this.mtBox_dataEntrada.Mask = "00/00/0000";
            this.mtBox_dataEntrada.Name = "mtBox_dataEntrada";
            this.mtBox_dataEntrada.Size = new System.Drawing.Size(98, 23);
            this.mtBox_dataEntrada.TabIndex = 47;
            this.mtBox_dataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtBox_dataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // mtBox_dataSaida
            // 
            this.mtBox_dataSaida.Location = new System.Drawing.Point(521, 29);
            this.mtBox_dataSaida.Mask = "00/00/0000";
            this.mtBox_dataSaida.Name = "mtBox_dataSaida";
            this.mtBox_dataSaida.Size = new System.Drawing.Size(98, 23);
            this.mtBox_dataSaida.TabIndex = 48;
            this.mtBox_dataSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtBox_dataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // mtBox_horaEntrada
            // 
            this.mtBox_horaEntrada.Location = new System.Drawing.Point(375, 89);
            this.mtBox_horaEntrada.Mask = "00:00";
            this.mtBox_horaEntrada.Name = "mtBox_horaEntrada";
            this.mtBox_horaEntrada.Size = new System.Drawing.Size(98, 23);
            this.mtBox_horaEntrada.TabIndex = 49;
            this.mtBox_horaEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtBox_horaEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // mtBox_horaSaida
            // 
            this.mtBox_horaSaida.Location = new System.Drawing.Point(523, 89);
            this.mtBox_horaSaida.Mask = "00:00";
            this.mtBox_horaSaida.Name = "mtBox_horaSaida";
            this.mtBox_horaSaida.Size = new System.Drawing.Size(98, 23);
            this.mtBox_horaSaida.TabIndex = 50;
            this.mtBox_horaSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtBox_horaSaida.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtBox_horaSaida);
            this.Controls.Add(this.mtBox_horaEntrada);
            this.Controls.Add(this.mtBox_dataSaida);
            this.Controls.Add(this.mtBox_dataEntrada);
            this.Controls.Add(this.mtBox_placa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.textBoxSaidaVeiculo);
            this.Controls.Add(this.label_dataSaida);
            this.Controls.Add(this.textBoxEntradaVeiculo);
            this.Controls.Add(this.button_Saida);
            this.Controls.Add(this.button_Entrada);
            this.Controls.Add(this.textBox_Placa);
            this.Controls.Add(this.label_horaSaida);
            this.Controls.Add(this.label_placa);
            this.Controls.Add(this.label_dataEntrada);
            this.Controls.Add(this.label_horaEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label_data;
        private Label label_hora;
        private Label label7;
        private Label label6;
        private TextBox textBoxSaidaVeiculo;
        private Label label_dataSaida;
        private TextBox textBoxEntradaVeiculo;
        private Button button_Saida;
        private Button button_Entrada;
        private TextBox textBox_Placa;
        private Label label_horaSaida;
        private Label label_placa;
        private Label label_dataEntrada;
        private Label label_horaEntrada;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox mtBox_placa;
        private MaskedTextBox mtBox_dataEntrada;
        private MaskedTextBox mtBox_dataSaida;
        private MaskedTextBox mtBox_horaEntrada;
        private MaskedTextBox mtBox_horaSaida;
    }
}