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

namespace SistemaDelivery.Presentacion {
    public partial class FrmCliente : Form {
        public FrmCliente() {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void listarClientes() {
            try {
                dgvCliente.DataSource = ClienteNegocio.listar();
                this.limpiar();
                lblTotalClientes.Text = "Total de Registros: " + Convert.ToString(dgvCliente.Rows.Count);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiar() {
            txtId.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtBuscar.Clear();
        }

        private void FrmCliente_Load(object sender, EventArgs e) {
            this.listarClientes();
        }

        private void textBoxSoloLectura(bool nombre, bool apellidos, bool direccion, bool telefono) {
            txtNombre.ReadOnly = nombre;
            txtApellidos.ReadOnly = apellidos;
            txtDireccion.ReadOnly = direccion;
            txtTelefono.ReadOnly = telefono;
        }

        private void habilitarBotones(bool nuevo, bool actualizar, bool cancelar, bool grabar, bool modificar) {
            btnNuevo.Enabled = nuevo;
            btnActualizar.Visible = actualizar;
            btnCancelar.Visible = cancelar;
            btnGrabar.Visible = grabar;
            btnModificar.Enabled = modificar;
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            this.limpiar();
            this.textBoxSoloLectura(false, false, false, false);
            this.habilitarBotones(false, false, true, true, false);
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.limpiar();
            this.textBoxSoloLectura(true, true, true, true);
            this.habilitarBotones(true, false, false, false, true);
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            this.textBoxSoloLectura(false, false, false, false);
            this.habilitarBotones(false, true, true, false, false);
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e) {
            if (chkSeleccionar.Checked) {
                dgvCliente.Columns[0].Visible = true;
                btnEliminar.Visible = true;
            }
            else {
                dgvCliente.Columns[0].Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            try {
                DialogResult opcion;
                int contador = 0;
                bool correcto = true;
                opcion = MessageBox.Show("Está seguro que desea eliminar?", "Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK) {
                    int codigo;
                    string respuesta;
                    foreach (DataGridViewRow row in dgvCliente.Rows) {
                        if (Convert.ToBoolean(row.Cells[0].Value)) {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = ClienteNegocio.eliminar(codigo);
                            if (respuesta == "OK. Registro Eliminado") {
                                contador++;
                            }
                            else {
                                correcto = false;
                            }
                        }
                    }
                    if (correcto) {
                        this.mensajeCorrecto("Se eliminaron " + contador + " cliente(s)..");
                        chkSeleccionar.Checked = false;
                        this.listarClientes();
                    }
                    else {
                        this.mensajeError("Ocurrió un error inesperado");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void mensajeCorrecto(string mensaje) {
            MessageBox.Show(mensaje, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje) {
            MessageBox.Show(mensaje, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGrabar_Click(object sender, EventArgs e) {
            try {
                string rpta = "";
                if (this.datosClienteVacios()) {
                    this.mensajeError("Falta completar datos de los campos");
                }
                else {
                    rpta = ClienteNegocio.insertar(txtNombre.Text.Trim().ToUpper(), txtApellidos.Text.Trim().ToUpper(), txtDireccion.Text.Trim().ToUpper(), txtTelefono.Text);
                    if (rpta.Equals("OK")) {
                        this.mensajeCorrecto("Se realizó la inserción correctamente");
                        this.limpiar();
                        this.listarClientes();
                    }
                    else {
                        this.mensajeError(rpta);
                    }
                    this.habilitarBotones(true, false, false, false, true);
                    this.textBoxSoloLectura(true, true, true, true);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private bool datosClienteVacios() {
            foreach(Control txt in pnlDatosCliente.Controls) {
                if (txt is TextBox && string.IsNullOrWhiteSpace(txt.Text)) {
                    return true;
                }
            }
            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            this.buscarCliente();
        }

        private void buscarCliente() {
            try {
                dgvCliente.DataSource = ClienteNegocio.buscar(txtBuscar.Text);
                lblTotalClientes.Text = "Total de Registros: " + Convert.ToString(dgvCliente.Rows.Count);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            this.actualizarCliente();
        }

        private void actualizarCliente() {
            try {
                string rpta = "";
                if (this.datosClienteVacios()) {
                    this.mensajeError("Falta completar datos de los campos");
                }
                else {
                    rpta = ClienteNegocio.actualizar(int.Parse(txtId.Text), txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text);
                    if (rpta.Equals("OK. Registro Actualizado")) {
                        this.mensajeCorrecto("Se realizó la modificación correctamente");
                        this.limpiar();
                        this.listarClientes();
                    }
                    else {
                        this.mensajeError(rpta);
                    }
                    this.habilitarBotones(true, false, false, false, true);
                    this.textBoxSoloLectura(true, true, true, true);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                txtId.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[1].Value);
                txtNombre.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[2].Value);
                txtApellidos.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[3].Value);
                txtDireccion.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[4].Value);
                txtTelefono.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[5].Value);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
