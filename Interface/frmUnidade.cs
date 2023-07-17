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

        private void ListarUnidades()
        //Método que lista as unidades no DataGridView.
        {
            novoProduto = new RegraNegocio.ProdutoRegraNegocio();
            bdsUnidade.DataSource = novoProduto.ListarUnidades();
            bdnUnidade.BindingSource = bdsUnidade;
            dtgUnidade.DataSource = bdsUnidade;
        }

        private void frmUnidade_Load(object sender, EventArgs e)
        //Evento load do formulário, que inicia o formulário com o método ListarUnidades.
        {
            ListarUnidades();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        //Ação do btnSalvar, que salva uma unidade no banco de dados.
        {
            novoProduto = new RegraNegocio.ProdutoRegraNegocio();

            if (txtRegistro.Text == "0")
            {
                novoProduto.SalvarUnidade(txtNome.Text, txtDescricao.Text);
                MessageBox.Show("Unidade salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                novoProduto.AlterarUnidade(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtDescricao.Text);
                MessageBox.Show("Unidade alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarUnidades();
            Limpar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        //Ação do btnAlterar, que carrega os dados da unidade cadastrada no banco para fazer alterações.
        {
            try
            {
                txtRegistro.Text = dtgUnidade.CurrentRow.Cells["ID_UNIDADE_PRODUTOS"].Value.ToString();
                txtNome.Text = dtgUnidade.CurrentRow.Cells["NOME_UNIDADE_PRODUTOS"].Value.ToString();
                txtDescricao.Text = dtgUnidade.CurrentRow.Cells["DESCRICAO_UNIDADE_PRODUTOS"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        //Ação do botão btnExcluir, que exclui uma unidade selecionado pelo usuário.
        {
            try
            {
                //Verifica se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
                if (MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Se sim, realiza o método ExcluirUnidade, mostra mensagem do sucesso dessa ação, lista as unidades no DataGrid e limpa todos os campos.
                    novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                    novoProduto.ExcluirUnidade(Convert.ToInt32(dtgUnidade.CurrentRow.Cells["ID_UNIDADE_PRODUTOS"].Value));
                    MessageBox.Show("Unidade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarUnidades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
