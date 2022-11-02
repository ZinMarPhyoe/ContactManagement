namespace ContactManagement
{
    partial class EditForm
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
            this.lblEditId = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditPhone = new System.Windows.Forms.Label();
            this.txtEditId = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.linkEditContact = new System.Windows.Forms.LinkLabel();
            this.linkEditBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblEditId
            // 
            this.lblEditId.AutoSize = true;
            this.lblEditId.Location = new System.Drawing.Point(65, 32);
            this.lblEditId.Name = "lblEditId";
            this.lblEditId.Size = new System.Drawing.Size(25, 21);
            this.lblEditId.TabIndex = 0;
            this.lblEditId.Text = "ID";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(65, 105);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(52, 21);
            this.lblEditName.TabIndex = 1;
            this.lblEditName.Text = "Name";
            // 
            // lblEditPhone
            // 
            this.lblEditPhone.AutoSize = true;
            this.lblEditPhone.Location = new System.Drawing.Point(65, 183);
            this.lblEditPhone.Name = "lblEditPhone";
            this.lblEditPhone.Size = new System.Drawing.Size(116, 21);
            this.lblEditPhone.TabIndex = 2;
            this.lblEditPhone.Text = "Phone Number";
            // 
            // txtEditId
            // 
            this.txtEditId.Location = new System.Drawing.Point(65, 56);
            this.txtEditId.Name = "txtEditId";
            this.txtEditId.Size = new System.Drawing.Size(191, 29);
            this.txtEditId.TabIndex = 3;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(65, 129);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(191, 29);
            this.txtEditName.TabIndex = 4;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Location = new System.Drawing.Point(65, 207);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(191, 29);
            this.txtEditPhone.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(106, 274);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // linkEditContact
            // 
            this.linkEditContact.AutoSize = true;
            this.linkEditContact.Location = new System.Drawing.Point(65, 339);
            this.linkEditContact.Name = "linkEditContact";
            this.linkEditContact.Size = new System.Drawing.Size(63, 21);
            this.linkEditContact.TabIndex = 7;
            this.linkEditContact.TabStop = true;
            this.linkEditContact.Text = "Contact";
            this.linkEditContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditContact_LinkClicked);
            // 
            // linkEditBack
            // 
            this.linkEditBack.AutoSize = true;
            this.linkEditBack.Location = new System.Drawing.Point(156, 339);
            this.linkEditBack.Name = "linkEditBack";
            this.linkEditBack.Size = new System.Drawing.Size(100, 21);
            this.linkEditBack.TabIndex = 8;
            this.linkEditBack.TabStop = true;
            this.linkEditBack.Text = "Back To Main";
            this.linkEditBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditBack_LinkClicked);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 395);
            this.Controls.Add(this.linkEditBack);
            this.Controls.Add(this.linkEditContact);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEditPhone);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.txtEditId);
            this.Controls.Add(this.lblEditPhone);
            this.Controls.Add(this.lblEditName);
            this.Controls.Add(this.lblEditId);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEditId;
        private Label lblEditName;
        private Label lblEditPhone;
        private TextBox txtEditId;
        private TextBox txtEditName;
        private TextBox txtEditPhone;
        private Button btnEdit;
        private LinkLabel linkEditContact;
        private LinkLabel linkEditBack;
    }
}