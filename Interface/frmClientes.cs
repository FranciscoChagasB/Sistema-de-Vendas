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
    public partial class frmClientes : Form
    {
        RegraNegocio.ClientesRegraNegocio novoCliente;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
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
        {
            tbcClientes.SelectedTab = tbpCadastro;
            Limpar();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            novoCliente = new RegraNegocio.ClientesRegraNegocio();
            dtgClientes.DataSource = novoCliente.Listar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Você está tentando cadastrar um cliente já cadastrado!", "Cliente já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        {
            Limpar();
        }
    }
}
