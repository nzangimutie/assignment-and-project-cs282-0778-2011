namespace SGSclient
{
    partial class SGSClient
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lstChatters = new System.Windows.Forms.ListBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lstMsgs = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(325, 364);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 47);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 364);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(307, 47);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // lstChatters
            // 
            this.lstChatters.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.lstChatters.Enabled = false;
            this.lstChatters.FormattingEnabled = true;
            this.lstChatters.Location = new System.Drawing.Point(372, 16);
            this.lstChatters.Name = "lstChatters";
            this.lstChatters.Size = new System.Drawing.Size(273, 329);
            this.lstChatters.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogOut.Location = new System.Drawing.Point(586, 361);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(52, 47);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 348);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 8;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(391, 364);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 44);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "&Delete Message";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lstMsgs
            // 
            this.lstMsgs.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstMsgs.Enabled = false;
            this.lstMsgs.FormattingEnabled = true;
            this.lstMsgs.Location = new System.Drawing.Point(12, 12);
            this.lstMsgs.Name = "lstMsgs";
            this.lstMsgs.Size = new System.Drawing.Size(328, 329);
            this.lstMsgs.TabIndex = 10;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(501, 364);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(49, 44);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // SGSClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(650, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lstMsgs);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lstChatters);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SGSClient";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SGSClient_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lstChatters;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox lstMsgs;
        private System.Windows.Forms.Button btnDone;
    }
}

