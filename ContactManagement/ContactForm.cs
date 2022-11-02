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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            BindGrid();
            
        }

        private void BindGrid()
        {
            string conString = "Data Source=ZIN_MAR_PHYOE\\SQLEXPRESS;Initial Catalog=Contact;Persist Security Info=True;Integrated Security=True;User ID=sa;Password=***********";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tContact", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        
        private void linkBackMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
