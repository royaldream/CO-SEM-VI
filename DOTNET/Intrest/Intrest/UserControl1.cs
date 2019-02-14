using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Intrest
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount, per, month;
            amount = Convert.ToDouble(text_amount.Text);
            per = Convert.ToDouble(text_per.Text);
            month = Convert.ToDouble(text_month.Text);
            double intrest;
            intrest = amount * per * month / (100*12);
            label4.Text = "Simple Intrest :- " + intrest.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double amount, per, month;
            amount = Convert.ToDouble(text_amount.Text);
            per = Convert.ToDouble(text_per.Text);
            month = Convert.ToDouble(text_month.Text);
            double cintrest;
            cintrest=amount;
            for (int i = 0; i < month; i++)
            {
                amount+=(double)amount*per*month/(100*12);
            }
            cintrest = amount - cintrest;
            label4.Text = "Compound Intrest :- " + cintrest.ToString();
        }

    

        
    }
}
