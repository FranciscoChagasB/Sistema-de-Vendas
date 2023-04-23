using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin formularioLogin = new frmLogin();
            formularioLogin.ShowDialog();

            if (formularioLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmPrincipal(formularioLogin.idUsuario));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
