using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GDI_
{
    public partial class Form1 : Form
    {
        int x1, x2, y1, y2;
        Boolean flag_draw;
        public Form1()
        {
            InitializeComponent();
            flag_draw = true;
           
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           /* Graphics g = this.CreateGraphics(); 
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush,0,0,this.Width,this.Height);*/
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            
            if (e.Button == MouseButtons.Left)
            {
                x2 = e.X;
                y2 = e.Y;
                if (flag_draw)
                {
                    g.DrawLine(new Pen(Color.White), x1, y1, x2, y2);
                    x1 = x2;
                    y1 = y2;
                }
                else
                {
                    g.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 15, 15);
                    x1 = x2;
                    y1 = y2;
                }
            }
            if (!flag_draw)
            {
                
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag_draw = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag_draw = false;
        }

        


    }
}
