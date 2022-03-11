using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caesar_encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veri = "";

            veri = textBox1.Text;
            char[] harfler = veri.ToCharArray();

            foreach  (char harf in harfler)
            {
                textBox2.Text += Convert.ToChar(harf + 3).ToString();
            }
             

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 gecis = new Form2();
            gecis.Show();
            this.Hide();


        }
    }
}
