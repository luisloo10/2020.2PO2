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
            this.bCalcular.Location = new System.Drawing.Point(87, 172);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(100, 47);
            this.bCalcular.TabIndex = 3;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // fOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 392);
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
    }
}