namespace K9
{
    partial class Crypt
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
            this.buscar1 = new System.Windows.Forms.Button();
            this.eligearchivencriptar = new System.Windows.Forms.TextBox();
            this.buscaricono = new System.Windows.Forms.Button();
            this.cajaicono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cifradobox = new System.Windows.Forms.ComboBox();
            this.KeyGenBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.labelencriptarmain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encriptarbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoinyeccion = new System.Windows.Forms.ComboBox();
            this.nombrearchivofinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscar1
            // 
            this.buscar1.Location = new System.Drawing.Point(211, 80);
            this.buscar1.Name = "buscar1";
            this.buscar1.Size = new System.Drawing.Size(69, 22);
            this.buscar1.TabIndex = 2;
            this.buscar1.Text = "Buscar";
            this.buscar1.UseVisualStyleBackColor = true;
            this.buscar1.Click += new System.EventHandler(this.buscar1_Click);
            // 
            // eligearchivencriptar
            // 
            this.eligearchivencriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.eligearchivencriptar.ForeColor = System.Drawing.Color.White;
            this.eligearchivencriptar.Location = new System.Drawing.Point(12, 82);
            this.eligearchivencriptar.Name = "eligearchivencriptar";
            this.eligearchivencriptar.Size = new System.Drawing.Size(167, 20);
            this.eligearchivencriptar.TabIndex = 4;
            this.eligearchivencriptar.TextChanged += new System.EventHandler(this.eligearchivencriptar_TextChanged);
            // 
            // buscaricono
            // 
            this.buscaricono.Location = new System.Drawing.Point(211, 264);
            this.buscaricono.Name = "buscaricono";
            this.buscaricono.Size = new System.Drawing.Size(69, 22);
            this.buscaricono.TabIndex = 5;
            this.buscaricono.Text = "Buscar";
            this.buscaricono.UseVisualStyleBackColor = true;
            this.buscaricono.Click += new System.EventHandler(this.button2_Click);
            // 
            // cajaicono
            // 
            this.cajaicono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.cajaicono.ForeColor = System.Drawing.Color.White;
            this.cajaicono.Location = new System.Drawing.Point(12, 266);
            this.cajaicono.Name = "cajaicono";
            this.cajaicono.Size = new System.Drawing.Size(167, 20);
            this.cajaicono.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(355, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo de cifrado";
            // 
            // cifradobox
            // 
            this.cifradobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.cifradobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cifradobox.ForeColor = System.Drawing.Color.White;
            this.cifradobox.FormattingEnabled = true;
            this.cifradobox.Items.AddRange(new object[] {
            "AES",
            "ROT",
            "XOR",
            "NONE"});
            this.cifradobox.Location = new System.Drawing.Point(359, 82);
            this.cifradobox.Name = "cifradobox";
            this.cifradobox.Size = new System.Drawing.Size(203, 21);
            this.cifradobox.TabIndex = 9;
            this.cifradobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // KeyGenBox
            // 
            this.KeyGenBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.KeyGenBox.ForeColor = System.Drawing.Color.White;
            this.KeyGenBox.Location = new System.Drawing.Point(12, 348);
            this.KeyGenBox.Name = "KeyGenBox";
            this.KeyGenBox.Size = new System.Drawing.Size(167, 20);
            this.KeyGenBox.TabIndex = 10;
            this.KeyGenBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 22);
            this.button4.TabIndex = 11;
            this.button4.Text = "Gen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelencriptarmain
            // 
            this.labelencriptarmain.AutoSize = true;
            this.labelencriptarmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelencriptarmain.ForeColor = System.Drawing.SystemColors.Control;
            this.labelencriptarmain.Location = new System.Drawing.Point(8, 37);
            this.labelencriptarmain.Name = "labelencriptarmain";
            this.labelencriptarmain.Size = new System.Drawing.Size(177, 20);
            this.labelencriptarmain.TabIndex = 12;
            this.labelencriptarmain.Text = "Elige archivo a encriptar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cambiar icono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Generar llave";
            // 
            // encriptarbtn
            // 
            this.encriptarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.encriptarbtn.Location = new System.Drawing.Point(359, 307);
            this.encriptarbtn.Name = "encriptarbtn";
            this.encriptarbtn.Size = new System.Drawing.Size(188, 63);
            this.encriptarbtn.TabIndex = 15;
            this.encriptarbtn.Text = "Encriptar";
            this.encriptarbtn.UseVisualStyleBackColor = true;
            this.encriptarbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(355, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo de inyección";
            // 
            // tipoinyeccion
            // 
            this.tipoinyeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tipoinyeccion.ForeColor = System.Drawing.Color.White;
            this.tipoinyeccion.FormattingEnabled = true;
            this.tipoinyeccion.Items.AddRange(new object[] {
            "Self-Injection",
            "Process Hollowing",
            "DLL Injection",
            "Process-Injection (Local)",
            "Process-Injection (Remote)",
            "Powershell Reflective Load (In-Memory) ",
            "Just encrypt my file (No Injection Method) "});
            this.tipoinyeccion.Location = new System.Drawing.Point(359, 197);
            this.tipoinyeccion.Name = "tipoinyeccion";
            this.tipoinyeccion.Size = new System.Drawing.Size(203, 21);
            this.tipoinyeccion.TabIndex = 17;
            this.tipoinyeccion.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // nombrearchivofinal
            // 
            this.nombrearchivofinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.nombrearchivofinal.ForeColor = System.Drawing.Color.White;
            this.nombrearchivofinal.Location = new System.Drawing.Point(12, 176);
            this.nombrearchivofinal.Name = "nombrearchivofinal";
            this.nombrearchivofinal.Size = new System.Drawing.Size(167, 20);
            this.nombrearchivofinal.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre de archivo";
            // 
            // Crypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(613, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombrearchivofinal);
            this.Controls.Add(this.tipoinyeccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encriptarbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelencriptarmain);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.KeyGenBox);
            this.Controls.Add(this.cifradobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cajaicono);
            this.Controls.Add(this.buscaricono);
            this.Controls.Add(this.eligearchivencriptar);
            this.Controls.Add(this.buscar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crypt";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar1;
        private System.Windows.Forms.TextBox eligearchivencriptar;
        private System.Windows.Forms.Button buscaricono;
        private System.Windows.Forms.TextBox cajaicono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cifradobox;
        private System.Windows.Forms.TextBox KeyGenBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelencriptarmain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button encriptarbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoinyeccion;
        private System.Windows.Forms.TextBox nombrearchivofinal;
        private System.Windows.Forms.Label label2;
    }
}