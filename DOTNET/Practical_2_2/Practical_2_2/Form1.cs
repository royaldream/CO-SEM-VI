using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practical_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string infix=textBox1.Text;
            string postfix = convert(infix);
            label1.Text = postfix;
        }
        static string convert( string infix )
        {
            string postfix;
            int prio = 0;
            postfix = "";
            Stack<Char> s1 = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                char ch = infix[i];
                if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                {
                    if (s1.Count <= 0)
                        s1.Push(ch);
                    else
                    {
                        if (s1.Peek() == '*' || s1.Peek() == '/')
                            prio = 1;
                        else
                            prio = 0;
                        if (prio == 1)
                        {
                            if (ch == '+' || ch == '-')
                            {
                                postfix += s1.Pop();
                                i--;
                            }
                            else
                            {
                                postfix += s1.Pop();
                                i--;
                            }
                        }
                        else
                        {
                            if (ch == '+' || ch == '-')
                            {
                                postfix += s1.Pop();
                                s1.Push(ch);

                            }
                            else
                                s1.Push(ch);
                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
            }
            int len = s1.Count;
            for (int j = 0; j < len; j++)
                postfix += s1.Pop();
            return postfix;
        }
    }
}
