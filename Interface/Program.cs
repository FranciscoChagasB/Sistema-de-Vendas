using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
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

            RegraNegocio.BancoSqlRegraNegocio novoBanco = new RegraNegocio.BancoSqlRegraNegocio();
            DataTable dadosTabela = new DataTable();

            dadosTabela = novoBanco.VerificarBanco();

            if (dadosTabela.Rows.Count <= 0)
            {
                novoBanco.CriaBanco();
                novoBanco.CriaNiveis();
                novoBanco.CriaUsuario();
            }

            /*
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

            if (frmLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmPrincipal(frmLogin.idUsuario));
            }
            else
            {
                Application.Exit();
            }
            */

            Application.Run(new frmPrincipal(1));
        }
    }
}
