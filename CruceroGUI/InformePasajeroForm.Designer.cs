
namespace CruceroGUI
{
    partial class InformePasajeroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformePasajeroForm));
            this.lblAyuda2 = new System.Windows.Forms.Label();
            this.gbEquipaje.SuspendLayout();
            this.gbDatosPasajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDocumento)).BeginInit();
            this.gbDatosPasaporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Checked = false;
            this.dtpFechaNacimiento.Value = new System.DateTime(2022, 10, 4, 21, 46, 19, 478);
            // 
            // gbDatosPasaporte
            // 
            this.gbDatosPasaporte.Location = new System.Drawing.Point(391, 55);
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Checked = false;
            this.dtpFechaEmision.Value = new System.DateTime(2022, 10, 4, 21, 46, 19, 483);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Checked = false;
            this.dtpFechaVencimiento.MinDate = new System.DateTime(2022, 10, 4, 21, 46, 19, 483);
            this.dtpFechaVencimiento.Value = new System.DateTime(2022, 10, 4, 21, 46, 19, 483);
            // 
            // cbSeleccionarCliente
            // 
            this.cbSeleccionarCliente.Items.AddRange(new object[] {
            "Vacio"});
            // 
            // lblAyuda
            // 
            this.lblAyuda.Location = new System.Drawing.Point(554, 7);
            this.lblAyuda.Visible = false;
            // 
            // lblAyuda2
            // 
            this.lblAyuda2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyuda2.AutoSize = true;
            this.lblAyuda2.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAyuda2.Image = ((System.Drawing.Image)(resources.GetObject("lblAyuda2.Image")));
            this.lblAyuda2.Location = new System.Drawing.Point(723, 7);
            this.lblAyuda2.Name = "lblAyuda2";
            this.lblAyuda2.Size = new System.Drawing.Size(29, 45);
            this.lblAyuda2.TabIndex = 24;
            this.lblAyuda2.Text = " ";
            // 
            // InformePasajeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 388);
            this.Controls.Add(this.lblAyuda2);
            this.MinimumSize = new System.Drawing.Size(784, 435);
            this.Name = "InformePasajeroForm";
            this.Text = "Datos del pasajero";
            this.Load += new System.EventHandler(this.InformePasajeroForm_Load);
            this.Controls.SetChildIndex(this.gbDatosPasajero, 0);
            this.Controls.SetChildIndex(this.gbDatosPasaporte, 0);
            this.Controls.SetChildIndex(this.gbGrupoFamiliar, 0);
            this.Controls.SetChildIndex(this.gbNecesidadesViaje, 0);
            this.Controls.SetChildIndex(this.gbViajesDisponibles, 0);
            this.Controls.SetChildIndex(this.btnAgregarPasajero, 0);
            this.Controls.SetChildIndex(this.gbEquipaje, 0);
            this.Controls.SetChildIndex(this.btnBorrarPasajero, 0);
            this.Controls.SetChildIndex(this.btnVenderViaje, 0);
            this.Controls.SetChildIndex(this.btnBuscarViajes, 0);
            this.Controls.SetChildIndex(this.gbCostos, 0);
            this.Controls.SetChildIndex(this.cbSeleccionarCliente, 0);
            this.Controls.SetChildIndex(this.lblSeleccionarCliente, 0);
            this.Controls.SetChildIndex(this.lblAyuda, 0);
            this.Controls.SetChildIndex(this.lblAyuda2, 0);
            this.gbEquipaje.ResumeLayout(false);
            this.gbEquipaje.PerformLayout();
            this.gbDatosPasajero.ResumeLayout(false);
            this.gbDatosPasajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroDocumento)).EndInit();
            this.gbDatosPasaporte.ResumeLayout(false);
            this.gbDatosPasaporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblAyuda2;
    }
}