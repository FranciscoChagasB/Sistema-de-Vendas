namespace Interface
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bdnProdutos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.bdsProdutos = new System.Windows.Forms.BindingSource(this.components);
            this.tbcClientes = new System.Windows.Forms.TabControl();
            this.tbpProcura = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOBARRAS_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_UNIDADE_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_MINIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_ATUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARGEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANOTACOES_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SITUACAO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.gbPrecos = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMargemLucro = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.gbEstoque = new System.Windows.Forms.GroupBox();
            this.cboUnidadeProduto = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnotacao = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpCategoria = new System.Windows.Forms.TabPage();
            this.gpbCategorias = new System.Windows.Forms.GroupBox();
            this.btnFormCategorias = new System.Windows.Forms.Button();
            this.dtgCategoriaProdutos = new System.Windows.Forms.DataGridView();
            this.ID_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisaCategoria = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbpUnidade = new System.Windows.Forms.TabPage();
            this.gpbUnidades = new System.Windows.Forms.GroupBox();
            this.btnFormUnidades = new System.Windows.Forms.Button();
            this.dtgUnidadeProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisaUnidade = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNomeUnidade = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnProdutos)).BeginInit();
            this.bdnProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProdutos)).BeginInit();
            this.tbcClientes.SuspendLayout();
            this.tbpProcura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.tbpCadastro.SuspendLayout();
            this.gbPrecos.SuspendLayout();
            this.gbEstoque.SuspendLayout();
            this.tbpCategoria.SuspendLayout();
            this.gpbCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoriaProdutos)).BeginInit();
            this.tbpUnidade.SuspendLayout();
            this.gpbUnidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidadeProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bdnProdutos);
            this.panel1.Controls.Add(this.btnAjuda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 732);
            this.panel1.TabIndex = 1;
            // 
            // bdnProdutos
            // 
            this.bdnProdutos.AddNewItem = null;
            this.bdnProdutos.CountItem = null;
            this.bdnProdutos.DeleteItem = null;
            this.bdnProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnProdutos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.separator1,
            this.bindingNavigatorMovePreviousItem,
            this.separator2,
            this.bindingNavigatorMoveNextItem,
            this.separator3,
            this.bindingNavigatorMoveLastItem});
            this.bdnProdutos.Location = new System.Drawing.Point(0, 555);
            this.bdnProdutos.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnProdutos.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnProdutos.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnProdutos.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnProdutos.Name = "bdnProdutos";
            this.bdnProdutos.PositionItem = null;
            this.bdnProdutos.Size = new System.Drawing.Size(197, 27);
            this.bdnProdutos.TabIndex = 5;
            this.bdnProdutos.Text = "bindingNavigator1";
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
            // btnAjuda
            // 
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjuda.Image = global::Interface.Properties.Resources.ajuda;
            this.btnAjuda.Location = new System.Drawing.Point(0, 582);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(197, 74);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.Image = global::Interface.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(0, 148);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 74);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlterar.Image = global::Interface.Properties.Resources.editar;
            this.btnAlterar.Location = new System.Drawing.Point(0, 74);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(197, 74);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar Produto";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.Image = global::Interface.Properties.Resources.adicionar;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(197, 74);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo Produto";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tbcClientes
            // 
            this.tbcClientes.Controls.Add(this.tbpProcura);
            this.tbcClientes.Controls.Add(this.tbpCadastro);
            this.tbcClientes.Controls.Add(this.tbpCategoria);
            this.tbcClientes.Controls.Add(this.tbpUnidade);
            this.tbcClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcClientes.Location = new System.Drawing.Point(199, 0);
            this.tbcClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tbcClientes.Name = "tbcClientes";
            this.tbcClientes.SelectedIndex = 0;
            this.tbcClientes.Size = new System.Drawing.Size(1288, 732);
            this.tbcClientes.TabIndex = 2;
            // 
            // tbpProcura
            // 
            this.tbpProcura.Controls.Add(this.label21);
            this.tbpProcura.Controls.Add(this.cboFiltro);
            this.tbpProcura.Controls.Add(this.cboOrdenar);
            this.tbpProcura.Controls.Add(this.txtNomeProduto);
            this.tbpProcura.Controls.Add(this.btnPesquisar);
            this.tbpProcura.Controls.Add(this.label19);
            this.tbpProcura.Controls.Add(this.label18);
            this.tbpProcura.Controls.Add(this.label7);
            this.tbpProcura.Controls.Add(this.dtgProdutos);
            this.tbpProcura.Location = new System.Drawing.Point(4, 25);
            this.tbpProcura.Margin = new System.Windows.Forms.Padding(4);
            this.tbpProcura.Name = "tbpProcura";
            this.tbpProcura.Padding = new System.Windows.Forms.Padding(4);
            this.tbpProcura.Size = new System.Drawing.Size(1280, 703);
            this.tbpProcura.TabIndex = 0;
            this.tbpProcura.Text = "Procura";
            this.tbpProcura.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 16);
            this.label21.TabIndex = 200;
            this.label21.Text = "Filtrar por:";
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "",
            "Ativos",
            "Inativos"});
            this.cboFiltro.Location = new System.Drawing.Point(13, 105);
            this.cboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(223, 28);
            this.cboFiltro.TabIndex = 199;
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Items.AddRange(new object[] {
            "",
            "Código",
            "Nome",
            "Situação"});
            this.cboOrdenar.Location = new System.Drawing.Point(814, 52);
            this.cboOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(184, 28);
            this.cboOrdenar.TabIndex = 198;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(13, 52);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProduto.MaxLength = 50;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(611, 29);
            this.txtNomeProduto.TabIndex = 196;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(632, 52);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 195;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(811, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 194;
            this.label19.Text = "Ordenar por:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 32);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 16);
            this.label18.TabIndex = 193;
            this.label18.Text = "Nome do Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 191;
            this.label7.Text = "Procura:";
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.AllowUserToAddRows = false;
            this.dtgProdutos.AllowUserToDeleteRows = false;
            this.dtgProdutos.AllowUserToResizeColumns = false;
            this.dtgProdutos.AllowUserToResizeRows = false;
            this.dtgProdutos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUTO,
            this.CODIGOBARRAS_PRODUTO,
            this.NOME_PRODUTO,
            this.DESCRICAO_PRODUTO,
            this.ID_UNIDADE,
            this.NOME_UNIDADE_PRODUTOS,
            this.ID_CATEGORIA,
            this.ESTOQUE_MINIMO,
            this.ESTOQUE_ATUAL,
            this.VALOR_COMPRA,
            this.VALOR_VENDA,
            this.MARGEM,
            this.ANOTACOES_PRODUTO,
            this.SITUACAO_PRODUTO,
            this.DATA_CADASTRO_PRODUTO});
            this.dtgProdutos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgProdutos.Location = new System.Drawing.Point(8, 223);
            this.dtgProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.ReadOnly = true;
            this.dtgProdutos.RowHeadersWidth = 51;
            this.dtgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdutos.Size = new System.Drawing.Size(1253, 470);
            this.dtgProdutos.TabIndex = 125;
            this.dtgProdutos.TabStop = false;
            this.dtgProdutos.Tag = "";
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.DataPropertyName = "ID_PRODUTO";
            this.ID_PRODUTO.HeaderText = "Código";
            this.ID_PRODUTO.MinimumWidth = 6;
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            this.ID_PRODUTO.ReadOnly = true;
            this.ID_PRODUTO.Width = 70;
            // 
            // CODIGOBARRAS_PRODUTO
            // 
            this.CODIGOBARRAS_PRODUTO.DataPropertyName = "CODIGOBARRAS_PRODUTO";
            this.CODIGOBARRAS_PRODUTO.HeaderText = "Código de Barras";
            this.CODIGOBARRAS_PRODUTO.MinimumWidth = 6;
            this.CODIGOBARRAS_PRODUTO.Name = "CODIGOBARRAS_PRODUTO";
            this.CODIGOBARRAS_PRODUTO.ReadOnly = true;
            this.CODIGOBARRAS_PRODUTO.Width = 250;
            // 
            // NOME_PRODUTO
            // 
            this.NOME_PRODUTO.DataPropertyName = "NOME_PRODUTO";
            this.NOME_PRODUTO.HeaderText = "Nome";
            this.NOME_PRODUTO.MinimumWidth = 6;
            this.NOME_PRODUTO.Name = "NOME_PRODUTO";
            this.NOME_PRODUTO.ReadOnly = true;
            this.NOME_PRODUTO.Width = 230;
            // 
            // DESCRICAO_PRODUTO
            // 
            this.DESCRICAO_PRODUTO.DataPropertyName = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.HeaderText = "Descrição";
            this.DESCRICAO_PRODUTO.MinimumWidth = 6;
            this.DESCRICAO_PRODUTO.Name = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.ReadOnly = true;
            this.DESCRICAO_PRODUTO.Width = 125;
            // 
            // ID_UNIDADE
            // 
            this.ID_UNIDADE.DataPropertyName = "ID_UNIDADE";
            this.ID_UNIDADE.HeaderText = "CodUnidade";
            this.ID_UNIDADE.MinimumWidth = 6;
            this.ID_UNIDADE.Name = "ID_UNIDADE";
            this.ID_UNIDADE.ReadOnly = true;
            this.ID_UNIDADE.Visible = false;
            this.ID_UNIDADE.Width = 125;
            // 
            // NOME_UNIDADE_PRODUTOS
            // 
            this.NOME_UNIDADE_PRODUTOS.DataPropertyName = "NOME_UNIDADE_PRODUTOS";
            this.NOME_UNIDADE_PRODUTOS.HeaderText = "Unidade";
            this.NOME_UNIDADE_PRODUTOS.MinimumWidth = 6;
            this.NOME_UNIDADE_PRODUTOS.Name = "NOME_UNIDADE_PRODUTOS";
            this.NOME_UNIDADE_PRODUTOS.ReadOnly = true;
            this.NOME_UNIDADE_PRODUTOS.Width = 130;
            // 
            // ID_CATEGORIA
            // 
            this.ID_CATEGORIA.DataPropertyName = "ID_CATEGORIA";
            this.ID_CATEGORIA.HeaderText = "Categoria";
            this.ID_CATEGORIA.MinimumWidth = 6;
            this.ID_CATEGORIA.Name = "ID_CATEGORIA";
            this.ID_CATEGORIA.ReadOnly = true;
            this.ID_CATEGORIA.Visible = false;
            this.ID_CATEGORIA.Width = 125;
            // 
            // ESTOQUE_MINIMO
            // 
            this.ESTOQUE_MINIMO.DataPropertyName = "ESTOQUE_MINIMO";
            this.ESTOQUE_MINIMO.HeaderText = "Estoque Mínimo";
            this.ESTOQUE_MINIMO.MinimumWidth = 6;
            this.ESTOQUE_MINIMO.Name = "ESTOQUE_MINIMO";
            this.ESTOQUE_MINIMO.ReadOnly = true;
            this.ESTOQUE_MINIMO.Visible = false;
            this.ESTOQUE_MINIMO.Width = 125;
            // 
            // ESTOQUE_ATUAL
            // 
            this.ESTOQUE_ATUAL.DataPropertyName = "ESTOQUE_ATUAL";
            this.ESTOQUE_ATUAL.HeaderText = "Quantidade";
            this.ESTOQUE_ATUAL.MinimumWidth = 6;
            this.ESTOQUE_ATUAL.Name = "ESTOQUE_ATUAL";
            this.ESTOQUE_ATUAL.ReadOnly = true;
            this.ESTOQUE_ATUAL.Width = 125;
            // 
            // VALOR_COMPRA
            // 
            this.VALOR_COMPRA.DataPropertyName = "VALOR_COMPRA";
            this.VALOR_COMPRA.HeaderText = "Valor";
            this.VALOR_COMPRA.MinimumWidth = 6;
            this.VALOR_COMPRA.Name = "VALOR_COMPRA";
            this.VALOR_COMPRA.ReadOnly = true;
            this.VALOR_COMPRA.Visible = false;
            this.VALOR_COMPRA.Width = 125;
            // 
            // VALOR_VENDA
            // 
            this.VALOR_VENDA.DataPropertyName = "VALOR_VENDA";
            this.VALOR_VENDA.HeaderText = "Valor Venda";
            this.VALOR_VENDA.MinimumWidth = 6;
            this.VALOR_VENDA.Name = "VALOR_VENDA";
            this.VALOR_VENDA.ReadOnly = true;
            this.VALOR_VENDA.Visible = false;
            this.VALOR_VENDA.Width = 125;
            // 
            // MARGEM
            // 
            this.MARGEM.DataPropertyName = "MARGEM";
            this.MARGEM.HeaderText = "Margem";
            this.MARGEM.MinimumWidth = 6;
            this.MARGEM.Name = "MARGEM";
            this.MARGEM.ReadOnly = true;
            this.MARGEM.Visible = false;
            this.MARGEM.Width = 125;
            // 
            // ANOTACOES_PRODUTO
            // 
            this.ANOTACOES_PRODUTO.DataPropertyName = "ANOTACOES_PRODUTO";
            this.ANOTACOES_PRODUTO.HeaderText = "Anotações";
            this.ANOTACOES_PRODUTO.MinimumWidth = 6;
            this.ANOTACOES_PRODUTO.Name = "ANOTACOES_PRODUTO";
            this.ANOTACOES_PRODUTO.ReadOnly = true;
            this.ANOTACOES_PRODUTO.Visible = false;
            this.ANOTACOES_PRODUTO.Width = 125;
            // 
            // SITUACAO_PRODUTO
            // 
            this.SITUACAO_PRODUTO.DataPropertyName = "SITUACAO_PRODUTO";
            this.SITUACAO_PRODUTO.HeaderText = "Situação";
            this.SITUACAO_PRODUTO.MinimumWidth = 6;
            this.SITUACAO_PRODUTO.Name = "SITUACAO_PRODUTO";
            this.SITUACAO_PRODUTO.ReadOnly = true;
            this.SITUACAO_PRODUTO.Width = 125;
            // 
            // DATA_CADASTRO_PRODUTO
            // 
            this.DATA_CADASTRO_PRODUTO.DataPropertyName = "DATA_CADASTRO_PRODUTO";
            this.DATA_CADASTRO_PRODUTO.HeaderText = "Cadastro";
            this.DATA_CADASTRO_PRODUTO.MinimumWidth = 6;
            this.DATA_CADASTRO_PRODUTO.Name = "DATA_CADASTRO_PRODUTO";
            this.DATA_CADASTRO_PRODUTO.ReadOnly = true;
            this.DATA_CADASTRO_PRODUTO.Width = 125;
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.gbPrecos);
            this.tbpCadastro.Controls.Add(this.gbEstoque);
            this.tbpCadastro.Controls.Add(this.cboCategoria);
            this.tbpCadastro.Controls.Add(this.label11);
            this.tbpCadastro.Controls.Add(this.cbAtivo);
            this.tbpCadastro.Controls.Add(this.btnSalvar);
            this.tbpCadastro.Controls.Add(this.btnLimpar);
            this.tbpCadastro.Controls.Add(this.label20);
            this.tbpCadastro.Controls.Add(this.label1);
            this.tbpCadastro.Controls.Add(this.label12);
            this.tbpCadastro.Controls.Add(this.dtpDataCadastro);
            this.tbpCadastro.Controls.Add(this.label6);
            this.tbpCadastro.Controls.Add(this.label3);
            this.tbpCadastro.Controls.Add(this.label10);
            this.tbpCadastro.Controls.Add(this.txtRegistro);
            this.tbpCadastro.Controls.Add(this.txtDescricao);
            this.tbpCadastro.Controls.Add(this.txtNome);
            this.tbpCadastro.Controls.Add(this.txtAnotacao);
            this.tbpCadastro.Controls.Add(this.txtCodigoBarras);
            this.tbpCadastro.Controls.Add(this.label2);
            this.tbpCadastro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCadastro.Location = new System.Drawing.Point(4, 25);
            this.tbpCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.tbpCadastro.Size = new System.Drawing.Size(1280, 703);
            this.tbpCadastro.TabIndex = 1;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // gbPrecos
            // 
            this.gbPrecos.Controls.Add(this.label8);
            this.gbPrecos.Controls.Add(this.label9);
            this.gbPrecos.Controls.Add(this.txtCusto);
            this.gbPrecos.Controls.Add(this.label13);
            this.gbPrecos.Controls.Add(this.txtMargemLucro);
            this.gbPrecos.Controls.Add(this.txtVenda);
            this.gbPrecos.Location = new System.Drawing.Point(12, 278);
            this.gbPrecos.Name = "gbPrecos";
            this.gbPrecos.Size = new System.Drawing.Size(893, 100);
            this.gbPrecos.TabIndex = 240;
            this.gbPrecos.TabStop = false;
            this.gbPrecos.Text = "Preços";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(564, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Venda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Custo:";
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.SystemColors.Window;
            this.txtCusto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCusto.Location = new System.Drawing.Point(11, 45);
            this.txtCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(183, 29);
            this.txtCusto.TabIndex = 16;
            this.txtCusto.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label13.Location = new System.Drawing.Point(276, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Margem de Lucro (%):";
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.BackColor = System.Drawing.SystemColors.Window;
            this.txtMargemLucro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMargemLucro.Location = new System.Drawing.Point(280, 45);
            this.txtMargemLucro.Margin = new System.Windows.Forms.Padding(4);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(183, 29);
            this.txtMargemLucro.TabIndex = 17;
            this.txtMargemLucro.Text = "0";
            // 
            // txtVenda
            // 
            this.txtVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtVenda.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtVenda.Location = new System.Drawing.Point(568, 45);
            this.txtVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(183, 29);
            this.txtVenda.TabIndex = 18;
            this.txtVenda.Text = "0";
            // 
            // gbEstoque
            // 
            this.gbEstoque.Controls.Add(this.cboUnidadeProduto);
            this.gbEstoque.Controls.Add(this.label14);
            this.gbEstoque.Controls.Add(this.txtEstoqueAtual);
            this.gbEstoque.Controls.Add(this.label5);
            this.gbEstoque.Controls.Add(this.txtEstoqueMinimo);
            this.gbEstoque.Controls.Add(this.label4);
            this.gbEstoque.Location = new System.Drawing.Point(12, 188);
            this.gbEstoque.Name = "gbEstoque";
            this.gbEstoque.Size = new System.Drawing.Size(893, 84);
            this.gbEstoque.TabIndex = 239;
            this.gbEstoque.TabStop = false;
            this.gbEstoque.Text = "Estoque";
            // 
            // cboUnidadeProduto
            // 
            this.cboUnidadeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadeProduto.FormattingEnabled = true;
            this.cboUnidadeProduto.ItemHeight = 18;
            this.cboUnidadeProduto.Location = new System.Drawing.Point(568, 45);
            this.cboUnidadeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.cboUnidadeProduto.Name = "cboUnidadeProduto";
            this.cboUnidadeProduto.Size = new System.Drawing.Size(241, 26);
            this.cboUnidadeProduto.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label14.Location = new System.Drawing.Point(564, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Unidade do Produto:";
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstoqueAtual.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEstoqueAtual.Location = new System.Drawing.Point(11, 43);
            this.txtEstoqueAtual.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(152, 29);
            this.txtEstoqueAtual.TabIndex = 11;
            this.txtEstoqueAtual.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estoque Atual:";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstoqueMinimo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(280, 43);
            this.txtEstoqueMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(152, 29);
            this.txtEstoqueMinimo.TabIndex = 12;
            this.txtEstoqueMinimo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(276, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estoque Mínimo:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(870, 88);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(241, 26);
            this.cboCategoria.TabIndex = 237;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(867, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 238;
            this.label11.Text = "Categoria:";
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtivo.Location = new System.Drawing.Point(742, 90);
            this.cbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(62, 22);
            this.cbAtivo.TabIndex = 236;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(985, 309);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(213, 43);
            this.btnSalvar.TabIndex = 235;
            this.btnSalvar.Text = "Salvar Produto";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLimpar.Location = new System.Drawing.Point(985, 208);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(213, 43);
            this.btnLimpar.TabIndex = 190;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(739, 68);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 18);
            this.label20.TabIndex = 188;
            this.label20.Text = "Situação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 173;
            this.label1.Text = "Registro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(923, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 182;
            this.label12.Text = "Data Cadastro:";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCadastro.Location = new System.Drawing.Point(927, 23);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(187, 29);
            this.dtpDataCadastro.TabIndex = 181;
            this.dtpDataCadastro.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(8, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 179;
            this.label6.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 176;
            this.label3.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(8, 378);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 175;
            this.label10.Text = "Anotações:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(12, 23);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(118, 29);
            this.txtRegistro.TabIndex = 180;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.Text = "0";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 151);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1249, 29);
            this.txtDescricao.TabIndex = 166;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 87);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(654, 29);
            this.txtNome.TabIndex = 163;
            // 
            // txtAnotacao
            // 
            this.txtAnotacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnotacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnotacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnotacao.Location = new System.Drawing.Point(12, 401);
            this.txtAnotacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnotacao.MaxLength = 50;
            this.txtAnotacao.Multiline = true;
            this.txtAnotacao.Name = "txtAnotacao";
            this.txtAnotacao.Size = new System.Drawing.Size(1249, 289);
            this.txtAnotacao.TabIndex = 170;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(165, 23);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarras.MaxLength = 50;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(710, 29);
            this.txtCodigoBarras.TabIndex = 162;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(161, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 174;
            this.label2.Text = "Código de Barras:";
            // 
            // tbpCategoria
            // 
            this.tbpCategoria.Controls.Add(this.gpbCategorias);
            this.tbpCategoria.Controls.Add(this.dtgCategoriaProdutos);
            this.tbpCategoria.Controls.Add(this.btnPesquisaCategoria);
            this.tbpCategoria.Controls.Add(this.label15);
            this.tbpCategoria.Controls.Add(this.txtNomeCategoria);
            this.tbpCategoria.Controls.Add(this.label16);
            this.tbpCategoria.Location = new System.Drawing.Point(4, 25);
            this.tbpCategoria.Name = "tbpCategoria";
            this.tbpCategoria.Size = new System.Drawing.Size(1280, 703);
            this.tbpCategoria.TabIndex = 2;
            this.tbpCategoria.Text = "Categoria";
            this.tbpCategoria.UseVisualStyleBackColor = true;
            // 
            // gpbCategorias
            // 
            this.gpbCategorias.Controls.Add(this.btnFormCategorias);
            this.gpbCategorias.Location = new System.Drawing.Point(874, 37);
            this.gpbCategorias.Name = "gpbCategorias";
            this.gpbCategorias.Size = new System.Drawing.Size(261, 136);
            this.gpbCategorias.TabIndex = 222;
            this.gpbCategorias.TabStop = false;
            this.gpbCategorias.Text = "Gerenciador de Categorias";
            // 
            // btnFormCategorias
            // 
            this.btnFormCategorias.Image = global::Interface.Properties.Resources.niveis_img;
            this.btnFormCategorias.Location = new System.Drawing.Point(21, 33);
            this.btnFormCategorias.Name = "btnFormCategorias";
            this.btnFormCategorias.Size = new System.Drawing.Size(221, 81);
            this.btnFormCategorias.TabIndex = 0;
            this.btnFormCategorias.Text = "Abir Gerenciador";
            this.btnFormCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormCategorias.UseVisualStyleBackColor = true;
            this.btnFormCategorias.Click += new System.EventHandler(this.btnFormCategorias_Click);
            // 
            // dtgCategoriaProdutos
            // 
            this.dtgCategoriaProdutos.AllowUserToAddRows = false;
            this.dtgCategoriaProdutos.AllowUserToDeleteRows = false;
            this.dtgCategoriaProdutos.AllowUserToResizeColumns = false;
            this.dtgCategoriaProdutos.AllowUserToResizeRows = false;
            this.dtgCategoriaProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtgCategoriaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoriaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CATEGORIA_PRODUTOS,
            this.NOME_CATEGORIA_PRODUTOS,
            this.DESCRICAO_CATEGORIA_PRODUTOS});
            this.dtgCategoriaProdutos.Location = new System.Drawing.Point(7, 83);
            this.dtgCategoriaProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgCategoriaProdutos.Name = "dtgCategoriaProdutos";
            this.dtgCategoriaProdutos.ReadOnly = true;
            this.dtgCategoriaProdutos.RowHeadersWidth = 51;
            this.dtgCategoriaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategoriaProdutos.Size = new System.Drawing.Size(833, 445);
            this.dtgCategoriaProdutos.TabIndex = 221;
            // 
            // ID_CATEGORIA_PRODUTOS
            // 
            this.ID_CATEGORIA_PRODUTOS.DataPropertyName = "ID_CATEGORIA_PRODUTOS";
            this.ID_CATEGORIA_PRODUTOS.HeaderText = "Código";
            this.ID_CATEGORIA_PRODUTOS.MinimumWidth = 6;
            this.ID_CATEGORIA_PRODUTOS.Name = "ID_CATEGORIA_PRODUTOS";
            this.ID_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.ID_CATEGORIA_PRODUTOS.Width = 80;
            // 
            // NOME_CATEGORIA_PRODUTOS
            // 
            this.NOME_CATEGORIA_PRODUTOS.DataPropertyName = "NOME_CATEGORIA_PRODUTOS";
            this.NOME_CATEGORIA_PRODUTOS.HeaderText = "Nome";
            this.NOME_CATEGORIA_PRODUTOS.MinimumWidth = 6;
            this.NOME_CATEGORIA_PRODUTOS.Name = "NOME_CATEGORIA_PRODUTOS";
            this.NOME_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.NOME_CATEGORIA_PRODUTOS.Width = 225;
            // 
            // DESCRICAO_CATEGORIA_PRODUTOS
            // 
            this.DESCRICAO_CATEGORIA_PRODUTOS.DataPropertyName = "DESCRICAO_CATEGORIA_PRODUTOS";
            this.DESCRICAO_CATEGORIA_PRODUTOS.HeaderText = "Descrição";
            this.DESCRICAO_CATEGORIA_PRODUTOS.MinimumWidth = 6;
            this.DESCRICAO_CATEGORIA_PRODUTOS.Name = "DESCRICAO_CATEGORIA_PRODUTOS";
            this.DESCRICAO_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.DESCRICAO_CATEGORIA_PRODUTOS.Width = 475;
            // 
            // btnPesquisaCategoria
            // 
            this.btnPesquisaCategoria.Location = new System.Drawing.Point(524, 46);
            this.btnPesquisaCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaCategoria.Name = "btnPesquisaCategoria";
            this.btnPesquisaCategoria.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisaCategoria.TabIndex = 220;
            this.btnPesquisaCategoria.Text = "Pesquisar";
            this.btnPesquisaCategoria.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 5);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 16);
            this.label15.TabIndex = 219;
            this.label15.Text = "Procura:";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(6, 46);
            this.txtNomeCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCategoria.MaxLength = 50;
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(510, 29);
            this.txtNomeCategoria.TabIndex = 217;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 16);
            this.label16.TabIndex = 216;
            this.label16.Text = "Nome da Categoria:";
            // 
            // tbpUnidade
            // 
            this.tbpUnidade.Controls.Add(this.gpbUnidades);
            this.tbpUnidade.Controls.Add(this.dtgUnidadeProdutos);
            this.tbpUnidade.Controls.Add(this.btnPesquisaUnidade);
            this.tbpUnidade.Controls.Add(this.label17);
            this.tbpUnidade.Controls.Add(this.txtNomeUnidade);
            this.tbpUnidade.Controls.Add(this.label22);
            this.tbpUnidade.Location = new System.Drawing.Point(4, 25);
            this.tbpUnidade.Name = "tbpUnidade";
            this.tbpUnidade.Size = new System.Drawing.Size(1280, 703);
            this.tbpUnidade.TabIndex = 3;
            this.tbpUnidade.Text = "Unidades";
            this.tbpUnidade.UseVisualStyleBackColor = true;
            // 
            // gpbUnidades
            // 
            this.gpbUnidades.Controls.Add(this.btnFormUnidades);
            this.gpbUnidades.Location = new System.Drawing.Point(874, 37);
            this.gpbUnidades.Name = "gpbUnidades";
            this.gpbUnidades.Size = new System.Drawing.Size(261, 136);
            this.gpbUnidades.TabIndex = 228;
            this.gpbUnidades.TabStop = false;
            this.gpbUnidades.Text = "Gerenciador de Unidades";
            // 
            // btnFormUnidades
            // 
            this.btnFormUnidades.Image = global::Interface.Properties.Resources.niveis_img;
            this.btnFormUnidades.Location = new System.Drawing.Point(21, 33);
            this.btnFormUnidades.Name = "btnFormUnidades";
            this.btnFormUnidades.Size = new System.Drawing.Size(221, 81);
            this.btnFormUnidades.TabIndex = 0;
            this.btnFormUnidades.Text = "Abir Gerenciador";
            this.btnFormUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormUnidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormUnidades.UseVisualStyleBackColor = true;
            this.btnFormUnidades.Click += new System.EventHandler(this.btnFormUnidades_Click);
            // 
            // dtgUnidadeProdutos
            // 
            this.dtgUnidadeProdutos.AllowUserToAddRows = false;
            this.dtgUnidadeProdutos.AllowUserToDeleteRows = false;
            this.dtgUnidadeProdutos.AllowUserToResizeColumns = false;
            this.dtgUnidadeProdutos.AllowUserToResizeRows = false;
            this.dtgUnidadeProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtgUnidadeProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUnidadeProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dtgUnidadeProdutos.Location = new System.Drawing.Point(7, 83);
            this.dtgUnidadeProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgUnidadeProdutos.Name = "dtgUnidadeProdutos";
            this.dtgUnidadeProdutos.ReadOnly = true;
            this.dtgUnidadeProdutos.RowHeadersWidth = 51;
            this.dtgUnidadeProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUnidadeProdutos.Size = new System.Drawing.Size(833, 445);
            this.dtgUnidadeProdutos.TabIndex = 227;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_UNIDADE_PRODUTOS";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_UNIDADE_PRODUTOS";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 225;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DESCRICAO_UNIDADE_PRODUTOS";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 475;
            // 
            // btnPesquisaUnidade
            // 
            this.btnPesquisaUnidade.Location = new System.Drawing.Point(524, 46);
            this.btnPesquisaUnidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaUnidade.Name = "btnPesquisaUnidade";
            this.btnPesquisaUnidade.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisaUnidade.TabIndex = 226;
            this.btnPesquisaUnidade.Text = "Pesquisar";
            this.btnPesquisaUnidade.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 5);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 16);
            this.label17.TabIndex = 225;
            this.label17.Text = "Procura:";
            // 
            // txtNomeUnidade
            // 
            this.txtNomeUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUnidade.Location = new System.Drawing.Point(6, 46);
            this.txtNomeUnidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUnidade.MaxLength = 50;
            this.txtNomeUnidade.Name = "txtNomeUnidade";
            this.txtNomeUnidade.Size = new System.Drawing.Size(510, 29);
            this.txtNomeUnidade.TabIndex = 224;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 26);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 16);
            this.label22.TabIndex = 223;
            this.label22.Text = "Nome da Unidade:";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 732);
            this.Controls.Add(this.tbcClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnProdutos)).EndInit();
            this.bdnProdutos.ResumeLayout(false);
            this.bdnProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsProdutos)).EndInit();
            this.tbcClientes.ResumeLayout(false);
            this.tbpProcura.ResumeLayout(false);
            this.tbpProcura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.gbPrecos.ResumeLayout(false);
            this.gbPrecos.PerformLayout();
            this.gbEstoque.ResumeLayout(false);
            this.gbEstoque.PerformLayout();
            this.tbpCategoria.ResumeLayout(false);
            this.tbpCategoria.PerformLayout();
            this.gpbCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoriaProdutos)).EndInit();
            this.tbpUnidade.ResumeLayout(false);
            this.tbpUnidade.PerformLayout();
            this.gpbUnidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidadeProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bdnProdutos;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.BindingSource bdsProdutos;
        private System.Windows.Forms.TabControl tbcClientes;
        private System.Windows.Forms.TabPage tbpProcura;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.GroupBox gbPrecos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMargemLucro;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.GroupBox gbEstoque;
        private System.Windows.Forms.ComboBox cboUnidadeProduto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAnotacao;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpCategoria;
        private System.Windows.Forms.GroupBox gpbCategorias;
        private System.Windows.Forms.Button btnFormCategorias;
        private System.Windows.Forms.DataGridView dtgCategoriaProdutos;
        private System.Windows.Forms.Button btnPesquisaCategoria;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CATEGORIA_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CATEGORIA_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_CATEGORIA_PRODUTOS;
        private System.Windows.Forms.TabPage tbpUnidade;
        private System.Windows.Forms.GroupBox gpbUnidades;
        private System.Windows.Forms.Button btnFormUnidades;
        private System.Windows.Forms.DataGridView dtgUnidadeProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnPesquisaUnidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNomeUnidade;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOBARRAS_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_UNIDADE_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_MINIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_ATUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARGEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANOTACOES_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SITUACAO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO_PRODUTO;
    }
}