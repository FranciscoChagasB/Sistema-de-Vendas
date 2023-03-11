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
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.bdnClientes = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tbcClientes = new System.Windows.Forms.TabControl();
            this.tbpProcura = new System.Windows.Forms.TabPage();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnClientes)).BeginInit();
            this.bdnClientes.SuspendLayout();
            this.tbcClientes.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 595);
            this.panel1.TabIndex = 0;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjuda.Image = global::Interface.Properties.Resources.ajuda;
            this.btnAjuda.Location = new System.Drawing.Point(0, 473);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(148, 60);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.Image = global::Interface.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(0, 533);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(148, 60);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.Image = global::Interface.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(0, 120);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(148, 60);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir Cliente";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlterar.Image = global::Interface.Properties.Resources.editar;
            this.btnAlterar.Location = new System.Drawing.Point(0, 60);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(148, 60);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar Cliente";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.Image = global::Interface.Properties.Resources.adicionar;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 60);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo Cliente";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // bdnClientes
            // 
            this.bdnClientes.AddNewItem = null;
            this.bdnClientes.CountItem = null;
            this.bdnClientes.DeleteItem = null;
            this.bdnClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bdnClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bdnClientes.Location = new System.Drawing.Point(0, 448);
            this.bdnClientes.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnClientes.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnClientes.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnClientes.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnClientes.Name = "bdnClientes";
            this.bdnClientes.PositionItem = null;
            this.bdnClientes.Size = new System.Drawing.Size(148, 25);
            this.bdnClientes.TabIndex = 5;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // tbcClientes
            // 
            this.tbcClientes.Controls.Add(this.tbpProcura);
            this.tbcClientes.Controls.Add(this.tbpCadastro);
            this.tbcClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcClientes.Location = new System.Drawing.Point(150, 0);
            this.tbcClientes.Name = "tbcClientes";
            this.tbcClientes.SelectedIndex = 0;
            this.tbcClientes.Size = new System.Drawing.Size(962, 595);
            this.tbcClientes.TabIndex = 1;
            // 
            // tbpProcura
            // 
            this.tbpProcura.Location = new System.Drawing.Point(4, 22);
            this.tbpProcura.Name = "tbpProcura";
            this.tbpProcura.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProcura.Size = new System.Drawing.Size(954, 569);
            this.tbpProcura.TabIndex = 0;
            this.tbpProcura.Text = "Procura";
            this.tbpProcura.UseVisualStyleBackColor = true;
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(954, 569);
            this.tbpCadastro.TabIndex = 1;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1112, 595);
            this.Controls.Add(this.tbcClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnClientes)).EndInit();
            this.bdnClientes.ResumeLayout(false);
            this.bdnClientes.PerformLayout();
            this.tbcClientes.ResumeLayout(false);
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
    }
}