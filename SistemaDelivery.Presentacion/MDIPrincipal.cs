using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDelivery.Presentacion {
    public partial class MDIPrincipal : Form {
        //private int childFormNumber = 0;

        public MDIPrincipal() {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.MdiParent = this;
            frmEmpleado.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void platoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmPlato frmPlato = new FrmPlato();
            frmPlato.MdiParent = this;
            frmPlato.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
