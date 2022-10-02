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
    public partial class ViajesForm : Form
    {

        private Flota flota;
        private List<Viaje> listaViajes;
        private bool fechaElegida;
        private Crucero.Crucero cruceroElegido;
        private string ciudadPartida;
        private string ciudadDeDestino;
        private DateTime fechaInicioViaje;
        private string nombreDeCrucero;
        private int cantCamarotesPremium;
        private int cantCamarotesTurista;
        private float costoDeTurista;
        private float costoDePremium;
        private int duracionDeViaje;


        public ViajesForm(List<Viaje> listaViajes,Flota flota)
        {
            InitializeComponent();

            this.flota = flota;
            this.fechaElegida = false;
            this.listaViajes = listaViajes;

            //MUESTRA INFORMACION AYUDA PASANDO EL MOUSE SOBRE ARRIBA DEL CONTROL
            ToolTip yourToolTip = new ToolTip();
            yourToolTip.ToolTipIcon = ToolTipIcon.Info;
            yourToolTip.IsBalloon = true;
            yourToolTip.ShowAlways = true;

            //-----------------

            //CARGO LAS CIUDADES DE PARTIDA Y DESTINO

            foreach (eCiudades item in Enum.GetValues(typeof(eCiudades)))
            {
                if (item != eCiudades.BuenosAires_Argentina)
                    this.comboBoxCiudadDestino.Items.Add(item);
            }

            //CARGO LAS 7 EMBARCACIONES

            foreach (Crucero.Crucero item in this.flota.obtenerListaEmbarcacion())
            {
                this.comboBoxCrucero.Items.Add((string)item);
            }

            //INICIALIZO Y PONGO MIN/MAX A FECHA
            this.dateTimePickerFechaViaje.Value = DateTime.Now;
            this.dateTimePickerFechaViaje.MinDate = this.dateTimePickerFechaViaje.Value;


            //PARAMETROS LISTA VIAJES
            this.dgvListaViajes.AllowUserToAddRows = false;
            this.dgvListaViajes.AllowUserToDeleteRows = false;

        }

        private void comboBoxCrucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCruceroElegido = this.comboBoxCrucero.Text.ToString();
            this.cruceroElegido = this.flota.obtenerEmbarcacionDeNombre(nombreCruceroElegido);
            if(this.cruceroElegido is not null)
            {
                int camarotesPremium = this.cantCamarotesPremium = cruceroElegido.CamarotesPremium();
                int camarotesTurista = this.cantCamarotesTurista = cruceroElegido.CamarotesTurista();
                this.nombreDeCrucero = nombreCruceroElegido;
                this.textBoxCCP.Text = camarotesPremium.ToString();
                this.textBoxCCT.Text = camarotesTurista.ToString();
            } 
        }

        private void comboBoxCiudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDestinoElegido = this.comboBoxCiudadDestino.Text.ToString();

            int duracion = Viaje.calcularDuracion(nombreDestinoElegido);
            float costoTurista = Viaje.calcularPrecioTurista(nombreDestinoElegido, duracion);
            float costoPremium = Viaje.calcularPrecioPremium(nombreDestinoElegido, duracion);
            this.textBoxDuracionViaje.Text = duracion.ToString();
            this.textBoxCostoViajeTurista.Text = "$"+ costoTurista.ToString();
            this.textBoxCostoViajePremium.Text = "$" + costoPremium.ToString();
            this.ciudadDeDestino = nombreDestinoElegido;
            this.duracionDeViaje = duracion;
            this.costoDePremium = costoPremium;
            this.costoDeTurista = costoTurista;

        }

        private void actualizar()
        {
            this.dgvListaViajes.Rows.Clear();
            foreach (Viaje item in this.listaViajes)
            {
                this.dgvListaViajes.Rows.Add(item.CiudadPartida, item.CiudadDestino, item.Crucero, item.FechaInicioViaje,
                                    item.CantidadCamarotesPremium, item.CantidadCamarotesTurista,
                                    item.CostoPremium, item.CostoTurista, item.DuracionViaje);
            }
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCrucero.Text != "" && this.comboBoxCiudadDestino.Text != "" && this.fechaElegida)
            {
                this.comboBoxCrucero.Items.RemoveAt(this.comboBoxCrucero.SelectedIndex);
                Viaje  viajeNuevo = new Viaje(this.ciudadPartida, this.ciudadDeDestino, this.fechaInicioViaje, this.cruceroElegido, this.cantCamarotesPremium, this.cantCamarotesTurista,
                     this.costoDeTurista, this.costoDePremium, this.duracionDeViaje);
                this.listaViajes.Add(viajeNuevo);
                this.actualizar();
            }
            else
                MessageBox.Show("Debe completar los campos:\n-Crucero\n-Ciudad de Destino\n-Fecha de viaje","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void dateTimePickerFechaViaje_ValueChanged(object sender, EventArgs e)
        {
            
            if (this.dateTimePickerFechaViaje.Checked)
            {
                this.fechaInicioViaje = this.dateTimePickerFechaViaje.Value;
                this.fechaElegida = true;
            }
        }

        private void dgvListaViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvListaViajes.Rows.Count > 0)
            {
                this.dgvListaViajes.CurrentRow.Selected = true;
                this.btnBorrarViaje.Enabled = true;
            }else
                this.btnBorrarViaje.Enabled = false;

        }

        private void btnBorrarViaje_Click(object sender, EventArgs e)
        {
            if(this.dgvListaViajes.Rows.Count > 0)
            {
                this.listaViajes.RemoveAt(this.dgvListaViajes.CurrentRow.Index);
                this.actualizar();
            }
            
            this.btnBorrarViaje.Enabled = false;
        }

        private void dgvListaViajes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.aplicarNumerosFilas(this.dgvListaViajes);
        }

        private void ViajesForm_Load(object sender, EventArgs e)
        {
            this.comboBoxCiudadPartida.Items.Add(eCiudades.BuenosAires_Argentina);
            this.comboBoxCiudadPartida.SelectedIndex = 0;
            this.comboBoxCiudadPartida.Enabled = false;
            this.ciudadPartida = this.comboBoxCiudadPartida.Text.ToString();
            this.actualizar();
            this.textBoxCostoViajePremium.Text = "";
        }
    }
}
