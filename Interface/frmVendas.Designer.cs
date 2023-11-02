namespace Interface
{
    partial class frmVendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcVendas = new System.Windows.Forms.TabControl();
            this.tbpVendas = new System.Windows.Forms.TabPage();
            this.tbpFinVenda = new System.Windows.Forms.TabPage();
            this.gbItemEmDestaque = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbDetalhesVendas = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblUsuário = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDigitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.ID_DETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_BARRAS_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_CUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValorSubtotal = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bdnVendas = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bdsVendas = new System.Windows.Forms.BindingSource(this.components);
            this.bntFin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ltCupomFiscal = new System.Windows.Forms.ListBox();
            this.chkAcrescimo = new System.Windows.Forms.CheckBox();
            this.chkDesconto = new System.Windows.Forms.CheckBox();
            this.cboPagamento = new System.Windows.Forms.ComboBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbcVendas.SuspendLayout();
            this.tbpVendas.SuspendLayout();
            this.tbpFinVenda.SuspendLayout();
            this.gbItemEmDestaque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDetalhesVendas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnVendas)).BeginInit();
            this.bdnVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVendas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bdnVendas);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.btnAjuda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 732);
            this.panel1.TabIndex = 6;
            // 
            // tbcVendas
            // 
            this.tbcVendas.Controls.Add(this.tbpVendas);
            this.tbcVendas.Controls.Add(this.tbpFinVenda);
            this.tbcVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcVendas.Location = new System.Drawing.Point(199, 0);
            this.tbcVendas.Name = "tbcVendas";
            this.tbcVendas.SelectedIndex = 0;
            this.tbcVendas.Size = new System.Drawing.Size(1288, 732);
            this.tbcVendas.TabIndex = 7;
            // 
            // tbpVendas
            // 
            this.tbpVendas.Controls.Add(this.lblValorSubtotal);
            this.tbpVendas.Controls.Add(this.labelSubtotal);
            this.tbpVendas.Controls.Add(this.gbItemEmDestaque);
            this.tbpVendas.Controls.Add(this.dataGridView1);
            this.tbpVendas.Controls.Add(this.gbDetalhesVendas);
            this.tbpVendas.Controls.Add(this.groupBox1);
            this.tbpVendas.Location = new System.Drawing.Point(4, 25);
            this.tbpVendas.Name = "tbpVendas";
            this.tbpVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVendas.Size = new System.Drawing.Size(1280, 703);
            this.tbpVendas.TabIndex = 0;
            this.tbpVendas.Text = "Vendas";
            this.tbpVendas.UseVisualStyleBackColor = true;
            // 
            // tbpFinVenda
            // 
            this.tbpFinVenda.Controls.Add(this.bntFin);
            this.tbpFinVenda.Controls.Add(this.btnCancel);
            this.tbpFinVenda.Controls.Add(this.panel2);
            this.tbpFinVenda.Controls.Add(this.chkAcrescimo);
            this.tbpFinVenda.Controls.Add(this.chkDesconto);
            this.tbpFinVenda.Controls.Add(this.cboPagamento);
            this.tbpFinVenda.Controls.Add(this.txtTroco);
            this.tbpFinVenda.Controls.Add(this.txtAcrescimo);
            this.tbpFinVenda.Controls.Add(this.txtDesconto);
            this.tbpFinVenda.Controls.Add(this.label6);
            this.tbpFinVenda.Controls.Add(this.txtTotal);
            this.tbpFinVenda.Controls.Add(this.txtSubTotal);
            this.tbpFinVenda.Controls.Add(this.label8);
            this.tbpFinVenda.Controls.Add(this.label9);
            this.tbpFinVenda.Controls.Add(this.label10);
            this.tbpFinVenda.Controls.Add(this.label11);
            this.tbpFinVenda.Controls.Add(this.txtValorPago);
            this.tbpFinVenda.Controls.Add(this.panel3);
            this.tbpFinVenda.Location = new System.Drawing.Point(4, 25);
            this.tbpFinVenda.Name = "tbpFinVenda";
            this.tbpFinVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFinVenda.Size = new System.Drawing.Size(1280, 703);
            this.tbpFinVenda.TabIndex = 1;
            this.tbpFinVenda.Text = "Finalizar Venda";
            this.tbpFinVenda.UseVisualStyleBackColor = true;
            // 
            // gbItemEmDestaque
            // 
            this.gbItemEmDestaque.BackColor = System.Drawing.SystemColors.Control;
            this.gbItemEmDestaque.Controls.Add(this.label7);
            this.gbItemEmDestaque.Controls.Add(this.lblSubtotal);
            this.gbItemEmDestaque.Controls.Add(this.lblQuantidade);
            this.gbItemEmDestaque.Controls.Add(this.lblValor);
            this.gbItemEmDestaque.Controls.Add(this.lblDescricao);
            this.gbItemEmDestaque.Controls.Add(this.lblItem);
            this.gbItemEmDestaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItemEmDestaque.Location = new System.Drawing.Point(7, 156);
            this.gbItemEmDestaque.Margin = new System.Windows.Forms.Padding(4);
            this.gbItemEmDestaque.Name = "gbItemEmDestaque";
            this.gbItemEmDestaque.Padding = new System.Windows.Forms.Padding(4);
            this.gbItemEmDestaque.Size = new System.Drawing.Size(1264, 134);
            this.gbItemEmDestaque.TabIndex = 38;
            this.gbItemEmDestaque.TabStop = false;
            this.gbItemEmDestaque.Text = "Item em destaque";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "X";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubtotal.Location = new System.Drawing.Point(964, 83);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(252, 25);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblQuantidade.Location = new System.Drawing.Point(707, 83);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(175, 25);
            this.lblQuantidade.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblValor.Location = new System.Drawing.Point(534, 83);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(129, 25);
            this.lblValor.TabIndex = 0;
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDescricao.Location = new System.Drawing.Point(8, 74);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(433, 41);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem
            // 
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblItem.Location = new System.Drawing.Point(8, 28);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(1248, 41);
            this.lblItem.TabIndex = 0;
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DETALHES,
            this.ID_VENDA,
            this.ID_PRODUTO,
            this.CODIGO_BARRAS_PRODUTO,
            this.NOME_PRODUTO,
            this.DESCRICAO_PRODUTO,
            this.VALOR_VENDA,
            this.QUANTIDADE,
            this.VALOR_CUSTO});
            this.dataGridView1.Location = new System.Drawing.Point(7, 298);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 345);
            this.dataGridView1.TabIndex = 36;
            // 
            // gbDetalhesVendas
            // 
            this.gbDetalhesVendas.BackColor = System.Drawing.SystemColors.Control;
            this.gbDetalhesVendas.Controls.Add(this.btnPesquisar);
            this.gbDetalhesVendas.Controls.Add(this.lblUsuário);
            this.gbDetalhesVendas.Controls.Add(this.lblData);
            this.gbDetalhesVendas.Controls.Add(this.label5);
            this.gbDetalhesVendas.Controls.Add(this.label3);
            this.gbDetalhesVendas.Controls.Add(this.lblNomeCliente);
            this.gbDetalhesVendas.Controls.Add(this.label2);
            this.gbDetalhesVendas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalhesVendas.Location = new System.Drawing.Point(671, 7);
            this.gbDetalhesVendas.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetalhesVendas.Name = "gbDetalhesVendas";
            this.gbDetalhesVendas.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetalhesVendas.Size = new System.Drawing.Size(600, 141);
            this.gbDetalhesVendas.TabIndex = 37;
            this.gbDetalhesVendas.TabStop = false;
            this.gbDetalhesVendas.Text = "Detalhes da venda";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(372, 38);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(162, 59);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblUsuário
            // 
            this.lblUsuário.AutoSize = true;
            this.lblUsuário.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUsuário.Location = new System.Drawing.Point(180, 96);
            this.lblUsuário.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuário.Name = "lblUsuário";
            this.lblUsuário.Size = new System.Drawing.Size(106, 19);
            this.lblUsuário.TabIndex = 5;
            this.lblUsuário.Text = "Administrador";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblData.Location = new System.Drawing.Point(8, 96);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(94, 19);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data de hoje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(180, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNomeCliente.Location = new System.Drawing.Point(8, 48);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(223, 19);
            this.lblNomeCliente.TabIndex = 5;
            this.lblNomeCliente.Text = "Não informado para esta venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnDigitar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodBarras);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(600, 141);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto por código";
            // 
            // btnDigitar
            // 
            this.btnDigitar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDigitar.Location = new System.Drawing.Point(427, 83);
            this.btnDigitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDigitar.Name = "btnDigitar";
            this.btnDigitar.Size = new System.Drawing.Size(120, 32);
            this.btnDigitar.TabIndex = 1;
            this.btnDigitar.Text = "Digitar";
            this.btnDigitar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Insira o código de barras do produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCodBarras.Location = new System.Drawing.Point(8, 31);
            this.txtCodBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(584, 29);
            this.txtCodBarras.TabIndex = 0;
            // 
            // ID_DETALHES
            // 
            this.ID_DETALHES.DataPropertyName = "ID_DETALHES";
            this.ID_DETALHES.HeaderText = "Codigo Detalhes";
            this.ID_DETALHES.MinimumWidth = 6;
            this.ID_DETALHES.Name = "ID_DETALHES";
            this.ID_DETALHES.ReadOnly = true;
            this.ID_DETALHES.Visible = false;
            this.ID_DETALHES.Width = 125;
            // 
            // ID_VENDA
            // 
            this.ID_VENDA.DataPropertyName = "ID_VENDA";
            this.ID_VENDA.HeaderText = "CodVenda";
            this.ID_VENDA.MinimumWidth = 6;
            this.ID_VENDA.Name = "ID_VENDA";
            this.ID_VENDA.ReadOnly = true;
            this.ID_VENDA.Visible = false;
            this.ID_VENDA.Width = 125;
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.DataPropertyName = "ID_PRODUTO";
            this.ID_PRODUTO.HeaderText = "CodProduto";
            this.ID_PRODUTO.MinimumWidth = 6;
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            this.ID_PRODUTO.ReadOnly = true;
            this.ID_PRODUTO.Visible = false;
            this.ID_PRODUTO.Width = 125;
            // 
            // CODIGO_BARRAS_PRODUTO
            // 
            this.CODIGO_BARRAS_PRODUTO.DataPropertyName = "CODIGO_BARRAS_PRODUTO";
            this.CODIGO_BARRAS_PRODUTO.HeaderText = "Código de Barras";
            this.CODIGO_BARRAS_PRODUTO.MinimumWidth = 6;
            this.CODIGO_BARRAS_PRODUTO.Name = "CODIGO_BARRAS_PRODUTO";
            this.CODIGO_BARRAS_PRODUTO.ReadOnly = true;
            this.CODIGO_BARRAS_PRODUTO.Width = 275;
            // 
            // NOME_PRODUTO
            // 
            this.NOME_PRODUTO.DataPropertyName = "NOME_PRODUTO";
            this.NOME_PRODUTO.HeaderText = "Nome";
            this.NOME_PRODUTO.MinimumWidth = 6;
            this.NOME_PRODUTO.Name = "NOME_PRODUTO";
            this.NOME_PRODUTO.ReadOnly = true;
            this.NOME_PRODUTO.Width = 225;
            // 
            // DESCRICAO_PRODUTO
            // 
            this.DESCRICAO_PRODUTO.DataPropertyName = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.HeaderText = "Descrição";
            this.DESCRICAO_PRODUTO.MinimumWidth = 6;
            this.DESCRICAO_PRODUTO.Name = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.ReadOnly = true;
            this.DESCRICAO_PRODUTO.Width = 175;
            // 
            // VALOR_VENDA
            // 
            this.VALOR_VENDA.DataPropertyName = "VALOR_VENDA";
            this.VALOR_VENDA.HeaderText = "Valor Unitário";
            this.VALOR_VENDA.MinimumWidth = 6;
            this.VALOR_VENDA.Name = "VALOR_VENDA";
            this.VALOR_VENDA.ReadOnly = true;
            this.VALOR_VENDA.Width = 175;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "Qtde.";
            this.QUANTIDADE.MinimumWidth = 6;
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 175;
            // 
            // VALOR_CUSTO
            // 
            this.VALOR_CUSTO.DataPropertyName = "VALOR_CUSTO";
            this.VALOR_CUSTO.HeaderText = "Subtotal";
            this.VALOR_CUSTO.MinimumWidth = 6;
            this.VALOR_CUSTO.Name = "VALOR_CUSTO";
            this.VALOR_CUSTO.ReadOnly = true;
            this.VALOR_CUSTO.Width = 175;
            // 
            // lblValorSubtotal
            // 
            this.lblValorSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblValorSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSubtotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorSubtotal.Location = new System.Drawing.Point(1036, 660);
            this.lblValorSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorSubtotal.Name = "lblValorSubtotal";
            this.lblValorSubtotal.Size = new System.Drawing.Size(235, 38);
            this.lblValorSubtotal.TabIndex = 39;
            this.lblValorSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(868, 659);
            this.labelSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(160, 39);
            this.labelSubtotal.TabIndex = 40;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinalizar.Image = global::Interface.Properties.Resources._6586148_accept_check_good_mark_ok_icon;
            this.btnFinalizar.Location = new System.Drawing.Point(0, 222);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(197, 74);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjuda.Image = global::Interface.Properties.Resources.ajuda;
            this.btnAjuda.Location = new System.Drawing.Point(0, 582);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(197, 74);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.Image = global::Interface.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(0, 656);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(197, 74);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.Image = global::Interface.Properties.Resources.excluir;
            this.btnCancelar.Location = new System.Drawing.Point(0, 148);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 74);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar e Fechar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemover.Image = global::Interface.Properties.Resources._17440_cart_ecommerce_remove_shopping_icon;
            this.btnRemover.Location = new System.Drawing.Point(0, 74);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(197, 74);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalvar.Image = global::Interface.Properties.Resources._17439_add_cart_ecommerce_shopping_icon;
            this.btnSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(197, 74);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar e Prosseguir";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // bdnVendas
            // 
            this.bdnVendas.AddNewItem = null;
            this.bdnVendas.CountItem = null;
            this.bdnVendas.DeleteItem = null;
            this.bdnVendas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnVendas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnVendas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.separator1,
            this.bindingNavigatorMovePreviousItem,
            this.separator2,
            this.bindingNavigatorMoveNextItem,
            this.separator3,
            this.bindingNavigatorMoveLastItem});
            this.bdnVendas.Location = new System.Drawing.Point(0, 555);
            this.bdnVendas.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnVendas.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnVendas.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnVendas.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnVendas.Name = "bdnVendas";
            this.bdnVendas.PositionItem = null;
            this.bdnVendas.Size = new System.Drawing.Size(197, 27);
            this.bdnVendas.TabIndex = 7;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bntFin
            // 
            this.bntFin.BackColor = System.Drawing.Color.LimeGreen;
            this.bntFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntFin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntFin.Location = new System.Drawing.Point(454, 476);
            this.bntFin.Margin = new System.Windows.Forms.Padding(4);
            this.bntFin.Name = "bntFin";
            this.bntFin.Size = new System.Drawing.Size(314, 49);
            this.bntFin.TabIndex = 112;
            this.bntFin.Text = "Finalizar";
            this.bntFin.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(16, 476);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(314, 49);
            this.btnCancel.TabIndex = 111;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightYellow;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ltCupomFiscal);
            this.panel2.Location = new System.Drawing.Point(786, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 687);
            this.panel2.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(133, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "CUPOM FISCAL";
            // 
            // ltCupomFiscal
            // 
            this.ltCupomFiscal.BackColor = System.Drawing.Color.LightYellow;
            this.ltCupomFiscal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltCupomFiscal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltCupomFiscal.FormattingEnabled = true;
            this.ltCupomFiscal.ItemHeight = 19;
            this.ltCupomFiscal.Items.AddRange(new object[] {
            "ITEM  CÓDIGO  DESCRIÇÃO  QTD.UN.VL  UNIT( R$)  ST  VL  ITEM( R$)",
            "---------------------------------------------------------------------------------" +
                "----------------------------------------"});
            this.ltCupomFiscal.Location = new System.Drawing.Point(4, 105);
            this.ltCupomFiscal.Margin = new System.Windows.Forms.Padding(4);
            this.ltCupomFiscal.Name = "ltCupomFiscal";
            this.ltCupomFiscal.Size = new System.Drawing.Size(481, 532);
            this.ltCupomFiscal.TabIndex = 2;
            // 
            // chkAcrescimo
            // 
            this.chkAcrescimo.AutoSize = true;
            this.chkAcrescimo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAcrescimo.Location = new System.Drawing.Point(16, 231);
            this.chkAcrescimo.Margin = new System.Windows.Forms.Padding(4);
            this.chkAcrescimo.Name = "chkAcrescimo";
            this.chkAcrescimo.Size = new System.Drawing.Size(115, 23);
            this.chkAcrescimo.TabIndex = 109;
            this.chkAcrescimo.Text = "Acréscimo(%):";
            this.chkAcrescimo.UseVisualStyleBackColor = true;
            // 
            // chkDesconto
            // 
            this.chkDesconto.AutoSize = true;
            this.chkDesconto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesconto.Location = new System.Drawing.Point(16, 275);
            this.chkDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.chkDesconto.Name = "chkDesconto";
            this.chkDesconto.Size = new System.Drawing.Size(119, 23);
            this.chkDesconto.TabIndex = 108;
            this.chkDesconto.Text = "Desconto  (%):";
            this.chkDesconto.UseVisualStyleBackColor = true;
            // 
            // cboPagamento
            // 
            this.cboPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPagamento.FormattingEnabled = true;
            this.cboPagamento.Items.AddRange(new object[] {
            "Dinheiro"});
            this.cboPagamento.Location = new System.Drawing.Point(180, 178);
            this.cboPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.cboPagamento.Name = "cboPagamento";
            this.cboPagamento.Size = new System.Drawing.Size(460, 29);
            this.cboPagamento.TabIndex = 95;
            // 
            // txtTroco
            // 
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(180, 399);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(460, 29);
            this.txtTroco.TabIndex = 105;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcrescimo.Enabled = false;
            this.txtAcrescimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcrescimo.Location = new System.Drawing.Point(180, 225);
            this.txtAcrescimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(460, 29);
            this.txtAcrescimo.TabIndex = 96;
            this.txtAcrescimo.Text = "0";
            this.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(180, 269);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(460, 29);
            this.txtDesconto.TabIndex = 97;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 409);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 100;
            this.label6.Text = "Troco:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Honeydew;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotal.Location = new System.Drawing.Point(180, 313);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(460, 29);
            this.txtTotal.TabIndex = 106;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtSubTotal.Location = new System.Drawing.Point(180, 128);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(460, 29);
            this.txtSubTotal.TabIndex = 107;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 367);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 101;
            this.label8.Text = "Valor pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 323);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 102;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 19);
            this.label10.TabIndex = 103;
            this.label10.Text = "Forma de pagamento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 104;
            this.label11.Text = "SubTotal:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(180, 357);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(460, 29);
            this.txtValorPago.TabIndex = 98;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 97);
            this.panel3.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(225, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(306, 54);
            this.label12.TabIndex = 0;
            this.label12.Text = "Finalizar venda";
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 732);
            this.Controls.Add(this.tbcVendas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendas";
            this.Text = "Gerenciador de Vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcVendas.ResumeLayout(false);
            this.tbpVendas.ResumeLayout(false);
            this.tbpVendas.PerformLayout();
            this.tbpFinVenda.ResumeLayout(false);
            this.tbpFinVenda.PerformLayout();
            this.gbItemEmDestaque.ResumeLayout(false);
            this.gbItemEmDestaque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDetalhesVendas.ResumeLayout(false);
            this.gbDetalhesVendas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnVendas)).EndInit();
            this.bdnVendas.ResumeLayout(false);
            this.bdnVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVendas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabControl tbcVendas;
        private System.Windows.Forms.TabPage tbpVendas;
        private System.Windows.Forms.TabPage tbpFinVenda;
        private System.Windows.Forms.GroupBox gbItemEmDestaque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbDetalhesVendas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblUsuário;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDigitar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lblValorSubtotal;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_BARRAS_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_CUSTO;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.BindingNavigator bdnVendas;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource bdsVendas;
        private System.Windows.Forms.Button bntFin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ltCupomFiscal;
        private System.Windows.Forms.CheckBox chkAcrescimo;
        private System.Windows.Forms.CheckBox chkDesconto;
        private System.Windows.Forms.ComboBox cboPagamento;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
    }
}