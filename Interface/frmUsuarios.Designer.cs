namespace Interface
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bdnUsuarios = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tbcUsuarios = new System.Windows.Forms.TabControl();
            this.tbpProcura = new System.Windows.Forms.TabPage();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtReeSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpNiveis = new System.Windows.Forms.TabPage();
            this.gpbNiveis = new System.Windows.Forms.GroupBox();
            this.btnFormNiveis = new System.Windows.Forms.Button();
            this.dtgNivelUsuario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodNivel = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.bdsUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.bdsNiveis = new System.Windows.Forms.BindingSource(this.components);
            this.codProcura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProcura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProcura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginProcura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaProcura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusProcura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codnivelProcura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomenivelProcura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codNivelUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeNivelUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnUsuarios)).BeginInit();
            this.bdnUsuarios.SuspendLayout();
            this.tbcUsuarios.SuspendLayout();
            this.tbpProcura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.tbpCadastro.SuspendLayout();
            this.tbpNiveis.SuspendLayout();
            this.gpbNiveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNivelUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bdnUsuarios);
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
            this.panel1.TabIndex = 2;
            // 
            // bdnUsuarios
            // 
            this.bdnUsuarios.AddNewItem = null;
            this.bdnUsuarios.CountItem = null;
            this.bdnUsuarios.DeleteItem = null;
            this.bdnUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnUsuarios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bdnUsuarios.Location = new System.Drawing.Point(0, 555);
            this.bdnUsuarios.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnUsuarios.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnUsuarios.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnUsuarios.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnUsuarios.Name = "bdnUsuarios";
            this.bdnUsuarios.PositionItem = null;
            this.bdnUsuarios.Size = new System.Drawing.Size(197, 27);
            this.bdnUsuarios.TabIndex = 5;
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
            this.btnExcluir.Text = "Excluir Usuário";
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
            this.btnAlterar.Text = "Alterar Usuário";
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
            this.btnNovo.Text = "Novo Usuário";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tbcUsuarios
            // 
            this.tbcUsuarios.Controls.Add(this.tbpProcura);
            this.tbcUsuarios.Controls.Add(this.tbpCadastro);
            this.tbcUsuarios.Controls.Add(this.tbpNiveis);
            this.tbcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcUsuarios.Location = new System.Drawing.Point(199, 0);
            this.tbcUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.tbcUsuarios.Name = "tbcUsuarios";
            this.tbcUsuarios.SelectedIndex = 0;
            this.tbcUsuarios.Size = new System.Drawing.Size(1288, 732);
            this.tbcUsuarios.TabIndex = 3;
            // 
            // tbpProcura
            // 
            this.tbpProcura.Controls.Add(this.label21);
            this.tbpProcura.Controls.Add(this.cboFiltro);
            this.tbpProcura.Controls.Add(this.dtgUsuarios);
            this.tbpProcura.Controls.Add(this.cboOrdenar);
            this.tbpProcura.Controls.Add(this.txtNomeUsuario);
            this.tbpProcura.Controls.Add(this.btnPesquisar);
            this.tbpProcura.Controls.Add(this.label19);
            this.tbpProcura.Controls.Add(this.label18);
            this.tbpProcura.Controls.Add(this.label7);
            this.tbpProcura.Location = new System.Drawing.Point(4, 25);
            this.tbpProcura.Margin = new System.Windows.Forms.Padding(4);
            this.tbpProcura.Name = "tbpProcura";
            this.tbpProcura.Padding = new System.Windows.Forms.Padding(4);
            this.tbpProcura.Size = new System.Drawing.Size(1280, 703);
            this.tbpProcura.TabIndex = 0;
            this.tbpProcura.Text = "Procura";
            this.tbpProcura.UseVisualStyleBackColor = true;
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToResizeColumns = false;
            this.dtgUsuarios.AllowUserToResizeRows = false;
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProcura,
            this.nomeProcura,
            this.dataProcura,
            this.loginProcura,
            this.senhaProcura,
            this.statusProcura,
            this.codnivelProcura,
            this.nomenivelProcura});
            this.dtgUsuarios.Location = new System.Drawing.Point(14, 223);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(1253, 470);
            this.dtgUsuarios.TabIndex = 208;
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
            "Situação",
            "Nível"});
            this.cboOrdenar.Location = new System.Drawing.Point(814, 53);
            this.cboOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(184, 28);
            this.cboOrdenar.TabIndex = 207;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(18, 52);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUsuario.MaxLength = 50;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(611, 29);
            this.txtNomeUsuario.TabIndex = 205;
            this.txtNomeUsuario.TextChanged += new System.EventHandler(this.txtNomeUsuario_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(637, 52);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 29);
            this.btnPesquisar.TabIndex = 204;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(811, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 203;
            this.label19.Text = "Ordenar por:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 32);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 16);
            this.label18.TabIndex = 202;
            this.label18.Text = "Nome do Usuário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 200;
            this.label7.Text = "Procura:";
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.btnSalvar);
            this.tbpCadastro.Controls.Add(this.label10);
            this.tbpCadastro.Controls.Add(this.txtObservacao);
            this.tbpCadastro.Controls.Add(this.cboStatus);
            this.tbpCadastro.Controls.Add(this.label4);
            this.tbpCadastro.Controls.Add(this.btnLimpar);
            this.tbpCadastro.Controls.Add(this.cboNivel);
            this.tbpCadastro.Controls.Add(this.label20);
            this.tbpCadastro.Controls.Add(this.txtReeSenha);
            this.tbpCadastro.Controls.Add(this.txtSenha);
            this.tbpCadastro.Controls.Add(this.label5);
            this.tbpCadastro.Controls.Add(this.lblSenha);
            this.tbpCadastro.Controls.Add(this.label1);
            this.tbpCadastro.Controls.Add(this.label12);
            this.tbpCadastro.Controls.Add(this.dtpDataCadastro);
            this.tbpCadastro.Controls.Add(this.label3);
            this.tbpCadastro.Controls.Add(this.txtRegistro);
            this.tbpCadastro.Controls.Add(this.txtLogin);
            this.tbpCadastro.Controls.Add(this.txtNome);
            this.tbpCadastro.Controls.Add(this.label2);
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
            this.btnSalvar.Location = new System.Drawing.Point(698, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(253, 46);
            this.btnSalvar.TabIndex = 234;
            this.btnSalvar.Text = "Salvar Usuário";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(12, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 19);
            this.label10.TabIndex = 233;
            this.label10.Text = "Observações:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(19, 320);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.MaxLength = 50;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(1249, 361);
            this.txtObservacao.TabIndex = 232;
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
            this.cboStatus.Location = new System.Drawing.Point(931, 104);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(143, 28);
            this.cboStatus.TabIndex = 231;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(927, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 230;
            this.label4.Text = "Situação:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLimpar.Location = new System.Drawing.Point(970, 168);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(253, 46);
            this.btnLimpar.TabIndex = 229;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cboNivel
            // 
            this.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(712, 104);
            this.cboNivel.Margin = new System.Windows.Forms.Padding(4);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(143, 28);
            this.cboNivel.TabIndex = 228;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(708, 85);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 16);
            this.label20.TabIndex = 227;
            this.label20.Text = "Nível:";
            // 
            // txtReeSenha
            // 
            this.txtReeSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReeSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReeSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReeSenha.Location = new System.Drawing.Point(383, 168);
            this.txtReeSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtReeSenha.MaxLength = 50;
            this.txtReeSenha.Name = "txtReeSenha";
            this.txtReeSenha.PasswordChar = '*';
            this.txtReeSenha.Size = new System.Drawing.Size(266, 29);
            this.txtReeSenha.TabIndex = 217;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(16, 168);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(266, 29);
            this.txtSenha.TabIndex = 218;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(379, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 225;
            this.label5.Text = "Reescreva a senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenha.Location = new System.Drawing.Point(12, 149);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 19);
            this.lblSenha.TabIndex = 226;
            this.lblSenha.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 219;
            this.label1.Text = "Registro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(927, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 224;
            this.label12.Text = "Data Cadastro:";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCadastro.Location = new System.Drawing.Point(931, 40);
            this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(187, 29);
            this.dtpDataCadastro.TabIndex = 223;
            this.dtpDataCadastro.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 221;
            this.label3.Text = "Login:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(16, 40);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(118, 29);
            this.txtRegistro.TabIndex = 222;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.Text = "0";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(16, 104);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(654, 29);
            this.txtLogin.TabIndex = 216;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(169, 40);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(710, 29);
            this.txtNome.TabIndex = 215;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(165, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 220;
            this.label2.Text = "Nome:";
            // 
            // tbpNiveis
            // 
            this.tbpNiveis.Controls.Add(this.gpbNiveis);
            this.tbpNiveis.Controls.Add(this.dtgNivelUsuario);
            this.tbpNiveis.Controls.Add(this.button1);
            this.tbpNiveis.Controls.Add(this.label9);
            this.tbpNiveis.Controls.Add(this.txtCodNivel);
            this.tbpNiveis.Controls.Add(this.txtNomeNivel);
            this.tbpNiveis.Controls.Add(this.label6);
            this.tbpNiveis.Controls.Add(this.label8);
            this.tbpNiveis.Location = new System.Drawing.Point(4, 25);
            this.tbpNiveis.Name = "tbpNiveis";
            this.tbpNiveis.Size = new System.Drawing.Size(1280, 703);
            this.tbpNiveis.TabIndex = 2;
            this.tbpNiveis.Text = "Niveis de Usuários";
            this.tbpNiveis.UseVisualStyleBackColor = true;
            // 
            // gpbNiveis
            // 
            this.gpbNiveis.Controls.Add(this.btnFormNiveis);
            this.gpbNiveis.Location = new System.Drawing.Point(858, 54);
            this.gpbNiveis.Name = "gpbNiveis";
            this.gpbNiveis.Size = new System.Drawing.Size(261, 136);
            this.gpbNiveis.TabIndex = 214;
            this.gpbNiveis.TabStop = false;
            this.gpbNiveis.Text = "Gerenciador de Níveis";
            // 
            // btnFormNiveis
            // 
            this.btnFormNiveis.Image = global::Interface.Properties.Resources.niveis_img;
            this.btnFormNiveis.Location = new System.Drawing.Point(21, 33);
            this.btnFormNiveis.Name = "btnFormNiveis";
            this.btnFormNiveis.Size = new System.Drawing.Size(162, 81);
            this.btnFormNiveis.TabIndex = 0;
            this.btnFormNiveis.Text = "Abir Gerenciador";
            this.btnFormNiveis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormNiveis.UseVisualStyleBackColor = true;
            this.btnFormNiveis.Click += new System.EventHandler(this.btnFormNiveis_Click);
            // 
            // dtgNivelUsuario
            // 
            this.dtgNivelUsuario.AllowUserToAddRows = false;
            this.dtgNivelUsuario.AllowUserToDeleteRows = false;
            this.dtgNivelUsuario.AllowUserToResizeColumns = false;
            this.dtgNivelUsuario.AllowUserToResizeRows = false;
            this.dtgNivelUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dtgNivelUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNivelUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codNivelUsuario,
            this.nomeNivelUsuario,
            this.Descricao});
            this.dtgNivelUsuario.Location = new System.Drawing.Point(18, 114);
            this.dtgNivelUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.dtgNivelUsuario.Name = "dtgNivelUsuario";
            this.dtgNivelUsuario.ReadOnly = true;
            this.dtgNivelUsuario.RowHeadersWidth = 51;
            this.dtgNivelUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNivelUsuario.Size = new System.Drawing.Size(804, 294);
            this.dtgNivelUsuario.TabIndex = 213;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 212;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 211;
            this.label9.Text = "Procura:";
            // 
            // txtCodNivel
            // 
            this.txtCodNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodNivel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodNivel.Location = new System.Drawing.Point(18, 54);
            this.txtCodNivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodNivel.MaxLength = 50;
            this.txtCodNivel.Name = "txtCodNivel";
            this.txtCodNivel.Size = new System.Drawing.Size(119, 29);
            this.txtCodNivel.TabIndex = 210;
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeNivel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNivel.Location = new System.Drawing.Point(177, 54);
            this.txtNomeNivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeNivel.MaxLength = 50;
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(510, 29);
            this.txtNomeNivel.TabIndex = 209;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 208;
            this.label6.Text = "Nome do Nível:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 207;
            this.label8.Text = "Código do Nível:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 16);
            this.label21.TabIndex = 210;
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
            this.cboFiltro.Location = new System.Drawing.Point(19, 105);
            this.cboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(223, 28);
            this.cboFiltro.TabIndex = 209;
            // 
            // codProcura
            // 
            this.codProcura.DataPropertyName = "ID_USUARIO";
            this.codProcura.HeaderText = "Código";
            this.codProcura.MinimumWidth = 6;
            this.codProcura.Name = "codProcura";
            this.codProcura.ReadOnly = true;
            this.codProcura.Width = 70;
            // 
            // nomeProcura
            // 
            this.nomeProcura.DataPropertyName = "NOME_USUARIO";
            this.nomeProcura.HeaderText = "Nome";
            this.nomeProcura.MinimumWidth = 6;
            this.nomeProcura.Name = "nomeProcura";
            this.nomeProcura.ReadOnly = true;
            this.nomeProcura.Width = 240;
            // 
            // dataProcura
            // 
            this.dataProcura.DataPropertyName = "DATA_CADASTRO";
            this.dataProcura.HeaderText = "Data de Cadastro";
            this.dataProcura.MinimumWidth = 6;
            this.dataProcura.Name = "dataProcura";
            this.dataProcura.ReadOnly = true;
            this.dataProcura.Width = 140;
            // 
            // loginProcura
            // 
            this.loginProcura.DataPropertyName = "LOGIN_USUARIO";
            this.loginProcura.HeaderText = "Login";
            this.loginProcura.MinimumWidth = 6;
            this.loginProcura.Name = "loginProcura";
            this.loginProcura.ReadOnly = true;
            this.loginProcura.Width = 190;
            // 
            // senhaProcura
            // 
            this.senhaProcura.DataPropertyName = "SENHA_USUARIO";
            this.senhaProcura.HeaderText = "Senha";
            this.senhaProcura.MinimumWidth = 6;
            this.senhaProcura.Name = "senhaProcura";
            this.senhaProcura.ReadOnly = true;
            this.senhaProcura.Visible = false;
            this.senhaProcura.Width = 125;
            // 
            // statusProcura
            // 
            this.statusProcura.DataPropertyName = "STATUS_USUARIO";
            this.statusProcura.HeaderText = "Status";
            this.statusProcura.MinimumWidth = 6;
            this.statusProcura.Name = "statusProcura";
            this.statusProcura.ReadOnly = true;
            this.statusProcura.Width = 120;
            // 
            // codnivelProcura
            // 
            this.codnivelProcura.DataPropertyName = "ID_NIVEL";
            this.codnivelProcura.HeaderText = "Código Nivel";
            this.codnivelProcura.MinimumWidth = 6;
            this.codnivelProcura.Name = "codnivelProcura";
            this.codnivelProcura.ReadOnly = true;
            this.codnivelProcura.Visible = false;
            this.codnivelProcura.Width = 125;
            // 
            // nomenivelProcura
            // 
            this.nomenivelProcura.DataPropertyName = "NOME_NIVEL";
            this.nomenivelProcura.HeaderText = "Nível";
            this.nomenivelProcura.MinimumWidth = 6;
            this.nomenivelProcura.Name = "nomenivelProcura";
            this.nomenivelProcura.ReadOnly = true;
            this.nomenivelProcura.Width = 150;
            // 
            // codNivelUsuario
            // 
            this.codNivelUsuario.DataPropertyName = "ID_NIVEL";
            this.codNivelUsuario.HeaderText = "Código";
            this.codNivelUsuario.MinimumWidth = 6;
            this.codNivelUsuario.Name = "codNivelUsuario";
            this.codNivelUsuario.ReadOnly = true;
            this.codNivelUsuario.Width = 80;
            // 
            // nomeNivelUsuario
            // 
            this.nomeNivelUsuario.DataPropertyName = "NOME_NIVEL";
            this.nomeNivelUsuario.HeaderText = "Nome";
            this.nomeNivelUsuario.MinimumWidth = 6;
            this.nomeNivelUsuario.Name = "nomeNivelUsuario";
            this.nomeNivelUsuario.ReadOnly = true;
            this.nomeNivelUsuario.Width = 225;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "DESCRICAO_NIVEL";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 475;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 732);
            this.Controls.Add(this.tbcUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Usuários";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnUsuarios)).EndInit();
            this.bdnUsuarios.ResumeLayout(false);
            this.bdnUsuarios.PerformLayout();
            this.tbcUsuarios.ResumeLayout(false);
            this.tbpProcura.ResumeLayout(false);
            this.tbpProcura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.tbpNiveis.ResumeLayout(false);
            this.tbpNiveis.PerformLayout();
            this.gpbNiveis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNivelUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNiveis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bdnUsuarios;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabControl tbcUsuarios;
        private System.Windows.Forms.TabPage tbpProcura;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.ComboBox cboOrdenar;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtReeSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabPage tbpNiveis;
        private System.Windows.Forms.GroupBox gpbNiveis;
        private System.Windows.Forms.Button btnFormNiveis;
        private System.Windows.Forms.DataGridView dtgNivelUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodNivel;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.BindingSource bdsUsuarios;
        private System.Windows.Forms.BindingSource bdsNiveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn codnivelProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomenivelProcura;
        private System.Windows.Forms.DataGridViewTextBoxColumn codNivelUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeNivelUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}