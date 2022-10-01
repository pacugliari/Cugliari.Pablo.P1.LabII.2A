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
    public partial class VentaViajesForm : Form 
    {
        private List<Viaje> listaViajes;
        private Flota flota;
        private List<Viajero> listaViajeros;

        public VentaViajesForm()
        {
            this.InitializeComponent();
        }
        public VentaViajesForm(List<Viaje> listaViajes,Flota flota,List<Viajero> listaViajeros): this()
        {
            
            this.listaViajes = listaViajes;
            this.flota = flota;
            this.listaViajeros = new List<Viajero>();

            this.nudNumeroDocumento.Controls[0].Visible = false;
            this.nudNumeroDocumento.Text = "";
            this.cbSexo.Items.Add("Masculino");
            this.cbSexo.Items.Add("Femenino");

            this.dtpFechaNacimiento.MaxDate = this.dtpFechaNacimiento.Value = DateTime.Now;
            this.dtpFechaEmision.MaxDate = this.dtpFechaEmision.Value = DateTime.Now;
            this.dtpFechaVencimiento.MinDate = this.dtpFechaEmision.Value;
          

            foreach (ePaises item in Enum.GetValues(typeof(ePaises)))
            {
                if(item != ePaises.Vacio)
                    this.cbNacionalidad.Items.Add(item);
            }
            this.cbCantidadValijas.Items.Add(0);
            this.cbCantidadValijas.Items.Add(1);

            foreach (ePasaportes item in Enum.GetValues(typeof(ePasaportes)))
            {
                 this.cbTipoPasaporte.Items.Add(item);
            }

            this.dgvGrupoFamiliar.AllowUserToAddRows = false;
            this.dgvGrupoFamiliar.AllowUserToDeleteRows = false;
            this.dgvListaViajes.AllowUserToAddRows = false;
            this.dgvListaViajes.AllowUserToDeleteRows = false;
            this.btnVenderViaje.Enabled = false;
            this.btnBorrarPasajero.Enabled = false;
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            this.dgvListaViajes.Rows.Clear();
            this.txtCostoFinalBruto.Text = "";
            this.txtNeto.Text = "";

            if (estanTodosLosCamposCompletos())
            {
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                char sexo = 'M';
                string nacionalidad = this.cbNacionalidad.Text;
                DateTime fechaNacimiento = this.dtpFechaNacimiento.Value;
                string numeroDocumento = this.nudNumeroDocumento.Value.ToString();
                string domicilio = this.txtDomicilio.Text;
                string ciudad = this.txtCiudad.Text;
                string numeroDocumentoViaje = this.txtPasaporte.Text;
                DateTime fechaEmision = this.dtpFechaEmision.Value;
                DateTime fechaVencimiento = this.dtpFechaVencimiento.Value;
                string tipoPasaporte = this.cbTipoPasaporte.Text;
                string codigoPaisExterior = this.txtCodigoExterior.Text;
                string autoridadExpendidora = this.txtExpendidora.Text;
                bool tieneBolso = this.cbBolsoMano.Checked;
                int cantidadValijas;
                int.TryParse(this.cbCantidadValijas.Text, out cantidadValijas);
                Equipaje equipaje = new Equipaje(tieneBolso,cantidadValijas);
                bool esPremium = this.cbPremium.Checked;
                
                if(this.cbSexo.Text == "Femenino")
                {
                    sexo = 'F';
                }
                
                this.listaViajeros.Add(new Viajero(nombre, apellido, sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, ciudad,
                    numeroDocumentoViaje, fechaEmision, fechaVencimiento, tipoPasaporte, codigoPaisExterior, autoridadExpendidora,equipaje,esPremium));

                this.dgvGrupoFamiliar.Rows.Add(this.txtNombre.Text, this.txtApellido.Text);
            }
            else
                MessageBox.Show("Deben estar todos los campos completos de para dar de alta un pasajero:\n-Datos de pasajero\n-Datos de pasaporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool estanTodosLosCamposCompletos()
        {
            bool retorno = false;
            if (this.txtNombre.Text != "" &&
                this.txtApellido.Text != "" &&
                this.cbSexo.Text != "" &&
                this.cbNacionalidad.Text != "" &&
                this.dtpFechaNacimiento.Checked &&
                this.nudNumeroDocumento.Text != "" &&
                this.txtCiudad.Text != "" &&
                this.txtDomicilio.Text != "" &&
                this.txtPasaporte.Text != "" &&
                this.dtpFechaEmision.Checked &&
                this.dtpFechaVencimiento.Checked &&
                this.cbTipoPasaporte.Text != "" &&
                this.txtCodigoExterior.Text != "" &&
                this.txtExpendidora.Text != "")
            {
                retorno = true;
            }
            return retorno;
        }

        private void cbPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbPremium.Checked)
                this.cbCantidadValijas.Items.Add(2);
            else
                this.cbCantidadValijas.Items.Remove(2);
        }

        private void dgvGrupoFamiliar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvGrupoFamiliar.Rows.Count > 0)
            {
                this.dgvGrupoFamiliar.CurrentRow.Selected = true;
                this.btnBorrarPasajero.Enabled = true;
            }
            else
                this.btnBorrarPasajero.Enabled = false;
        }

        private void btnBorrarPasajero_Click(object sender, EventArgs e)
        {
            this.dgvListaViajes.Rows.Clear();
            this.txtCostoFinalBruto.Text = "";
            this.txtNeto.Text = "";

            if (this.dgvGrupoFamiliar.Rows.Count > 0)
            {
                this.listaViajeros.RemoveAt(this.dgvGrupoFamiliar.CurrentRow.Index);
                this.dgvGrupoFamiliar.Rows.Remove(this.dgvGrupoFamiliar.CurrentRow);
            }

            this.btnVenderViaje.Enabled = false;
            this.btnBorrarPasajero.Enabled = false;
        }

        private void dtpFechaEmision_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaVencimiento.MinDate = this.dtpFechaEmision.Value;
        }

        private List<eSalones> obtenerNecesidades()
        {
            List<eSalones> necesidades = new List<eSalones>();
            if (this.cbGimnasio.Checked)
                necesidades.Add(eSalones.Gimnasio);
            if (this.cbPiscina.Checked)
                necesidades.Add(eSalones.Piscina);
            if (this.cbSpa.Checked)
                necesidades.Add(eSalones.Spa);
            if (this.cbBar.Checked)
                necesidades.Add(eSalones.Bar);
            if (this.cbTeatro.Checked)
                necesidades.Add(eSalones.Teatro);
            if (this.cbCine.Checked)
                necesidades.Add(eSalones.Cine);
            if (this.cbGaleria.Checked)
                necesidades.Add(eSalones.Galeria);
            if (this.cbDiscoteca.Checked)
                necesidades.Add(eSalones.Discoteca);

            return necesidades;

        }

        private void btnBuscarViajes_Click(object sender, EventArgs e)
        {
            this.dgvListaViajes.Rows.Clear();
            if (this.dgvGrupoFamiliar.Rows.Count > 0)
            {
                List<Embarcacion> listaFiltradaDeCruceros = Flota.filtrarFlota(this.flota, this.obtenerNecesidades(), this.listaViajeros);
                List<Viaje> listaFiltradaDeViajes = Viaje.filtrarViajes(this.listaViajes, listaFiltradaDeCruceros);
                foreach (Viaje item in listaFiltradaDeViajes)
                {
                    this.dgvListaViajes.Rows.Add(item.CiudadPartida, item.CiudadDestino, item.Crucero, item.FechaInicioViaje,
                        item.CantidadCamarotesPremium, item.CantidadCamarotesTurista,
                        item.CostoPremium, item.CostoTurista, item.DuracionViaje);

                }
            }
        }

        private void dgvListaViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvListaViajes.Rows.Count > 0)
            {
                this.dgvListaViajes.CurrentRow.Selected = true;
                this.btnVenderViaje.Enabled = true;
                this.actualizar();
            }
            else
                this.btnVenderViaje.Enabled = false;
        }

        private void btnVenderViaje_Click(object sender, EventArgs e)
        {
            Embarcacion crucero;
            Viaje viaje;

            if (this.dgvListaViajes.Rows.Count > 0)
            {
                Menu.obtenerDatosDeDataGridView(this.dgvListaViajes,out crucero,out viaje);
                if(crucero is not null)
                {
                    crucero.agregarPasajeros(this.listaViajeros);
                    MessageBox.Show("La venta del viaje se realizo de manera exitosa", "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                    
            }

            this.btnVenderViaje.Enabled = false;
        }

       

        private void actualizar()
        {
            Viaje viaje;
            Embarcacion crucero;
            float costo=0;

            Menu.obtenerDatosDeDataGridView(this.dgvListaViajes, out crucero, out viaje);
            if (viaje is not null)
            {
                costo = viaje.calcularCostos(this.listaViajeros);
                this.txtCostoFinalBruto.Text = "$"+ costo.ToString(".##");
                this.txtNeto.Text = "$" + (costo*1.21).ToString(".##");

            }
        }

        private void dgvGrupoFamiliar_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.aplicarNumerosFilas(this.dgvGrupoFamiliar);
        }

        private void dgvListaViajes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.aplicarNumerosFilas(this.dgvListaViajes);
        }

        private void VentaViajesForm_Load(object sender, EventArgs e)
        {
            if(this.cbSexo.Items.Count > 0)
                this.cbSexo.SelectedIndex = 0;

            if (this.cbCantidadValijas.Items.Count > 0)
                this.cbCantidadValijas.SelectedIndex = 0;

            if (this.cbTipoPasaporte.Items.Count > 0)
                this.cbTipoPasaporte.SelectedIndex = 2;

            if (this.cbNacionalidad.Items.Count > 0)
                this.cbNacionalidad.SelectedIndex = 1;
        }

    }
}
