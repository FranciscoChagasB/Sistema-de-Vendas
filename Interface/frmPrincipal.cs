using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes formClientes = new frmClientes();
            formClientes.ShowDialog();
        }

        private void mstripClientes_Click(object sender, EventArgs e)
        {
            frmClientes formClientes = new frmClientes();
            formClientes.ShowDialog();
        }
    }
}
