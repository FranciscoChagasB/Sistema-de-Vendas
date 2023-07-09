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
    public partial class frmUnidade : Form
    {
        RegraNegocio.ProdutoRegraNegocio novoProduto;

        public frmUnidade()
        {
            InitializeComponent();
        }

        private void Limpar()
        //Método para limpar os campos do formulário.
        {
            txtRegistro.Text = "0";
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void frmUnidade_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        //Ação do botão btnNovo, que limpa os campos do formulário com o método Limpar.
        {
            Limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        //Ação do botão btnLimpar que limpa os campos do formulário.
        {
            Limpar();
        }
    }
}
