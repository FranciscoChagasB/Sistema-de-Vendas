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
    public partial class frmNiveis : Form
    {
        RegraNegocio.NiveisRegraNegocio novoNivel;
        frmUsuarios formUsuarios;
        public frmNiveis(frmUsuarios usuarios)
        {
            InitializeComponent();
            formUsuarios = usuarios;
        }

        private void frmNiveis_Load(object sender, EventArgs e)
        //Evento load do formulário, que inicia o formulário com o método Listar.
        {
            ListarNiveisDataGrid();
        }

        private void ListarNiveisDataGrid()
        //Método para listar todos os níveis de usuários do banco de dados no DataGridViews dtgNiveis.
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();
                bdsNiveis.DataSource = novoNivel.Listar();
                bdnNiveis.BindingSource = bdsNiveis;
                dtgNiveis.DataSource = bdsNiveis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar()
        //Método para limpar os campos do formulário.
        {
            txtRegistro.Text = "0";
            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        //Ação do botão btnLimpar, que chama o método Limpar para limpar os campos do formulário.
        {
            Limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        //Ação do botão btnNovo, que limpa os campos com o método Limpar.
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        //Ação do botão btnSalvar, que salva um nível no banco de dados.
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();

                if (txtRegistro.Text == "0")
                //Verifica se o registro é zero, caso seja, é um novo nível e chama o método Salvar da classe NiveisRegraNegocio.
                {
                    novoNivel.Salvar(txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Nível cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                //Caso não, altera um nível já cadastrado.
                {
                    novoNivel.Alterar(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtDescricao.Text);
                    MessageBox.Show("Nível alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Após a ação, atualiza a lista de níveis e limpa os campos do formulário.
                ListarNiveisDataGrid();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        //Ação do btnAlterar, que carrega os dados do nível cadastrado no banco para fazer alterações.
        {
            try
            {
                //Preenche cada componente do formulário com as informações do DataGrid correspondentes.
                txtRegistro.Text = dtgNiveis.CurrentRow.Cells["ID_NIVEL"].Value.ToString();
                txtNome.Text = dtgNiveis.CurrentRow.Cells["NOME_NIVEL"].Value.ToString();
                txtDescricao.Text = dtgNiveis.CurrentRow.Cells["DESCRICAO_NIVEL"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o resultado foi Yes para a pergunta se deseja excluir o nível.
                if (MessageBox.Show("Deseja realmente excluir esse registro?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Se sim, realiza o método Excluir, mostra mensagem do sucesso dessa ação, lista os níveis no DataGrid e limpa todos os campos.
                    novoNivel = new RegraNegocio.NiveisRegraNegocio();
                    novoNivel.Excluir(Convert.ToInt32(dtgNiveis.CurrentRow.Cells["ID_NIVEL"].Value));
                    MessageBox.Show("Nível excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Após a ação, atualiza a lista de níveis e limpa os campos do formulário.
                    ListarNiveisDataGrid();
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
