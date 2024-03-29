﻿
namespace CruceroGUI
{
    partial class VentaViajesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaViajesForm));
            this.gbDatosPasajero = new System.Windows.Forms.GroupBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudNumeroDocumento = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNacionalidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosPasaporte = new System.Windows.Forms.GroupBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoExterior = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbTipoPasaporte = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExpendidora = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gbGrupoFamiliar = new System.Windows.Forms.GroupBox();
            this.dgvGrupoFamiliar = new System.Windows.Forms.DataGridView();
            this.nombrePasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPasajero = new System.Windows.Forms.Button();
            this.btnBorrarPasajero = new System.Windows.Forms.Button();
            this.gbNecesidadesViaje = new System.Windows.Forms.GroupBox();
            this.cbDiscoteca = new System.Windows.Forms.CheckBox();
            this.cbGaleria = new System.Windows.Forms.CheckBox();
            this.cbCine = new System.Windows.Forms.CheckBox();
            this.cbTeatro = new System.Windows.Forms.CheckBox();
            this.cbBar = new System.Windows.Forms.CheckBox();
            this.cbSpa = new System.Windows.Forms.CheckBox();
            this.cbPiscina = new System.Windows.Forms.CheckBox();
            this.cbGimnasio = new System.Windows.Forms.CheckBox();
            this.cbPremium = new System.Windows.Forms.CheckBox();
            this.gbViajesDisponibles = new System.Windows.Forms.GroupBox();
            this.dgvListaViajes = new System.Windows.Forms.DataGridView();
            this.ciudadPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCamarotesPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCamarotesTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEquipaje = new System.Windows.Forms.GroupBox();
            this.cbCantidadValijas = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbBolsoMano = new System.Windows.Forms.CheckBox();
            this.btnVenderViaje = new System.Windows.Forms.Button();
            this.btnBuscarViajes = new System.Windows.Forms.Button();
            this.gbCostos = new System.Windows.Forms.GroupBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCostoFinalBruto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSeleccionarCliente = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarCliente = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.gbDatosPasajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDocumento)).BeginInit();
            this.gbDatosPasaporte.SuspendLayout();
            this.gbGrupoFamiliar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoFamiliar)).BeginInit();
            this.gbNecesidadesViaje.SuspendLayout();
            this.gbViajesDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaViajes)).BeginInit();
            this.gbEquipaje.SuspendLayout();
            this.gbCostos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosPasajero
            // 
            this.gbDatosPasajero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDatosPasajero.Controls.Add(this.txtCiudad);
            this.gbDatosPasajero.Controls.Add(this.label8);
            this.gbDatosPasajero.Controls.Add(this.txtDomicilio);
            this.gbDatosPasajero.Controls.Add(this.label7);
            this.gbDatosPasajero.Controls.Add(this.nudNumeroDocumento);
            this.gbDatosPasajero.Controls.Add(this.label6);
            this.gbDatosPasajero.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosPasajero.Controls.Add(this.label5);
            this.gbDatosPasajero.Controls.Add(this.cbNacionalidad);
            this.gbDatosPasajero.Controls.Add(this.label4);
            this.gbDatosPasajero.Controls.Add(this.cbSexo);
            this.gbDatosPasajero.Controls.Add(this.label3);
            this.gbDatosPasajero.Controls.Add(this.txtApellido);
            this.gbDatosPasajero.Controls.Add(this.label2);
            this.gbDatosPasajero.Controls.Add(this.txtNombre);
            this.gbDatosPasajero.Controls.Add(this.label1);
            this.gbDatosPasajero.Location = new System.Drawing.Point(12, 45);
            this.gbDatosPasajero.Name = "gbDatosPasajero";
            this.gbDatosPasajero.Size = new System.Drawing.Size(363, 333);
            this.gbDatosPasajero.TabIndex = 0;
            this.gbDatosPasajero.TabStop = false;
            this.gbDatosPasajero.Text = "Datos pasajero";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(214, 252);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(125, 27);
            this.txtCiudad.TabIndex = 3;
            this.txtCiudad.Click += new System.EventHandler(this.txtCiudad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ciudad:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(214, 286);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(125, 27);
            this.txtDomicilio.TabIndex = 2;
            this.txtDomicilio.Click += new System.EventHandler(this.txtDomicilio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Domicilio:";
            // 
            // nudNumeroDocumento
            // 
            this.nudNumeroDocumento.Location = new System.Drawing.Point(214, 214);
            this.nudNumeroDocumento.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudNumeroDocumento.Minimum = new decimal(new int[] {
            7000000,
            0,
            0,
            0});
            this.nudNumeroDocumento.Name = "nudNumeroDocumento";
            this.nudNumeroDocumento.Size = new System.Drawing.Size(125, 27);
            this.nudNumeroDocumento.TabIndex = 11;
            this.nudNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumeroDocumento.Value = new decimal(new int[] {
            7000000,
            0,
            0,
            0});
            this.nudNumeroDocumento.Click += new System.EventHandler(this.nudNumeroDocumento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero de documento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(214, 171);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(125, 27);
            this.dtpFechaNacimiento.TabIndex = 9;
            this.dtpFechaNacimiento.Value = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // cbNacionalidad
            // 
            this.cbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNacionalidad.FormattingEnabled = true;
            this.cbNacionalidad.Location = new System.Drawing.Point(214, 131);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(125, 28);
            this.cbNacionalidad.TabIndex = 7;
            this.cbNacionalidad.Click += new System.EventHandler(this.cbNacionalidad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nacionalidad:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(214, 92);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(125, 28);
            this.cbSexo.TabIndex = 5;
            this.cbSexo.Click += new System.EventHandler(this.cbSexo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(214, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Click += new System.EventHandler(this.txtApellido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // gbDatosPasaporte
            // 
            this.gbDatosPasaporte.Controls.Add(this.dtpFechaVencimiento);
            this.gbDatosPasaporte.Controls.Add(this.txtCodigoExterior);
            this.gbDatosPasaporte.Controls.Add(this.label14);
            this.gbDatosPasaporte.Controls.Add(this.cbTipoPasaporte);
            this.gbDatosPasaporte.Controls.Add(this.label9);
            this.gbDatosPasaporte.Controls.Add(this.txtExpendidora);
            this.gbDatosPasaporte.Controls.Add(this.label10);
            this.gbDatosPasaporte.Controls.Add(this.dtpFechaEmision);
            this.gbDatosPasaporte.Controls.Add(this.label12);
            this.gbDatosPasaporte.Controls.Add(this.label13);
            this.gbDatosPasaporte.Controls.Add(this.txtPasaporte);
            this.gbDatosPasaporte.Controls.Add(this.label16);
            this.gbDatosPasaporte.Location = new System.Drawing.Point(395, 45);
            this.gbDatosPasaporte.Name = "gbDatosPasaporte";
            this.gbDatosPasaporte.Size = new System.Drawing.Size(363, 241);
            this.gbDatosPasaporte.TabIndex = 1;
            this.gbDatosPasaporte.TabStop = false;
            this.gbDatosPasaporte.Text = "Datos pasaporte";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(214, 94);
            this.dtpFechaVencimiento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(125, 27);
            this.dtpFechaVencimiento.TabIndex = 14;
            this.dtpFechaVencimiento.ValueChanged += new System.EventHandler(this.dtpFechaVencimiento_ValueChanged);
            // 
            // txtCodigoExterior
            // 
            this.txtCodigoExterior.Location = new System.Drawing.Point(216, 169);
            this.txtCodigoExterior.Name = "txtCodigoExterior";
            this.txtCodigoExterior.Size = new System.Drawing.Size(125, 27);
            this.txtCodigoExterior.TabIndex = 3;
            this.txtCodigoExterior.Click += new System.EventHandler(this.txtCodigoExterior_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tipo de pasaporte:";
            // 
            // cbTipoPasaporte
            // 
            this.cbTipoPasaporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPasaporte.FormattingEnabled = true;
            this.cbTipoPasaporte.Location = new System.Drawing.Point(214, 129);
            this.cbTipoPasaporte.Name = "cbTipoPasaporte";
            this.cbTipoPasaporte.Size = new System.Drawing.Size(125, 28);
            this.cbTipoPasaporte.TabIndex = 5;
            this.cbTipoPasaporte.Click += new System.EventHandler(this.cbTipoPasaporte_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Codigo de pais exterior:";
            // 
            // txtExpendidora
            // 
            this.txtExpendidora.Location = new System.Drawing.Point(216, 203);
            this.txtExpendidora.Name = "txtExpendidora";
            this.txtExpendidora.Size = new System.Drawing.Size(125, 27);
            this.txtExpendidora.TabIndex = 2;
            this.txtExpendidora.Click += new System.EventHandler(this.txtExpendidora_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Autoridad expendidora:";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(216, 59);
            this.dtpFechaEmision.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEmision.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(125, 27);
            this.dtpFechaEmision.TabIndex = 9;
            this.dtpFechaEmision.ValueChanged += new System.EventHandler(this.dtpFechaEmision_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Fecha emision:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Fecha vencimiento:";
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Location = new System.Drawing.Point(214, 25);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(125, 27);
            this.txtPasaporte.TabIndex = 1;
            this.txtPasaporte.Click += new System.EventHandler(this.txtPasaporte_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Numero pasaporte:";
            // 
            // gbGrupoFamiliar
            // 
            this.gbGrupoFamiliar.Controls.Add(this.dgvGrupoFamiliar);
            this.gbGrupoFamiliar.Location = new System.Drawing.Point(14, 384);
            this.gbGrupoFamiliar.Name = "gbGrupoFamiliar";
            this.gbGrupoFamiliar.Size = new System.Drawing.Size(361, 177);
            this.gbGrupoFamiliar.TabIndex = 2;
            this.gbGrupoFamiliar.TabStop = false;
            this.gbGrupoFamiliar.Text = "Grupo familiar:";
            // 
            // dgvGrupoFamiliar
            // 
            this.dgvGrupoFamiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoFamiliar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePasajero,
            this.apellidoPasajero});
            this.dgvGrupoFamiliar.Location = new System.Drawing.Point(17, 26);
            this.dgvGrupoFamiliar.Name = "dgvGrupoFamiliar";
            this.dgvGrupoFamiliar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvGrupoFamiliar.RowTemplate.Height = 29;
            this.dgvGrupoFamiliar.Size = new System.Drawing.Size(304, 132);
            this.dgvGrupoFamiliar.TabIndex = 0;
            this.dgvGrupoFamiliar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupoFamiliar_CellClick);
            this.dgvGrupoFamiliar.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvGrupoFamiliar_RowStateChanged);
            // 
            // nombrePasajero
            // 
            this.nombrePasajero.HeaderText = "Nombre";
            this.nombrePasajero.MinimumWidth = 6;
            this.nombrePasajero.Name = "nombrePasajero";
            this.nombrePasajero.Width = 125;
            // 
            // apellidoPasajero
            // 
            this.apellidoPasajero.HeaderText = "Apellido";
            this.apellidoPasajero.MinimumWidth = 6;
            this.apellidoPasajero.Name = "apellidoPasajero";
            this.apellidoPasajero.ReadOnly = true;
            this.apellidoPasajero.Width = 125;
            // 
            // btnAgregarPasajero
            // 
            this.btnAgregarPasajero.Location = new System.Drawing.Point(974, 70);
            this.btnAgregarPasajero.Name = "btnAgregarPasajero";
            this.btnAgregarPasajero.Size = new System.Drawing.Size(148, 29);
            this.btnAgregarPasajero.TabIndex = 15;
            this.btnAgregarPasajero.Text = "Agregar pasajero";
            this.btnAgregarPasajero.UseVisualStyleBackColor = true;
            this.btnAgregarPasajero.Click += new System.EventHandler(this.btnAgregarPasajero_Click);
            // 
            // btnBorrarPasajero
            // 
            this.btnBorrarPasajero.Location = new System.Drawing.Point(974, 107);
            this.btnBorrarPasajero.Name = "btnBorrarPasajero";
            this.btnBorrarPasajero.Size = new System.Drawing.Size(148, 29);
            this.btnBorrarPasajero.TabIndex = 16;
            this.btnBorrarPasajero.Text = "Borrar pasajero";
            this.btnBorrarPasajero.UseVisualStyleBackColor = true;
            this.btnBorrarPasajero.Click += new System.EventHandler(this.btnBorrarPasajero_Click);
            // 
            // gbNecesidadesViaje
            // 
            this.gbNecesidadesViaje.Controls.Add(this.cbDiscoteca);
            this.gbNecesidadesViaje.Controls.Add(this.cbGaleria);
            this.gbNecesidadesViaje.Controls.Add(this.cbCine);
            this.gbNecesidadesViaje.Controls.Add(this.cbTeatro);
            this.gbNecesidadesViaje.Controls.Add(this.cbBar);
            this.gbNecesidadesViaje.Controls.Add(this.cbSpa);
            this.gbNecesidadesViaje.Controls.Add(this.cbPiscina);
            this.gbNecesidadesViaje.Controls.Add(this.cbGimnasio);
            this.gbNecesidadesViaje.Location = new System.Drawing.Point(774, 45);
            this.gbNecesidadesViaje.Name = "gbNecesidadesViaje";
            this.gbNecesidadesViaje.Size = new System.Drawing.Size(171, 333);
            this.gbNecesidadesViaje.TabIndex = 3;
            this.gbNecesidadesViaje.TabStop = false;
            this.gbNecesidadesViaje.Text = "Necesidades viaje:";
            // 
            // cbDiscoteca
            // 
            this.cbDiscoteca.AutoSize = true;
            this.cbDiscoteca.Location = new System.Drawing.Point(21, 232);
            this.cbDiscoteca.Name = "cbDiscoteca";
            this.cbDiscoteca.Size = new System.Drawing.Size(96, 24);
            this.cbDiscoteca.TabIndex = 4;
            this.cbDiscoteca.Text = "Discoteca";
            this.cbDiscoteca.UseVisualStyleBackColor = true;
            // 
            // cbGaleria
            // 
            this.cbGaleria.AutoSize = true;
            this.cbGaleria.Location = new System.Drawing.Point(21, 202);
            this.cbGaleria.Name = "cbGaleria";
            this.cbGaleria.Size = new System.Drawing.Size(78, 24);
            this.cbGaleria.TabIndex = 4;
            this.cbGaleria.Text = "Galeria";
            this.cbGaleria.UseVisualStyleBackColor = true;
            // 
            // cbCine
            // 
            this.cbCine.AutoSize = true;
            this.cbCine.Location = new System.Drawing.Point(21, 177);
            this.cbCine.Name = "cbCine";
            this.cbCine.Size = new System.Drawing.Size(60, 24);
            this.cbCine.TabIndex = 5;
            this.cbCine.Text = "Cine";
            this.cbCine.UseVisualStyleBackColor = true;
            // 
            // cbTeatro
            // 
            this.cbTeatro.AutoSize = true;
            this.cbTeatro.Location = new System.Drawing.Point(21, 147);
            this.cbTeatro.Name = "cbTeatro";
            this.cbTeatro.Size = new System.Drawing.Size(73, 24);
            this.cbTeatro.TabIndex = 4;
            this.cbTeatro.Text = "Teatro";
            this.cbTeatro.UseVisualStyleBackColor = true;
            // 
            // cbBar
            // 
            this.cbBar.AutoSize = true;
            this.cbBar.Location = new System.Drawing.Point(21, 117);
            this.cbBar.Name = "cbBar";
            this.cbBar.Size = new System.Drawing.Size(53, 24);
            this.cbBar.TabIndex = 3;
            this.cbBar.Text = "Bar";
            this.cbBar.UseVisualStyleBackColor = true;
            // 
            // cbSpa
            // 
            this.cbSpa.AutoSize = true;
            this.cbSpa.Location = new System.Drawing.Point(21, 87);
            this.cbSpa.Name = "cbSpa";
            this.cbSpa.Size = new System.Drawing.Size(56, 24);
            this.cbSpa.TabIndex = 2;
            this.cbSpa.Text = "Spa";
            this.cbSpa.UseVisualStyleBackColor = true;
            // 
            // cbPiscina
            // 
            this.cbPiscina.AutoSize = true;
            this.cbPiscina.Location = new System.Drawing.Point(21, 57);
            this.cbPiscina.Name = "cbPiscina";
            this.cbPiscina.Size = new System.Drawing.Size(76, 24);
            this.cbPiscina.TabIndex = 1;
            this.cbPiscina.Text = "Piscina";
            this.cbPiscina.UseVisualStyleBackColor = true;
            // 
            // cbGimnasio
            // 
            this.cbGimnasio.AutoSize = true;
            this.cbGimnasio.Location = new System.Drawing.Point(21, 27);
            this.cbGimnasio.Name = "cbGimnasio";
            this.cbGimnasio.Size = new System.Drawing.Size(93, 24);
            this.cbGimnasio.TabIndex = 0;
            this.cbGimnasio.Text = "Gimnasio";
            this.cbGimnasio.UseVisualStyleBackColor = true;
            // 
            // cbPremium
            // 
            this.cbPremium.AutoSize = true;
            this.cbPremium.Location = new System.Drawing.Point(19, 53);
            this.cbPremium.Name = "cbPremium";
            this.cbPremium.Size = new System.Drawing.Size(90, 24);
            this.cbPremium.TabIndex = 6;
            this.cbPremium.Text = "Premium";
            this.cbPremium.UseVisualStyleBackColor = true;
            this.cbPremium.CheckedChanged += new System.EventHandler(this.cbPremium_CheckedChanged);
            // 
            // gbViajesDisponibles
            // 
            this.gbViajesDisponibles.Controls.Add(this.dgvListaViajes);
            this.gbViajesDisponibles.Location = new System.Drawing.Point(397, 384);
            this.gbViajesDisponibles.Name = "gbViajesDisponibles";
            this.gbViajesDisponibles.Size = new System.Drawing.Size(725, 177);
            this.gbViajesDisponibles.TabIndex = 4;
            this.gbViajesDisponibles.TabStop = false;
            this.gbViajesDisponibles.Text = "Viajes disponibles:";
            // 
            // dgvListaViajes
            // 
            this.dgvListaViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciudadPartida,
            this.ciudadDestino,
            this.crucero,
            this.fechaInicioViaje,
            this.cantidadCamarotesPremium,
            this.cantidadCamarotesTurista,
            this.costoPremium,
            this.costoTurista,
            this.duracionViaje});
            this.dgvListaViajes.Location = new System.Drawing.Point(17, 26);
            this.dgvListaViajes.Name = "dgvListaViajes";
            this.dgvListaViajes.RowHeadersWidth = 51;
            this.dgvListaViajes.RowTemplate.Height = 29;
            this.dgvListaViajes.Size = new System.Drawing.Size(702, 132);
            this.dgvListaViajes.TabIndex = 1;
            this.dgvListaViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaViajes_CellClick);
            this.dgvListaViajes.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvListaViajes_RowStateChanged);
            // 
            // ciudadPartida
            // 
            this.ciudadPartida.HeaderText = "Ciudad de Partida";
            this.ciudadPartida.MinimumWidth = 6;
            this.ciudadPartida.Name = "ciudadPartida";
            this.ciudadPartida.ReadOnly = true;
            this.ciudadPartida.Width = 125;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.HeaderText = "Ciudad de destino";
            this.ciudadDestino.MinimumWidth = 6;
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.ReadOnly = true;
            this.ciudadDestino.Width = 125;
            // 
            // crucero
            // 
            this.crucero.HeaderText = "Crucero";
            this.crucero.MinimumWidth = 6;
            this.crucero.Name = "crucero";
            this.crucero.ReadOnly = true;
            this.crucero.Width = 125;
            // 
            // fechaInicioViaje
            // 
            this.fechaInicioViaje.HeaderText = "Fecha y hora de partida";
            this.fechaInicioViaje.MinimumWidth = 6;
            this.fechaInicioViaje.Name = "fechaInicioViaje";
            this.fechaInicioViaje.ReadOnly = true;
            this.fechaInicioViaje.Width = 125;
            // 
            // cantidadCamarotesPremium
            // 
            this.cantidadCamarotesPremium.HeaderText = "Cantidad de camarotes premium";
            this.cantidadCamarotesPremium.MinimumWidth = 6;
            this.cantidadCamarotesPremium.Name = "cantidadCamarotesPremium";
            this.cantidadCamarotesPremium.ReadOnly = true;
            this.cantidadCamarotesPremium.Width = 125;
            // 
            // cantidadCamarotesTurista
            // 
            this.cantidadCamarotesTurista.HeaderText = "Cantidad camarotes turista";
            this.cantidadCamarotesTurista.MinimumWidth = 6;
            this.cantidadCamarotesTurista.Name = "cantidadCamarotesTurista";
            this.cantidadCamarotesTurista.ReadOnly = true;
            this.cantidadCamarotesTurista.Width = 125;
            // 
            // costoPremium
            // 
            this.costoPremium.HeaderText = "Costo premium (Dolares)";
            this.costoPremium.MinimumWidth = 6;
            this.costoPremium.Name = "costoPremium";
            this.costoPremium.ReadOnly = true;
            this.costoPremium.Width = 125;
            // 
            // costoTurista
            // 
            this.costoTurista.HeaderText = "Costo turista (Dolares)";
            this.costoTurista.MinimumWidth = 6;
            this.costoTurista.Name = "costoTurista";
            this.costoTurista.ReadOnly = true;
            this.costoTurista.Width = 125;
            // 
            // duracionViaje
            // 
            this.duracionViaje.HeaderText = "Duracion (Horas)";
            this.duracionViaje.MinimumWidth = 6;
            this.duracionViaje.Name = "duracionViaje";
            this.duracionViaje.ReadOnly = true;
            this.duracionViaje.Width = 125;
            // 
            // gbEquipaje
            // 
            this.gbEquipaje.Controls.Add(this.cbPremium);
            this.gbEquipaje.Controls.Add(this.cbCantidadValijas);
            this.gbEquipaje.Controls.Add(this.label11);
            this.gbEquipaje.Controls.Add(this.cbBolsoMano);
            this.gbEquipaje.Location = new System.Drawing.Point(395, 292);
            this.gbEquipaje.Name = "gbEquipaje";
            this.gbEquipaje.Size = new System.Drawing.Size(363, 86);
            this.gbEquipaje.TabIndex = 5;
            this.gbEquipaje.TabStop = false;
            this.gbEquipaje.Text = "Equipaje:";
            // 
            // cbCantidadValijas
            // 
            this.cbCantidadValijas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCantidadValijas.FormattingEnabled = true;
            this.cbCantidadValijas.Location = new System.Drawing.Point(232, 26);
            this.cbCantidadValijas.Name = "cbCantidadValijas";
            this.cbCantidadValijas.Size = new System.Drawing.Size(125, 28);
            this.cbCantidadValijas.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Valija:";
            // 
            // cbBolsoMano
            // 
            this.cbBolsoMano.AutoSize = true;
            this.cbBolsoMano.Location = new System.Drawing.Point(19, 23);
            this.cbBolsoMano.Name = "cbBolsoMano";
            this.cbBolsoMano.Size = new System.Drawing.Size(131, 24);
            this.cbBolsoMano.TabIndex = 0;
            this.cbBolsoMano.Text = "Bolso de mano";
            this.cbBolsoMano.UseVisualStyleBackColor = true;
            // 
            // btnVenderViaje
            // 
            this.btnVenderViaje.Location = new System.Drawing.Point(974, 180);
            this.btnVenderViaje.Name = "btnVenderViaje";
            this.btnVenderViaje.Size = new System.Drawing.Size(148, 29);
            this.btnVenderViaje.TabIndex = 17;
            this.btnVenderViaje.Text = "Vender viaje";
            this.btnVenderViaje.UseVisualStyleBackColor = true;
            this.btnVenderViaje.Click += new System.EventHandler(this.btnVenderViaje_Click);
            // 
            // btnBuscarViajes
            // 
            this.btnBuscarViajes.Location = new System.Drawing.Point(974, 145);
            this.btnBuscarViajes.Name = "btnBuscarViajes";
            this.btnBuscarViajes.Size = new System.Drawing.Size(148, 29);
            this.btnBuscarViajes.TabIndex = 18;
            this.btnBuscarViajes.Text = "Buscar viajes";
            this.btnBuscarViajes.UseVisualStyleBackColor = true;
            this.btnBuscarViajes.Click += new System.EventHandler(this.btnBuscarViajes_Click);
            // 
            // gbCostos
            // 
            this.gbCostos.Controls.Add(this.txtNeto);
            this.gbCostos.Controls.Add(this.label17);
            this.gbCostos.Controls.Add(this.txtCostoFinalBruto);
            this.gbCostos.Controls.Add(this.label15);
            this.gbCostos.Location = new System.Drawing.Point(964, 222);
            this.gbCostos.Name = "gbCostos";
            this.gbCostos.Size = new System.Drawing.Size(152, 150);
            this.gbCostos.TabIndex = 19;
            this.gbCostos.TabStop = false;
            this.gbCostos.Text = "Costos";
            // 
            // txtNeto
            // 
            this.txtNeto.Enabled = false;
            this.txtNeto.Location = new System.Drawing.Point(10, 105);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(125, 27);
            this.txtNeto.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "Neto (+21%IVA):";
            // 
            // txtCostoFinalBruto
            // 
            this.txtCostoFinalBruto.Enabled = false;
            this.txtCostoFinalBruto.Location = new System.Drawing.Point(10, 49);
            this.txtCostoFinalBruto.Name = "txtCostoFinalBruto";
            this.txtCostoFinalBruto.Size = new System.Drawing.Size(125, 27);
            this.txtCostoFinalBruto.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Costo final bruto:";
            // 
            // cbSeleccionarCliente
            // 
            this.cbSeleccionarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccionarCliente.FormattingEnabled = true;
            this.cbSeleccionarCliente.Location = new System.Drawing.Point(165, 12);
            this.cbSeleccionarCliente.Name = "cbSeleccionarCliente";
            this.cbSeleccionarCliente.Size = new System.Drawing.Size(361, 28);
            this.cbSeleccionarCliente.TabIndex = 20;
            this.cbSeleccionarCliente.SelectedIndexChanged += new System.EventHandler(this.cbSeleccionarCliente_SelectedIndexChanged);
            // 
            // lblSeleccionarCliente
            // 
            this.lblSeleccionarCliente.AutoSize = true;
            this.lblSeleccionarCliente.Location = new System.Drawing.Point(23, 15);
            this.lblSeleccionarCliente.Name = "lblSeleccionarCliente";
            this.lblSeleccionarCliente.Size = new System.Drawing.Size(136, 20);
            this.lblSeleccionarCliente.TabIndex = 21;
            this.lblSeleccionarCliente.Text = "Seleccionar cliente:";
            // 
            // lblAyuda
            // 
            this.lblAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAyuda.Image = ((System.Drawing.Image)(resources.GetObject("lblAyuda.Image")));
            this.lblAyuda.Location = new System.Drawing.Point(1093, 9);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(29, 45);
            this.lblAyuda.TabIndex = 23;
            this.lblAyuda.Text = " ";
            // 
            // VentaViajesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 579);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.lblSeleccionarCliente);
            this.Controls.Add(this.cbSeleccionarCliente);
            this.Controls.Add(this.gbCostos);
            this.Controls.Add(this.btnBuscarViajes);
            this.Controls.Add(this.btnVenderViaje);
            this.Controls.Add(this.btnBorrarPasajero);
            this.Controls.Add(this.gbEquipaje);
            this.Controls.Add(this.btnAgregarPasajero);
            this.Controls.Add(this.gbViajesDisponibles);
            this.Controls.Add(this.gbNecesidadesViaje);
            this.Controls.Add(this.gbGrupoFamiliar);
            this.Controls.Add(this.gbDatosPasaporte);
            this.Controls.Add(this.gbDatosPasajero);
            this.MinimumSize = new System.Drawing.Size(1158, 626);
            this.Name = "VentaViajesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de viajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentaViajesForm_FormClosing);
            this.Load += new System.EventHandler(this.VentaViajesForm_Load);
            this.gbDatosPasajero.ResumeLayout(false);
            this.gbDatosPasajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDocumento)).EndInit();
            this.gbDatosPasaporte.ResumeLayout(false);
            this.gbDatosPasaporte.PerformLayout();
            this.gbGrupoFamiliar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoFamiliar)).EndInit();
            this.gbNecesidadesViaje.ResumeLayout(false);
            this.gbNecesidadesViaje.PerformLayout();
            this.gbViajesDisponibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaViajes)).EndInit();
            this.gbEquipaje.ResumeLayout(false);
            this.gbEquipaje.PerformLayout();
            this.gbCostos.ResumeLayout(false);
            this.gbCostos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGrupoFamiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPasajero;
        private System.Windows.Forms.CheckBox cbGimnasio;
        private System.Windows.Forms.CheckBox cbDiscoteca;
        private System.Windows.Forms.CheckBox cbGaleria;
        private System.Windows.Forms.CheckBox cbCine;
        private System.Windows.Forms.CheckBox cbTeatro;
        private System.Windows.Forms.CheckBox cbBar;
        private System.Windows.Forms.CheckBox cbSpa;
        private System.Windows.Forms.CheckBox cbPiscina;
        private System.Windows.Forms.DataGridView dgvListaViajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn crucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCamarotesPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCamarotesTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionViaje;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCostoFinalBruto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNeto;
        protected System.Windows.Forms.GroupBox gbGrupoFamiliar;
        protected System.Windows.Forms.Button btnBorrarPasajero;
        protected System.Windows.Forms.Button btnAgregarPasajero;
        protected System.Windows.Forms.GroupBox gbNecesidadesViaje;
        protected System.Windows.Forms.GroupBox gbViajesDisponibles;
        protected System.Windows.Forms.GroupBox gbEquipaje;
        protected System.Windows.Forms.Button btnVenderViaje;
        protected System.Windows.Forms.Button btnBuscarViajes;
        protected System.Windows.Forms.GroupBox gbCostos;
        protected System.Windows.Forms.GroupBox gbDatosPasajero;
        protected System.Windows.Forms.NumericUpDown nudNumeroDocumento;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.ComboBox cbNacionalidad;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.ComboBox cbSexo;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtApellido;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtCiudad;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtDomicilio;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.GroupBox gbDatosPasaporte;
        protected System.Windows.Forms.TextBox txtCodigoExterior;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox txtExpendidora;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.DateTimePicker dtpFechaEmision;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.ComboBox cbTipoPasaporte;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.TextBox txtPasaporte;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        protected System.Windows.Forms.CheckBox cbPremium;
        protected System.Windows.Forms.ComboBox cbCantidadValijas;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.CheckBox cbBolsoMano;
        protected System.Windows.Forms.Label lblSeleccionarCliente;
        protected System.Windows.Forms.ComboBox cbSeleccionarCliente;
        protected System.Windows.Forms.Label lblAyuda;
    }
}