namespace WindowsFormsSerialização
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_dataNasimento = new System.Windows.Forms.TextBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.Btn_gravar = new System.Windows.Forms.Button();
            this.btn_serializar = new System.Windows.Forms.Button();
            this.btn_Deserializar = new System.Windows.Forms.Button();
            this.btn_SerializarXML = new System.Windows.Forms.Button();
            this.btn_DeserializarXML = new System.Windows.Forms.Button();
            this.btn_SerializarJSON = new System.Windows.Forms.Button();
            this.btn_DeserializarJSON = new System.Windows.Forms.Button();
            this.txbDesserializar = new System.Windows.Forms.TextBox();
            this.btn_Serializar2 = new System.Windows.Forms.Button();
            this.btn_Deserializar2 = new System.Windows.Forms.Button();
            this.txbSerializar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_conteudoArquivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(115, 25);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(146, 23);
            this.textBox_Nome.TabIndex = 4;
            // 
            // textBox_dataNasimento
            // 
            this.textBox_dataNasimento.Location = new System.Drawing.Point(380, 25);
            this.textBox_dataNasimento.Name = "textBox_dataNasimento";
            this.textBox_dataNasimento.Size = new System.Drawing.Size(100, 23);
            this.textBox_dataNasimento.TabIndex = 5;
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.Location = new System.Drawing.Point(558, 25);
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(161, 23);
            this.textBox_cpf.TabIndex = 6;
            // 
            // Btn_gravar
            // 
            this.Btn_gravar.Location = new System.Drawing.Point(60, 144);
            this.Btn_gravar.Name = "Btn_gravar";
            this.Btn_gravar.Size = new System.Drawing.Size(75, 41);
            this.Btn_gravar.TabIndex = 7;
            this.Btn_gravar.Text = "Gravar";
            this.Btn_gravar.UseVisualStyleBackColor = true;
            this.Btn_gravar.Click += new System.EventHandler(this.Btn_gravar_Click);
            // 
            // btn_serializar
            // 
            this.btn_serializar.Location = new System.Drawing.Point(182, 114);
            this.btn_serializar.Name = "btn_serializar";
            this.btn_serializar.Size = new System.Drawing.Size(114, 41);
            this.btn_serializar.TabIndex = 8;
            this.btn_serializar.Text = "Serializar";
            this.btn_serializar.UseVisualStyleBackColor = true;
            this.btn_serializar.Click += new System.EventHandler(this.btn_serializar_Click);
            // 
            // btn_Deserializar
            // 
            this.btn_Deserializar.Location = new System.Drawing.Point(182, 172);
            this.btn_Deserializar.Name = "btn_Deserializar";
            this.btn_Deserializar.Size = new System.Drawing.Size(114, 41);
            this.btn_Deserializar.TabIndex = 9;
            this.btn_Deserializar.Text = "Deserializar";
            this.btn_Deserializar.UseVisualStyleBackColor = true;
            this.btn_Deserializar.Click += new System.EventHandler(this.btn_Deserializar_Click);
            // 
            // btn_SerializarXML
            // 
            this.btn_SerializarXML.Location = new System.Drawing.Point(470, 114);
            this.btn_SerializarXML.Name = "btn_SerializarXML";
            this.btn_SerializarXML.Size = new System.Drawing.Size(114, 41);
            this.btn_SerializarXML.TabIndex = 10;
            this.btn_SerializarXML.Text = "SerializarXML";
            this.btn_SerializarXML.UseVisualStyleBackColor = true;
            this.btn_SerializarXML.Click += new System.EventHandler(this.btn_SerializarXML_Click);
            // 
            // btn_DeserializarXML
            // 
            this.btn_DeserializarXML.Location = new System.Drawing.Point(470, 172);
            this.btn_DeserializarXML.Name = "btn_DeserializarXML";
            this.btn_DeserializarXML.Size = new System.Drawing.Size(114, 41);
            this.btn_DeserializarXML.TabIndex = 11;
            this.btn_DeserializarXML.Text = "DeserializarXML";
            this.btn_DeserializarXML.UseVisualStyleBackColor = true;
            this.btn_DeserializarXML.Click += new System.EventHandler(this.btn_DeserializarXML_Click);
            // 
            // btn_SerializarJSON
            // 
            this.btn_SerializarJSON.Location = new System.Drawing.Point(610, 114);
            this.btn_SerializarJSON.Name = "btn_SerializarJSON";
            this.btn_SerializarJSON.Size = new System.Drawing.Size(114, 41);
            this.btn_SerializarJSON.TabIndex = 12;
            this.btn_SerializarJSON.Text = "Serializar Json";
            this.btn_SerializarJSON.UseVisualStyleBackColor = true;
            this.btn_SerializarJSON.Click += new System.EventHandler(this.btn_SerializarJSON_Click);
            // 
            // btn_DeserializarJSON
            // 
            this.btn_DeserializarJSON.Location = new System.Drawing.Point(610, 172);
            this.btn_DeserializarJSON.Name = "btn_DeserializarJSON";
            this.btn_DeserializarJSON.Size = new System.Drawing.Size(114, 41);
            this.btn_DeserializarJSON.TabIndex = 13;
            this.btn_DeserializarJSON.Text = "Deserializar JSON";
            this.btn_DeserializarJSON.UseVisualStyleBackColor = true;
            this.btn_DeserializarJSON.Click += new System.EventHandler(this.btn_DeserializarJSON_Click);
            // 
            // txbDesserializar
            // 
            this.txbDesserializar.Location = new System.Drawing.Point(144, 54);
            this.txbDesserializar.Name = "txbDesserializar";
            this.txbDesserializar.Size = new System.Drawing.Size(579, 23);
            this.txbDesserializar.TabIndex = 14;
            // 
            // btn_Serializar2
            // 
            this.btn_Serializar2.Location = new System.Drawing.Point(325, 114);
            this.btn_Serializar2.Name = "btn_Serializar2";
            this.btn_Serializar2.Size = new System.Drawing.Size(114, 41);
            this.btn_Serializar2.TabIndex = 15;
            this.btn_Serializar2.Text = "Serializar 2";
            this.btn_Serializar2.UseVisualStyleBackColor = true;
            this.btn_Serializar2.Click += new System.EventHandler(this.btn_Serializar2_Click);
            // 
            // btn_Deserializar2
            // 
            this.btn_Deserializar2.Location = new System.Drawing.Point(325, 172);
            this.btn_Deserializar2.Name = "btn_Deserializar2";
            this.btn_Deserializar2.Size = new System.Drawing.Size(114, 41);
            this.btn_Deserializar2.TabIndex = 16;
            this.btn_Deserializar2.Text = "Deserializar 2";
            this.btn_Deserializar2.UseVisualStyleBackColor = true;
            this.btn_Deserializar2.Click += new System.EventHandler(this.btn_Deserializar2_Click);
            // 
            // txbSerializar
            // 
            this.txbSerializar.Location = new System.Drawing.Point(144, 85);
            this.txbSerializar.Name = "txbSerializar";
            this.txbSerializar.Size = new System.Drawing.Size(579, 23);
            this.txbSerializar.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Deserializar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Serializar";
            // 
            // textBox_conteudoArquivo
            // 
            this.textBox_conteudoArquivo.Location = new System.Drawing.Point(50, 239);
            this.textBox_conteudoArquivo.Multiline = true;
            this.textBox_conteudoArquivo.Name = "textBox_conteudoArquivo";
            this.textBox_conteudoArquivo.Size = new System.Drawing.Size(674, 135);
            this.textBox_conteudoArquivo.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_conteudoArquivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSerializar);
            this.Controls.Add(this.btn_Deserializar2);
            this.Controls.Add(this.btn_Serializar2);
            this.Controls.Add(this.txbDesserializar);
            this.Controls.Add(this.btn_DeserializarJSON);
            this.Controls.Add(this.btn_SerializarJSON);
            this.Controls.Add(this.btn_DeserializarXML);
            this.Controls.Add(this.btn_SerializarXML);
            this.Controls.Add(this.btn_Deserializar);
            this.Controls.Add(this.btn_serializar);
            this.Controls.Add(this.Btn_gravar);
            this.Controls.Add(this.textBox_cpf);
            this.Controls.Add(this.textBox_dataNasimento);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label3);
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
        private Label label3;
        private TextBox textBox_Nome;
        private TextBox textBox_dataNasimento;
        private TextBox textBox_cpf;
        private Button Btn_gravar;
        private Button btn_serializar;
        private Button btn_Deserializar;
        private Button btn_SerializarXML;
        private Button btn_DeserializarXML;
        private Button btn_SerializarJSON;
        private Button btn_DeserializarJSON;
        private TextBox txbDesserializar;
        private Button btn_Serializar2;
        private Button btn_Deserializar2;
        private TextBox txbSerializar;
        private Label label4;
        private Label label5;
        private TextBox textBox_conteudoArquivo;
    }
}