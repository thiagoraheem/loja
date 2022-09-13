using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace Loja
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

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            //UserLookAndFeel.Default.SetSkinStyle("Money Twins");
            UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.Estilo);

            Application.Run(new frmPrincipal());
        }
    }
}