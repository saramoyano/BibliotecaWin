﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm.FrmSplash());
            Application.Run(new Frm.FrmPpal());
            //Application.Run(new Frm.FrmEditorialRead());
            //Application.Run(new Frm.FrmPrestamosRead());
        }
    }
}
