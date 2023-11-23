namespace Interface
{
    partial class frmFinVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinVenda));
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
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntFin
            // 
            this.bntFin.BackColor = System.Drawing.Color.LimeGreen;
            this.bntFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntFin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntFin.Location = new System.Drawing.Point(460, 482);
            this.bntFin.Margin = new System.Windows.Forms.Padding(4);
            this.bntFin.Name = "bntFin";
            this.bntFin.Size = new System.Drawing.Size(314, 49);
            this.bntFin.TabIndex = 130;
            this.bntFin.Text = "Finalizar";
            this.bntFin.UseVisualStyleBackColor = false;
            this.bntFin.Click += new System.EventHandler(this.bntFin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(22, 482);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(314, 49);
            this.btnCancel.TabIndex = 129;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightYellow;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ltCupomFiscal);
            this.panel2.Location = new System.Drawing.Point(792, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 687);
            this.panel2.TabIndex = 128;
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
            this.chkAcrescimo.Location = new System.Drawing.Point(22, 237);
            this.chkAcrescimo.Margin = new System.Windows.Forms.Padding(4);
            this.chkAcrescimo.Name = "chkAcrescimo";
            this.chkAcrescimo.Size = new System.Drawing.Size(115, 23);
            this.chkAcrescimo.TabIndex = 127;
            this.chkAcrescimo.Text = "Acréscimo(%):";
            this.chkAcrescimo.UseVisualStyleBackColor = true;
            this.chkAcrescimo.CheckedChanged += new System.EventHandler(this.chkAcrescimo_CheckedChanged);
            // 
            // chkDesconto
            // 
            this.chkDesconto.AutoSize = true;
            this.chkDesconto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesconto.Location = new System.Drawing.Point(22, 281);
            this.chkDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.chkDesconto.Name = "chkDesconto";
            this.chkDesconto.Size = new System.Drawing.Size(119, 23);
            this.chkDesconto.TabIndex = 126;
            this.chkDesconto.Text = "Desconto  (%):";
            this.chkDesconto.UseVisualStyleBackColor = true;
            this.chkDesconto.CheckedChanged += new System.EventHandler(this.chkDesconto_CheckedChanged);
            // 
            // cboPagamento
            // 
            this.cboPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPagamento.FormattingEnabled = true;
            this.cboPagamento.Items.AddRange(new object[] {
            "Dinheiro"});
            this.cboPagamento.Location = new System.Drawing.Point(186, 184);
            this.cboPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.cboPagamento.Name = "cboPagamento";
            this.cboPagamento.Size = new System.Drawing.Size(460, 29);
            this.cboPagamento.TabIndex = 113;
            // 
            // txtTroco
            // 
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(186, 405);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(460, 29);
            this.txtTroco.TabIndex = 123;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcrescimo.Enabled = false;
            this.txtAcrescimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcrescimo.Location = new System.Drawing.Point(186, 231);
            this.txtAcrescimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(460, 29);
            this.txtAcrescimo.TabIndex = 114;
            this.txtAcrescimo.Text = "0";
            this.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAcrescimo.Leave += new System.EventHandler(this.txtAcrescimo_Leave);
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(186, 275);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(460, 29);
            this.txtDesconto.TabIndex = 115;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 118;
            this.label6.Text = "Troco:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Honeydew;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotal.Location = new System.Drawing.Point(186, 319);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(460, 29);
            this.txtTotal.TabIndex = 124;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtSubTotal.Location = new System.Drawing.Point(186, 134);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(460, 29);
            this.txtSubTotal.TabIndex = 125;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 373);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 119;
            this.label8.Text = "Valor pago:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 120;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 19);
            this.label10.TabIndex = 121;
            this.label10.Text = "Forma de pagamento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 122;
            this.label11.Text = "SubTotal:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(186, 363);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(460, 29);
            this.txtValorPago.TabIndex = 116;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPago.Enter += new System.EventHandler(this.txtValorPago_Enter);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 97);
            this.panel3.TabIndex = 117;
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
            // frmFinVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 724);
            this.Controls.Add(this.bntFin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkAcrescimo);
            this.Controls.Add(this.chkDesconto);
            this.Controls.Add(this.cboPagamento);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtAcrescimo);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFinVenda";
            this.Text = "Finalizar Venda";
            this.Load += new System.EventHandler(this.frmFinVenda_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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