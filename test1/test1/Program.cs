﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace test1
{
    static class Program
    {
        public static string stuname;
        public static string manname;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
