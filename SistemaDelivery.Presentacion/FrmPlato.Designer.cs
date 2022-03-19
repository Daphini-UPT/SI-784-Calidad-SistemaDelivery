
namespace SistemaDelivery.Presentacion {
    partial class FrmPlato {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTotalPlatos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPlato = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatosPlato = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTipoPlato = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ColSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTPLcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).BeginInit();
            this.pnlDatosPlato.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(490, 101);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Location = new System.Drawing.Point(32, 440);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.chkSeleccionar.TabIndex = 35;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(131, 436);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(490, 130);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(571, 75);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(490, 75);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 31;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTotalPlatos
            // 
            this.lblTotalPlatos.AutoSize = true;
            this.lblTotalPlatos.Location = new System.Drawing.Point(487, 436);
            this.lblTotalPlatos.Name = "lblTotalPlatos";
            this.lblTotalPlatos.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPlatos.TabIndex = 30;
            this.lblTotalPlatos.Text = "label7";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(574, 460);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(32, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 43);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(390, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(58, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(310, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID:";
            // 
            // dgvPlato
            // 
            this.dgvPlato.AllowUserToAddRows = false;
            this.dgvPlato.AllowUserToDeleteRows = false;
            this.dgvPlato.AllowUserToOrderColumns = true;
            this.dgvPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSeleccionar,
            this.ColCodigo,
            this.ColNombre,
            this.ColPrecio,
            this.ColTPLcodigo,
            this.ColTelefono});
            this.dgvPlato.Location = new System.Drawing.Point(32, 259);
            this.dgvPlato.Name = "dgvPlato";
            this.dgvPlato.RowHeadersWidth = 25;
            this.dgvPlato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlato.Size = new System.Drawing.Size(617, 164);
            this.dgvPlato.TabIndex = 26;
            this.dgvPlato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlato_CellClick);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(104, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(44, 20);
            this.txtId.TabIndex = 25;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(490, 49);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 24;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Visible = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "GESTIONAR PLATO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDatosPlato
            // 
            this.pnlDatosPlato.Controls.Add(this.txtNombre);
            this.pnlDatosPlato.Controls.Add(this.txtPrecio);
            this.pnlDatosPlato.Location = new System.Drawing.Point(101, 73);
            this.pnlDatosPlato.Name = "pnlDatosPlato";
            this.pnlDatosPlato.Size = new System.Drawing.Size(172, 67);
            this.pnlDatosPlato.TabIndex = 37;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE"});
            this.cmbEstado.Location = new System.Drawing.Point(104, 171);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 14;
            // 
            // cmbTipoPlato
            // 
            this.cmbTipoPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPlato.Enabled = false;
            this.cmbTipoPlato.FormattingEnabled = true;
            this.cmbTipoPlato.Location = new System.Drawing.Point(104, 140);
            this.cmbTipoPlato.Name = "cmbTipoPlato";
            this.cmbTipoPlato.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPlato.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(3, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(3, 36);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Plato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado:";
            // 
            // ColSeleccionar
            // 
            this.ColSeleccionar.HeaderText = "Seleccionar";
            this.ColSeleccionar.Name = "ColSeleccionar";
            this.ColSeleccionar.Visible = false;
            this.ColSeleccionar.Width = 70;
            // 
            // ColCodigo
            // 
            this.ColCodigo.DataPropertyName = "PLAcodigo";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCodigo.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.Width = 50;
            // 
            // ColNombre
            // 
            this.ColNombre.DataPropertyName = "PLAnombre";
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 150;
            // 
            // ColPrecio
            // 
            this.ColPrecio.DataPropertyName = "PLAprecio";
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 80;
            // 
            // ColTPLcodigo
            // 
            this.ColTPLcodigo.DataPropertyName = "TPLcodigo";
            this.ColTPLcodigo.HeaderText = "Tipo Plato";
            this.ColTPLcodigo.Name = "ColTPLcodigo";
            this.ColTPLcodigo.ReadOnly = true;
            this.ColTPLcodigo.Width = 80;
            // 
            // ColTelefono
            // 
            this.ColTelefono.DataPropertyName = "PLAestado";
            this.ColTelefono.HeaderText = "Estado";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // FrmPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 488);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbTipoPlato);
            this.Controls.Add(this.chkSeleccionar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalPlatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPlato);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDatosPlato);
            this.Name = "FrmPlato";
            this.Text = "FrmPlato";
            this.Load += new System.EventHandler(this.FrmPlato_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).EndInit();
            this.pnlDatosPlato.ResumeLayout(false);
            this.pnlDatosPlato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTotalPlatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPlato;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDatosPlato;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTipoPlato;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTPLcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
    }
}