using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Algorithm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SABBIR;Initial Catalog=sorting_algo;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)From register where username='"+textBox1.Text+"' and pass='"+textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sd = new SqlDataAdapter("Select approve from register where id=dt.Rows[0][0] and approve = 'True'", con);
                 DataTable d = new DataTable();
            sda.Fill(d);
            if (d.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 lgn = new Form2();
                lgn.Show();
            }
            else
                MessageBox.Show("Not allow");
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                this.Hide();
                Admin lgn = new Admin();
                MessageBox.Show("You are login as Admin");
                lgn.Show();
            }
            else
            {
                MessageBox.Show("Please check Your Username and password");
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();   
            signup fm = new signup();
                fm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
