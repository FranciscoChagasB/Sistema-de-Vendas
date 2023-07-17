namespace Interface
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.bdnCategorias = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bdsCategorias = new System.Windows.Forms.BindingSource(this.components);
            this.ID_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnCategorias)).BeginInit();
            this.bdnCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bdnCategorias);
            this.panel1.Controls.Add(this.btnAjuda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 546);
            this.panel1.TabIndex = 6;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjuda.Image = global::Interface.Properties.Resources.ajuda;
            this.btnAjuda.Location = new System.Drawing.Point(0, 362);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(5);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(260, 91);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.Image = global::Interface.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(0, 453);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(260, 91);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.Image = global::Interface.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(0, 182);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(260, 91);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir Categoria";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlterar.Image = global::Interface.Properties.Resources.editar;
            this.btnAlterar.Location = new System.Drawing.Point(0, 91);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(260, 91);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar Categoria";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.Image = global::Interface.Properties.Resources.adicionar;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(260, 91);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Nova Categoria";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.AllowUserToAddRows = false;
            this.dtgCategorias.AllowUserToDeleteRows = false;
            this.dtgCategorias.AllowUserToResizeColumns = false;
            this.dtgCategorias.AllowUserToResizeRows = false;
            this.dtgCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CATEGORIA_PRODUTOS,
            this.NOME_CATEGORIA_PRODUTOS,
            this.DESCRICAO_CATEGORIA_PRODUTOS});
            this.dtgCategorias.Location = new System.Drawing.Point(279, 251);
            this.dtgCategorias.Margin = new System.Windows.Forms.Padding(5);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.ReadOnly = true;
            this.dtgCategorias.RowHeadersWidth = 51;
            this.dtgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategorias.Size = new System.Drawing.Size(812, 276);
            this.dtgCategorias.TabIndex = 236;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(1108, 177);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(265, 38);
            this.btnLimpar.TabIndex = 234;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(1108, 124);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(265, 38);
            this.btnSalvar.TabIndex = 235;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDescricao.Location = new System.Drawing.Point(279, 110);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescricao.MaxLength = 500;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(815, 127);
            this.txtDescricao.TabIndex = 228;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 233;
            this.label3.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(524, 36);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(569, 29);
            this.txtNome.TabIndex = 232;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 231;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(273, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 229;
            this.label1.Text = "Registro:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(279, 36);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(5);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(157, 29);
            this.txtRegistro.TabIndex = 230;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.Text = "0";
            // 
            // bdnCategorias
            // 
            this.bdnCategorias.AddNewItem = null;
            this.bdnCategorias.CountItem = null;
            this.bdnCategorias.DeleteItem = null;
            this.bdnCategorias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnCategorias.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.separator1,
            this.bindingNavigatorMovePreviousItem,
            this.separator2,
            this.bindingNavigatorMoveNextItem,
            this.separator3,
            this.bindingNavigatorMoveLastItem});
            this.bdnCategorias.Location = new System.Drawing.Point(0, 335);
            this.bdnCategorias.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnCategorias.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnCategorias.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnCategorias.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnCategorias.Name = "bdnCategorias";
            this.bdnCategorias.PositionItem = null;
            this.bdnCategorias.Size = new System.Drawing.Size(260, 27);
            this.bdnCategorias.TabIndex = 7;
            this.bdnCategorias.Text = "bindingNavigator1";
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
            // ID_CATEGORIA_PRODUTOS
            // 
            this.ID_CATEGORIA_PRODUTOS.DataPropertyName = "ID_CATEGORIA_PRODUTOS";
            this.ID_CATEGORIA_PRODUTOS.HeaderText = "Código";
            this.ID_CATEGORIA_PRODUTOS.MinimumWidth = 6;
            this.ID_CATEGORIA_PRODUTOS.Name = "ID_CATEGORIA_PRODUTOS";
            this.ID_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.ID_CATEGORIA_PRODUTOS.Width = 65;
            // 
            // NOME_CATEGORIA_PRODUTOS
            // 
            this.NOME_CATEGORIA_PRODUTOS.DataPropertyName = "NOME_CATEGORIA_PRODUTOS";
            this.NOME_CATEGORIA_PRODUTOS.HeaderText = "Nome";
            this.NOME_CATEGORIA_PRODUTOS.MinimumWidth = 6;
            this.NOME_CATEGORIA_PRODUTOS.Name = "NOME_CATEGORIA_PRODUTOS";
            this.NOME_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.NOME_CATEGORIA_PRODUTOS.Width = 250;
            // 
            // DESCRICAO_CATEGORIA_PRODUTOS
            // 
            this.DESCRICAO_CATEGORIA_PRODUTOS.DataPropertyName = "DESCRICAO_CATEGORIA_PRODUTOS";
            this.DESCRICAO_CATEGORIA_PRODUTOS.HeaderText = "Descrição";
            this.DESCRICAO_CATEGORIA_PRODUTOS.MinimumWidth = 6;
            this.DESCRICAO_CATEGORIA_PRODUTOS.Name = "DESCRICAO_CATEGORIA_PRODUTOS";
            this.DESCRICAO_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.DESCRICAO_CATEGORIA_PRODUTOS.Width = 440;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 546);
            this.Controls.Add(this.dtgCategorias);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnCategorias)).EndInit();
            this.bdnCategorias.ResumeLayout(false);
            this.bdnCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgCategorias;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.BindingNavigator bdnCategorias;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource bdsCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CATEGORIA_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CATEGORIA_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_CATEGORIA_PRODUTOS;
    }
}