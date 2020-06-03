namespace Hola_Mundo.Practica_2
{
    partial class TrafficCity
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
            this.components = new System.ComponentModel.Container();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.bStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Image = global::Hola_Mundo.Properties.Resources.White;
            this.p1.Location = new System.Drawing.Point(3, 3);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(51, 50);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Image = global::Hola_Mundo.Properties.Resources.White;
            this.p2.Location = new System.Drawing.Point(3, 59);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(51, 50);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p2.TabIndex = 0;
            this.p2.TabStop = false;
            // 
            // p3
            // 
            this.p3.Image = global::Hola_Mundo.Properties.Resources.White;
            this.p3.Location = new System.Drawing.Point(3, 115);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(51, 50);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p3.TabIndex = 0;
            this.p3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.p3);
            this.panel1.Controls.Add(this.p2);
            this.panel1.Location = new System.Drawing.Point(166, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 169);
            this.panel1.TabIndex = 1;
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(56, 112);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(77, 43);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // TrafficCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 375);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.panel1);
            this.Name = "TrafficCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrafficCity";
            this.Load += new System.EventHandler(this.TrafficCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Button bStart;
    }
}