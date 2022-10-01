using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crucero;

namespace CruceroGUI
{
    public partial class InformePasajeroForm : VentaViajesForm
    {
        private Viajero pasajero;
        public InformePasajeroForm(Viajero pasajero) : base() {

            this.InitializeComponent();

            this.pasajero = pasajero;
            this.gbGrupoFamiliar.Visible = false;
            this.gbCostos.Visible = false;
            this.gbEquipaje.Visible = false;
            this.gbNecesidadesViaje.Visible = false;
            this.gbViajesDisponibles.Visible = false;
            this.btnAgregarPasajero.Visible = false;
            this.btnBorrarPasajero.Visible = false;
            this.btnBuscarViajes.Visible = false;
            this.btnVenderViaje.Visible = false;

            foreach (Control item in this.gbDatosPasajero.Controls)
            {
                item.Enabled = false;
            }

            foreach (Control item in this.gbDatosPasaporte.Controls)
            {
                item.Enabled = false;
            }


        }

        private void InformePasajeroForm_Load(object sender, EventArgs e)
        {
            //DATOS PERSONA
            this.txtNombre.Text = this.pasajero.Nombre;
            this.txtApellido.Text = this.pasajero.Apellido;
            this.cbSexo.Text = this.pasajero.Sexo;
            this.cbNacionalidad.Text = this.pasajero.Nacionalidad;
            this.dtpFechaNacimiento.Text = this.pasajero.FechaNacimiento;
            this.nudNumeroDocumento.Text = this.pasajero.NumeroDocumento;
            this.txtDomicilio.Text = this.pasajero.Domicilio;
            this.txtCiudad.Text = this.pasajero.LugarNacimiento;

            //DATOS PASAPORTE
            this.txtPasaporte.Text = this.pasajero.Pasaporte.NumeroDocumentoViaje;
            this.dtpFechaEmision.Value = this.pasajero.Pasaporte.FechaEmision;
            this.dtpFechaVencimiento.Value = this.pasajero.Pasaporte.FechaVencimiento;
            this.cbTipoPasaporte.Text = this.pasajero.Pasaporte.TipoPasaporte;
            this.txtCodigoExterior.Text = this.pasajero.Pasaporte.CodigoPaisExterior;
            this.txtExpendidora.Text = this.pasajero.Pasaporte.AutoridadExpedidora;
        }
    }
}

