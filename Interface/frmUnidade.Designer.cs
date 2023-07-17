namespace Interface
{
    partial class frmUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnidade));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bdnUnidade = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dtgUnidade = new System.Windows.Forms.DataGridView();
            this.ID_UNIDADE_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_UNIDADE_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_UNIDADE_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.bdsUnidade = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnUnidade)).BeginInit();
            this.bdnUnidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUnidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bdnUnidade);
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
            this.panel1.TabIndex = 7;
            // 
            // bdnUnidade
            // 
            this.bdnUnidade.AddNewItem = null;
            this.bdnUnidade.CountItem = null;
            this.bdnUnidade.DeleteItem = null;
            this.bdnUnidade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnUnidade.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnUnidade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.separator1,
            this.bindingNavigatorMovePreviousItem,
            this.separator2,
            this.bindingNavigatorMoveNextItem,
            this.separator3,
            this.bindingNavigatorMoveLastItem});
            this.bdnUnidade.Location = new System.Drawing.Point(0, 335);
            this.bdnUnidade.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnUnidade.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnUnidade.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnUnidade.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnUnidade.Name = "bdnUnidade";
            this.bdnUnidade.PositionItem = null;
            this.bdnUnidade.Size = new System.Drawing.Size(260, 27);
            this.bdnUnidade.TabIndex = 7;
            this.bdnUnidade.Text = "bindingNavigator1";
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
            this.btnExcluir.Text = "Excluir Unidade";
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
            this.btnAlterar.Text = "Alterar Unidade";
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
            this.btnNovo.Text = "Nova Unidade";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtgUnidade
            // 
            this.dtgUnidade.AllowUserToAddRows = false;
            this.dtgUnidade.AllowUserToDeleteRows = false;
            this.dtgUnidade.AllowUserToResizeColumns = false;
            this.dtgUnidade.AllowUserToResizeRows = false;
            this.dtgUnidade.BackgroundColor = System.Drawing.Color.White;
            this.dtgUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUnidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_UNIDADE_PRODUTOS,
            this.NOME_UNIDADE_PRODUTOS,
            this.DESCRICAO_UNIDADE_PRODUTOS});
            this.dtgUnidade.Location = new System.Drawing.Point(278, 249);
            this.dtgUnidade.Margin = new System.Windows.Forms.Padding(5);
            this.dtgUnidade.Name = "dtgUnidade";
            this.dtgUnidade.ReadOnly = true;
            this.dtgUnidade.RowHeadersWidth = 51;
            this.dtgUnidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUnidade.Size = new System.Drawing.Size(812, 276);
            this.dtgUnidade.TabIndex = 245;
            // 
            // ID_UNIDADE_PRODUTOS
            // 
            this.ID_UNIDADE_PRODUTOS.DataPropertyName = "ID_UNIDADE_PRODUTOS";
            this.ID_UNIDADE_PRODUTOS.HeaderText = "Código";
            this.ID_UNIDADE_PRODUTOS.MinimumWidth = 6;
            this.ID_UNIDADE_PRODUTOS.Name = "ID_UNIDADE_PRODUTOS";
            this.ID_UNIDADE_PRODUTOS.ReadOnly = true;
            this.ID_UNIDADE_PRODUTOS.Width = 65;
            // 
            // NOME_UNIDADE_PRODUTOS
            // 
            this.NOME_UNIDADE_PRODUTOS.DataPropertyName = "NOME_UNIDADE_PRODUTOS";
            this.NOME_UNIDADE_PRODUTOS.HeaderText = "Nome";
            this.NOME_UNIDADE_PRODUTOS.MinimumWidth = 6;
            this.NOME_UNIDADE_PRODUTOS.Name = "NOME_UNIDADE_PRODUTOS";
            this.NOME_UNIDADE_PRODUTOS.ReadOnly = true;
            this.NOME_UNIDADE_PRODUTOS.Width = 250;
            // 
            // DESCRICAO_UNIDADE_PRODUTOS
            // 
            this.DESCRICAO_UNIDADE_PRODUTOS.DataPropertyName = "DESCRICAO_UNIDADE_PRODUTOS";
            this.DESCRICAO_UNIDADE_PRODUTOS.HeaderText = "Descrição";
            this.DESCRICAO_UNIDADE_PRODUTOS.MinimumWidth = 6;
            this.DESCRICAO_UNIDADE_PRODUTOS.Name = "DESCRICAO_UNIDADE_PRODUTOS";
            this.DESCRICAO_UNIDADE_PRODUTOS.ReadOnly = true;
            this.DESCRICAO_UNIDADE_PRODUTOS.Width = 440;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(1107, 175);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(265, 38);
            this.btnLimpar.TabIndex = 243;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(1107, 122);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(265, 38);
            this.btnSalvar.TabIndex = 244;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDescricao.Location = new System.Drawing.Point(278, 108);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescricao.MaxLength = 500;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(815, 127);
            this.txtDescricao.TabIndex = 237;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 242;
            this.label3.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(523, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(569, 29);
            this.txtNome.TabIndex = 241;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 240;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 238;
            this.label1.Text = "Registro:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(278, 34);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(5);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(157, 29);
            this.txtRegistro.TabIndex = 239;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.Text = "0";
            // 
            // frmUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 546);
            this.Controls.Add(this.dtgUnidade);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Unidades";
            this.Load += new System.EventHandler(this.frmUnidade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnUnidade)).EndInit();
            this.bdnUnidade.ResumeLayout(false);
            this.bdnUnidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUnidade)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgUnidade;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.BindingNavigator bdnUnidade;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource bdsUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_UNIDADE_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_UNIDADE_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_UNIDADE_PRODUTOS;
    }
}