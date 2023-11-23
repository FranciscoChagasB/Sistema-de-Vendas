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
    public partial class frmPesClientes : Form
    {
        RegraNegocio.ClientesRegraNegocio novoCliente;
        frmVendas formularioVendas;
        public frmPesClientes(frmVendas formularioVendas)
        {
            InitializeComponent();
            this.formularioVendas = formularioVendas;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                novoCliente = new RegraNegocio.ClientesRegraNegocio();

                if (rbCnpj.Checked)
                {
                    dtgClientes.DataSource = novoCliente.PesquisaCnpj(txtPesquisa.Text);
                }
                else
                {
                    dtgClientes.DataSource = novoCliente.PesquisaCpf(txtPesquisa.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formularioVendas.idCliente = Convert.ToInt32(dtgClientes.Rows[e.RowIndex].Cells["ID_CLIENTE"].Value);
            formularioVendas.lblNomeCliente.Text = dtgClientes.Rows[e.RowIndex].Cells["NOME_CLIENTE"].Value.ToString();

            if (dtgClientes.Rows[e.RowIndex].Cells["CPF"].Value == null)
            {
                formularioVendas.cpfCliente = "";
            }
            else
            {
                formularioVendas.cpfCliente = dtgClientes.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                formularioVendas.documentoCliente = Convert.ToString(formularioVendas.cpfCliente);
            }

            if (dtgClientes.Rows[e.RowIndex].Cells["CNPJ"].Value == null)
            {
                formularioVendas.cnpjCliente = "";
            }
            else
            {
                formularioVendas.cnpjCliente = dtgClientes.Rows[e.RowIndex].Cells["CNPJ"].Value.ToString();
                formularioVendas.documentoCliente = Convert.ToString(formularioVendas.cnpjCliente);
            }

            this.Close();
        }
    }
}
