using System;
using System.Windows.Forms;

namespace CSharp_lesson_10._2
{
    public partial class Form1 : Form
    {
        enum Goods
        {
            Phones,
            Tablets,
            Notebooks
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = (int)Goods.Phones;

            Goods g = (Goods)comboBox1.SelectedIndex;
        }
    }
}
