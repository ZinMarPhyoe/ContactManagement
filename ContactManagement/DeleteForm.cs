using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ContactManagement
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelete.Text))
            {
                MessageBox.Show("Please fill ID!");
            }
            else
            {
                string id = txtDelete.Text;
                string command = "DELETE FROM tContact WHERE ID= '" + id + "'";
                string conString = "Data Source=ZIN_MAR_PHYOE\\SQLEXPRESS;Initial Catalog=Contact;Persist Security Info=True;Integrated Security=True;User ID=sa;Password=***********";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Phone Number is deleted.");
                con.Close();
                DeleteForm deleteForm = new DeleteForm();
                deleteForm.Show();
                this.Hide();
            }
        }

        private void linkDeleteContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
            this.Hide();
        }

        private void linkDeleteBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
