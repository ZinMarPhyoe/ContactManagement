namespace ContactManagement
{
    partial class DeleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.linkDeleteBack = new System.Windows.Forms.LinkLabel();
            this.linkDeleteContact = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(60, 53);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(125, 29);
            this.txtDelete.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(60, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // linkDeleteBack
            // 
            this.linkDeleteBack.AutoSize = true;
            this.linkDeleteBack.Location = new System.Drawing.Point(118, 164);
            this.linkDeleteBack.Name = "linkDeleteBack";
            this.linkDeleteBack.Size = new System.Drawing.Size(100, 21);
            this.linkDeleteBack.TabIndex = 3;
            this.linkDeleteBack.TabStop = true;
            this.linkDeleteBack.Text = "Back To Main";
            this.linkDeleteBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeleteBack_LinkClicked);
            // 
            // linkDeleteContact
            // 
            this.linkDeleteContact.AutoSize = true;
            this.linkDeleteContact.Location = new System.Drawing.Point(22, 164);
            this.linkDeleteContact.Name = "linkDeleteContact";
            this.linkDeleteContact.Size = new System.Drawing.Size(63, 21);
            this.linkDeleteContact.TabIndex = 4;
            this.linkDeleteContact.TabStop = true;
            this.linkDeleteContact.Text = "Contact";
            this.linkDeleteContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeleteContact_LinkClicked);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 214);
            this.Controls.Add(this.linkDeleteContact);
            this.Controls.Add(this.linkDeleteBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.label1);
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDelete;
        private Button btnDelete;
        private LinkLabel linkDeleteBack;
        private LinkLabel linkDeleteContact;
    }
}