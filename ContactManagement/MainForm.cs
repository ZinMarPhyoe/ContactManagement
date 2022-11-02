using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ContactManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string connectionString = "Data Source=ZIN_MAR_PHYOE\\SQLEXPRESS;Initial Catalog=Beauty;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand cmd=new SqlCommand("sp_insert", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
           // cmd.Parameters.AddWithValue("@ID", tBoxID.Text);
            //cmd.Parameters.AddWithValue("@Cosmetic", tBoxCos.Text);
            //cmd.Parameters.AddWithValue("@Price", tBoxPrice.Text);
            sqlCon.Open();
            int i = cmd.ExecuteNonQuery();
            
            sqlCon.Close();
            if(i!=0)
            {
                MessageBox.Show(i + "Data Saved");
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void linkContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
            this.Hide();

        }

        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }

        private void linkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
            this.Hide();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
            this.Hide();
        }
    }
}