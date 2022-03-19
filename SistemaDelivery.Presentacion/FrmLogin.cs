using SistemaDelivery.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDelivery.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = UsuarioNegocio.loguear(txtId.Text, txtPassword.Text);
            if(tabla.Rows.Count <= 0)
            {
                MessageBox.Show("El usuario no existe en la base datos");
            }
            else
            {
                if(Convert.ToString(tabla.Rows[0][3]) == "I")
                {
                    MessageBox.Show("El usuario esta inactivo");
                }
                else
                {
                    MessageBox.Show("Bienvenido " + tabla.Rows[0][1]);
                    MDIPrincipal mdiPrincipal = new MDIPrincipal();
                    mdiPrincipal.Show();
                    this.Hide();
                }
               
            }
        }
    }
}
