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
    public partial class InformesForm : Form
    {
        private List<Viaje> listaViajes;
        private Crucero.Crucero cruceroSeleccionado;
        public InformesForm(List<Viaje> listaViajes)
        {
            InitializeComponent();
            this.listaViajes = listaViajes;
            this.dgvListaViajes.AllowUserToAddRows = false;
            this.dgvListaViajes.AllowUserToDeleteRows = false;
            this.dgvListaPasajeros.AllowUserToAddRows = false;
            this.dgvListaPasajeros.AllowUserToDeleteRows = false;

        }

        private void dgvListaViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Viaje viaje;
            this.dgvListaPasajeros.Rows.Clear();
            if (this.dgvListaViajes.Rows.Count > 0)
            {
                this.dgvListaViajes.CurrentRow.Selected = true;
                Menu.obtenerDatosDeDataGridView(this.dgvListaViajes, out this.cruceroSeleccionado, out viaje);
                this.txtMatricula.Text = this.cruceroSeleccionado.Matricula;
                this.txtNombre.Text = this.cruceroSeleccionado.Nombre;
                this.txtCantPremium.Text = this.cruceroSeleccionado.CamarotesPremium().ToString();
                this.txtCantPremiumDisponbiles.Text = (this.cruceroSeleccionado.CamarotesPremium() - this.cruceroSeleccionado.CamarotesPremiumUsados).ToString();
                this.txtCantTurista.Text = this.cruceroSeleccionado.CamarotesTurista().ToString();
                this.txtCantTuristaDisponibles.Text = (this.cruceroSeleccionado.CamarotesTurista() - this.cruceroSeleccionado.CamarotesTuristaUsados).ToString();
                this.txtCapacidadBodegaLibre.Text = (this.cruceroSeleccionado.CapacidadBodega - this.cruceroSeleccionado.CapacidadBodegaUsada).ToString();
                this.txtCantSalones.Text = this.cruceroSeleccionado.CantidadSalones;
                this.txtCantCasinos.Text = this.cruceroSeleccionado.CantidadCasinos;
                this.txtCantBodega.Text = this.cruceroSeleccionado.CapacidadBodega.ToString("#.##");
                this.txtCantCamarote.Text = this.cruceroSeleccionado.CantidadPasajerosPorCamarote;

                if (this.cruceroSeleccionado.estaCompleto())
                {
                    this.txtEstado.Text = "Completo";
                    this.txtEstado.BackColor = Color.Yellow;
                }
                else if (!this.cruceroSeleccionado.EstaDisponible)
                {
                    this.txtEstado.Text = "En viaje";
                    this.txtEstado.BackColor = Color.Red;
                }
                else
                {
                    this.txtEstado.Text = "Disponible";
                    this.txtEstado.BackColor = Color.Lime;
                }

                this.cbGimnasio.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Gimnasio);
                this.cbPiscina.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Piscina);
                this.cbSpa.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Spa);
                this.cbBar.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Bar);
                this.cbTeatro.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Teatro);
                this.cbCine.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Cine);
                this.cbGaleria.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Galeria);
                this.cbDiscoteca.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Discoteca);
                this.cbCasino.Checked  = this.cruceroSeleccionado.tieneElSalon(eSalones.Casino);
                this.cbComedor.Checked = this.cruceroSeleccionado.tieneElSalon(eSalones.Comedor);

                foreach (Pasajero item in this.cruceroSeleccionado.Pasajeros)
                {
                    this.dgvListaPasajeros.Rows.Add(item.Pasaporte.NumeroDocumentoViaje,item.Nombre,item.Apellido,item.Edad);
                }
            }
        }

        private void InformesForm_Load(object sender, EventArgs e)
        {
            Menu.vaciarFormulario(this);
            this.dgvListaViajes.Rows.Clear();
            foreach (Viaje item in this.listaViajes)
            {
                this.dgvListaViajes.Rows.Add(item.CiudadPartida, item.CiudadDestino, item.Crucero, item.FechaInicioViaje,
                                    item.CantidadCamarotesPremium, item.CantidadCamarotesTurista,
                                    item.CostoPremium, item.CostoTurista, item.DuracionViaje);
            }
        }

        private void dgvListaViajes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.aplicarNumerosFilas(this.dgvListaViajes);
        }

        private void dgvListaPasajeros_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.aplicarNumerosFilas(this.dgvListaPasajeros);
        }

        private void dgvListaPasajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(this.dgvListaPasajeros.RowCount > 0)
            {
                Pasajero pasajero = this.cruceroSeleccionado.obtenerPasajero(this.dgvListaPasajeros.CurrentRow.Cells[0].Value.ToString());
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
