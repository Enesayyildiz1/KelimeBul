using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = textBox1.Text;
            char harf = Convert.ToChar(textBox2.Text);
            int toplam = 0;
            foreach (char i in cumle)
            {
                if (i==harf)
                {
                    toplam++;
                }            
            }
            label4.Text = toplam.ToString();
        }
    }
}
