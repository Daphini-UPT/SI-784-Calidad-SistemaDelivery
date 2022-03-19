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
    public partial class FrmPlato : Form {
        public FrmPlato() {
            InitializeComponent();
        }

        private void FrmPlato_Load(object sender, EventArgs e) {
            this.listarPlatos();
            this.listarTiposDePlato();
        }

        private void listarTiposDePlato() {
            cmbTipoPlato.DataSource = PlatoNegocio.listarTiposDePlato();
            cmbTipoPlato.DisplayMember = "TPLnombre";
            cmbTipoPlato.ValueMember = "TPLcodigo";
        }

        private void listarPlatos() {
            try {
                dgvPlato.DataSource = PlatoNegocio.listar();
                this.limpiar();
                lblTotalPlatos.Text = "Total de Registros: " + Convert.ToString(dgvPlato.Rows.Count);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiar() {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtBuscar.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            this.limpiar();
            this.textBoxSoloLectura(false);
            this.habilitarBotones(false, false, true, true, false);
            txtNombre.Focus();
        }

        private void textBoxSoloLectura(bool estado) {
            txtNombre.ReadOnly = estado;
            txtPrecio.ReadOnly = estado;
            cmbTipoPlato.Enabled = !estado;
            cmbEstado.Enabled = !estado;
        }

        private void habilitarBotones(bool nuevo, bool actualizar, bool cancelar, bool grabar, bool modificar) {
            btnNuevo.Enabled = nuevo;
            btnActualizar.Visible = actualizar;
            btnCancelar.Visible = cancelar;
            btnGrabar.Visible = grabar;
            btnModificar.Enabled = modificar;
        }

        private void btnGrabar_Click(object sender, EventArgs e) {
            try {
                string rpta = "";
                if (this.datosPlatoVacios()) {
                    this.mensajeError("Falta completar datos de los campos");
                }
                else {
                    rpta = PlatoNegocio.insertar(txtNombre.Text.Trim().ToUpper(), float.Parse(txtPrecio.Text), Convert.ToInt32(cmbTipoPlato.SelectedValue), cmbEstado.Text);
                    if (rpta.Equals("OK")) {
                        this.mensajeCorrecto("Se realizó la inserción correctamente");
                        this.limpiar();
                        this.listarPlatos();
                    }
                    else {
                        this.mensajeError(rpta);
                    }
                    this.habilitarBotones(true, false, false, false, true);
                    this.textBoxSoloLectura(true);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private bool datosPlatoVacios() {
            foreach (Control txt in pnlDatosPlato.Controls) {
                if (txt is TextBox && string.IsNullOrWhiteSpace(txt.Text)) {
                    return true;
                }
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.limpiar();
            this.textBoxSoloLectura(true);
            this.habilitarBotones(true, false, false, false, true);
        }

        private void mensajeCorrecto(string mensaje) {
            MessageBox.Show(mensaje, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensajeError(string mensaje) {
            MessageBox.Show(mensaje, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            this.textBoxSoloLectura(false);
            this.habilitarBotones(false, true, true, false, false);
        }

        private void dgvPlato_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                txtId.Text = Convert.ToString(dgvPlato.CurrentRow.Cells[1].Value);
                txtNombre.Text = Convert.ToString(dgvPlato.CurrentRow.Cells[2].Value);
                txtPrecio.Text = Convert.ToString(dgvPlato.CurrentRow.Cells[3].Value);
                cmbTipoPlato.SelectedValue = dgvPlato.CurrentRow.Cells[4].Value;
                cmbEstado.Text = Convert.ToString(dgvPlato.CurrentRow.Cells[5].Value);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            this.actualizarPlato();
        }

        private void actualizarPlato() {
            try {
                string rpta = "";
                if (this.datosPlatoVacios()) {
                    this.mensajeError("Falta completar datos de los campos");
                }
                else {
                    rpta = PlatoNegocio.actualizar(int.Parse(txtId.Text), txtNombre.Text.Trim().ToUpper(), float.Parse(txtPrecio.Text), Convert.ToInt32(cmbTipoPlato.SelectedValue), cmbEstado.Text);
                    if (rpta.Equals("OK. Registro Actualizado")) {
                        this.mensajeCorrecto("Se realizó la modificación correctamente");
                        this.limpiar();
                        this.listarPlatos();
                    }
                    else {
                        this.mensajeError(rpta);
                    }
                    this.habilitarBotones(true, false, false, false, true);
                    this.textBoxSoloLectura(true);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            try {
                DialogResult opcion;
                int contador = 0;
                bool correcto = true;
                opcion = MessageBox.Show("Está seguro que desea eliminar?", "Plato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK) {
                    int codigo;
                    string respuesta;
                    foreach (DataGridViewRow row in dgvPlato.Rows) {
                        if (Convert.ToBoolean(row.Cells[0].Value)) {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            respuesta = PlatoNegocio.eliminar(codigo);
                            if (respuesta == "OK. Registro Eliminado") {
                                contador++;
                            }
                            else {
                                correcto = false;
                            }
                        }
                    }
                    if (correcto) {
                        this.mensajeCorrecto("Se eliminaron " + contador + " plato(s)..");
                        chkSeleccionar.Checked = false;
                        this.listarPlatos();
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

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e) {
            if (chkSeleccionar.Checked) {
                dgvPlato.Columns[0].Visible = true;
                btnEliminar.Visible = true;
            }
            else {
                dgvPlato.Columns[0].Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            this.buscarPlato();
        }

        private void buscarPlato() {
            try {
                dgvPlato.DataSource = PlatoNegocio.buscar(txtBuscar.Text);
                lblTotalPlatos.Text = "Total de Registros: " + Convert.ToString(dgvPlato.Rows.Count);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
