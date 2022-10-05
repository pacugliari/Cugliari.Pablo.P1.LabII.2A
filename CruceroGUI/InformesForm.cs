using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CruceroLOG;

namespace CruceroGUI
{
    public partial class InformesForm : Form
    {
        private Viaje viajeSeleccionado;
        private Crucero cruceroSeleccionado;

        public InformesForm()
        {
            InitializeComponent();
            this.dgvListaViajes.AllowUserToAddRows = false;
            this.dgvListaViajes.AllowUserToDeleteRows = false;
            this.dgvListaPasajeros.AllowUserToAddRows = false;
            this.dgvListaPasajeros.AllowUserToDeleteRows = false;

            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Ventana para informes de viajes/cruceros y pasajeros");
            textoAyuda.AppendLine("Para poder consultar la informacion:");
            textoAyuda.AppendLine("1) Seleccionar un viaje de la lista");
            textoAyuda.AppendLine("2) Automaticamente mostrar en la parte inferior los datos del crucero");
            textoAyuda.AppendLine("3) A la derecha se cargan los pasajeros del viaje");
            textoAyuda.AppendLine("4) Si hacemos click sobre un pasajero nos mostrara la informacion del mismo");

            Login.MostrarAyuda(this.lblAyuda, textoAyuda.ToString());

        }

        private void dgvListaViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvListaPasajeros.Rows.Clear();
            if (this.dgvListaViajes.Rows.Count > 0)
            {
                this.dgvListaViajes.CurrentRow.Selected = true;
                Menu.obtenerDatosDeDataGridView(this.dgvListaViajes, out cruceroSeleccionado, out this.viajeSeleccionado);
                string[] estadoCrucero = this.viajeSeleccionado.Crucero.ToString().Split("-");

                this.txtMatricula.Text = estadoCrucero[0];
                this.txtNombre.Text = estadoCrucero[1];
                this.txtCantPremium.Text = this.viajeSeleccionado.Crucero.CamarotesPremium.ToString();
                this.txtCantPremiumDisponbiles.Text = this.viajeSeleccionado.Crucero.CamarotesPremiumLibres.ToString();
                this.txtCantTurista.Text = this.viajeSeleccionado.Crucero.CamarotesTurista.ToString();
                this.txtCantTuristaDisponibles.Text = this.viajeSeleccionado.Crucero.CamarotesTuristaLibres.ToString();
                this.txtCapacidadBodegaLibre.Text = this.viajeSeleccionado.Crucero.CapacidadBodegaLibre.ToString();
                this.txtCantSalones.Text = estadoCrucero[3];
                this.txtCantCasinos.Text = estadoCrucero[5];
                this.txtCantBodega.Text = estadoCrucero[6];
                this.txtCantCamarote.Text = estadoCrucero[9];


                if (this.viajeSeleccionado.Crucero.EstaCompleto())
                {
                    this.txtEstado.Text = "Completo";
                    this.txtEstado.BackColor = Color.Yellow;
                }
                else if (!this.viajeSeleccionado.Crucero.EstaDisponible)
                {
                    this.txtEstado.Text = "En viaje";
                    this.txtEstado.BackColor = Color.Red;
                }
                else
                {
                    this.txtEstado.Text = "Disponible";
                    this.txtEstado.BackColor = Color.Lime;
                }

                this.cbGimnasio.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Gimnasio);
                this.cbPiscina.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Piscina);
                this.cbSpa.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Spa);
                this.cbBar.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Bar);
                this.cbTeatro.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Teatro);
                this.cbCine.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Cine);
                this.cbGaleria.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Galeria);
                this.cbDiscoteca.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Discoteca);
                this.cbCasino.Checked  = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Casino);
                this.cbComedor.Checked = this.viajeSeleccionado.Crucero.TieneElSalon(eSalones.Comedor);


                for (int i = 0; i < this.viajeSeleccionado.CantidadPasajeros; i++)
                {
                    this.dgvListaPasajeros.Rows.Add(this.viajeSeleccionado[i].Pasaporte.NumeroDocumentoViaje,
                        this.viajeSeleccionado[i].Nombre, this.viajeSeleccionado[i].Apellido, this.viajeSeleccionado[i].Edad);
                }
            }
        }

        private void InformesForm_Load(object sender, EventArgs e)
        {
            Menu.VaciarFormulario(this);
            Menu.CargarListaViajesEn(dgvListaViajes);
            
        }

        private void dgvListaViajes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.AplicarNumerosFilas(this.dgvListaViajes);
        }

        private void dgvListaPasajeros_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.AplicarNumerosFilas(this.dgvListaPasajeros);
        }

        private void dgvListaPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(this.dgvListaPasajeros.RowCount > 0)
            {
                //Pasajero pasajero = this.cruceroSeleccionado.obtenerPasajero();
                Pasajero pasajero = Pasajero.BuscarPasajero(this.viajeSeleccionado, this.dgvListaPasajeros.CurrentRow.Cells[0].Value.ToString());
                if(pasajero is not null)
                {
                    this.dgvListaPasajeros.CurrentRow.Selected = true;
                    InformePasajeroForm datosPasajero = new InformePasajeroForm(pasajero);
                    datosPasajero.ShowDialog();
                }
                
            }
        }
    }
}
