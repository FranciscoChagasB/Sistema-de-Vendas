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
            txtEstoqueAtual.Text = "0";
            txtEstoqueMinimo.Text = "0";
            txtCusto.Text = "0";
            txtMargemLucro.Text = "0";
            txtVenda.Text = "0";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            tbcClientes.SelectedTab = tbpCadastro;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica se é um novo produto, caso sim, o método a ser utilizado é o salvar.
                if (txtRegistro.Text == "0")
                {
                    novoProduto = new RegraNegocio.ProdutoRegraNegocio();

                    //Salva um novo produto no banco de dados.
                    novoProduto.Salvar(txtCodigoBarras.Text, txtNome.Text, txtDescricao.Text, Convert.ToInt32(cboUnidadeProduto.SelectedValue), Convert.ToInt32(cboCategoria.SelectedValue),
                       Convert.ToInt32(txtEstoqueMinimo.Text), Convert.ToInt32(txtEstoqueAtual.Text),
                       txtCusto.Text, txtVenda.Text, txtMargemLucro.Text, txtAnotacao.Text, Convert.ToBoolean(cbAtivo.Checked), dtpDataCadastro.Value.Date);

                    //Exibe uma mensagem de sucesso ao salvar o produto.
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbcClientes.SelectedTab = tbpProcura;
                }
                //Caso não, o método a ser utilizado é o alterar.
                else
                {
                    novoProduto = new RegraNegocio.ProdutoRegraNegocio();

                    //Altera as informações de um produto existente no banco de dados.
                    novoProduto.Alterar(Convert.ToInt32(txtRegistro.Text), txtCodigoBarras.Text, txtNome.Text, txtDescricao.Text,
                        Convert.ToInt32(cboUnidadeProduto.SelectedValue), Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(txtEstoqueMinimo.Text),
                        Convert.ToInt32(txtEstoqueAtual.Text), txtCusto.Text, txtVenda.Text,
                        txtMargemLucro.Text, txtAnotacao.Text, Convert.ToBoolean(cbAtivo.Checked), dtpDataCadastro.Value.Date);

                    //Exibe uma mensagem de sucesso ao alterar um produto.
                    MessageBox.Show("Produto alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbcClientes.SelectedTab = tbpProcura;
                }
                Limpar();
                ListarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            ListarCategoria();
            ListarUnidades();
            ListarProdutos();

        }

        public void ListarCategoria()
        //Método para listar as categorias no ComboBox CboCategoria.
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                cboCategoria.DataSource = novoProduto.ListarCategorias();
                cboCategoria.DisplayMember = "NOME_CATEGORIA_PRODUTOS";
                cboCategoria.ValueMember = "ID_CATEGORIA_PRODUTOS";
                cboCategoria.SelectedIndex = -1;

                novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                dtgCategoriaProdutos.DataSource = novoProduto.ListarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarUnidades()
        //Método para listar as unidades no ComboBox CboUnidadeProdutos.
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                cboUnidadeProduto.DataSource =  novoProduto.ListarUnidades();
                cboUnidadeProduto.DisplayMember = "NOME_UNIDADE_PRODUTOS";
                cboUnidadeProduto.ValueMember = "ID_UNIDADE_PRODUTOS";
                cboUnidadeProduto.SelectedIndex = -1;

                novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                dtgUnidadeProdutos.DataSource = novoProduto.ListarUnidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarProdutos()
        //Método para listar os produtos no dtgProdutos.
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                bdsProdutos.DataSource = novoProduto.Listar();
                bdnProdutos.BindingSource = bdsProdutos;
                dtgProdutos.DataSource = bdsProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        //Método que traz informações do produto selecionado para realizar alterações
        {
            txtRegistro.Text = dtgProdutos.CurrentRow.Cells["ID_PRODUTO"].Value.ToString();
            txtCodigoBarras.Text = dtgProdutos.CurrentRow.Cells["CODIGOBARRAS_PRODUTO"].Value.ToString();
            txtNome.Text = dtgProdutos.CurrentRow.Cells["NOME_PRODUTO"].Value.ToString();
            txtDescricao.Text = dtgProdutos.CurrentRow.Cells["DESCRICAO_PRODUTO"].Value.ToString();
            cboUnidadeProduto.SelectedValue = dtgProdutos.CurrentRow.Cells["ID_UNIDADE"].Value.ToString();
            cboCategoria.SelectedValue = dtgProdutos.CurrentRow.Cells["ID_CATEGORIA"].Value.ToString();
            txtEstoqueMinimo.Text = dtgProdutos.CurrentRow.Cells["ESTOQUE_MINIMO"].Value.ToString();
            txtEstoqueAtual.Text = dtgProdutos.CurrentRow.Cells["ESTOQUE_ATUAL"].Value.ToString();
            txtCusto.Text = dtgProdutos.CurrentRow.Cells["VALOR_COMPRA"].Value.ToString();
            txtVenda.Text = dtgProdutos.CurrentRow.Cells["VALOR_VENDA"].Value.ToString();
            txtMargemLucro.Text = dtgProdutos.CurrentRow.Cells["MARGEM"].Value.ToString();
            txtAnotacao.Text = dtgProdutos.CurrentRow.Cells["ANOTACOES_PRODUTO"].Value.ToString();
            dtpDataCadastro.Value = Convert.ToDateTime(dtgProdutos.CurrentRow.Cells["DATA_CADASTRO_PRODUTO"].Value);
            cbAtivo.Checked = Convert.ToBoolean(dtgProdutos.CurrentRow.Cells["SITUACAO_PRODUTO"].Value);

            tbcClientes.SelectedTab = tbpCadastro;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
                if (MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Se sim, realiza o método ExcluirCategoria, mostra mensagem do sucesso dessa ação, lista as categorias no DataGrid e limpa todos os campos.
                    novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                    novoProduto.Excluir(Convert.ToInt32(dtgProdutos.CurrentRow.Cells["ID_PRODUTO"].Value));
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                    ListarProdutos();
                    tbcClientes.SelectedTab = tbpProcura;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
