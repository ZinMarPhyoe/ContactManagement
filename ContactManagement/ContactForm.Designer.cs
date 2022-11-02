namespace ContactManagement
{
    partial class ContactForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkBackMain = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(23, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(464, 601);
            this.dataGridView1.TabIndex = 3;
            // 
            // linkBackMain
            // 
            this.linkBackMain.AutoSize = true;
            this.linkBackMain.Location = new System.Drawing.Point(206, 655);
            this.linkBackMain.Name = "linkBackMain";
            this.linkBackMain.Size = new System.Drawing.Size(100, 21);
            this.linkBackMain.TabIndex = 4;
            this.linkBackMain.TabStop = true;
            this.linkBackMain.Text = "Back To Main";
            this.linkBackMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackMain_LinkClicked);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 703);
            this.Controls.Add(this.linkBackMain);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactForm";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private LinkLabel linkBackMain;
    }
}