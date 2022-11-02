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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void linkAddBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill data!");
            }
            else
            {
                string name = txtName.Text;
                string phone = txtPhone.Text;
                //string query = "INSERT INTO tContact VALUES (' "+name+"', '"+phone+"'";
                string conString = "Data Source=ZIN_MAR_PHYOE\\SQLEXPRESS;Initial Catalog=Contact;Persist Security Info=True;Integrated Security=True;User ID=sa;Password=***********";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO tContact (Name, PhoneNumber) VALUES(@value1,@value2)", con);
                cmd.Parameters.AddWithValue("@value1", name);
                cmd.Parameters.AddWithValue("@value2", phone);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Phone Number is added.");
                con.Close();
                AddForm addForm = new AddForm();
                addForm.Show();
                this.Hide();
            }
        }

        private void linkAddContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
            this.Hide();
        }
    }
}
