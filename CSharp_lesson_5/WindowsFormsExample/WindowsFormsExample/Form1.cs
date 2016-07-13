using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int d = Convert.ToInt32(textBox4.Text);

                Fraction f1 = new Fraction(a, b);
                MessageBox.Show(f1.Display());

                Fraction f2 = new Fraction(c, d);
                MessageBox.Show(f2.Display());

                int op = comboBox1.SelectedIndex;
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        Fraction res = f1 * f2;
                        textBox5.Text = res.X.ToString();
                        textBox6.Text = res.Y.ToString();
                        break;
                    case 3:
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
