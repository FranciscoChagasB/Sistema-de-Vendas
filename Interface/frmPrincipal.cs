using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmPrincipal : Form
    {
        RegraNegocio.UsuariosRegraNegocio novoUsuario;
        frmUsuarios formUsuarios;
        string nomeUsuario, nivelUsuario;
        int idUsuario;

        public frmPrincipal(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        //Ação do botão btnClientes que inicializa o formulário frmClientes.
        {
            frmClientes formClientes = new frmClientes();
            formClientes.ShowDialog();
        }

        private void mstripClientes_Click(object sender, EventArgs e)
        //Ação do botão de menu mstripClientes que inicializa o formulário frmClientes.
        {
            frmClientes formClientes = new frmClientes();
            formClientes.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        //Ação do botão btnUsuarios que inicializa o formulário frmUsuarios.
        {
            frmUsuarios formUsuarios = new frmUsuarios();
            formUsuarios.ShowDialog();
        }

        private void mstripUsuarios_Click(object sender, EventArgs e)
        //Ação do botão de menu mstripUsuarios que inicializa o formulário frmUsuarios.
        {
            frmUsuarios formUsuarios = new frmUsuarios();
            formUsuarios.ShowDialog();
        }

        private void btnNiveis_Click(object sender, EventArgs e)
        //Ação do botão btnNiveis que inicializa o formulário frmNiveis.
        {
            frmNiveis formNiveis = new frmNiveis(formUsuarios);
            formNiveis.ShowDialog();
        }

        private void mstripNíveis_Click(object sender, EventArgs e)
        //Ação do botão de menu mstripNiveis que inicializa o formulário frmNiveis.
        {
            frmNiveis formNiveis = new frmNiveis(formUsuarios);
            formNiveis.ShowDialog();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        //Ação do botão btnFuncionarios que inicializa o formulário frmNiveis.
        {
            frmFuncionarios formFuncionarios = new frmFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void mstripFuncionarios_Click(object sender, EventArgs e)
        //Ação do botão de menu mstripFuncionarios que inicializa o formulário frmFuncionarios.
        {
            frmFuncionarios formFuncionarios = new frmFuncionarios();
            formFuncionarios.ShowDialog();
        }
    }
}
