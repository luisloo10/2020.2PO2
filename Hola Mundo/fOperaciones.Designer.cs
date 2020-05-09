namespace Hola_Mundo
{
    partial class fOperaciones
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
            this.tValor1 = new System.Windows.Forms.TextBox();
            this.tResultado = new System.Windows.Forms.TextBox();
            this.tValor2 = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSuma = new System.Windows.Forms.Button();
            this.bResta = new System.Windows.Forms.Button();
            this.bMultiplicacion = new System.Windows.Forms.Button();
            this.bSumax5 = new System.Windows.Forms.Button();
            this.bPotencia = new System.Windows.Forms.Button();
            this.bDivision = new System.Windows.Forms.Button();
            this.cOperaciones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tValor1
            // 
            this.tValor1.Location = new System.Drawing.Point(87, 43);
            this.tValor1.Name = "tValor1";
            this.tValor1.Size = new System.Drawing.Size(100, 20);
            this.tValor1.TabIndex = 0;
            // 
            // tResultado
            // 
            this.tResultado.Location = new System.Drawing.Point(87, 132);
            this.tResultado.Name = "tResultado";
            this.tResultado.Size = new System.Drawing.Size(100, 20);
            this.tResultado.TabIndex = 1;
            // 
            // tValor2
            // 
            this.tValor2.Location = new System.Drawing.Point(87, 88);
            this.tValor2.Name = "tValor2";
            this.tValor2.Size = new System.Drawing.Size(100, 20);
            this.tValor2.TabIndex = 2;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(87, 170);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(100, 47);
            this.bCalcular.TabIndex = 3;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // bSuma
            // 
            this.bSuma.Location = new System.Drawing.Point(220, 40);
            this.bSuma.Name = "bSuma";
            this.bSuma.Size = new System.Drawing.Size(80, 39);
            this.bSuma.TabIndex = 5;
            this.bSuma.Text = "Suma";
            this.bSuma.UseVisualStyleBackColor = true;
            this.bSuma.Click += new System.EventHandler(this.bSuma_Click);
            // 
            // bResta
            // 
            this.bResta.Location = new System.Drawing.Point(220, 88);
            this.bResta.Name = "bResta";
            this.bResta.Size = new System.Drawing.Size(80, 39);
            this.bResta.TabIndex = 5;
            this.bResta.Text = "Resta";
            this.bResta.UseVisualStyleBackColor = true;
            // 
            // bMultiplicacion
            // 
            this.bMultiplicacion.Location = new System.Drawing.Point(220, 133);
            this.bMultiplicacion.Name = "bMultiplicacion";
            this.bMultiplicacion.Size = new System.Drawing.Size(80, 39);
            this.bMultiplicacion.TabIndex = 5;
            this.bMultiplicacion.Text = "Multiplicación";
            this.bMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // bSumax5
            // 
            this.bSumax5.Location = new System.Drawing.Point(306, 132);
            this.bSumax5.Name = "bSumax5";
            this.bSumax5.Size = new System.Drawing.Size(80, 39);
            this.bSumax5.TabIndex = 5;
            this.bSumax5.Text = "Sumax5";
            this.bSumax5.UseVisualStyleBackColor = true;
            // 
            // bPotencia
            // 
            this.bPotencia.Location = new System.Drawing.Point(306, 88);
            this.bPotencia.Name = "bPotencia";
            this.bPotencia.Size = new System.Drawing.Size(80, 39);
            this.bPotencia.TabIndex = 5;
            this.bPotencia.Text = "Potencia";
            this.bPotencia.UseVisualStyleBackColor = true;
            this.bPotencia.Click += new System.EventHandler(this.bPotencia_Click);
            // 
            // bDivision
            // 
            this.bDivision.Location = new System.Drawing.Point(220, 178);
            this.bDivision.Name = "bDivision";
            this.bDivision.Size = new System.Drawing.Size(80, 39);
            this.bDivision.TabIndex = 5;
            this.bDivision.Text = "División";
            this.bDivision.UseVisualStyleBackColor = true;
            this.bDivision.Click += new System.EventHandler(this.bDivision_Click);
            // 
            // cOperaciones
            // 
            this.cOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cOperaciones.FormattingEnabled = true;
            this.cOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division",
            "Potencia"});
            this.cOperaciones.Location = new System.Drawing.Point(220, 233);
            this.cOperaciones.Name = "cOperaciones";
            this.cOperaciones.Size = new System.Drawing.Size(166, 21);
            this.cOperaciones.TabIndex = 6;
            this.cOperaciones.SelectedIndexChanged += new System.EventHandler(this.cOperaciones_SelectedIndexChanged);
            // 
            // fOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 392);
            this.Controls.Add(this.cOperaciones);
            this.Controls.Add(this.bPotencia);
            this.Controls.Add(this.bSumax5);
            this.Controls.Add(this.bMultiplicacion);
            this.Controls.Add(this.bDivision);
            this.Controls.Add(this.bResta);
            this.Controls.Add(this.bSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tValor2);
            this.Controls.Add(this.tResultado);
            this.Controls.Add(this.tValor1);
            this.Name = "fOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fOperaciones";
            this.Load += new System.EventHandler(this.fOperaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tValor1;
        private System.Windows.Forms.TextBox tResultado;
        private System.Windows.Forms.TextBox tValor2;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSuma;
        private System.Windows.Forms.Button bResta;
        private System.Windows.Forms.Button bMultiplicacion;
        private System.Windows.Forms.Button bSumax5;
        private System.Windows.Forms.Button bPotencia;
        private System.Windows.Forms.Button bDivision;
        private System.Windows.Forms.ComboBox cOperaciones;
    }
}