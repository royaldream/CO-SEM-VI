﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Practical_2_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Practical_2_8());
        }
    }
}
