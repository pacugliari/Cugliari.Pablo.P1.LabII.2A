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
        private Pasajero pasajero;
        public InformePasajeroForm(Pasajero pasajero) : base() {

            this.InitializeComponent();

            this.pasajero = pasajero;
            this.gbGrupoFamiliar.Visible = false;
            this.gbCostos.Visible = false;
            //this.gbEquipaje.Visible = false;
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

            foreach (Control item in this.gbEquipaje.Controls)
            {
                item.Enabled = false;
            }

        }

        private void InformePasajeroForm_Load(object sender, EventArgs e)
        {

            base.cargarDatosPasajero(this.pasajero);
            this.lblSeleccionarCliente.Visible = false;
            this.cbSeleccionarCliente.Visible = false;

            //EQUIPAJE
            this.cbBolsoMano.Checked = this.pasajero.Equipaje.BolsoMano;
            this.cbPremium.Checked = this.pasajero.EsPremium;
            this.cbCantidadValijas.SelectedItem = this.pasajero.Equipaje.Valijas;

        }
    }
}

