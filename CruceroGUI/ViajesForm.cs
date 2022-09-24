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
        private Viaje viaje;
        private bool fechaElegida;
        public ViajesForm()
        {
            InitializeComponent();
            this.flota = new Flota();
            this.viaje = new Viaje();
            this.fechaElegida = false;

            //MUESTRA INFORMACION AYUDA PASANDO EL MOUSE SOBRE ARRIBA DEL CONTROL
            ToolTip yourToolTip = new ToolTip();
            yourToolTip.ToolTipIcon = ToolTipIcon.Info;
            yourToolTip.IsBalloon = true;
            yourToolTip.ShowAlways = true;
            /*
            yourToolTip.SetToolTip(this.lblCCP, "Cantidad de camarotes disponibles para clase premium");
            yourToolTip.SetToolTip(this.lblCCT, "Cantidad de camarotes disponibles para clase turista");
            yourToolTip.SetToolTip(this.lblP, "Costo del viaje clase premium en dolares");
            yourToolTip.SetToolTip(this.lblT, "Costo del viaje clase turista en dolares");*/
            //-----------------

            //CARGO LAS CIUDADES DE PARTIDA Y DESTINO
            this.comboBoxCiudadPartida.Items.Add(eCiudades.BuenosAires_Argentina);
            this.comboBoxCiudadPartida.SelectedIndex = 0;
            this.comboBoxCiudadPartida.Enabled = false;
            this.viaje.CiudadPartida = this.comboBoxCiudadPartida.Text.ToString();

            foreach (eCiudades item in Enum.GetValues(typeof(eCiudades)))
            {
                if (item != eCiudades.BuenosAires_Argentina)
                    this.comboBoxCiudadDestino.Items.Add(item);
            }

            //CARGO LAS 7 EMBARCACIONES

            foreach (Embarcacion item in this.flota.obtenerListaEmbarcacion())
            {
                this.comboBoxCrucero.Items.Add((string)item);
            }

            //INICIALIZO Y PONGO MIN/MAX A FECHA
            this.dateTimePickerFechaViaje.Value = DateTime.Now;
            this.dateTimePickerFechaViaje.MinDate = this.dateTimePickerFechaViaje.Value;

        }

        private void comboBoxCrucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCruceroElegido = this.comboBoxCrucero.Text.ToString();
            Embarcacion cruceroElegido = this.flota.obtenerEmbarcacionDeNombre(nombreCruceroElegido);
            int camarotesPremium = cruceroElegido.CamarotesPremium();
            int camarotesTurista = cruceroElegido.CamarotesTurista();
            this.viaje.Crucero = cruceroElegido;
            this.viaje.CantidadCamarotesPremium = camarotesPremium;
            this.viaje.CantidadCamarotesTurista = camarotesTurista;
            this.textBoxCCP.Text = camarotesPremium.ToString();
            this.textBoxCCT.Text = camarotesTurista.ToString();
            
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
            this.viaje.CiudadDestino = nombreDestinoElegido;
            this.viaje.DuracionViaje = duracion;
            this.viaje.CostoTurista = costoTurista;
            this.viaje.CostoPremium = costoPremium;

        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCrucero.Text != "" && this.comboBoxCiudadDestino.Text != "" && this.fechaElegida)
            {
                this.listBoxListaViajes.Items.Add((string)this.viaje);
            }
            else
                MessageBox.Show("Debe completar los campos:\n-Crucero\n-Ciudad de Destino\n-Fecha de viaje","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void dateTimePickerFechaViaje_ValueChanged(object sender, EventArgs e)
        {
            
            if (this.dateTimePickerFechaViaje.Checked)
            {
                this.viaje.FechaInicioViaje = this.dateTimePickerFechaViaje.Value;
                this.fechaElegida = true;
            }
        }
    }
}
