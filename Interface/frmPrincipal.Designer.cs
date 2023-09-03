namespace Interface
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mstripPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripNíveis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpageClientes = new System.Windows.Forms.TabPage();
            this.tstripClientes = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbpageUsuarios = new System.Windows.Forms.TabPage();
            this.tstripUsuarios = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbpageFuncionarios = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tbpageProdutos = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.btnNiveis = new System.Windows.Forms.ToolStripButton();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripButton();
            this.btnProdutos = new System.Windows.Forms.ToolStripButton();
            this.btnUnidade = new System.Windows.Forms.ToolStripButton();
            this.btnCategoria = new System.Windows.Forms.ToolStripButton();
            this.mstripPrincipal.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tbpageClientes.SuspendLayout();
            this.tstripClientes.SuspendLayout();
            this.tbpageUsuarios.SuspendLayout();
            this.tstripUsuarios.SuspendLayout();
            this.tbpageFuncionarios.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbpageProdutos.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstripPrincipal
            // 
            this.mstripPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.mstripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiUsuarios,
            this.tsmiFuncionarios,
            this.tsmiProdutos});
            this.mstripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstripPrincipal.Name = "mstripPrincipal";
            this.mstripPrincipal.Size = new System.Drawing.Size(1685, 28);
            this.mstripPrincipal.TabIndex = 0;
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripClientes});
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(75, 24);
            this.tsmiClientes.Text = "Clientes";
            // 
            // mstripClientes
            // 
            this.mstripClientes.Name = "mstripClientes";
            this.mstripClientes.Size = new System.Drawing.Size(144, 26);
            this.mstripClientes.Text = "Clientes";
            this.mstripClientes.Click += new System.EventHandler(this.mstripClientes_Click);
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripUsuarios,
            this.mstripNíveis});
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(79, 24);
            this.tsmiUsuarios.Text = "Usuários";
            // 
            // mstripUsuarios
            // 
            this.mstripUsuarios.Name = "mstripUsuarios";
            this.mstripUsuarios.Size = new System.Drawing.Size(213, 26);
            this.mstripUsuarios.Text = "Usuários";
            this.mstripUsuarios.Click += new System.EventHandler(this.mstripUsuarios_Click);
            // 
            // mstripNíveis
            // 
            this.mstripNíveis.Name = "mstripNíveis";
            this.mstripNíveis.Size = new System.Drawing.Size(213, 26);
            this.mstripNíveis.Text = "Níveis de Usuários";
            this.mstripNíveis.Click += new System.EventHandler(this.mstripNíveis_Click);
            // 
            // tsmiFuncionarios
            // 
            this.tsmiFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripFuncionarios});
            this.tsmiFuncionarios.Name = "tsmiFuncionarios";
            this.tsmiFuncionarios.Size = new System.Drawing.Size(106, 24);
            this.tsmiFuncionarios.Text = "Funcionários";
            // 
            // mstripFuncionarios
            // 
            this.mstripFuncionarios.Name = "mstripFuncionarios";
            this.mstripFuncionarios.Size = new System.Drawing.Size(224, 26);
            this.mstripFuncionarios.Text = "Funcionários";
            this.mstripFuncionarios.Click += new System.EventHandler(this.mstripFuncionarios_Click);
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpageClientes);
            this.tbcPrincipal.Controls.Add(this.tbpageUsuarios);
            this.tbcPrincipal.Controls.Add(this.tbpageFuncionarios);
            this.tbcPrincipal.Controls.Add(this.tbpageProdutos);
            this.tbcPrincipal.Location = new System.Drawing.Point(3, 33);
            this.tbcPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1683, 123);
            this.tbcPrincipal.TabIndex = 1;
            // 
            // tbpageClientes
            // 
            this.tbpageClientes.Controls.Add(this.tstripClientes);
            this.tbpageClientes.Location = new System.Drawing.Point(4, 25);
            this.tbpageClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tbpageClientes.Name = "tbpageClientes";
            this.tbpageClientes.Padding = new System.Windows.Forms.Padding(4);
            this.tbpageClientes.Size = new System.Drawing.Size(1675, 94);
            this.tbpageClientes.TabIndex = 0;
            this.tbpageClientes.Text = "Clientes";
            this.tbpageClientes.UseVisualStyleBackColor = true;
            // 
            // tstripClientes
            // 
            this.tstripClientes.AutoSize = false;
            this.tstripClientes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tstripClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnClientes,
            this.toolStripSeparator2});
            this.tstripClientes.Location = new System.Drawing.Point(4, 4);
            this.tstripClientes.Name = "tstripClientes";
            this.tstripClientes.Size = new System.Drawing.Size(1667, 84);
            this.tstripClientes.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 84);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 84);
            // 
            // tbpageUsuarios
            // 
            this.tbpageUsuarios.Controls.Add(this.tstripUsuarios);
            this.tbpageUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tbpageUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.tbpageUsuarios.Name = "tbpageUsuarios";
            this.tbpageUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.tbpageUsuarios.Size = new System.Drawing.Size(1675, 94);
            this.tbpageUsuarios.TabIndex = 1;
            this.tbpageUsuarios.Text = "Usuários";
            this.tbpageUsuarios.UseVisualStyleBackColor = true;
            // 
            // tstripUsuarios
            // 
            this.tstripUsuarios.AutoSize = false;
            this.tstripUsuarios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tstripUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.btnUsuarios,
            this.toolStripSeparator4,
            this.btnNiveis,
            this.toolStripSeparator5});
            this.tstripUsuarios.Location = new System.Drawing.Point(4, 4);
            this.tstripUsuarios.Name = "tstripUsuarios";
            this.tstripUsuarios.Size = new System.Drawing.Size(1667, 84);
            this.tstripUsuarios.TabIndex = 1;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 84);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 84);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 84);
            // 
            // tbpageFuncionarios
            // 
            this.tbpageFuncionarios.Controls.Add(this.toolStrip1);
            this.tbpageFuncionarios.Location = new System.Drawing.Point(4, 25);
            this.tbpageFuncionarios.Name = "tbpageFuncionarios";
            this.tbpageFuncionarios.Size = new System.Drawing.Size(1675, 94);
            this.tbpageFuncionarios.TabIndex = 2;
            this.tbpageFuncionarios.Text = "Funcionários";
            this.tbpageFuncionarios.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.btnFuncionarios,
            this.toolStripSeparator7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1675, 84);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 84);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 84);
            // 
            // tsmiProdutos
            // 
            this.tsmiProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripProdutos,
            this.mstripUnidades,
            this.mstripCategorias});
            this.tsmiProdutos.Name = "tsmiProdutos";
            this.tsmiProdutos.Size = new System.Drawing.Size(82, 24);
            this.tsmiProdutos.Text = "Produtos";
            // 
            // mstripProdutos
            // 
            this.mstripProdutos.Name = "mstripProdutos";
            this.mstripProdutos.Size = new System.Drawing.Size(224, 26);
            this.mstripProdutos.Text = "Produtos";
            this.mstripProdutos.Click += new System.EventHandler(this.mstripProdutos_Click);
            // 
            // mstripUnidades
            // 
            this.mstripUnidades.Name = "mstripUnidades";
            this.mstripUnidades.Size = new System.Drawing.Size(224, 26);
            this.mstripUnidades.Text = "Unidades";
            this.mstripUnidades.Click += new System.EventHandler(this.mstripUnidades_Click);
            // 
            // mstripCategorias
            // 
            this.mstripCategorias.Name = "mstripCategorias";
            this.mstripCategorias.Size = new System.Drawing.Size(224, 26);
            this.mstripCategorias.Text = "Categorias";
            this.mstripCategorias.Click += new System.EventHandler(this.mstripCategorias_Click);
            // 
            // tbpageProdutos
            // 
            this.tbpageProdutos.Controls.Add(this.toolStrip2);
            this.tbpageProdutos.Location = new System.Drawing.Point(4, 25);
            this.tbpageProdutos.Name = "tbpageProdutos";
            this.tbpageProdutos.Size = new System.Drawing.Size(1675, 94);
            this.tbpageProdutos.TabIndex = 3;
            this.tbpageProdutos.Text = "Produtos";
            this.tbpageProdutos.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.btnProdutos,
            this.toolStripSeparator9,
            this.btnUnidade,
            this.toolStripSeparator10,
            this.btnCategoria});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1675, 84);
            this.toolStrip2.TabIndex = 2;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 84);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 84);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 84);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Interface.Properties.Resources.clientes;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(113, 81);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = global::Interface.Properties.Resources.user_img;
            this.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(117, 81);
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnNiveis
            // 
            this.btnNiveis.Image = global::Interface.Properties.Resources.niveis_img;
            this.btnNiveis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNiveis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNiveis.Name = "btnNiveis";
            this.btnNiveis.Size = new System.Drawing.Size(101, 81);
            this.btnNiveis.Text = "Níveis";
            this.btnNiveis.Click += new System.EventHandler(this.btnNiveis_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Image = global::Interface.Properties.Resources.funcionarios;
            this.btnFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(144, 81);
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Image = global::Interface.Properties.Resources.produtos;
            this.btnProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(120, 81);
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnUnidade
            // 
            this.btnUnidade.Image = global::Interface.Properties.Resources.unidade;
            this.btnUnidade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUnidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnidade.Name = "btnUnidade";
            this.btnUnidade.Size = new System.Drawing.Size(117, 81);
            this.btnUnidade.Text = "Unidade";
            this.btnUnidade.Click += new System.EventHandler(this.btnUnidade_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Image = global::Interface.Properties.Resources.categorias;
            this.btnCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(126, 81);
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.mstripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas";
            this.mstripPrincipal.ResumeLayout(false);
            this.mstripPrincipal.PerformLayout();
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpageClientes.ResumeLayout(false);
            this.tstripClientes.ResumeLayout(false);
            this.tstripClientes.PerformLayout();
            this.tbpageUsuarios.ResumeLayout(false);
            this.tstripUsuarios.ResumeLayout(false);
            this.tstripUsuarios.PerformLayout();
            this.tbpageFuncionarios.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbpageProdutos.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem mstripClientes;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpageClientes;
        private System.Windows.Forms.TabPage tbpageUsuarios;
        private System.Windows.Forms.ToolStrip tstripClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mstripUsuarios;
        private System.Windows.Forms.ToolStrip tstripUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnNiveis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mstripNíveis;
        private System.Windows.Forms.ToolStripMenuItem tsmiFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mstripFuncionarios;
        private System.Windows.Forms.TabPage tbpageFuncionarios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnFuncionarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsmiProdutos;
        private System.Windows.Forms.ToolStripMenuItem mstripProdutos;
        private System.Windows.Forms.ToolStripMenuItem mstripUnidades;
        private System.Windows.Forms.ToolStripMenuItem mstripCategorias;
        private System.Windows.Forms.TabPage tbpageProdutos;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnUnidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnCategoria;
    }
}

