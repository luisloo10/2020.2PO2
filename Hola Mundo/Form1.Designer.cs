namespace Hola_Mundo
{
    partial class Form1
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
            this.bHola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gDatos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llantas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puertas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cilindraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAgregar = new System.Windows.Forms.Button();
            this.tTransmision = new System.Windows.Forms.TextBox();
            this.tCilindraje = new System.Windows.Forms.TextBox();
            this.tModelo = new System.Windows.Forms.TextBox();
            this.tMarca = new System.Windows.Forms.TextBox();
            this.tAño = new System.Windows.Forms.TextBox();
            this.tPuertas = new System.Windows.Forms.TextBox();
            this.tColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tLlantas = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.bOperaciones = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLlantas)).BeginInit();
            this.SuspendLayout();
            // 
            // bHola
            // 
            this.bHola.Location = new System.Drawing.Point(12, 25);
            this.bHola.Name = "bHola";
            this.bHola.Size = new System.Drawing.Size(75, 23);
            this.bHola.TabIndex = 0;
            this.bHola.Text = "Hola";
            this.bHola.UseVisualStyleBackColor = true;
            this.bHola.Click += new System.EventHandler(this.bHola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Llantas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tLlantas);
            this.groupBox1.Controls.Add(this.gDatos);
            this.groupBox1.Controls.Add(this.bAgregar);
            this.groupBox1.Controls.Add(this.tTransmision);
            this.groupBox1.Controls.Add(this.tCilindraje);
            this.groupBox1.Controls.Add(this.tModelo);
            this.groupBox1.Controls.Add(this.tMarca);
            this.groupBox1.Controls.Add(this.tAño);
            this.groupBox1.Controls.Add(this.tPuertas);
            this.groupBox1.Controls.Add(this.tColor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automóvil";
            // 
            // gDatos
            // 
            this.gDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Llantas,
            this.Color,
            this.Puertas,
            this.Año,
            this.Marca,
            this.TxtModelo,
            this.Cilindraje,
            this.Transmision});
            this.gDatos.Location = new System.Drawing.Point(206, 19);
            this.gDatos.Name = "gDatos";
            this.gDatos.Size = new System.Drawing.Size(586, 257);
            this.gDatos.TabIndex = 0;
            this.gDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Llantas
            // 
            this.Llantas.HeaderText = "Llantas";
            this.Llantas.Name = "Llantas";
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Puertas
            // 
            this.Puertas.HeaderText = "Puertas";
            this.Puertas.Name = "Puertas";
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // TxtModelo
            // 
            this.TxtModelo.HeaderText = "Modelo";
            this.TxtModelo.Name = "TxtModelo";
            // 
            // Cilindraje
            // 
            this.Cilindraje.HeaderText = "Cilindraje";
            this.Cilindraje.Name = "Cilindraje";
            // 
            // Transmision
            // 
            this.Transmision.HeaderText = "Transmision";
            this.Transmision.Name = "Transmision";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(85, 236);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(99, 36);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // tTransmision
            // 
            this.tTransmision.Location = new System.Drawing.Point(85, 210);
            this.tTransmision.Name = "tTransmision";
            this.tTransmision.Size = new System.Drawing.Size(100, 20);
            this.tTransmision.TabIndex = 7;
            // 
            // tCilindraje
            // 
            this.tCilindraje.Location = new System.Drawing.Point(85, 184);
            this.tCilindraje.Name = "tCilindraje";
            this.tCilindraje.Size = new System.Drawing.Size(100, 20);
            this.tCilindraje.TabIndex = 6;
            // 
            // tModelo
            // 
            this.tModelo.Location = new System.Drawing.Point(85, 158);
            this.tModelo.Name = "tModelo";
            this.tModelo.Size = new System.Drawing.Size(100, 20);
            this.tModelo.TabIndex = 5;
            // 
            // tMarca
            // 
            this.tMarca.Location = new System.Drawing.Point(85, 132);
            this.tMarca.Name = "tMarca";
            this.tMarca.Size = new System.Drawing.Size(100, 20);
            this.tMarca.TabIndex = 4;
            // 
            // tAño
            // 
            this.tAño.Location = new System.Drawing.Point(85, 106);
            this.tAño.Name = "tAño";
            this.tAño.Size = new System.Drawing.Size(100, 20);
            this.tAño.TabIndex = 3;
            // 
            // tPuertas
            // 
            this.tPuertas.Location = new System.Drawing.Point(85, 80);
            this.tPuertas.Name = "tPuertas";
            this.tPuertas.Size = new System.Drawing.Size(100, 20);
            this.tPuertas.TabIndex = 2;
            // 
            // tColor
            // 
            this.tColor.Location = new System.Drawing.Point(85, 54);
            this.tColor.Name = "tColor";
            this.tColor.Size = new System.Drawing.Size(100, 20);
            this.tColor.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Transmisión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cilindraje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Puertas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // tLlantas
            // 
            this.tLlantas.Location = new System.Drawing.Point(85, 29);
            this.tLlantas.Name = "tLlantas";
            this.tLlantas.Size = new System.Drawing.Size(43, 20);
            this.tLlantas.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(97, 27);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // bOperaciones
            // 
            this.bOperaciones.Location = new System.Drawing.Point(218, 16);
            this.bOperaciones.Name = "bOperaciones";
            this.bOperaciones.Size = new System.Drawing.Size(92, 40);
            this.bOperaciones.TabIndex = 4;
            this.bOperaciones.Text = "Abrir Operaciones";
            this.bOperaciones.UseVisualStyleBackColor = true;
            this.bOperaciones.Click += new System.EventHandler(this.bOperaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 409);
            this.Controls.Add(this.bOperaciones);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bHola);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLlantas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bHola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gDatos;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.TextBox tTransmision;
        private System.Windows.Forms.TextBox tCilindraje;
        private System.Windows.Forms.TextBox tModelo;
        private System.Windows.Forms.TextBox tMarca;
        private System.Windows.Forms.TextBox tAño;
        private System.Windows.Forms.TextBox tPuertas;
        private System.Windows.Forms.TextBox tColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llantas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cilindraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmision;
        private System.Windows.Forms.NumericUpDown tLlantas;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button bOperaciones;
    }
}

