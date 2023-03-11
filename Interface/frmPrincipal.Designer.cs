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
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpageClientes = new System.Windows.Forms.TabPage();
            this.tstripClientes = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mstripPrincipal.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tbpageClientes.SuspendLayout();
            this.tstripClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstripPrincipal
            // 
            this.mstripPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.mstripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes});
            this.mstripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstripPrincipal.Name = "mstripPrincipal";
            this.mstripPrincipal.Size = new System.Drawing.Size(1264, 24);
            this.mstripPrincipal.TabIndex = 0;
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripClientes});
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmiClientes.Text = "Clientes";
            // 
            // mstripClientes
            // 
            this.mstripClientes.Name = "mstripClientes";
            this.mstripClientes.Size = new System.Drawing.Size(180, 22);
            this.mstripClientes.Text = "Clientes";
            this.mstripClientes.Click += new System.EventHandler(this.mstripClientes_Click);
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpageClientes);
            this.tbcPrincipal.Controls.Add(this.tabPage2);
            this.tbcPrincipal.Location = new System.Drawing.Point(2, 27);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1262, 100);
            this.tbcPrincipal.TabIndex = 1;
            // 
            // tbpageClientes
            // 
            this.tbpageClientes.Controls.Add(this.tstripClientes);
            this.tbpageClientes.Location = new System.Drawing.Point(4, 22);
            this.tbpageClientes.Name = "tbpageClientes";
            this.tbpageClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageClientes.Size = new System.Drawing.Size(1254, 74);
            this.tbpageClientes.TabIndex = 0;
            this.tbpageClientes.Text = "Clientes";
            this.tbpageClientes.UseVisualStyleBackColor = true;
            // 
            // tstripClientes
            // 
            this.tstripClientes.AutoSize = false;
            this.tstripClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnClientes,
            this.toolStripSeparator2});
            this.tstripClientes.Location = new System.Drawing.Point(3, 3);
            this.tstripClientes.Name = "tstripClientes";
            this.tstripClientes.Size = new System.Drawing.Size(1248, 68);
            this.tstripClientes.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 68);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Interface.Properties.Resources.clientes;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(101, 65);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 68);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.mstripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstripPrincipal;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem mstripClientes;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpageClientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip tstripClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

