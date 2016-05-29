#region License

// <copyright file="Program.cs" company="Siasur Development">
//     Copyright (c) 2016 Mischa Behrend (Siasur)
// </copyright>

#endregion

using System;
using System.Windows.Forms;
using Siasur.G510Display.Core;

namespace Siasur.G510Display.GUI
{
    static class Program
    {
        #region Methoden

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            G510Core core = new G510Core();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new G510Gui(core));
        }

        #endregion
    }
}
