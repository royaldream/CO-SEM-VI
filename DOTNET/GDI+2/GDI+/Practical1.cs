using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Practical1 : Form
    {
        public Practical1()
        {
            InitializeComponent();
        }

        private void doller_Click(object sender, EventArgs e)
        {
            double doller_price = Convert.ToDouble(textBox1.Text) * 0.014;
            label1.Text = Convert.ToString(doller_price)+" $";
        }

        private void Practical1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void frank_Click(object sender, EventArgs e)
        {
            double doller_price = Convert.ToDouble(textBox1.Text) * 0.014;
            label1.Text = Convert.ToString(doller_price)+" Franc";
        }

        private void euro_Click(object sender, EventArgs e)
        {
            double doller_price = Convert.ToDouble(textBox1.Text) * 0.012;
            label1.Text = Convert.ToString(doller_price)+" Euro";
        }
    }
}
