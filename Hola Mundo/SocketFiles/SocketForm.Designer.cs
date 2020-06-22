namespace Hola_Mundo.SocketFiles
{
    partial class SocketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocketForm));
            this.bPlay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bActivar = new System.Windows.Forms.Button();
            this.pRaqueta1 = new System.Windows.Forms.PictureBox();
            this.pRaqueta2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pRaqueta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRaqueta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bPlay
            // 
            this.bPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlay.Location = new System.Drawing.Point(313, 21);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(103, 46);
            this.bPlay.TabIndex = 2;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(422, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "subir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "bajar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bActivar
            // 
            this.bActivar.BackColor = System.Drawing.SystemColors.Control;
            this.bActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActivar.Location = new System.Drawing.Point(12, 21);
            this.bActivar.Name = "bActivar";
            this.bActivar.Size = new System.Drawing.Size(103, 59);
            this.bActivar.TabIndex = 2;
            this.bActivar.Text = "Open Chat";
            this.bActivar.UseVisualStyleBackColor = false;
            this.bActivar.Click += new System.EventHandler(this.bActivar_Click);
            // 
            // pRaqueta1
            // 
            this.pRaqueta1.Image = ((System.Drawing.Image)(resources.GetObject("pRaqueta1.Image")));
            this.pRaqueta1.Location = new System.Drawing.Point(54, 336);
            this.pRaqueta1.Name = "pRaqueta1";
            this.pRaqueta1.Size = new System.Drawing.Size(61, 52);
            this.pRaqueta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pRaqueta1.TabIndex = 0;
            this.pRaqueta1.TabStop = false;
            this.pRaqueta1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pRaqueta1_MouseMove);
            // 
            // pRaqueta2
            // 
            this.pRaqueta2.Image = ((System.Drawing.Image)(resources.GetObject("pRaqueta2.Image")));
            this.pRaqueta2.Location = new System.Drawing.Point(683, 336);
            this.pRaqueta2.Name = "pRaqueta2";
            this.pRaqueta2.Size = new System.Drawing.Size(61, 52);
            this.pRaqueta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pRaqueta2.TabIndex = 0;
            this.pRaqueta2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(763, 341);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // SocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bActivar);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.pRaqueta1);
            this.Controls.Add(this.pRaqueta2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "SocketForm";
            this.Text = "SocketForm";
            this.Load += new System.EventHandler(this.SocketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRaqueta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRaqueta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pRaqueta2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.PictureBox pRaqueta1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bActivar;
    }
}