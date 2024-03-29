﻿using System;
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
    public partial class frmClientes : Form
    {
        RegraNegocio.ClientesRegraNegocio novoCliente;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        //RadioButton para cadastrar um cliente do tipo pessoa física.
        {
            //Se verificado que o RadionButton rbPessoaFisica está selecionado,
            if (rbPessoaFisica.Checked == true)
            {
                //o GroupBox dos documentos da pessoa física fica visível e da jurídica invisível.
                gbDocumentosPessoaFisica.Visible = true;
                gbDocumentosPessoaJuridica.Visible = false;
            }
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        //RadioButton para cadastrar um cliente do tipo pessoa jurídica.
        {
            //Se verificado que o RadionButton rbPessoaJuridica está selecionado,
            if (rbPessoaJuridica.Checked == true)
            {
                //o GroupBox dos documentos da pessoa jurídica fica visível e da física invisível.
                gbDocumentosPessoaJuridica.Visible = true;
                gbDocumentosPessoaFisica.Visible = false;
            }
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
            txtCnpj.Clear();
            txtIe.Clear();
            txtTelefone.Clear();
            cboStatus.SelectedIndex = 0;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        //Ação do botão btnNovo, que altera para a aba de cadastro do formulário e limpa os campos com o método Limpar.
        {
            tbcClientes.SelectedTab = tbpCadastro;
            Limpar();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        //Evento load do formulário, que inicia o formulário com o método Listar.
        {
            Listar();
        }

        private void Listar()
        //Método para listar todos os clientes do banco de dados no formulário na aba de procura.
        {
            tbcClientes.SelectedTab = tbpProcura;
            novoCliente = new RegraNegocio.ClientesRegraNegocio();
            bdsClientes.DataSource = novoCliente.Listar();
            bdnClientes.BindingSource = bdsClientes;
            dtgClientes.DataSource = bdsClientes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        //Ação do btnSalvar, que salva um cliente no banco de dados.
        {
            try
            {
                if (txtRegistro.Text == "0")
                {
                    //verifica se o RadioButton referente à pessoa física está selecionado.
                    if (rbPessoaFisica.Checked == true)
                    {
                        //Se sim, realiza a ação de salvar os dados na tabela Cliente.
                        novoCliente.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text,
                                           txtEstado.Text, txtTelefone.Text, txtEmail.Text, dtpDataCadastro.Value.Date,
                                           dtpNascimento.Value.Date, txtObservacao.Text, cboStatus.Text);

                        //Depois lista todos os clientes da tabela, tendo como base o id deles,
                        DataTable dadosTabela = new DataTable();
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        dadosTabela = novoCliente.Listar();

                        //em seguida, salva os dados referentes ao RG e CPF na tabela Pessoa_fisica.
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        novoCliente.SalvarPessoaFisica(Convert.ToInt32(dadosTabela.Rows[0]["ID_CLIENTE"]), txtCpf.Text, txtRg.Text);
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        /*Se não, é o RadioButton referente à pessoa jurídica que está selecionado e realiza a ação salvar os dados
                         * na tabela Cliente.*/
                        novoCliente.Salvar(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text,
                                           txtEstado.Text, txtTelefone.Text, txtEmail.Text, dtpDataCadastro.Value.Date,
                                           dtpNascimento.Value.Date, txtObservacao.Text, cboStatus.Text); ;

                        //Depois lista todos os clientes da tabela, tendo como base o id deles,
                        DataTable dadosTabela = new DataTable();
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        dadosTabela = novoCliente.Listar();

                        //em seguida, salva os dados referentes ao IE e CNPJ na tabela Pessoa_juridica.
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        novoCliente.SalvarPessoaJuridica(Convert.ToInt32(dadosTabela.Rows[0]["ID_CLIENTE"]), txtCnpj.Text, txtIe.Text);
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //Se não, se o código for diferente de 0 e o RadioButton referente à pessoa física estiver selecionado,
                    if (rbPessoaFisica.Checked == true)
                    {
                        //realizará o método Alterar e AlterarPessoaFisica, para as tabelas Cliente e Pessoa_fisica receberem as mudanças,
                        novoCliente.Alterar(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text,
                                            txtCidade.Text, txtEstado.Text, txtTelefone.Text, txtEmail.Text, dtpDataCadastro.Value.Date,
                                            dtpNascimento.Value.Date, txtObservacao.Text, cboStatus.Text);
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        novoCliente.AlterarPessoaFisica(Convert.ToInt32(txtRegistro.Text), txtCpf.Text, txtRg.Text);
                        MessageBox.Show("Cliente alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //senão, significa que o rbPessoaJuridica está selecionado e realiza os métodos Alterar e AlterarPessoaJuridica.
                        novoCliente.Alterar(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text,
                                            txtCidade.Text, txtEstado.Text, txtTelefone.Text, txtEmail.Text, dtpDataCadastro.Value.Date,
                                            dtpNascimento.Value.Date, txtObservacao.Text, cboStatus.Text);
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        novoCliente.AlterarPessoaJuridica(Convert.ToInt32(txtRegistro.Text), txtCnpj.Text, txtIe.Text);
                        MessageBox.Show("Cliente alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //Após a ação, atualiza a lista de clientes e limpa os campos do formulário.
                Listar();
                Limpar();

                //Traz de volta a aba de procura para visualizar os clientes cadastrados.
                tbcClientes.SelectedTab = tbpProcura;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        //Ação do btnAlterar, que carrega os dados do cliente cadastrado no banco para fazer alterações.
        {
            tbcClientes.SelectedTab = tbpCadastro;

            try
            {
                txtRegistro.Text = dtgClientes.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
                txtNome.Text = dtgClientes.CurrentRow.Cells["NOME_CLIENTE"].Value.ToString();
                txtEndereco.Text = dtgClientes.CurrentRow.Cells["ENDERECO_CLIENTE"].Value.ToString();
                txtBairro.Text = dtgClientes.CurrentRow.Cells["BAIRRO_CLIENTE"].Value.ToString();
                txtCep.Text = dtgClientes.CurrentRow.Cells["CEP_CLIENTE"].Value.ToString();
                txtCidade.Text = dtgClientes.CurrentRow.Cells["CIDADE_CLIENTE"].Value.ToString();
                txtEstado.Text = dtgClientes.CurrentRow.Cells["ESTADO_CLIENTE"].Value.ToString();
                txtTelefone.Text = dtgClientes.CurrentRow.Cells["TELEFONE_CLIENTE"].Value.ToString();
                txtEmail.Text = dtgClientes.CurrentRow.Cells["EMAIL_CLIENTE"].Value.ToString();
                dtpDataCadastro.Value = Convert.ToDateTime(dtgClientes.CurrentRow.Cells["DATA_CADASTRO_CLIENTE"].Value.ToString());
                dtpNascimento.Value = Convert.ToDateTime(dtgClientes.CurrentRow.Cells["NASCIMENTO_CLIENTE"].Value.ToString());
                txtObservacao.Text = dtgClientes.CurrentRow.Cells["OBSERVACOES_CLIENTE"].Value.ToString();
                cboStatus.Text = dtgClientes.CurrentRow.Cells["STATUS_CLIENTE"].Value.ToString();

                //Depois realiza a listagem dos clientes de pessoa física, baseado no ID deles.
                DataTable dadosTabela = new DataTable();
                novoCliente = new RegraNegocio.ClientesRegraNegocio();
                dadosTabela = novoCliente.ListarPessoaFisica(Convert.ToInt32(dtgClientes.CurrentRow.Cells["ID_CLIENTE"].Value));

                //Se contagem for maior que 0, o cliente é uma pessoa física,
                if (dadosTabela.Rows.Count > 0)
                {
                    //os componentes referentes ao CPF e RG recebem estes valores do DataGrid,
                    txtCpf.Text = dadosTabela.Rows[0]["CPF_CLIENTE"].ToString();
                    txtRg.Text = dadosTabela.Rows[0]["RG_CLIENTE"].ToString();

                    //e deixa o GroupBox referente à pessoa física visível e o jurídico invisível.
                    gbDocumentosPessoaFisica.Visible = true;
                    gbDocumentosPessoaJuridica.Visible = false;
                }
                else
                {
                    /*Se não, é pessoa jurídica e realiza o processo de listar os clientes desse tipo baseado por seu ID,
                     * no qual os componentes referentes ao CNPJ e IE recebem os valores do DataGrid e deixa visível o 
                       GroupBox referente à pessoa jurídica e a física invisível.*/
                    novoCliente = new RegraNegocio.ClientesRegraNegocio();
                    dadosTabela = novoCliente.ListarPessoaJuridica(Convert.ToInt32(dtgClientes.CurrentRow.Cells["ID_CLIENTE"].Value));

                    txtCnpj.Text = dadosTabela.Rows[0]["CNPJ_CLIENTE"].ToString();
                    txtIe.Text = dadosTabela.Rows[0]["IE_CLIENTE"].ToString();

                    gbDocumentosPessoaJuridica.Visible = true;
                    gbDocumentosPessoaFisica.Visible = false;
                }
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
        //Ação do botão btnExcluir, que exclui um cliente selecionado pelo usuário.
        {
            //Verifica se o resultado foi Yes para a pergunta se deseja excluir o cadastro.
            if (MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Se sim, realiza o método Excluir, mostra mensagem do sucesso dessa ação, lista os clientes no DataGrid e limpa todos os campos.
                    novoCliente = new RegraNegocio.ClientesRegraNegocio();
                    novoCliente.Excluir(Convert.ToInt32(dtgClientes.CurrentRow.Cells["ID_CLIENTE"].Value));
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Após a ação, atualiza a lista de clientes e limpa os campos do formulário.
                    Listar();
                    Limpar();

                    //Traz de volta a aba de procura para visualizar os clientes cadastrados.
                    tbcClientes.SelectedTab = tbpProcura;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        //Ação de alteração de texto que pesquisa um cliente no banco com base nos dados fornecidos.
        {
            try
            {
                //Verifica qual filtro foi selecionado para filtrar os dados.
                switch (cboFiltro.Text)
                {
                    //Mostra apenas os dados de clientes cadastrados com cpf.
                    case "Cadastrados com CPF":
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaCpf(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                    //Mostra apenas os dados de clientes cadastrados com cnpj.
                    case "Cadastrados com CNPJ":
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaCnpj(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                    //Mostra apenas os dados de clientes ativos.
                    case "Ativos":
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaAtivos(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                    //Mostra apenas os dados de clientes inativos.
                    case "Inativos":
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaInativos(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                    //Mostra todos os clientes cadastrados.
                    default:
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaNome(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        //Ação do botão btnPesquisar que pesquisa um cliente no banco com base nos dados fornecidos.
        {
            try
            {
                novoCliente = new RegraNegocio.ClientesRegraNegocio();

                //Verifica qual filtro foi selecionado para filtrar os dados.
                switch (cboFiltro.Text)
                {
                    //Mostra apenas os dados de clientes cadastrados com cpf.
                    case "Cadastrados com CPF":
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaCpf(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                    //Mostra apenas os dados de clientes cadastrados com cnpj.
                    case "Cadastrados com CNPJ":
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaCnpj(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                    //Mostra apenas os dados de clientes ativos.
                    case "Ativos":
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaAtivos(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                    //Mostra apenas os dados de clientes inativos.
                    case "Inativos":
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaInativos(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
                        break;
                    //Mostra todos os clientes cadastrados.
                    default:
                        tbcClientes.SelectedTab = tbpProcura;
                        novoCliente = new RegraNegocio.ClientesRegraNegocio();
                        bdsClientes.DataSource = novoCliente.PesquisaNome(txtNomeCliente.Text, cboOrdenar.Text);
                        bdnClientes.BindingSource = bdsClientes;
                        dtgClientes.DataSource = bdsClientes;
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

