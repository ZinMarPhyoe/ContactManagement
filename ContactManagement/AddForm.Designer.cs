namespace ContactManagement
{
    partial class AddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.linkAddBack = new System.Windows.Forms.LinkLabel();
            this.linkAddContact = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 29);
            this.txtName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(57, 139);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 29);
            this.txtPhone.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // linkAddBack
            // 
            this.linkAddBack.AutoSize = true;
            this.linkAddBack.Location = new System.Drawing.Point(159, 273);
            this.linkAddBack.Name = "linkAddBack";
            this.linkAddBack.Size = new System.Drawing.Size(100, 21);
            this.linkAddBack.TabIndex = 5;
            this.linkAddBack.TabStop = true;
            this.linkAddBack.Text = "Back To Main";
            this.linkAddBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddBack_LinkClicked);
            // 
            // linkAddContact
            // 
            this.linkAddContact.AutoSize = true;
            this.linkAddContact.Location = new System.Drawing.Point(28, 273);
            this.linkAddContact.Name = "linkAddContact";
            this.linkAddContact.Size = new System.Drawing.Size(63, 21);
            this.linkAddContact.TabIndex = 6;
            this.linkAddContact.TabStop = true;
            this.linkAddContact.Text = "Contact";
            this.linkAddContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddContact_LinkClicked);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(282, 303);
            this.Controls.Add(this.linkAddContact);
            this.Controls.Add(this.linkAddBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnAdd;
        private LinkLabel linkAddBack;
        private LinkLabel linkAddContact;
    }
}