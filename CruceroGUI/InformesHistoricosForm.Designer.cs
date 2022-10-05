
namespace CruceroGUI
{
    partial class InformesHistoricosForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHorasCrucero = new System.Windows.Forms.RadioButton();
            this.rbPasajerosOrdenados = new System.Windows.Forms.RadioButton();
            this.rbDestinosOrdenados = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListaHorasCrucero = new System.Windows.Forms.DataGridView();
            this.Crucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestinosOrdenados = new System.Windows.Forms.DataGridView();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListaPasajeros = new System.Windows.Forms.DataGridView();
            this.CantidadViajes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHorasCrucero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosOrdenados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHorasCrucero);
            this.groupBox1.Controls.Add(this.rbPasajerosOrdenados);
            this.groupBox1.Controls.Add(this.rbDestinosOrdenados);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // rbHorasCrucero
            // 
            this.rbHorasCrucero.AutoSize = true;
            this.rbHorasCrucero.Location = new System.Drawing.Point(19, 81);
            this.rbHorasCrucero.Name = "rbHorasCrucero";
            this.rbHorasCrucero.Size = new System.Drawing.Size(235, 24);
            this.rbHorasCrucero.TabIndex = 2;
            this.rbHorasCrucero.TabStop = true;
            this.rbHorasCrucero.Text = "Horas de viaje de cada crucero";
            this.rbHorasCrucero.UseVisualStyleBackColor = true;
            this.rbHorasCrucero.CheckedChanged += new System.EventHandler(this.rbHorasCrucero_CheckedChanged);
            // 
            // rbPasajerosOrdenados
            // 
            this.rbPasajerosOrdenados.AutoSize = true;
            this.rbPasajerosOrdenados.Location = new System.Drawing.Point(19, 51);
            this.rbPasajerosOrdenados.Name = "rbPasajerosOrdenados";
            this.rbPasajerosOrdenados.Size = new System.Drawing.Size(445, 24);
            this.rbPasajerosOrdenados.TabIndex = 1;
            this.rbPasajerosOrdenados.TabStop = true;
            this.rbPasajerosOrdenados.Text = "Lista de pasajeros frecuentes ordenadas por cantidad de viajes";
            this.rbPasajerosOrdenados.UseVisualStyleBackColor = true;
            this.rbPasajerosOrdenados.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbDestinosOrdenados
            // 
            this.rbDestinosOrdenados.AutoSize = true;
            this.rbDestinosOrdenados.Location = new System.Drawing.Point(19, 27);
            this.rbDestinosOrdenados.Name = "rbDestinosOrdenados";
            this.rbDestinosOrdenados.Size = new System.Drawing.Size(473, 24);
            this.rbDestinosOrdenados.TabIndex = 0;
            this.rbDestinosOrdenados.TabStop = true;
            this.rbDestinosOrdenados.Text = "Lista de destinos ordenados por facturacion de forma descendente";
            this.rbDestinosOrdenados.UseVisualStyleBackColor = true;
            this.rbDestinosOrdenados.CheckedChanged += new System.EventHandler(this.rbDestinosOrdenados_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListaHorasCrucero);
            this.groupBox2.Controls.Add(this.dgvDestinosOrdenados);
            this.groupBox2.Controls.Add(this.dgvListaPasajeros);
            this.groupBox2.Location = new System.Drawing.Point(21, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion:";
            // 
            // dgvListaHorasCrucero
            // 
            this.dgvListaHorasCrucero.AllowUserToAddRows = false;
            this.dgvListaHorasCrucero.AllowUserToDeleteRows = false;
            this.dgvListaHorasCrucero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaHorasCrucero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Crucero,
            this.Horas,
            this.CantidadPasajeros});
            this.dgvListaHorasCrucero.Location = new System.Drawing.Point(6, 27);
            this.dgvListaHorasCrucero.Name = "dgvListaHorasCrucero";
            this.dgvListaHorasCrucero.ReadOnly = true;
            this.dgvListaHorasCrucero.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListaHorasCrucero.RowTemplate.Height = 29;
            this.dgvListaHorasCrucero.Size = new System.Drawing.Size(492, 275);
            this.dgvListaHorasCrucero.TabIndex = 3;
            // 
            // Crucero
            // 
            this.Crucero.HeaderText = "Crucero";
            this.Crucero.MinimumWidth = 6;
            this.Crucero.Name = "Crucero";
            this.Crucero.ReadOnly = true;
            this.Crucero.Width = 125;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.MinimumWidth = 6;
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            this.Horas.Width = 125;
            // 
            // CantidadPasajeros
            // 
            this.CantidadPasajeros.HeaderText = "Cantidad de pasajeros";
            this.CantidadPasajeros.MinimumWidth = 6;
            this.CantidadPasajeros.Name = "CantidadPasajeros";
            this.CantidadPasajeros.ReadOnly = true;
            this.CantidadPasajeros.Width = 125;
            // 
            // dgvDestinosOrdenados
            // 
            this.dgvDestinosOrdenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinosOrdenados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Destino,
            this.Facturacion});
            this.dgvDestinosOrdenados.Location = new System.Drawing.Point(6, 27);
            this.dgvDestinosOrdenados.Name = "dgvDestinosOrdenados";
            this.dgvDestinosOrdenados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDestinosOrdenados.RowTemplate.Height = 29;
            this.dgvDestinosOrdenados.Size = new System.Drawing.Size(492, 275);
            this.dgvDestinosOrdenados.TabIndex = 0;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.MinimumWidth = 6;
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 125;
            // 
            // Facturacion
            // 
            this.Facturacion.HeaderText = "Facturacion";
            this.Facturacion.MinimumWidth = 6;
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.ReadOnly = true;
            this.Facturacion.Width = 125;
            // 
            // dgvListaPasajeros
            // 
            this.dgvListaPasajeros.AllowUserToAddRows = false;
            this.dgvListaPasajeros.AllowUserToDeleteRows = false;
            this.dgvListaPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CantidadViajes,
            this.Pasaporte,
            this.Nombre,
            this.Apellido,
            this.Edad});
            this.dgvListaPasajeros.Location = new System.Drawing.Point(6, 27);
            this.dgvListaPasajeros.Name = "dgvListaPasajeros";
            this.dgvListaPasajeros.ReadOnly = true;
            this.dgvListaPasajeros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaPasajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvListaPasajeros.RowTemplate.Height = 29;
            this.dgvListaPasajeros.Size = new System.Drawing.Size(492, 275);
            this.dgvListaPasajeros.TabIndex = 2;
            // 
            // CantidadViajes
            // 
            this.CantidadViajes.HeaderText = "Cantidad Viajes";
            this.CantidadViajes.MinimumWidth = 6;
            this.CantidadViajes.Name = "CantidadViajes";
            this.CantidadViajes.ReadOnly = true;
            this.CantidadViajes.Width = 125;
            // 
            // Pasaporte
            // 
            this.Pasaporte.HeaderText = "Pasaporte";
            this.Pasaporte.MinimumWidth = 6;
            this.Pasaporte.Name = "Pasaporte";
            this.Pasaporte.ReadOnly = true;
            this.Pasaporte.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 125;
            // 
            // InformesHistoricosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(561, 497);
            this.Name = "InformesHistoricosForm";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.InformesHistoricosForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHorasCrucero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinosOrdenados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPasajerosOrdenados;
        private System.Windows.Forms.RadioButton rbDestinosOrdenados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDestinosOrdenados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facturacion;
        private System.Windows.Forms.DataGridView dgvListaPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadViajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.RadioButton rbHorasCrucero;
        private System.Windows.Forms.DataGridView dgvListaHorasCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPasajeros;
    }
}