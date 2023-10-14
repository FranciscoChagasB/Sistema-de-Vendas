using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmProdutos : Form
    {
        RegraNegocio.ProdutoRegraNegocio novoProduto;
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnFormCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias formCategoria = new frmCategorias();
            formCategoria.ShowDialog();
        }

        private void btnFormUnidades_Click(object sender, EventArgs e)
        {
            frmUnidade formUnidade = new frmUnidade();
            formUnidade.ShowDialog();
        }

        public void Limpar()
        {
            txtRegistro.Text = "0";
            txtCodigoBarras.Text = "0";
            dtpDataCadastro.Value = DateTime.Today;
            txtNome.Text = "";
            cboCategoria.SelectedIndex = -1;
            txtDescricao.Clear();
            txtEstoqueAtual.Text = "";
            txtEstoqueMinimo.Text = "";
            cboUnidadeProduto.SelectedIndex = -1;
            txtCusto.Text = "";
            txtMargemLucro.Text = "";
            txtVenda.Text = "";
            txtAnotacao.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegistro.Text == "0")
                {
                    novoProduto = new RegraNegocio.ProdutoRegraNegocio();

                    novoProduto
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
