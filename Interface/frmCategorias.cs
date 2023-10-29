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
    public partial class frmCategorias : Form
    {
        RegraNegocio.ProdutoRegraNegocio novoProduto;
        public frmCategorias()
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

        private void ListarCategorias()
        //Método que lista as categorias no DataGridView.
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                bdsCategorias.DataSource = novoProduto.ListarCategorias();
                bdnCategorias.BindingSource = bdsCategorias;
                dtgCategorias.DataSource = bdsCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        //Ação do botão btnNovo, que limpa os campos do formulário com o método Limpar.
        {
            Limpar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        //Ação do btnAlterar, que carrega os dados da categoria cadastrada no banco para fazer alterações.
        {
            try
            {
                txtRegistro.Text = dtgCategorias.CurrentRow.Cells["ID_CATEGORIA_PRODUTOS"].Value.ToString();
                txtNome.Text = dtgCategorias.CurrentRow.Cells["NOME_CATEGORIA_PRODUTOS"].Value.ToString();
                txtDescricao.Text = dtgCategorias.CurrentRow.Cells["DESCRICAO_CATEGORIA_PRODUTOS"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        //Ação do botão btnExcluir, que exclui uma categoria selecionado pelo usuário.
        {
            try
            {
                //Verifica se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
                if (MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Se sim, realiza o método ExcluirCategoria, mostra mensagem do sucesso dessa ação, lista as categorias no DataGrid e limpa todos os campos.
                    novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                    novoProduto.ExcluirCategoria(Convert.ToInt32(dtgCategorias.CurrentRow.Cells["ID_CATEGORIA_PRODUTOS"].Value));
                    MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        //Evento load do formulário, que inicia o formulário com o método ListarCategorias.
        {
            ListarCategorias();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        //Ação do botão btnLimpar que limpa os campos do formulário.
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        //Ação do btnSalvar, que salva uma categoria no banco de dados.
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutoRegraNegocio();

                if (txtRegistro.Text == "0")
                {
                    novoProduto.SalvarCategoria(txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoProduto.AlterarCategoria(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Categoria alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ListarCategorias();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
