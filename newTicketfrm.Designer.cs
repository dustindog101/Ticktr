namespace Ticktr
{
    partial class newTicketfrm
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
            this.subjecttxt = new System.Windows.Forms.TextBox();
            this.bodytxt = new System.Windows.Forms.RichTextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjecttxt
            // 
            this.subjecttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjecttxt.Location = new System.Drawing.Point(12, 12);
            this.subjecttxt.Name = "subjecttxt";
            this.subjecttxt.Size = new System.Drawing.Size(619, 21);
            this.subjecttxt.TabIndex = 1;
            // 
            // bodytxt
            // 
            this.bodytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodytxt.Location = new System.Drawing.Point(12, 38);
            this.bodytxt.Name = "bodytxt";
            this.bodytxt.Size = new System.Drawing.Size(619, 400);
            this.bodytxt.TabIndex = 3;
            this.bodytxt.Text = "";
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(637, 379);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(151, 59);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // newTicketfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.bodytxt);
            this.Controls.Add(this.subjecttxt);
            this.Name = "newTicketfrm";
            this.Text = "newTicket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.newTicket_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subjecttxt;
        private System.Windows.Forms.RichTextBox bodytxt;
        private System.Windows.Forms.Button createBtn;
    }
}