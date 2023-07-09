using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnFormCategorias_Click(object sender, EventArgs e)
        {
            frmCategoria formCategoria = new frmCategoria();
            formCategoria.ShowDialog();
        }
    }
}
