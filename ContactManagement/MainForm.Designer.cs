namespace ContactManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkContact = new System.Windows.Forms.LinkLabel();
            this.linkAdd = new System.Windows.Forms.LinkLabel();
            this.linkEdit = new System.Windows.Forms.LinkLabel();
            this.linkDelete = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkContact
            // 
            this.linkContact.AutoSize = true;
            this.linkContact.Location = new System.Drawing.Point(55, 107);
            this.linkContact.Name = "linkContact";
            this.linkContact.Size = new System.Drawing.Size(63, 21);
            this.linkContact.TabIndex = 0;
            this.linkContact.TabStop = true;
            this.linkContact.Text = "Contact";
            this.linkContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContact_LinkClicked);
            // 
            // linkAdd
            // 
            this.linkAdd.AutoSize = true;
            this.linkAdd.Location = new System.Drawing.Point(188, 107);
            this.linkAdd.Name = "linkAdd";
            this.linkAdd.Size = new System.Drawing.Size(38, 21);
            this.linkAdd.TabIndex = 1;
            this.linkAdd.TabStop = true;
            this.linkAdd.Text = "Add";
            this.linkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdd_LinkClicked);
            // 
            // linkEdit
            // 
            this.linkEdit.AutoSize = true;
            this.linkEdit.Location = new System.Drawing.Point(307, 107);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(36, 21);
            this.linkEdit.TabIndex = 2;
            this.linkEdit.TabStop = true;
            this.linkEdit.Text = "Edit";
            this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
            // 
            // linkDelete
            // 
            this.linkDelete.AutoSize = true;
            this.linkDelete.Location = new System.Drawing.Point(423, 107);
            this.linkDelete.Name = "linkDelete";
            this.linkDelete.Size = new System.Drawing.Size(54, 21);
            this.linkDelete.TabIndex = 3;
            this.linkDelete.TabStop = true;
            this.linkDelete.Text = "Delete";
            this.linkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelete_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.linkDelete);
            this.Controls.Add(this.linkEdit);
            this.Controls.Add(this.linkAdd);
            this.Controls.Add(this.linkContact);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkContact;
        private LinkLabel linkAdd;
        private LinkLabel linkEdit;
        private LinkLabel linkDelete;
    }
}