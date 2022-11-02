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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void linkEditContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactForm contact = new ContactForm();
            contact.Show();
            this.Hide();
        }

        private void linkEditBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtEditId.Text)) || (string.IsNullOrEmpty(txtEditName.Text)) || (string.IsNullOrEmpty(txtEditPhone.Text)))
            {
                MessageBox.Show("Please fill data!");
            }
            else
            {
                string id = txtEditId.Text;
                string name = txtEditName.Text;
                string phone = txtEditPhone.Text;
                string command = "UPDATE tContact SET Name = '" + name + "', PhoneNumber = '" + phone + "' WHERE ID= " + id;
                string conString = "Data Source=ZIN_MAR_PHYOE\\SQLEXPRESS;Initial Catalog=Contact;Persist Security Info=True;Integrated Security=True;User ID=sa;Password=***********";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Phone Number is edited.");
                con.Close();
                EditForm editForm = new EditForm();
                editForm.Show();
                this.Hide();
            }
        }
    }
}
