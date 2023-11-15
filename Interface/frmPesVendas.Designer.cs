namespace Interface
{
    partial class frmPesVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesVendas));
            this.rbCodigoBarras = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNomeProduto = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dtgPesquisa = new System.Windows.Forms.DataGridView();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_BARRAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_MINIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_ATUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_UNIDADE_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_UNIDADE_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARGEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SITUACAO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANOTACOES_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCodigoBarras
            // 
            this.rbCodigoBarras.AutoSize = true;
            this.rbCodigoBarras.Checked = true;
            this.rbCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigoBarras.Location = new System.Drawing.Point(217, 89);
            this.rbCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigoBarras.Name = "rbCodigoBarras";
            this.rbCodigoBarras.Size = new System.Drawing.Size(138, 21);
            this.rbCodigoBarras.TabIndex = 49;
            this.rbCodigoBarras.TabStop = true;
            this.rbCodigoBarras.Text = "Código de barras";
            this.rbCodigoBarras.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Dê um duplo clique no produto para inserí-lo na venda.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Digite o nome ou o código de barras do produto.";
            // 
            // rbNomeProduto
            // 
            this.rbNomeProduto.AutoSize = true;
            this.rbNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomeProduto.Location = new System.Drawing.Point(374, 89);
            this.rbNomeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.rbNomeProduto.Name = "rbNomeProduto";
            this.rbNomeProduto.Size = new System.Drawing.Size(66, 21);
            this.rbNomeProduto.TabIndex = 48;
            this.rbNomeProduto.Text = "Nome";
            this.rbNomeProduto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 482);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 52;
            this.label3.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(194, 480);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(74, 37);
            this.txtQuantidade.TabIndex = 51;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgPesquisa
            // 
            this.dtgPesquisa.AllowUserToAddRows = false;
            this.dtgPesquisa.AllowUserToDeleteRows = false;
            this.dtgPesquisa.AllowUserToResizeColumns = false;
            this.dtgPesquisa.AllowUserToResizeRows = false;
            this.dtgPesquisa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUTO,
            this.CODIGO_BARRAS,
            this.DATA,
            this.NOME,
            this.DETALHES,
            this.CATEGORIA,
            this.ESTOQUE_MINIMO,
            this.ESTOQUE_ATUAL,
            this.CUSTO,
            this.VENDA,
            this.NOME_CATEGORIA,
            this.ID_UNIDADE_PRODUTOS,
            this.NOME_UNIDADE_PRODUTOS,
            this.MARGEM,
            this.SITUACAO_PRODUTO,
            this.ANOTACOES_PRODUTO});
            this.dtgPesquisa.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgPesquisa.Location = new System.Drawing.Point(13, 155);
            this.dtgPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPesquisa.Name = "dtgPesquisa";
            this.dtgPesquisa.ReadOnly = true;
            this.dtgPesquisa.RowHeadersWidth = 51;
            this.dtgPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dtgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisa.Size = new System.Drawing.Size(601, 255);
            this.dtgPesquisa.TabIndex = 50;
            this.dtgPesquisa.TabStop = false;
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisaProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaProduto.Location = new System.Drawing.Point(13, 33);
            this.txtPesquisaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaProduto.MaxLength = 13;
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(601, 46);
            this.txtPesquisaProduto.TabIndex = 45;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = global::Interface.Properties.Resources._17439_add_cart_ecommerce_shopping_icon;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(449, 476);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(165, 50);
            this.btnAdicionar.TabIndex = 53;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.DataPropertyName = "ID_PRODUTO";
            this.ID_PRODUTO.HeaderText = "Código";
            this.ID_PRODUTO.MinimumWidth = 6;
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            this.ID_PRODUTO.ReadOnly = true;
            this.ID_PRODUTO.Visible = false;
            this.ID_PRODUTO.Width = 125;
            // 
            // CODIGO_BARRAS
            // 
            this.CODIGO_BARRAS.DataPropertyName = "CODIGOBARRAS_PRODUTO";
            this.CODIGO_BARRAS.HeaderText = "Cód Barras";
            this.CODIGO_BARRAS.MinimumWidth = 6;
            this.CODIGO_BARRAS.Name = "CODIGO_BARRAS";
            this.CODIGO_BARRAS.ReadOnly = true;
            this.CODIGO_BARRAS.Width = 200;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA_CADASTRO_PRODUTO";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle1;
            this.DATA.HeaderText = "Data Cadastro";
            this.DATA.MinimumWidth = 6;
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Visible = false;
            this.DATA.Width = 125;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME_PRODUTO";
            this.NOME.HeaderText = "Nome";
            this.NOME.MinimumWidth = 6;
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 175;
            // 
            // DETALHES
            // 
            this.DETALHES.DataPropertyName = "DESCRICAO_PRODUTO";
            this.DETALHES.HeaderText = "Detalhes";
            this.DETALHES.MinimumWidth = 6;
            this.DETALHES.Name = "DETALHES";
            this.DETALHES.ReadOnly = true;
            this.DETALHES.Width = 150;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "ID_CATEGORIA";
            this.CATEGORIA.HeaderText = "Id_Categoria";
            this.CATEGORIA.MinimumWidth = 6;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.Visible = false;
            this.CATEGORIA.Width = 125;
            // 
            // ESTOQUE_MINIMO
            // 
            this.ESTOQUE_MINIMO.DataPropertyName = "ESTOQUE_MINIMO";
            this.ESTOQUE_MINIMO.HeaderText = "Estoque Minimo";
            this.ESTOQUE_MINIMO.MinimumWidth = 6;
            this.ESTOQUE_MINIMO.Name = "ESTOQUE_MINIMO";
            this.ESTOQUE_MINIMO.ReadOnly = true;
            this.ESTOQUE_MINIMO.Visible = false;
            this.ESTOQUE_MINIMO.Width = 50;
            // 
            // ESTOQUE_ATUAL
            // 
            this.ESTOQUE_ATUAL.DataPropertyName = "ESTOQUE_ATUAL";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ESTOQUE_ATUAL.DefaultCellStyle = dataGridViewCellStyle2;
            this.ESTOQUE_ATUAL.HeaderText = "Estoque";
            this.ESTOQUE_ATUAL.MinimumWidth = 6;
            this.ESTOQUE_ATUAL.Name = "ESTOQUE_ATUAL";
            this.ESTOQUE_ATUAL.ReadOnly = true;
            this.ESTOQUE_ATUAL.Visible = false;
            this.ESTOQUE_ATUAL.Width = 50;
            // 
            // CUSTO
            // 
            this.CUSTO.DataPropertyName = "VALOR_COMPRA";
            this.CUSTO.HeaderText = "Custo";
            this.CUSTO.MinimumWidth = 6;
            this.CUSTO.Name = "CUSTO";
            this.CUSTO.ReadOnly = true;
            this.CUSTO.Visible = false;
            this.CUSTO.Width = 125;
            // 
            // VENDA
            // 
            this.VENDA.DataPropertyName = "VALOR_VENDA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.VENDA.DefaultCellStyle = dataGridViewCellStyle3;
            this.VENDA.HeaderText = "Venda";
            this.VENDA.MinimumWidth = 6;
            this.VENDA.Name = "VENDA";
            this.VENDA.ReadOnly = true;
            this.VENDA.Visible = false;
            this.VENDA.Width = 90;
            // 
            // NOME_CATEGORIA
            // 
            this.NOME_CATEGORIA.DataPropertyName = "NOME_CATEGORIA_PRODUTOS";
            this.NOME_CATEGORIA.HeaderText = "Categoria";
            this.NOME_CATEGORIA.MinimumWidth = 6;
            this.NOME_CATEGORIA.Name = "NOME_CATEGORIA";
            this.NOME_CATEGORIA.ReadOnly = true;
            this.NOME_CATEGORIA.Visible = false;
            this.NOME_CATEGORIA.Width = 125;
            // 
            // ID_UNIDADE_PRODUTOS
            // 
            this.ID_UNIDADE_PRODUTOS.DataPropertyName = "ID_UNIDADE";
            this.ID_UNIDADE_PRODUTOS.HeaderText = "ID_UNIDADE_PRODUTOS";
            this.ID_UNIDADE_PRODUTOS.MinimumWidth = 6;
            this.ID_UNIDADE_PRODUTOS.Name = "ID_UNIDADE_PRODUTOS";
            this.ID_UNIDADE_PRODUTOS.ReadOnly = true;
            this.ID_UNIDADE_PRODUTOS.Visible = false;
            this.ID_UNIDADE_PRODUTOS.Width = 125;
            // 
            // NOME_UNIDADE_PRODUTOS
            // 
            this.NOME_UNIDADE_PRODUTOS.DataPropertyName = "NOME_UNIDADE_PRODUTOS";
            this.NOME_UNIDADE_PRODUTOS.HeaderText = "NOME_UNIDADE_PRODUTOS";
            this.NOME_UNIDADE_PRODUTOS.MinimumWidth = 6;
            this.NOME_UNIDADE_PRODUTOS.Name = "NOME_UNIDADE_PRODUTOS";
            this.NOME_UNIDADE_PRODUTOS.ReadOnly = true;
            this.NOME_UNIDADE_PRODUTOS.Visible = false;
            this.NOME_UNIDADE_PRODUTOS.Width = 125;
            // 
            // MARGEM
            // 
            this.MARGEM.DataPropertyName = "MARGEM";
            this.MARGEM.HeaderText = "MARGEM";
            this.MARGEM.MinimumWidth = 6;
            this.MARGEM.Name = "MARGEM";
            this.MARGEM.ReadOnly = true;
            this.MARGEM.Visible = false;
            this.MARGEM.Width = 125;
            // 
            // SITUACAO_PRODUTO
            // 
            this.SITUACAO_PRODUTO.DataPropertyName = "SITUACAO_PRODUTO";
            this.SITUACAO_PRODUTO.HeaderText = "SITUACAO_PRODUTO";
            this.SITUACAO_PRODUTO.MinimumWidth = 6;
            this.SITUACAO_PRODUTO.Name = "SITUACAO_PRODUTO";
            this.SITUACAO_PRODUTO.ReadOnly = true;
            this.SITUACAO_PRODUTO.Visible = false;
            this.SITUACAO_PRODUTO.Width = 125;
            // 
            // ANOTACOES_PRODUTO
            // 
            this.ANOTACOES_PRODUTO.DataPropertyName = "ANOTACOES_PRODUTO";
            this.ANOTACOES_PRODUTO.HeaderText = "ANOTACOES_PRODUTO";
            this.ANOTACOES_PRODUTO.MinimumWidth = 6;
            this.ANOTACOES_PRODUTO.Name = "ANOTACOES_PRODUTO";
            this.ANOTACOES_PRODUTO.ReadOnly = true;
            this.ANOTACOES_PRODUTO.Visible = false;
            this.ANOTACOES_PRODUTO.Width = 125;
            // 
            // frmPesVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(627, 539);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.rbCodigoBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbNomeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.dtgPesquisa);
            this.Controls.Add(this.txtPesquisaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesVendas";
            this.Text = "Pesquisa Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.RadioButton rbCodigoBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView dtgPesquisa;
        public System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_BARRAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_MINIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_ATUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_UNIDADE_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_UNIDADE_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARGEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SITUACAO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANOTACOES_PRODUTO;
    }
}