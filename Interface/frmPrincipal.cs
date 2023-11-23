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

        private void mstripProdutos_Click(object sender, EventArgs e)
        //Ação do botão de menu mstripProdutos que inicializa o formulário frmProdutos.
        {
            frmProdutos formProdutos = new frmProdutos();
            formProdutos.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        //Ação do botão btnProdutos que inicializa o formulário frmProdutos.
        {
            frmProdutos formProdutos = new frmProdutos();
            formProdutos.ShowDialog();
        }

        private void mstripUnidades_Click(object sender, EventArgs e)
        //Ação do botão de menu mstripUnidades que inicializa o formulário frmUnidade.
        {
            frmUnidade formUnidade = new frmUnidade();
            formUnidade.ShowDialog();
        }

        private void btnUnidade_Click(object sender, EventArgs e)
        //Ação do botão btnUnidade que inicializa o formulário frmUnidade.
        {
            frmUnidade formUnidade = new frmUnidade();
            formUnidade.ShowDialog();
        }

        private void mstripCategorias_Click(object sender, EventArgs e)
        //Ação do botão de menu mstripCategorias que inicializa o formulário frmCategorias.
        {
            frmCategorias formCategorias = new frmCategorias();
            formCategorias.ShowDialog();
        }


        private void btnCategoria_Click(object sender, EventArgs e)
        //Ação do botão btnCategoria que inicializa o formulário frmCategorias.
        {
            frmCategorias formCategorias = new frmCategorias();
            formCategorias.ShowDialog();
        }

        private void mstripVendas_Click(object sender, EventArgs e)
        //Ação do botão de menu mstripVendas que inicializa o formulário frmVendas.
        {
            frmVendas formVendas = new frmVendas(idUsuario, nomeUsuario);
            formVendas.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        //Ação do botão btnVendas que inicializa o formulário frmVendas.
        {
            frmVendas formVendas = new frmVendas(idUsuario, nomeUsuario);
            formVendas.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        //Inicia o formulário com os dados do usuário logado.
        {
            CarregarDados();
        }

        public void CarregarDados()
        //Método para guardar informações do usuário que está logado.
        {
            try
            {
                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                DataTable dadosTabela = new DataTable();
                dadosTabela = novoUsuario.RetornarUsuario(idUsuario);

                nomeUsuario = dadosTabela.Rows[0]["NOME_USUARIO"].ToString();
                nivelUsuario = dadosTabela.Rows[0]["NOME_NIVEL"].ToString();

                lblUsuario.Text = "Usuário: " + nomeUsuario;
                lblNivel.Text = "Nível: " + nivelUsuario;
                lblData.Text = DateTime.Today.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
