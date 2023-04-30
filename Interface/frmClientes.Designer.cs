namespace Interface
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bdnClientes = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tbcClientes = new System.Windows.Forms.TabControl();
            this.tbpProcura = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NASCIMENTO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACOES_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.gbDocumentosPessoaFisica = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbDocumentosPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.gbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnClientes)).BeginInit();
            this.bdnClientes.SuspendLayout();
            this.tbcClientes.SuspendLayout();
            this.tbpProcura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.tbpCadastro.SuspendLayout();
            this.gbDocumentosPessoaFisica.SuspendLayout();
            this.gbDocumentosPessoaJuridica.SuspendLayout();
            this.gbTipoPessoa.SuspendLayout();
            this.gbContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bdnClientes);
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
            this.panel1.TabIndex = 0;
            // 
            // bdnClientes
            // 
            this.bdnClientes.AddNewItem = null;
            this.bdnClientes.BindingSource = this.bdsClientes;
            this.bdnClientes.CountItem = null;
            this.bdnClientes.DeleteItem = null;
            this.bdnClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnClientes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bdnClientes.Location = new System.Drawing.Point(0, 555);
            this.bdnClientes.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnClientes.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnClientes.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnClientes.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnClientes.Name = "bdnClientes";
            this.bdnClientes.PositionItem = null;
            this.bdnClientes.Size = new System.Drawing.Size(197, 27);
            this.bdnClientes.TabIndex = 5;
            this.bdnClientes.Tag = "";
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
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            this.btnExcluir.Text = "Excluir Cliente";
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
            this.btnAlterar.Text = "Alterar Cliente";
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
            this.btnNovo.Text = "Novo Cliente";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tbcClientes
            // 
            this.tbcClientes.Controls.Add(this.tbpProcura);
            this.tbcClientes.Controls.Add(this.tbpCadastro);
            this.tbcClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcClientes.Location = new System.Drawing.Point(199, 0);
            this.tbcClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tbcClientes.Name = "tbcClientes";
            this.tbcClientes.SelectedIndex = 0;
            this.tbcClientes.Size = new System.Drawing.Size(1288, 732);
            this.tbcClientes.TabIndex = 1;
            // 
            // tbpProcura
            // 
            this.tbpProcura.Controls.Add(this.label21);
            this.tbpProcura.Controls.Add(this.cboFiltro);
            this.tbpProcura.Controls.Add(this.cboOrdenar);
            this.tbpProcura.Controls.Add(this.txtCodCliente);
            this.tbpProcura.Controls.Add(this.txtNomeCliente);
            this.tbpProcura.Controls.Add(this.btnPesquisar);
            this.tbpProcura.Controls.Add(this.label19);
            this.tbpProcura.Controls.Add(this.label18);
            this.tbpProcura.Controls.Add(this.label16);
            this.tbpProcura.Controls.Add(this.label7);
            this.tbpProcura.Controls.Add(this.dtgClientes);
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
            "Cadastrados com CPF",
            "Cadastrados com CNPJ",
            "Ativos",
            "Inativos"});
            this.cboFiltro.Location = new System.Drawing.Point(13, 105);
            this.cboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(143, 28);
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
            this.cboOrdenar.Location = new System.Drawing.Point(855, 52);
            this.cboOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(143, 28);
            this.cboOrdenar.TabIndex = 198;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(13, 52);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCliente.MaxLength = 50;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(119, 29);
            this.txtCodCliente.TabIndex = 197;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(167, 52);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(510, 29);
            this.txtNomeCliente.TabIndex = 196;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(685, 52);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 195;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(851, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 194;
            this.label19.Text = "Ordenar por:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(163, 32);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 16);
            this.label18.TabIndex = 193;
            this.label18.Text = "Nome do Cliente:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 16);
            this.label16.TabIndex = 192;
            this.label16.Text = "Código do Cliente:";
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
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeColumns = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.NOME_CLIENTE,
            this.ENDERECO_CLIENTE,
            this.BAIRRO_CLIENTE,
            this.CEP_CLIENTE,
            this.CIDADE_CLIENTE,
            this.ESTADO_CLIENTE,
            this.TELEFONE_CLIENTE,
            this.EMAIL_CLIENTE,
            this.DATA_CADASTRO_CLIENTE,
            this.NASCIMENTO_CLIENTE,
            this.OBSERVACOES_CLIENTE,
            this.STATUS_CLIENTE});
            this.dtgClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgClientes.Location = new System.Drawing.Point(8, 223);
            this.dtgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.RowHeadersWidth = 51;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(1253, 470);
            this.dtgClientes.TabIndex = 125;
            this.dtgClientes.TabStop = false;
            this.dtgClientes.Tag = "";
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "Código";
            this.ID_CLIENTE.MinimumWidth = 6;
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Width = 70;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "Nome";
            this.NOME_CLIENTE.MinimumWidth = 6;
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.ReadOnly = true;
            this.NOME_CLIENTE.Width = 250;
            // 
            // ENDERECO_CLIENTE
            // 
            this.ENDERECO_CLIENTE.DataPropertyName = "ENDERECO_CLIENTE";
            this.ENDERECO_CLIENTE.HeaderText = "Endereço";
            this.ENDERECO_CLIENTE.MinimumWidth = 6;
            this.ENDERECO_CLIENTE.Name = "ENDERECO_CLIENTE";
            this.ENDERECO_CLIENTE.ReadOnly = true;
            this.ENDERECO_CLIENTE.Width = 230;
            // 
            // BAIRRO_CLIENTE
            // 
            this.BAIRRO_CLIENTE.DataPropertyName = "BAIRRO_CLIENTE";
            this.BAIRRO_CLIENTE.HeaderText = "Bairro";
            this.BAIRRO_CLIENTE.MinimumWidth = 6;
            this.BAIRRO_CLIENTE.Name = "BAIRRO_CLIENTE";
            this.BAIRRO_CLIENTE.ReadOnly = true;
            this.BAIRRO_CLIENTE.Visible = false;
            this.BAIRRO_CLIENTE.Width = 125;
            // 
            // CEP_CLIENTE
            // 
            this.CEP_CLIENTE.DataPropertyName = "CEP_CLIENTE";
            this.CEP_CLIENTE.HeaderText = "CEP";
            this.CEP_CLIENTE.MinimumWidth = 6;
            this.CEP_CLIENTE.Name = "CEP_CLIENTE";
            this.CEP_CLIENTE.ReadOnly = true;
            this.CEP_CLIENTE.Visible = false;
            this.CEP_CLIENTE.Width = 125;
            // 
            // CIDADE_CLIENTE
            // 
            this.CIDADE_CLIENTE.DataPropertyName = "CIDADE_CLIENTE";
            this.CIDADE_CLIENTE.HeaderText = "Cidade";
            this.CIDADE_CLIENTE.MinimumWidth = 6;
            this.CIDADE_CLIENTE.Name = "CIDADE_CLIENTE";
            this.CIDADE_CLIENTE.ReadOnly = true;
            this.CIDADE_CLIENTE.Width = 180;
            // 
            // ESTADO_CLIENTE
            // 
            this.ESTADO_CLIENTE.DataPropertyName = "ESTADO_CLIENTE";
            this.ESTADO_CLIENTE.HeaderText = "Estado";
            this.ESTADO_CLIENTE.MinimumWidth = 6;
            this.ESTADO_CLIENTE.Name = "ESTADO_CLIENTE";
            this.ESTADO_CLIENTE.ReadOnly = true;
            this.ESTADO_CLIENTE.Visible = false;
            this.ESTADO_CLIENTE.Width = 125;
            // 
            // TELEFONE_CLIENTE
            // 
            this.TELEFONE_CLIENTE.DataPropertyName = "TELEFONE_CLIENTE";
            this.TELEFONE_CLIENTE.HeaderText = "Telefone";
            this.TELEFONE_CLIENTE.MinimumWidth = 6;
            this.TELEFONE_CLIENTE.Name = "TELEFONE_CLIENTE";
            this.TELEFONE_CLIENTE.ReadOnly = true;
            this.TELEFONE_CLIENTE.Width = 125;
            // 
            // EMAIL_CLIENTE
            // 
            this.EMAIL_CLIENTE.DataPropertyName = "EMAIL_CLIENTE";
            this.EMAIL_CLIENTE.HeaderText = "Email";
            this.EMAIL_CLIENTE.MinimumWidth = 6;
            this.EMAIL_CLIENTE.Name = "EMAIL_CLIENTE";
            this.EMAIL_CLIENTE.ReadOnly = true;
            this.EMAIL_CLIENTE.Visible = false;
            this.EMAIL_CLIENTE.Width = 125;
            // 
            // DATA_CADASTRO_CLIENTE
            // 
            this.DATA_CADASTRO_CLIENTE.DataPropertyName = "DATA_CADASTRO_CLIENTE";
            this.DATA_CADASTRO_CLIENTE.HeaderText = "Data";
            this.DATA_CADASTRO_CLIENTE.MinimumWidth = 6;
            this.DATA_CADASTRO_CLIENTE.Name = "DATA_CADASTRO_CLIENTE";
            this.DATA_CADASTRO_CLIENTE.ReadOnly = true;
            this.DATA_CADASTRO_CLIENTE.Visible = false;
            this.DATA_CADASTRO_CLIENTE.Width = 125;
            // 
            // NASCIMENTO_CLIENTE
            // 
            this.NASCIMENTO_CLIENTE.DataPropertyName = "NASCIMENTO_CLIENTE";
            this.NASCIMENTO_CLIENTE.HeaderText = "Nascimento";
            this.NASCIMENTO_CLIENTE.MinimumWidth = 6;
            this.NASCIMENTO_CLIENTE.Name = "NASCIMENTO_CLIENTE";
            this.NASCIMENTO_CLIENTE.ReadOnly = true;
            this.NASCIMENTO_CLIENTE.Visible = false;
            this.NASCIMENTO_CLIENTE.Width = 125;
            // 
            // OBSERVACOES_CLIENTE
            // 
            this.OBSERVACOES_CLIENTE.DataPropertyName = "OBSERVACOES_CLIENTE";
            this.OBSERVACOES_CLIENTE.HeaderText = "Observações";
            this.OBSERVACOES_CLIENTE.MinimumWidth = 6;
            this.OBSERVACOES_CLIENTE.Name = "OBSERVACOES_CLIENTE";
            this.OBSERVACOES_CLIENTE.ReadOnly = true;
            this.OBSERVACOES_CLIENTE.Visible = false;
            this.OBSERVACOES_CLIENTE.Width = 125;
            // 
            // STATUS_CLIENTE
            // 
            this.STATUS_CLIENTE.DataPropertyName = "STATUS_CLIENTE";
            this.STATUS_CLIENTE.HeaderText = "Situação";
            this.STATUS_CLIENTE.MinimumWidth = 6;
            this.STATUS_CLIENTE.Name = "STATUS_CLIENTE";
            this.STATUS_CLIENTE.ReadOnly = true;
            this.STATUS_CLIENTE.Width = 125;
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.btnSalvar);
            this.tbpCadastro.Controls.Add(this.btnLimpar);
            this.tbpCadastro.Controls.Add(this.cboStatus);
            this.tbpCadastro.Controls.Add(this.gbDocumentosPessoaFisica);
            this.tbpCadastro.Controls.Add(this.gbDocumentosPessoaJuridica);
            this.tbpCadastro.Controls.Add(this.label20);
            this.tbpCadastro.Controls.Add(this.txtEstado);
            this.tbpCadastro.Controls.Add(this.label17);
            this.tbpCadastro.Controls.Add(this.dtpNascimento);
            this.tbpCadastro.Controls.Add(this.gbTipoPessoa);
            this.tbpCadastro.Controls.Add(this.label13);
            this.tbpCadastro.Controls.Add(this.txtEmail);
            this.tbpCadastro.Controls.Add(this.lblEstado);
            this.tbpCadastro.Controls.Add(this.gbContato);
            this.tbpCadastro.Controls.Add(this.txtCep);
            this.tbpCadastro.Controls.Add(this.label1);
            this.tbpCadastro.Controls.Add(this.label5);
            this.tbpCadastro.Controls.Add(this.label4);
            this.tbpCadastro.Controls.Add(this.label12);
            this.tbpCadastro.Controls.Add(this.dtpDataCadastro);
            this.tbpCadastro.Controls.Add(this.label6);
            this.tbpCadastro.Controls.Add(this.label3);
            this.tbpCadastro.Controls.Add(this.label10);
            this.tbpCadastro.Controls.Add(this.txtRegistro);
            this.tbpCadastro.Controls.Add(this.txtCidade);
            this.tbpCadastro.Controls.Add(this.txtBairro);
            this.tbpCadastro.Controls.Add(this.txtEndereco);
            this.tbpCadastro.Controls.Add(this.txtObservacao);
            this.tbpCadastro.Controls.Add(this.txtNome);
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
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(769, 336);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(213, 32);
            this.btnSalvar.TabIndex = 235;
            this.btnSalvar.Text = "Salvar Cliente";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLimpar.Location = new System.Drawing.Point(989, 336);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(212, 32);
            this.btnLimpar.TabIndex = 190;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "",
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(1011, 273);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(143, 28);
            this.cboStatus.TabIndex = 189;
            // 
            // gbDocumentosPessoaFisica
            // 
            this.gbDocumentosPessoaFisica.Controls.Add(this.txtCpf);
            this.gbDocumentosPessoaFisica.Controls.Add(this.txtRg);
            this.gbDocumentosPessoaFisica.Controls.Add(this.label14);
            this.gbDocumentosPessoaFisica.Controls.Add(this.label15);
            this.gbDocumentosPessoaFisica.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocumentosPessoaFisica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDocumentosPessoaFisica.Location = new System.Drawing.Point(569, 8);
            this.gbDocumentosPessoaFisica.Margin = new System.Windows.Forms.Padding(4);
            this.gbDocumentosPessoaFisica.Name = "gbDocumentosPessoaFisica";
            this.gbDocumentosPessoaFisica.Padding = new System.Windows.Forms.Padding(4);
            this.gbDocumentosPessoaFisica.Size = new System.Drawing.Size(335, 100);
            this.gbDocumentosPessoaFisica.TabIndex = 186;
            this.gbDocumentosPessoaFisica.TabStop = false;
            this.gbDocumentosPessoaFisica.Text = "Documentos";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(64, 59);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Mask = "999,999,999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(262, 32);
            this.txtCpf.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(64, 20);
            this.txtRg.Margin = new System.Windows.Forms.Padding(4);
            this.txtRg.MaxLength = 50;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(262, 32);
            this.txtRg.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "RG:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 62);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "CPF:";
            // 
            // gbDocumentosPessoaJuridica
            // 
            this.gbDocumentosPessoaJuridica.Controls.Add(this.txtCnpj);
            this.gbDocumentosPessoaJuridica.Controls.Add(this.txtIe);
            this.gbDocumentosPessoaJuridica.Controls.Add(this.label11);
            this.gbDocumentosPessoaJuridica.Controls.Add(this.label9);
            this.gbDocumentosPessoaJuridica.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocumentosPessoaJuridica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDocumentosPessoaJuridica.Location = new System.Drawing.Point(569, 8);
            this.gbDocumentosPessoaJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.gbDocumentosPessoaJuridica.Name = "gbDocumentosPessoaJuridica";
            this.gbDocumentosPessoaJuridica.Padding = new System.Windows.Forms.Padding(4);
            this.gbDocumentosPessoaJuridica.Size = new System.Drawing.Size(335, 100);
            this.gbDocumentosPessoaJuridica.TabIndex = 187;
            this.gbDocumentosPessoaJuridica.TabStop = false;
            this.gbDocumentosPessoaJuridica.Text = "Documentos";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCnpj.Location = new System.Drawing.Point(104, 60);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.Mask = "99.999.999/9999-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(186, 32);
            this.txtCnpj.TabIndex = 96;
            // 
            // txtIe
            // 
            this.txtIe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIe.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtIe.Location = new System.Drawing.Point(104, 26);
            this.txtIe.Margin = new System.Windows.Forms.Padding(4);
            this.txtIe.MaxLength = 50;
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(186, 32);
            this.txtIe.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label11.Location = new System.Drawing.Point(25, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "IE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label9.Location = new System.Drawing.Point(25, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "CNPJ:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1007, 254);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 19);
            this.label20.TabIndex = 188;
            this.label20.Text = "Situação:";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(769, 273);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(182, 29);
            this.txtEstado.TabIndex = 167;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(8, 318);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 19);
            this.label17.TabIndex = 184;
            this.label17.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpNascimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascimento.Location = new System.Drawing.Point(12, 337);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(141, 29);
            this.dtpNascimento.TabIndex = 169;
            // 
            // gbTipoPessoa
            // 
            this.gbTipoPessoa.Controls.Add(this.rbPessoaJuridica);
            this.gbTipoPessoa.Controls.Add(this.rbPessoaFisica);
            this.gbTipoPessoa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPessoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbTipoPessoa.Location = new System.Drawing.Point(4, 4);
            this.gbTipoPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.gbTipoPessoa.Name = "gbTipoPessoa";
            this.gbTipoPessoa.Padding = new System.Windows.Forms.Padding(4);
            this.gbTipoPessoa.Size = new System.Drawing.Size(557, 86);
            this.gbTipoPessoa.TabIndex = 161;
            this.gbTipoPessoa.TabStop = false;
            this.gbTipoPessoa.Text = "Escolha o tipo de Pessoa";
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaJuridica.Location = new System.Drawing.Point(292, 33);
            this.rbPessoaJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(160, 29);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Checked = true;
            this.rbPessoaFisica.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaFisica.Location = new System.Drawing.Point(83, 33);
            this.rbPessoaFisica.Margin = new System.Windows.Forms.Padding(4);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(141, 29);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(235, 318);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 19);
            this.label13.TabIndex = 183;
            this.label13.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(239, 337);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(495, 29);
            this.txtEmail.TabIndex = 168;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(765, 254);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 19);
            this.lblEstado.TabIndex = 185;
            this.lblEstado.Text = "Estado:";
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtTelefone);
            this.gbContato.Controls.Add(this.label8);
            this.gbContato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbContato.Location = new System.Drawing.Point(927, 7);
            this.gbContato.Margin = new System.Windows.Forms.Padding(4);
            this.gbContato.Name = "gbContato";
            this.gbContato.Padding = new System.Windows.Forms.Padding(4);
            this.gbContato.Size = new System.Drawing.Size(335, 114);
            this.gbContato.TabIndex = 171;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(131, 47);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(147, 32);
            this.txtTelefone.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefone:";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(600, 273);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(114, 29);
            this.txtCep.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 173;
            this.label1.Text = "Registro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(596, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 178;
            this.label5.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(717, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 177;
            this.label4.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(923, 126);
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
            this.dtpDataCadastro.Location = new System.Drawing.Point(927, 145);
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
            this.label6.Location = new System.Drawing.Point(8, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 179;
            this.label6.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 176;
            this.label3.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(8, 382);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 175;
            this.label10.Text = "Observações:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(12, 145);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(118, 29);
            this.txtRegistro.TabIndex = 180;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.Text = "0";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(12, 273);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(557, 29);
            this.txtCidade.TabIndex = 166;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(721, 209);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(441, 29);
            this.txtBairro.TabIndex = 164;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(12, 209);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(654, 29);
            this.txtEndereco.TabIndex = 163;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(12, 401);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.MaxLength = 50;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(1249, 289);
            this.txtObservacao.TabIndex = 170;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(165, 145);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(710, 29);
            this.txtNome.TabIndex = 162;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(161, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 174;
            this.label2.Text = "Nome:";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1487, 732);
            this.Controls.Add(this.tbcClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnClientes)).EndInit();
            this.bdnClientes.ResumeLayout(false);
            this.bdnClientes.PerformLayout();
            this.tbcClientes.ResumeLayout(false);
            this.tbpProcura.ResumeLayout(false);
            this.tbpProcura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.gbDocumentosPessoaFisica.ResumeLayout(false);
            this.gbDocumentosPessoaFisica.PerformLayout();
            this.gbDocumentosPessoaJuridica.ResumeLayout(false);
            this.gbDocumentosPessoaJuridica.PerformLayout();
            this.gbTipoPessoa.ResumeLayout(false);
            this.gbTipoPessoa.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.BindingNavigator bdnClientes;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.TabControl tbcClientes;
        private System.Windows.Forms.TabPage tbpProcura;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.GroupBox gbDocumentosPessoaFisica;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.GroupBox gbTipoPessoa;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.GroupBox gbDocumentosPessoaJuridica;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NASCIMENTO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACOES_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_CLIENTE;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.BindingSource bdsClientes;
    }
}