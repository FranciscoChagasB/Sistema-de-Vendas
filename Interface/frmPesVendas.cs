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
    public partial class frmPesVendas : Form
    {
        RegraNegocio.ProdutoRegraNegocio novoProduto;
        frmVendas formularioVendas;
        public frmPesVendas(frmVendas formularioVendas)
        {
            InitializeComponent();
            this.formularioVendas = formularioVendas;
        }

        private void ListarProdutos()
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                dtgPesquisa.DataSource = novoProduto.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPesVendas_Load(object sender, EventArgs e)
        //Inicia o formulário com a listagem dos produtos no banco
        {
            ListarProdutos();
        }

        private void txtPesquisaProduto_TextChanged(object sender, EventArgs e)
        //Pesquisa um produto de acordo com o nome.
        {
            try
            {
                novoProduto = new RegraNegocio.ProdutoRegraNegocio();

                if (rbNomeProduto.Checked)
                {
                    dtgPesquisa.DataSource = novoProduto.PesquisaNome(txtPesquisaProduto.Text);
                }
                else
                {
                    dtgPesquisa.DataSource = novoProduto.PesquisaCodigoBarras(txtPesquisaProduto.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                //"Pega" do banco a quantidade em estoque do produto que será comprado.
                novoProduto = new RegraNegocio.ProdutoRegraNegocio();
                int estoqueAtual = novoProduto.RetornarEstoqueProduto(Convert.ToInt32(dtgPesquisa.Rows[dtgPesquisa.CurrentCell.RowIndex].Cells["ID_PRODUTO"].Value));

                //Verifica se a quantidade comprada é maior do que o estoque atual do produto.
                //Se for maior, não deixa a compra continuar, avisando o usuário do problema.
                if (Convert.ToInt32(txtQuantidade.Text) > estoqueAtual)
                {
                    MessageBox.Show("Quantidade excede o estoque do produto!", "Sem estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Caso contrário, executa a venda.
                else
                {
                    formularioVendas.quantidadeProduto = Convert.ToInt32(txtQuantidade.Text);
                    formularioVendas.txtCodBarras.Text = dtgPesquisa.Rows[dtgPesquisa.CurrentCell.RowIndex].Cells["CODIGO_BARRAS"].Value.ToString();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
