namespace Interface
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.tbcFuncionarios = new System.Windows.Forms.TabControl();
            this.tbpProcura = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.dtgFuncionarios = new System.Windows.Forms.DataGridView();
            this.ID_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NASCIMENTO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACOES_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDocumentosPessoaFisica = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bdnFuncionarios = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bdsFuncionarios = new System.Windows.Forms.BindingSource(this.components);
            this.tbcFuncionarios.SuspendLayout();
            this.tbpProcura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).BeginInit();
            this.tbpCadastro.SuspendLayout();
            this.gbDocumentosPessoaFisica.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnFuncionarios)).BeginInit();
            this.bdnFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcFuncionarios
            // 
            this.tbcFuncionarios.Controls.Add(this.tbpProcura);
            this.tbcFuncionarios.Controls.Add(this.tbpCadastro);
            this.tbcFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcFuncionarios.Location = new System.Drawing.Point(199, 0);
            this.tbcFuncionarios.Margin = new System.Windows.Forms.Padding(5);
            this.tbcFuncionarios.Name = "tbcFuncionarios";
            this.tbcFuncionarios.SelectedIndex = 0;
            this.tbcFuncionarios.Size = new System.Drawing.Size(1288, 732);
            this.tbcFuncionarios.TabIndex = 6;
            // 
            // tbpProcura
            // 
            this.tbpProcura.Controls.Add(this.label21);
            this.tbpProcura.Controls.Add(this.cboFiltro);
            this.tbpProcura.Controls.Add(this.dtgFuncionarios);
            this.tbpProcura.Controls.Add(this.cboOrdenar);
            this.tbpProcura.Controls.Add(this.txtNomeFuncionario);
            this.tbpProcura.Controls.Add(this.btnPesquisar);
            this.tbpProcura.Controls.Add(this.label19);
            this.tbpProcura.Controls.Add(this.label18);
            this.tbpProcura.Controls.Add(this.label7);
            this.tbpProcura.Location = new System.Drawing.Point(4, 25);
            this.tbpProcura.Margin = new System.Windows.Forms.Padding(5);
            this.tbpProcura.Name = "tbpProcura";
            this.tbpProcura.Padding = new System.Windows.Forms.Padding(5);
            this.tbpProcura.Size = new System.Drawing.Size(1280, 703);
            this.tbpProcura.TabIndex = 0;
            this.tbpProcura.Text = "Procura";
            this.tbpProcura.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 16);
            this.label21.TabIndex = 209;
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
            this.cboFiltro.Location = new System.Drawing.Point(14, 103);
            this.cboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(223, 28);
            this.cboFiltro.TabIndex = 208;
            // 
            // dtgFuncionarios
            // 
            this.dtgFuncionarios.AllowUserToAddRows = false;
            this.dtgFuncionarios.AllowUserToDeleteRows = false;
            this.dtgFuncionarios.AllowUserToResizeColumns = false;
            this.dtgFuncionarios.AllowUserToResizeRows = false;
            this.dtgFuncionarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_FUNCIONARIO,
            this.NOME_FUNCIONARIO,
            this.ENDERECO_FUNCIONARIO,
            this.BAIRRO_FUNCIONARIO,
            this.CEP_FUNCIONARIO,
            this.CIDADE_FUNCIONARIO,
            this.ESTADO_FUNCIONARIO,
            this.TELEFONE_FUNCIONARIO,
            this.EMAIL_FUNCIONARIO,
            this.DATA_CADASTRO_FUNCIONARIO,
            this.NASCIMENTO_FUNCIONARIO,
            this.OBSERVACOES_FUNCIONARIO,
            this.STATUS_FUNCIONARIO});
            this.dtgFuncionarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgFuncionarios.Location = new System.Drawing.Point(9, 224);
            this.dtgFuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.dtgFuncionarios.Name = "dtgFuncionarios";
            this.dtgFuncionarios.ReadOnly = true;
            this.dtgFuncionarios.RowHeadersVisible = false;
            this.dtgFuncionarios.RowHeadersWidth = 51;
            this.dtgFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFuncionarios.Size = new System.Drawing.Size(1262, 470);
            this.dtgFuncionarios.TabIndex = 207;
            this.dtgFuncionarios.TabStop = false;
            this.dtgFuncionarios.Tag = "";
            // 
            // ID_FUNCIONARIO
            // 
            this.ID_FUNCIONARIO.DataPropertyName = "ID_FUNCIONARIO";
            this.ID_FUNCIONARIO.HeaderText = "Código";
            this.ID_FUNCIONARIO.MinimumWidth = 6;
            this.ID_FUNCIONARIO.Name = "ID_FUNCIONARIO";
            this.ID_FUNCIONARIO.ReadOnly = true;
            this.ID_FUNCIONARIO.Width = 70;
            // 
            // NOME_FUNCIONARIO
            // 
            this.NOME_FUNCIONARIO.DataPropertyName = "NOME_FUNCIONARIO";
            this.NOME_FUNCIONARIO.HeaderText = "Nome";
            this.NOME_FUNCIONARIO.MinimumWidth = 6;
            this.NOME_FUNCIONARIO.Name = "NOME_FUNCIONARIO";
            this.NOME_FUNCIONARIO.ReadOnly = true;
            this.NOME_FUNCIONARIO.Width = 250;
            // 
            // ENDERECO_FUNCIONARIO
            // 
            this.ENDERECO_FUNCIONARIO.DataPropertyName = "ENDERECO_FUNCIONARIO";
            this.ENDERECO_FUNCIONARIO.HeaderText = "Endereço";
            this.ENDERECO_FUNCIONARIO.MinimumWidth = 6;
            this.ENDERECO_FUNCIONARIO.Name = "ENDERECO_FUNCIONARIO";
            this.ENDERECO_FUNCIONARIO.ReadOnly = true;
            this.ENDERECO_FUNCIONARIO.Width = 230;
            // 
            // BAIRRO_FUNCIONARIO
            // 
            this.BAIRRO_FUNCIONARIO.DataPropertyName = "BAIRRO_FUNCIONARIO";
            this.BAIRRO_FUNCIONARIO.HeaderText = "Bairro";
            this.BAIRRO_FUNCIONARIO.MinimumWidth = 6;
            this.BAIRRO_FUNCIONARIO.Name = "BAIRRO_FUNCIONARIO";
            this.BAIRRO_FUNCIONARIO.ReadOnly = true;
            this.BAIRRO_FUNCIONARIO.Visible = false;
            this.BAIRRO_FUNCIONARIO.Width = 125;
            // 
            // CEP_FUNCIONARIO
            // 
            this.CEP_FUNCIONARIO.DataPropertyName = "CEP_FUNCIONARIO";
            this.CEP_FUNCIONARIO.HeaderText = "CEP";
            this.CEP_FUNCIONARIO.MinimumWidth = 6;
            this.CEP_FUNCIONARIO.Name = "CEP_FUNCIONARIO";
            this.CEP_FUNCIONARIO.ReadOnly = true;
            this.CEP_FUNCIONARIO.Visible = false;
            this.CEP_FUNCIONARIO.Width = 125;
            // 
            // CIDADE_FUNCIONARIO
            // 
            this.CIDADE_FUNCIONARIO.DataPropertyName = "CIDADE_FUNCIONARIO";
            this.CIDADE_FUNCIONARIO.HeaderText = "Cidade";
            this.CIDADE_FUNCIONARIO.MinimumWidth = 6;
            this.CIDADE_FUNCIONARIO.Name = "CIDADE_FUNCIONARIO";
            this.CIDADE_FUNCIONARIO.ReadOnly = true;
            this.CIDADE_FUNCIONARIO.Width = 180;
            // 
            // ESTADO_FUNCIONARIO
            // 
            this.ESTADO_FUNCIONARIO.DataPropertyName = "ESTADO_FUNCIONARIO";
            this.ESTADO_FUNCIONARIO.HeaderText = "Estado";
            this.ESTADO_FUNCIONARIO.MinimumWidth = 6;
            this.ESTADO_FUNCIONARIO.Name = "ESTADO_FUNCIONARIO";
            this.ESTADO_FUNCIONARIO.ReadOnly = true;
            this.ESTADO_FUNCIONARIO.Visible = false;
            this.ESTADO_FUNCIONARIO.Width = 125;
            // 
            // TELEFONE_FUNCIONARIO
            // 
            this.TELEFONE_FUNCIONARIO.DataPropertyName = "TELEFONE_FUNCIONARIO";
            this.TELEFONE_FUNCIONARIO.HeaderText = "Telefone";
            this.TELEFONE_FUNCIONARIO.MinimumWidth = 6;
            this.TELEFONE_FUNCIONARIO.Name = "TELEFONE_FUNCIONARIO";
            this.TELEFONE_FUNCIONARIO.ReadOnly = true;
            this.TELEFONE_FUNCIONARIO.Width = 125;
            // 
            // EMAIL_FUNCIONARIO
            // 
            this.EMAIL_FUNCIONARIO.DataPropertyName = "EMAIL_FUNCIONARIO";
            this.EMAIL_FUNCIONARIO.HeaderText = "Email";
            this.EMAIL_FUNCIONARIO.MinimumWidth = 6;
            this.EMAIL_FUNCIONARIO.Name = "EMAIL_FUNCIONARIO";
            this.EMAIL_FUNCIONARIO.ReadOnly = true;
            this.EMAIL_FUNCIONARIO.Visible = false;
            this.EMAIL_FUNCIONARIO.Width = 125;
            // 
            // DATA_CADASTRO_FUNCIONARIO
            // 
            this.DATA_CADASTRO_FUNCIONARIO.DataPropertyName = "DATA_CADASTRO_FUNCIONARIO";
            this.DATA_CADASTRO_FUNCIONARIO.HeaderText = "Data";
            this.DATA_CADASTRO_FUNCIONARIO.MinimumWidth = 6;
            this.DATA_CADASTRO_FUNCIONARIO.Name = "DATA_CADASTRO_FUNCIONARIO";
            this.DATA_CADASTRO_FUNCIONARIO.ReadOnly = true;
            this.DATA_CADASTRO_FUNCIONARIO.Visible = false;
            this.DATA_CADASTRO_FUNCIONARIO.Width = 125;
            // 
            // NASCIMENTO_FUNCIONARIO
            // 
            this.NASCIMENTO_FUNCIONARIO.DataPropertyName = "NASCIMENTO_FUNCIONARIO";
            this.NASCIMENTO_FUNCIONARIO.HeaderText = "Nascimento";
            this.NASCIMENTO_FUNCIONARIO.MinimumWidth = 6;
            this.NASCIMENTO_FUNCIONARIO.Name = "NASCIMENTO_FUNCIONARIO";
            this.NASCIMENTO_FUNCIONARIO.ReadOnly = true;
            this.NASCIMENTO_FUNCIONARIO.Visible = false;
            this.NASCIMENTO_FUNCIONARIO.Width = 125;
            // 
            // OBSERVACOES_FUNCIONARIO
            // 
            this.OBSERVACOES_FUNCIONARIO.DataPropertyName = "OBSERVACOES_FUNCIONARIO";
            this.OBSERVACOES_FUNCIONARIO.HeaderText = "Observações";
            this.OBSERVACOES_FUNCIONARIO.MinimumWidth = 6;
            this.OBSERVACOES_FUNCIONARIO.Name = "OBSERVACOES_FUNCIONARIO";
            this.OBSERVACOES_FUNCIONARIO.ReadOnly = true;
            this.OBSERVACOES_FUNCIONARIO.Visible = false;
            this.OBSERVACOES_FUNCIONARIO.Width = 125;
            // 
            // STATUS_FUNCIONARIO
            // 
            this.STATUS_FUNCIONARIO.DataPropertyName = "STATUS_FUNCIONARIO";
            this.STATUS_FUNCIONARIO.HeaderText = "Situação";
            this.STATUS_FUNCIONARIO.MinimumWidth = 6;
            this.STATUS_FUNCIONARIO.Name = "STATUS_FUNCIONARIO";
            this.STATUS_FUNCIONARIO.ReadOnly = true;
            this.STATUS_FUNCIONARIO.Width = 125;
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Situação",
            "Nível"});
            this.cboOrdenar.Location = new System.Drawing.Point(851, 49);
            this.cboOrdenar.Margin = new System.Windows.Forms.Padding(5);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(189, 28);
            this.cboOrdenar.TabIndex = 206;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(14, 49);
            this.txtNomeFuncionario.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeFuncionario.MaxLength = 50;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(679, 29);
            this.txtNomeFuncionario.TabIndex = 204;
            this.txtNomeFuncionario.TextChanged += new System.EventHandler(this.txtNomeFuncionario_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(714, 48);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 203;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(848, 28);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 202;
            this.label19.Text = "Ordenar por:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 28);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 16);
            this.label18.TabIndex = 201;
            this.label18.Text = "Nome do Funcionário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 199;
            this.label7.Text = "Procura:";
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.btnSalvar);
            this.tbpCadastro.Controls.Add(this.btnLimpar);
            this.tbpCadastro.Controls.Add(this.cboStatus);
            this.tbpCadastro.Controls.Add(this.label20);
            this.tbpCadastro.Controls.Add(this.txtEstado);
            this.tbpCadastro.Controls.Add(this.label17);
            this.tbpCadastro.Controls.Add(this.dtpNascimento);
            this.tbpCadastro.Controls.Add(this.label13);
            this.tbpCadastro.Controls.Add(this.txtEmail);
            this.tbpCadastro.Controls.Add(this.lblEstado);
            this.tbpCadastro.Controls.Add(this.txtCep);
            this.tbpCadastro.Controls.Add(this.label1);
            this.tbpCadastro.Controls.Add(this.label5);
            this.tbpCadastro.Controls.Add(this.label4);
            this.tbpCadastro.Controls.Add(this.label12);
            this.tbpCadastro.Controls.Add(this.dtpDataCadastro);
            this.tbpCadastro.Controls.Add(this.label6);
            this.tbpCadastro.Controls.Add(this.label3);
            this.tbpCadastro.Controls.Add(this.txtRegistro);
            this.tbpCadastro.Controls.Add(this.txtCidade);
            this.tbpCadastro.Controls.Add(this.txtBairro);
            this.tbpCadastro.Controls.Add(this.txtEndereco);
            this.tbpCadastro.Controls.Add(this.txtNome);
            this.tbpCadastro.Controls.Add(this.label2);
            this.tbpCadastro.Controls.Add(this.gbDocumentosPessoaFisica);
            this.tbpCadastro.Controls.Add(this.label10);
            this.tbpCadastro.Controls.Add(this.txtObservacao);
            this.tbpCadastro.Controls.Add(this.gbContato);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 25);
            this.tbpCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(5);
            this.tbpCadastro.Size = new System.Drawing.Size(1280, 703);
            this.tbpCadastro.TabIndex = 1;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(953, 274);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(213, 32);
            this.btnSalvar.TabIndex = 259;
            this.btnSalvar.Text = "Salvar Funcionário";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLimpar.Location = new System.Drawing.Point(954, 345);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(212, 32);
            this.btnLimpar.TabIndex = 258;
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
            this.cboStatus.Location = new System.Drawing.Point(1012, 152);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(143, 28);
            this.cboStatus.TabIndex = 257;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1008, 133);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 16);
            this.label20.TabIndex = 256;
            this.label20.Text = "Situação:";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(770, 152);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(182, 29);
            this.txtEstado.TabIndex = 241;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(9, 197);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 19);
            this.label17.TabIndex = 254;
            this.label17.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpNascimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascimento.Location = new System.Drawing.Point(13, 216);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(141, 29);
            this.dtpNascimento.TabIndex = 243;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(236, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 19);
            this.label13.TabIndex = 253;
            this.label13.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(240, 216);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(712, 29);
            this.txtEmail.TabIndex = 242;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(766, 133);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 19);
            this.lblEstado.TabIndex = 255;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(601, 152);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(114, 29);
            this.txtCep.TabIndex = 239;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 244;
            this.label1.Text = "Registro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(597, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 248;
            this.label5.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(718, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 247;
            this.label4.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(924, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 252;
            this.label12.Text = "Data Cadastro:";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCadastro.Location = new System.Drawing.Point(928, 24);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(187, 29);
            this.dtpDataCadastro.TabIndex = 251;
            this.dtpDataCadastro.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(9, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 249;
            this.label6.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 246;
            this.label3.Text = "Endereço:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(13, 24);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(118, 29);
            this.txtRegistro.TabIndex = 250;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.Text = "0";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(13, 152);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(557, 29);
            this.txtCidade.TabIndex = 240;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(722, 88);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(441, 29);
            this.txtBairro.TabIndex = 238;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(13, 88);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(654, 29);
            this.txtEndereco.TabIndex = 237;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(166, 24);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(710, 29);
            this.txtNome.TabIndex = 236;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(162, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 245;
            this.label2.Text = "Nome:";
            // 
            // gbDocumentosPessoaFisica
            // 
            this.gbDocumentosPessoaFisica.Controls.Add(this.txtCpf);
            this.gbDocumentosPessoaFisica.Controls.Add(this.txtRg);
            this.gbDocumentosPessoaFisica.Controls.Add(this.label14);
            this.gbDocumentosPessoaFisica.Controls.Add(this.label15);
            this.gbDocumentosPessoaFisica.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocumentosPessoaFisica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDocumentosPessoaFisica.Location = new System.Drawing.Point(13, 254);
            this.gbDocumentosPessoaFisica.Margin = new System.Windows.Forms.Padding(5);
            this.gbDocumentosPessoaFisica.Name = "gbDocumentosPessoaFisica";
            this.gbDocumentosPessoaFisica.Padding = new System.Windows.Forms.Padding(5);
            this.gbDocumentosPessoaFisica.Size = new System.Drawing.Size(447, 123);
            this.gbDocumentosPessoaFisica.TabIndex = 189;
            this.gbDocumentosPessoaFisica.TabStop = false;
            this.gbDocumentosPessoaFisica.Text = "Documentos";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(85, 73);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(5);
            this.txtCpf.Mask = "999,999,999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(349, 32);
            this.txtCpf.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(85, 25);
            this.txtRg.Margin = new System.Windows.Forms.Padding(5);
            this.txtRg.MaxLength = 50;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(349, 32);
            this.txtRg.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "RG:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 76);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "CPF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(16, 432);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 202;
            this.label10.Text = "Observações:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(20, 456);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(5);
            this.txtObservacao.MaxLength = 50;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(1249, 237);
            this.txtObservacao.TabIndex = 199;
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtTelefone);
            this.gbContato.Controls.Add(this.label8);
            this.gbContato.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbContato.Location = new System.Drawing.Point(485, 255);
            this.gbContato.Margin = new System.Windows.Forms.Padding(5);
            this.gbContato.Name = "gbContato";
            this.gbContato.Padding = new System.Windows.Forms.Padding(5);
            this.gbContato.Size = new System.Drawing.Size(447, 140);
            this.gbContato.TabIndex = 187;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(175, 58);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(195, 32);
            this.txtTelefone.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefone:";
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.Image = global::Interface.Properties.Resources.adicionar;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(197, 74);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo Funcionário";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlterar.Image = global::Interface.Properties.Resources.editar;
            this.btnAlterar.Location = new System.Drawing.Point(0, 74);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(197, 74);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar Funcionário";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.Image = global::Interface.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(0, 148);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 74);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir Funcionário";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bdnFuncionarios);
            this.panel1.Controls.Add(this.btnAjuda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 732);
            this.panel1.TabIndex = 5;
            // 
            // bdnFuncionarios
            // 
            this.bdnFuncionarios.AddNewItem = null;
            this.bdnFuncionarios.CountItem = null;
            this.bdnFuncionarios.DeleteItem = null;
            this.bdnFuncionarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnFuncionarios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnFuncionarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.separator1,
            this.bindingNavigatorMovePreviousItem,
            this.separator2,
            this.bindingNavigatorMoveNextItem,
            this.separator3,
            this.bindingNavigatorMoveLastItem});
            this.bdnFuncionarios.Location = new System.Drawing.Point(0, 555);
            this.bdnFuncionarios.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnFuncionarios.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnFuncionarios.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnFuncionarios.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnFuncionarios.Name = "bdnFuncionarios";
            this.bdnFuncionarios.PositionItem = null;
            this.bdnFuncionarios.Size = new System.Drawing.Size(197, 27);
            this.bdnFuncionarios.TabIndex = 6;
            this.bdnFuncionarios.Text = "bindingNavigator1";
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
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 732);
            this.Controls.Add(this.tbcFuncionarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.tbcFuncionarios.ResumeLayout(false);
            this.tbpProcura.ResumeLayout(false);
            this.tbpProcura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).EndInit();
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.gbDocumentosPessoaFisica.ResumeLayout(false);
            this.gbDocumentosPessoaFisica.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnFuncionarios)).EndInit();
            this.bdnFuncionarios.ResumeLayout(false);
            this.bdnFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcFuncionarios;
        private System.Windows.Forms.TabPage tbpProcura;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.GroupBox gbDocumentosPessoaFisica;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NASCIMENTO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACOES_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_FUNCIONARIO;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.BindingNavigator bdnFuncionarios;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource bdsFuncionarios;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}