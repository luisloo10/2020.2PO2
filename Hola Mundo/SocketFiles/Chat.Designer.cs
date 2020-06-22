namespace Hola_Mundo.SocketFiles
{
    partial class Chat
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
            this.bStartHost = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstChatters = new System.Windows.Forms.ListBox();
            this.txtChatBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStartHost
            // 
            this.bStartHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bStartHost.Location = new System.Drawing.Point(697, 19);
            this.bStartHost.Name = "bStartHost";
            this.bStartHost.Size = new System.Drawing.Size(109, 52);
            this.bStartHost.TabIndex = 0;
            this.bStartHost.Text = "Start Host";
            this.bStartHost.UseVisualStyleBackColor = true;
            this.bStartHost.Click += new System.EventHandler(this.bStartHost_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMessage.Location = new System.Drawing.Point(12, 361);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(495, 45);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSend.Location = new System.Drawing.Point(513, 361);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 45);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstChatters
            // 
            this.lstChatters.FormattingEnabled = true;
            this.lstChatters.Location = new System.Drawing.Point(513, 13);
            this.lstChatters.Name = "lstChatters";
            this.lstChatters.Size = new System.Drawing.Size(118, 342);
            this.lstChatters.TabIndex = 8;
            // 
            // txtChatBox
            // 
            this.txtChatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChatBox.BackColor = System.Drawing.SystemColors.Window;
            this.txtChatBox.Location = new System.Drawing.Point(12, 12);
            this.txtChatBox.Multiline = true;
            this.txtChatBox.Name = "txtChatBox";
            this.txtChatBox.ReadOnly = true;
            this.txtChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatBox.Size = new System.Drawing.Size(495, 343);
            this.txtChatBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Server IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Name:";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(73, 59);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(128, 20);
            this.txtServerIP.TabIndex = 12;
            this.txtServerIP.Text = "192.168.1.19";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 11;
            this.txtName.Text = "Luis";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(137, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Location = new System.Drawing.Point(638, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tStatus
            // 
            this.tStatus.Name = "tStatus";
            this.tStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lstChatters);
            this.Controls.Add(this.txtChatBox);
            this.Controls.Add(this.bStartHost);
            this.Name = "Chat";
            this.ShowIcon = false;
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Chat_FormClosed);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStartHost;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstChatters;
        private System.Windows.Forms.TextBox txtChatBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tStatus;
    }
}