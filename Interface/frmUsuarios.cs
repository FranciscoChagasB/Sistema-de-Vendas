using System;
using System.Collections;
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
    public partial class frmUsuarios : Form
    {
        RegraNegocio.UsuariosRegraNegocio novoUsuario;
        RegraNegocio.NiveisRegraNegocio novoNivel;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        //Evento load do formulário, que inicia o formulário com o método Listar.
        {
            ListarUsuarios();
            ListarNiveisComboBox();
            ListarNiveisDataGrid();
        }

        private void ListarUsuarios()
        //Método para listar todos os usuários do banco de dados no formulário na aba de procura.
        {
            try
            {
                tbcUsuarios.SelectedTab = tbpProcura;
                novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                bdsUsuarios.DataSource = novoUsuario.Listar();
                bdnUsuarios.BindingSource = bdsUsuarios;
                dtgUsuarios.DataSource = bdsUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarNiveisDataGrid()
        //Método para listar todos os níveis do banco de dados no formulário na aba de Nivel de Usuarios.
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();
                bdsNiveis.DataSource = novoNivel.Listar();
                dtgNivelUsuario.DataSource = bdsNiveis;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarNiveisComboBox()
        //Método que retorna os níveis dos usuários através do método Listar da classe NiveisRegraNegocio.
        {
            try
            {
                novoNivel = new RegraNegocio.NiveisRegraNegocio();

                cboNivel.DataSource = novoNivel.Listar();
                cboNivel.DisplayMember = "NOME_NIVEL";
                cboNivel.ValueMember = "ID_NIVEL";
                cboNivel.SelectedIndex = -1;
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
            cboNivel.SelectedIndex = 0;
            txtLogin.Clear();
            txtSenha.Clear();
            txtReeSenha.Clear();
            dtpDataCadastro.Value = DateTime.Today;
            txtObservacao.Clear();
            cboStatus.SelectedIndex = 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        //Ação do botão btnNovo, que altera para a aba de cadastro do formulário e limpa os campos com o método Limpar.
        {
            tbcUsuarios.SelectedTab = tbpCadastro;
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegistro.Text == "0")
                //Verifica se o registro é zero, caso seja, é um novo usuário e chama o método Salvar da classe UsuariosRegraNegocio.
                {
                    novoUsuario = new RegraNegocio.UsuariosRegraNegocio();

                    novoUsuario.Salvar(txtNome.Text, dtpDataCadastro.Value.Date, txtLogin.Text, Convert.ToInt32(cboNivel.SelectedValue), txtSenha.Text, txtReeSenha.Text, cboStatus.Text);
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                //Caso não, altera um usuário já cadastrado.
                {
                    novoUsuario.Alterar(Convert.ToInt32(txtRegistro.Text), txtNome.Text, dtpDataCadastro.Value.Date, txtLogin.Text, Convert.ToInt32(cboNivel.SelectedValue), txtSenha.Text, txtReeSenha.Text, cboStatus.Text);
                    MessageBox.Show("Usuário alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Após a ação, atualiza a lista de usuários e limpa os campos do formulário.
                ListarUsuarios();
                Limpar();

                //Traz de volta a aba de procura para visualizar os clientes cadastrados.
                tbcUsuarios.SelectedTab = tbpProcura;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tbcUsuarios.SelectedTab = tbpCadastro;

            try
            {
                //Preenche cada componente do formulário com as informações do DataGrid correspondentes.
                txtRegistro.Text = dtgUsuarios.CurrentRow.Cells["ID_USUARIO"].Value.ToString();
                txtNome.Text = dtgUsuarios.CurrentRow.Cells["NOME"].Value.ToString();
                txtLogin.Text = dtgUsuarios.CurrentRow.Cells["LOGIN"].Value.ToString();

                if (dtgUsuarios.CurrentRow.Cells["SENHA"].Value.ToString().Trim().Length == 32)
                {
                    string novaSenha = dtgUsuarios.CurrentRow.Cells["SENHA"].Value.ToString().Substring(0, 8);
                    txtSenha.Text = novaSenha;
                    txtReeSenha.Text = novaSenha;
                }
                cboNivel.SelectedValue = dtgUsuarios.CurrentRow.Cells["ID_NIVEL"].Value.ToString();
                cboStatus.Text = dtgUsuarios.CurrentRow.Cells["STATUS"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        //Ação do botão btnLimpar, que chama o método Limpar para limpar os campos do formulário.
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Verifica se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Se sim, realiza o método Excluir, mostra mensagem do sucesso dessa ação, lista os usuários no DataGrid e limpa todos os campos.
                    novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                    novoUsuario.Excluir(Convert.ToInt32(dtgUsuarios.CurrentRow.Cells["ID_USUARIO"].Value));
                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Após a ação, atualiza a lista de clientes e limpa os campos do formulário.
                    ListarUsuarios();
                    Limpar();

                    //Traz de volta a aba de procura para visualizar os usuários cadastrados.
                    tbcUsuarios.SelectedTab = tbpProcura;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFormNiveis_Click(object sender, EventArgs e)
        {
            frmNiveis formNiveis = new frmNiveis();
            formNiveis.ShowDialog();
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        //Ação de alteração de texto que pesquisa um usuário no banco com base nos dados fornecidos.
        {
            try
            {
                //Verifica qual filtro foi selecionado para filtrar os dados.
                switch (cboFiltro.Text)
                {
                    //Mostra apenas os dados de usuários ativos.
                    case "Ativos":
                        tbcUsuarios.SelectedTab = tbpProcura;
                        novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                        bdsUsuarios.DataSource = novoUsuario.PesquisaAtivos(txtNomeUsuario.Text, cboOrdenar.Text);
                        bdnUsuarios.BindingSource = bdsUsuarios;
                        dtgUsuarios.DataSource = bdsUsuarios;
                        break;
                    //Mostra apenas os dados de usuários inativos.
                    case "Inativos":
                        tbcUsuarios.SelectedTab = tbpProcura;
                        novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                        bdsUsuarios.DataSource = novoUsuario.PesquisaInativos(txtNomeUsuario.Text, cboOrdenar.Text);
                        bdnUsuarios.BindingSource = bdsUsuarios;
                        dtgUsuarios.DataSource = bdsUsuarios;
                        break;
                    //Mostra todos os usuários cadastrados.
                    default:
                        tbcUsuarios.SelectedTab = tbpProcura;
                        novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                        bdsUsuarios.DataSource = novoUsuario.PesquisaNome(txtNomeUsuario.Text, cboOrdenar.Text);
                        bdnUsuarios.BindingSource = bdsUsuarios;
                        dtgUsuarios.DataSource = bdsUsuarios;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        //Ação do botão btnPesquisar que pesquisa um usuário no banco com base nos dados fornecidos.
        {
            try
            {
                //Verifica qual filtro foi selecionado para filtrar os dados.
                switch (cboFiltro.Text)
                {
                    //Mostra apenas os dados de usuários ativos.
                    case "Ativos":
                        tbcUsuarios.SelectedTab = tbpProcura;
                        novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                        bdsUsuarios.DataSource = novoUsuario.PesquisaAtivos(txtNomeUsuario.Text, cboOrdenar.Text);
                        bdnUsuarios.BindingSource = bdsUsuarios;
                        dtgUsuarios.DataSource = bdsUsuarios;
                        break;
                    //Mostra apenas os dados de usuários inativos.
                    case "Inativos":
                        tbcUsuarios.SelectedTab = tbpProcura;
                        novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                        bdsUsuarios.DataSource = novoUsuario.PesquisaInativos(txtNomeUsuario.Text, cboOrdenar.Text);
                        bdnUsuarios.BindingSource = bdsUsuarios;
                        dtgUsuarios.DataSource = bdsUsuarios;
                        break;
                    //Mostra todos os usuários cadastrados.
                    default:
                        tbcUsuarios.SelectedTab = tbpProcura;
                        novoUsuario = new RegraNegocio.UsuariosRegraNegocio();
                        bdsUsuarios.DataSource = novoUsuario.PesquisaNome(txtNomeUsuario.Text, cboOrdenar.Text);
                        bdnUsuarios.BindingSource = bdsUsuarios;
                        dtgUsuarios.DataSource = bdsUsuarios;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
