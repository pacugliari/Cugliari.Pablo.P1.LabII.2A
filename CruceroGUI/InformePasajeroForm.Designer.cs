
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
            // InformePasajeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 388);
            this.MinimumSize = new System.Drawing.Size(784, 435);
            this.Name = "InformePasajeroForm";
            this.Text = "Datos del pasajero";
            this.Load += new System.EventHandler(this.InformePasajeroForm_Load);
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
    }
}