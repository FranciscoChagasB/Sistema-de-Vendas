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
    public partial class frmFuncionarios : Form
    {
        RegraNegocio.FuncionariosRegraNegocio novoFuncionario;
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void Limpar()
        //Método para limpar os campos do formulário.
        {
            txtRegistro.Text = "0";
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtEmail.Clear();
            txtCep.Clear();
            dtpNascimento.Value = DateTime.Today;
            txtObservacao.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            cboStatus.SelectedIndex = 0;
        }

        private void Listar()
        //Método para listar todos os funcionários do banco de dados no formulário na aba de procura.
        {
            tbcFuncionarios.SelectedTab = tbpProcura;
            novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
            bdsFuncionarios.DataSource = novoFuncionario.Listar();
            bdnFuncionarios.BindingSource = bdsFuncionarios;
            dtgFuncionarios.DataSource = bdsFuncionarios;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        //Ação do btnSalvar, que salva um funcionário no banco de dados.
        {
            try
            {
                novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                if (txtRegistro.Text == "0")
                {
                    novoFuncionario.Salvar(txtNome.Text, txtCpf.Text, txtRg.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtEstado.Text,
                                           txtTelefone.Text, txtEmail.Text, dtpDataCadastro.Value.Date,
                                           dtpNascimento.Value.Date, txtObservacao.Text, cboStatus.Text);
                    MessageBox.Show("Funcionário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    novoFuncionario.Alterar(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtCpf.Text, txtRg.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtEstado.Text,
                                           txtTelefone.Text, txtEmail.Text, dtpDataCadastro.Value.Date,
                                           dtpNascimento.Value.Date, txtObservacao.Text, cboStatus.Text);
                    MessageBox.Show("Funcionário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Após a ação, atualiza a lista de funcionários e limpa os campos do formulário.
                Listar();
                Limpar();

                //Traz de volta a aba de procura para visualizar os funcionários cadastrados.
                tbcFuncionarios.SelectedTab = tbpProcura;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        //Ação do botão btnExcluir, que exclui um funcionário selecionado pelo usuário.
        {
            //Verifica se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
            if (MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Se sim, realiza o método Excluir, mostra mensagem do sucesso dessa ação, lista os funcionários no DataGrid e limpa todos os campos.
                    novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                    novoFuncionario.Excluir(Convert.ToInt32(dtgFuncionarios.CurrentRow.Cells["ID_FUNCIONARIO"].Value));
                    MessageBox.Show("Funcionário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Após a ação, atualiza a lista de funcionários e limpa os campos do formulário.
                    Listar();
                    Limpar();

                    //Traz de volta a aba de procura para visualizar os funcionários cadastrados.
                    tbcFuncionarios.SelectedTab = tbpProcura;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        //Ação do botão btnNovo, que altera para a aba de cadastro do formulário e limpa os campos com o método Limpar.
        {
            tbcFuncionarios.SelectedTab = tbpCadastro;
            Limpar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        //Ação do btnAlterar, que carrega os dados do funcionário cadastrado no banco para fazer alterações.
        {
            tbcFuncionarios.SelectedTab = tbpCadastro;
            try
            {
                txtRegistro.Text = dtgFuncionarios.CurrentRow.Cells["ID_FUNCIONARIO"].Value.ToString();
                txtNome.Text = dtgFuncionarios.CurrentRow.Cells["NOME_FUNCIONARIO"].Value.ToString();
                txtEndereco.Text = dtgFuncionarios.CurrentRow.Cells["ENDERECO_FUNCIONARIO"].Value.ToString();
                txtBairro.Text = dtgFuncionarios.CurrentRow.Cells["BAIRRO_FUNCIONARIO"].Value.ToString();
                txtCep.Text = dtgFuncionarios.CurrentRow.Cells["CEP_FUNCIONARIO"].Value.ToString();
                txtCidade.Text = dtgFuncionarios.CurrentRow.Cells["CIDADE_FUNCIONARIO"].Value.ToString();
                txtEstado.Text = dtgFuncionarios.CurrentRow.Cells["ESTADO_FUNCIONARIO"].Value.ToString();
                txtEmail.Text = dtgFuncionarios.CurrentRow.Cells["EMAIL_FUNCIONARIO"].Value.ToString();
                dtpNascimento.Value = Convert.ToDateTime(dtgFuncionarios.CurrentRow.Cells["NASCIMENTO_FUNCIONARIO"].Value.ToString());
                txtTelefone.Text = dtgFuncionarios.CurrentRow.Cells["TELEFONE_FUNCIONARIO"].Value.ToString();
                txtRg.Text = dtgFuncionarios.CurrentRow.Cells["RG_FUNCIONARIO"].Value.ToString();
                txtCpf.Text = dtgFuncionarios.CurrentRow.Cells["CPF_FUNCIONARIO"].Value.ToString();
                dtpDataCadastro.Value = Convert.ToDateTime(dtgFuncionarios.CurrentRow.Cells["DATA_CADASTRO_FUNCIONARIO"].Value.ToString());
                txtObservacao.Text = dtgFuncionarios.CurrentRow.Cells["OBSERVACOES_FUNCIONARIO"].Value.ToString();
                cboStatus.Text = dtgFuncionarios.CurrentRow.Cells["STATUS_FUNCIONARIO"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNomeFuncionario_TextChanged(object sender, EventArgs e)
        //Ação de alteração de texto que pesquisa um funcionário no banco com base nos dados fornecidos.
        {
            try
            {
                //Verifica qual filtro foi selecionado para filtrar os dados.
                switch (cboFiltro.Text)
                {
                    //Mostra apenas os dados de clientes ativos.
                    case "Ativos":
                        tbcFuncionarios.SelectedTab = tbpProcura;
                        novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                        bdsFuncionarios.DataSource = novoFuncionario.PesquisaAtivos(txtNomeFuncionario.Text, cboOrdenar.Text);
                        bdnFuncionarios.BindingSource = bdsFuncionarios;
                        dtgFuncionarios.DataSource = bdsFuncionarios;
                        break;
                    //Mostra apenas os dados de clientes inativos.
                    case "Inativos":
                        tbcFuncionarios.SelectedTab = tbpProcura;
                        novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                        bdsFuncionarios.DataSource = novoFuncionario.PesquisaInativos(txtNomeFuncionario.Text, cboOrdenar.Text);
                        bdnFuncionarios.BindingSource = bdsFuncionarios;
                        dtgFuncionarios.DataSource = bdsFuncionarios;
                        break;
                    //Mostra todos os funcionários cadastrados.
                    default:
                        tbcFuncionarios.SelectedTab = tbpProcura;
                        novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                        bdsFuncionarios.DataSource = novoFuncionario.PesquisarNome(txtNomeFuncionario.Text, cboOrdenar.Text);
                        bdnFuncionarios.BindingSource = bdsFuncionarios;
                        dtgFuncionarios.DataSource = bdsFuncionarios;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        //Ação do botão btnPesquisar que pesquisa um funcionário no banco com base nos dados fornecidos.
        {
            try
            {
                //Verifica qual filtro foi selecionado para filtrar os dados.
                switch (cboFiltro.Text)
                {
                    //Mostra apenas os dados de clientes ativos.
                    case "Ativos":
                        tbcFuncionarios.SelectedTab = tbpProcura;
                        novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                        bdsFuncionarios.DataSource = novoFuncionario.PesquisaAtivos(txtNomeFuncionario.Text, cboOrdenar.Text);
                        bdnFuncionarios.BindingSource = bdsFuncionarios;
                        dtgFuncionarios.DataSource = bdsFuncionarios;
                        break;
                    //Mostra apenas os dados de clientes inativos.
                    case "Inativos":
                        tbcFuncionarios.SelectedTab = tbpProcura;
                        novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                        bdsFuncionarios.DataSource = novoFuncionario.PesquisaInativos(txtNomeFuncionario.Text, cboOrdenar.Text);
                        bdnFuncionarios.BindingSource = bdsFuncionarios;
                        dtgFuncionarios.DataSource = bdsFuncionarios;
                        break;
                    //Mostra todos os funcionários cadastrados.
                    default:
                        tbcFuncionarios.SelectedTab = tbpProcura;
                        novoFuncionario = new RegraNegocio.FuncionariosRegraNegocio();
                        bdsFuncionarios.DataSource = novoFuncionario.PesquisarNome(txtNomeFuncionario.Text, cboOrdenar.Text);
                        bdnFuncionarios.BindingSource = bdsFuncionarios;
                        dtgFuncionarios.DataSource = bdsFuncionarios;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        //Evento load do formulário, que inicia o formulário com o método Listar.
        {
            Listar();
        }
    }
}
