using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Algorithm
{
    public partial class Form2 : Form
    {
        int zz;

        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            zz = Convert.ToInt16(textBox1.Text);
           // flag = true;
           // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Form1 f=new Form1(zz);
            f.ShowDialog();
            /*else
            {
                label7.Visible = true;
            }
              */

        }
        
    }
}
