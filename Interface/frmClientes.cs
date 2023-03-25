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
    }
}
