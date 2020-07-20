using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Algorithm
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        private void signup_Load(object sender, EventArgs e)
        {
            label6.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""  && textBox5.Text != "")
            {
                if (label7.Visible == true || label8.Visible == true)
                {
                    label7.Visible = false;
                    label8.Visible = false;
                }
                if (textBox4.Text.Contains("@") && textBox4.Text.Contains(".com"))
                {

                    if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && textBox5.Text != null)
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=SABBIR;Initial Catalog=sorting_algo;Integrated Security=True;");
                            con.Open();
                            if (con.State == ConnectionState.Open)
                            {
                                String str = "insert into register(username,pass,confirm_pass,email,phone,approve) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','False')";
                                SqlCommand cmd = new SqlCommand(str, con);
                                cmd.ExecuteNonQuery();
                                this.Hide();
                                Login lgn = new Login();
                                lgn.Show();
                            }
                        }
                        else
                        {
                            label6.Show();
                            label6.Text = "Password Incorrect";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter all required DATA !!!");
                        //label8.Visible = true;

                    }
                }
                else
                {
                    //MessageBox.Show("Enter all required DATA !!!");
                    label8.Visible = true;

                }
            }
            else
            {
                label7.Visible = true;
            }

            //SqlDataAdapter sda = new SqlDataAdapter("Insert INTO  Table1(uname,pass,email,phone) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            //// DataTable dt = new DataTable();
            ////  sda.Fill(dt);
            //// if (dt.Rows[0][0].ToString() == "1")
            //// {
            //this.Hide();
            //Login ss = new Login();
            //ss.Show();
            //// }
            ////else
            ////{
            ////  MessageBox.Show("Please fill up the filled");
            ////}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.Show();
        }

       
    }
}
