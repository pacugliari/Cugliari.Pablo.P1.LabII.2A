
namespace CruceroGUI
{
    partial class InformesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformesForm));
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCapacidadBodegaLibre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.txtCantTuristaDisponibles = new System.Windows.Forms.TextBox();
            this.txtCantPremiumDisponbiles = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCantCasinos = new System.Windows.Forms.TextBox();
            this.txtCantSalones = new System.Windows.Forms.TextBox();
            this.txtCantTurista = new System.Windows.Forms.TextBox();
            this.txtCantPremium = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantBodega = new System.Windows.Forms.TextBox();
            this.txtCantCamarote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCasino = new System.Windows.Forms.CheckBox();
            this.cbComedor = new System.Windows.Forms.CheckBox();
            this.cbDiscoteca = new System.Windows.Forms.CheckBox();
            this.cbGaleria = new System.Windows.Forms.CheckBox();
            this.cbCine = new System.Windows.Forms.CheckBox();
            this.cbTeatro = new System.Windows.Forms.CheckBox();
            this.cbBar = new System.Windows.Forms.CheckBox();
            this.cbSpa = new System.Windows.Forms.CheckBox();
            this.cbPiscina = new System.Windows.Forms.CheckBox();
            this.cbGimnasio = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListaPasajeros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaViajes)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPasajeros)).BeginInit();
            this.SuspendLayout();
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
            this.dgvListaViajes.Size = new System.Drawing.Size(519, 129);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvListaViajes);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(555, 176);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Viajes disponibles:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCapacidadBodegaLibre);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblAyuda);
            this.groupBox1.Controls.Add(this.txtCantTuristaDisponibles);
            this.groupBox1.Controls.Add(this.txtCantPremiumDisponbiles);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtCantCasinos);
            this.groupBox1.Controls.Add(this.txtCantSalones);
            this.groupBox1.Controls.Add(this.txtCantTurista);
            this.groupBox1.Controls.Add(this.txtCantPremium);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCantBodega);
            this.groupBox1.Controls.Add(this.txtCantCamarote);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 387);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion crucero:";
            // 
            // txtCapacidadBodegaLibre
            // 
            this.txtCapacidadBodegaLibre.Enabled = false;
            this.txtCapacidadBodegaLibre.Location = new System.Drawing.Point(251, 312);
            this.txtCapacidadBodegaLibre.Name = "txtCapacidadBodegaLibre";
            this.txtCapacidadBodegaLibre.Size = new System.Drawing.Size(125, 27);
            this.txtCapacidadBodegaLibre.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Capacidad bodega libre (KG)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "-> Disponibles:";
            // 
            // lblAyuda
            // 
            this.lblAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAyuda.Image = ((System.Drawing.Image)(resources.GetObject("lblAyuda.Image")));
            this.lblAyuda.Location = new System.Drawing.Point(347, 23);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(29, 45);
            this.lblAyuda.TabIndex = 13;
            this.lblAyuda.Text = " ";
            // 
            // txtCantTuristaDisponibles
            // 
            this.txtCantTuristaDisponibles.Enabled = false;
            this.txtCantTuristaDisponibles.Location = new System.Drawing.Point(288, 180);
            this.txtCantTuristaDisponibles.Name = "txtCantTuristaDisponibles";
            this.txtCantTuristaDisponibles.Size = new System.Drawing.Size(32, 27);
            this.txtCantTuristaDisponibles.TabIndex = 22;
            // 
            // txtCantPremiumDisponbiles
            // 
            this.txtCantPremiumDisponbiles.Enabled = false;
            this.txtCantPremiumDisponbiles.Location = new System.Drawing.Point(288, 150);
            this.txtCantPremiumDisponbiles.Name = "txtCantPremiumDisponbiles";
            this.txtCantPremiumDisponbiles.Size = new System.Drawing.Size(32, 27);
            this.txtCantPremiumDisponbiles.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "-> Disponibles:";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(96, 26);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(189, 27);
            this.txtEstado.TabIndex = 18;
            // 
            // txtCantCasinos
            // 
            this.txtCantCasinos.Enabled = false;
            this.txtCantCasinos.Location = new System.Drawing.Point(172, 245);
            this.txtCantCasinos.Name = "txtCantCasinos";
            this.txtCantCasinos.Size = new System.Drawing.Size(32, 27);
            this.txtCantCasinos.TabIndex = 17;
            // 
            // txtCantSalones
            // 
            this.txtCantSalones.Enabled = false;
            this.txtCantSalones.Location = new System.Drawing.Point(172, 213);
            this.txtCantSalones.Name = "txtCantSalones";
            this.txtCantSalones.Size = new System.Drawing.Size(32, 27);
            this.txtCantSalones.TabIndex = 16;
            // 
            // txtCantTurista
            // 
            this.txtCantTurista.Enabled = false;
            this.txtCantTurista.Location = new System.Drawing.Point(129, 183);
            this.txtCantTurista.Name = "txtCantTurista";
            this.txtCantTurista.Size = new System.Drawing.Size(32, 27);
            this.txtCantTurista.TabIndex = 15;
            // 
            // txtCantPremium
            // 
            this.txtCantPremium.Enabled = false;
            this.txtCantPremium.Location = new System.Drawing.Point(129, 150);
            this.txtCantPremium.Name = "txtCantPremium";
            this.txtCantPremium.Size = new System.Drawing.Size(32, 27);
            this.txtCantPremium.TabIndex = 14;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Location = new System.Drawing.Point(96, 59);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(189, 27);
            this.txtMatricula.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(96, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 27);
            this.txtNombre.TabIndex = 12;
            // 
            // txtCantBodega
            // 
            this.txtCantBodega.Enabled = false;
            this.txtCantBodega.Location = new System.Drawing.Point(251, 279);
            this.txtCantBodega.Name = "txtCantBodega";
            this.txtCantBodega.Size = new System.Drawing.Size(125, 27);
            this.txtCantBodega.TabIndex = 11;
            // 
            // txtCantCamarote
            // 
            this.txtCantCamarote.Enabled = false;
            this.txtCantCamarote.Location = new System.Drawing.Point(251, 350);
            this.txtCantCamarote.Name = "txtCantCamarote";
            this.txtCantCamarote.Size = new System.Drawing.Size(125, 27);
            this.txtCantCamarote.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad personas por camarote:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Capacidad bodega (KG)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad casinos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad salones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "         Turista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "         Premium:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad camarotes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCasino);
            this.groupBox4.Controls.Add(this.cbComedor);
            this.groupBox4.Controls.Add(this.cbDiscoteca);
            this.groupBox4.Controls.Add(this.cbGaleria);
            this.groupBox4.Controls.Add(this.cbCine);
            this.groupBox4.Controls.Add(this.cbTeatro);
            this.groupBox4.Controls.Add(this.cbBar);
            this.groupBox4.Controls.Add(this.cbSpa);
            this.groupBox4.Controls.Add(this.cbPiscina);
            this.groupBox4.Controls.Add(this.cbGimnasio);
            this.groupBox4.Location = new System.Drawing.Point(419, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 380);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salones:";
            // 
            // cbCasino
            // 
            this.cbCasino.AutoSize = true;
            this.cbCasino.Enabled = false;
            this.cbCasino.Location = new System.Drawing.Point(21, 283);
            this.cbCasino.Name = "cbCasino";
            this.cbCasino.Size = new System.Drawing.Size(75, 24);
            this.cbCasino.TabIndex = 19;
            this.cbCasino.Text = "Casino";
            this.cbCasino.UseVisualStyleBackColor = true;
            // 
            // cbComedor
            // 
            this.cbComedor.AutoSize = true;
            this.cbComedor.Enabled = false;
            this.cbComedor.Location = new System.Drawing.Point(21, 255);
            this.cbComedor.Name = "cbComedor";
            this.cbComedor.Size = new System.Drawing.Size(93, 24);
            this.cbComedor.TabIndex = 6;
            this.cbComedor.Text = "Comedor";
            this.cbComedor.UseVisualStyleBackColor = true;
            // 
            // cbDiscoteca
            // 
            this.cbDiscoteca.AutoSize = true;
            this.cbDiscoteca.Enabled = false;
            this.cbDiscoteca.Location = new System.Drawing.Point(21, 225);
            this.cbDiscoteca.Name = "cbDiscoteca";
            this.cbDiscoteca.Size = new System.Drawing.Size(96, 24);
            this.cbDiscoteca.TabIndex = 4;
            this.cbDiscoteca.Text = "Discoteca";
            this.cbDiscoteca.UseVisualStyleBackColor = true;
            // 
            // cbGaleria
            // 
            this.cbGaleria.AutoSize = true;
            this.cbGaleria.Enabled = false;
            this.cbGaleria.Location = new System.Drawing.Point(21, 195);
            this.cbGaleria.Name = "cbGaleria";
            this.cbGaleria.Size = new System.Drawing.Size(78, 24);
            this.cbGaleria.TabIndex = 4;
            this.cbGaleria.Text = "Galeria";
            this.cbGaleria.UseVisualStyleBackColor = true;
            // 
            // cbCine
            // 
            this.cbCine.AutoSize = true;
            this.cbCine.Enabled = false;
            this.cbCine.Location = new System.Drawing.Point(21, 165);
            this.cbCine.Name = "cbCine";
            this.cbCine.Size = new System.Drawing.Size(60, 24);
            this.cbCine.TabIndex = 5;
            this.cbCine.Text = "Cine";
            this.cbCine.UseVisualStyleBackColor = true;
            // 
            // cbTeatro
            // 
            this.cbTeatro.AutoSize = true;
            this.cbTeatro.Enabled = false;
            this.cbTeatro.Location = new System.Drawing.Point(21, 135);
            this.cbTeatro.Name = "cbTeatro";
            this.cbTeatro.Size = new System.Drawing.Size(73, 24);
            this.cbTeatro.TabIndex = 4;
            this.cbTeatro.Text = "Teatro";
            this.cbTeatro.UseVisualStyleBackColor = true;
            // 
            // cbBar
            // 
            this.cbBar.AutoSize = true;
            this.cbBar.Enabled = false;
            this.cbBar.Location = new System.Drawing.Point(21, 105);
            this.cbBar.Name = "cbBar";
            this.cbBar.Size = new System.Drawing.Size(53, 24);
            this.cbBar.TabIndex = 3;
            this.cbBar.Text = "Bar";
            this.cbBar.UseVisualStyleBackColor = true;
            // 
            // cbSpa
            // 
            this.cbSpa.AutoSize = true;
            this.cbSpa.Enabled = false;
            this.cbSpa.Location = new System.Drawing.Point(21, 75);
            this.cbSpa.Name = "cbSpa";
            this.cbSpa.Size = new System.Drawing.Size(56, 24);
            this.cbSpa.TabIndex = 2;
            this.cbSpa.Text = "Spa";
            this.cbSpa.UseVisualStyleBackColor = true;
            // 
            // cbPiscina
            // 
            this.cbPiscina.AutoSize = true;
            this.cbPiscina.Enabled = false;
            this.cbPiscina.Location = new System.Drawing.Point(21, 48);
            this.cbPiscina.Name = "cbPiscina";
            this.cbPiscina.Size = new System.Drawing.Size(76, 24);
            this.cbPiscina.TabIndex = 1;
            this.cbPiscina.Text = "Piscina";
            this.cbPiscina.UseVisualStyleBackColor = true;
            // 
            // cbGimnasio
            // 
            this.cbGimnasio.AutoSize = true;
            this.cbGimnasio.Enabled = false;
            this.cbGimnasio.Location = new System.Drawing.Point(21, 21);
            this.cbGimnasio.Name = "cbGimnasio";
            this.cbGimnasio.Size = new System.Drawing.Size(93, 24);
            this.cbGimnasio.TabIndex = 0;
            this.cbGimnasio.Text = "Gimnasio";
            this.cbGimnasio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListaPasajeros);
            this.groupBox2.Location = new System.Drawing.Point(585, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 562);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista pasajeros:";
            // 
            // dgvListaPasajeros
            // 
            this.dgvListaPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvListaPasajeros.Location = new System.Drawing.Point(17, 26);
            this.dgvListaPasajeros.Name = "dgvListaPasajeros";
            this.dgvListaPasajeros.RowHeadersWidth = 51;
            this.dgvListaPasajeros.RowTemplate.Height = 29;
            this.dgvListaPasajeros.Size = new System.Drawing.Size(519, 526);
            this.dgvListaPasajeros.TabIndex = 1;
            this.dgvListaPasajeros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPasajeros_CellClick);
            this.dgvListaPasajeros.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvListaPasajeros_RowStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Pasaporte";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // InformesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.MinimumSize = new System.Drawing.Size(1170, 633);
            this.Name = "InformesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.InformesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaViajes)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCantCasinos;
        private System.Windows.Forms.TextBox txtCantSalones;
        private System.Windows.Forms.TextBox txtCantTurista;
        private System.Windows.Forms.TextBox txtCantPremium;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantBodega;
        private System.Windows.Forms.TextBox txtCantCamarote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbDiscoteca;
        private System.Windows.Forms.CheckBox cbGaleria;
        private System.Windows.Forms.CheckBox cbCine;
        private System.Windows.Forms.CheckBox cbTeatro;
        private System.Windows.Forms.CheckBox cbBar;
        private System.Windows.Forms.CheckBox cbSpa;
        private System.Windows.Forms.CheckBox cbPiscina;
        private System.Windows.Forms.CheckBox cbGimnasio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaPasajeros;
        private System.Windows.Forms.CheckBox cbCasino;
        private System.Windows.Forms.CheckBox cbComedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantTuristaDisponibles;
        private System.Windows.Forms.TextBox txtCantPremiumDisponbiles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCapacidadBodegaLibre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAyuda;
    }
}