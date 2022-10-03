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
        private List<Pasajero> listaViajeros;
        private List<Pasajero> clientes;
        private float recaudacion;

        public VentaViajesForm()
        {
            this.InitializeComponent();
            this.listaViajeros = new List<Pasajero>();
        }
        public VentaViajesForm(List<Viaje> listaViajes,Flota flota,List<Pasajero> clientes): this()
        {
            
            this.listaViajes = listaViajes;
            this.flota = flota; 
            this.clientes = clientes;
            this.recaudacion = 0;

            this.nudNumeroDocumento.Controls[0].Visible = false;
            this.nudNumeroDocumento.Text = "";
            this.cbSexo.Items.Add("Masculino");
            this.cbSexo.Items.Add("Femenino");

            this.dtpFechaNacimiento.MaxDate = this.dtpFechaNacimiento.Value = DateTime.Now;
            this.dtpFechaEmision.MaxDate = this.dtpFechaEmision.Value = DateTime.Now;
            this.dtpFechaVencimiento.MinDate = this.dtpFechaEmision.Value;

            this.cbSeleccionarCliente.Items.Add("Vacio");
          

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
            this.txtCostoFinalBruto.Text = "";
            this.txtNeto.Text = "";
            this.btnVenderViaje.Enabled = false;
            this.dgvListaViajes.Rows.Clear();
            this.dgvGrupoFamiliar.Rows.Clear();

            foreach (Pasajero item in this.listaViajeros)
            {
                this.dgvGrupoFamiliar.Rows.Add(item.Nombre, item.Apellido);
            }


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
            Equipaje equipaje = new Equipaje(tieneBolso, cantidadValijas);
            bool esPremium = this.cbPremium.Checked;
            bool darAlta = true;
            Pasajero pasajeroNuevo = Menu.buscarCliente(numeroDocumento.ToString());

            sexo = this.cbSexo.Text == "Femenino" ? 'F' : 'M';

            
            if (pasajeroNuevo is null)
            {
                if (estanTodosLosCamposCompletos())
                {
                    pasajeroNuevo = new Pasajero(nombre, apellido, sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, ciudad,
                                       numeroDocumentoViaje, fechaEmision, fechaVencimiento, tipoPasaporte, codigoPaisExterior, autoridadExpendidora, equipaje, esPremium);
                }
                else
                {
                    MessageBox.Show("Deben estar todos los campos completos de para dar de alta un pasajero:\n-Datos de pasajero\n-Datos de pasaporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    darAlta = false;
                }
                   
            }
            else if (pasajeroNuevo is not null && this.cbSeleccionarCliente.Text == "Vacio")
            {
                MessageBox.Show("El numero de documento ya se encuentra dado de alta como cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cbSeleccionarCliente.Focus();
                darAlta = false;
            }


            if (!this.listaViajeros.Contains(pasajeroNuevo) && darAlta )
            {
                this.habiliarEstadoDatosPasajero(true);
                this.VentaViajesForm_Load(sender, e);
                this.listaViajeros.Add(pasajeroNuevo);
                this.dgvGrupoFamiliar.Rows.Add(pasajeroNuevo.Nombre, pasajeroNuevo.Apellido);
            }


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
                List<Crucero.Crucero> listaFiltradaDeCruceros = Flota.filtrarFlota(this.flota, this.obtenerNecesidades(), this.listaViajeros);
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
            Crucero.Crucero crucero;
            Viaje viaje;
            StringBuilder textoRepetido = new StringBuilder();
            textoRepetido.AppendLine("Los siguientes pasajeros ya se encuentran en el viaje: ");
            bool hayRepetidos = false;

            if (this.dgvListaViajes.Rows.Count > 0)
            {
                this.dgvListaViajes.CurrentRow.Selected = true;
                this.btnVenderViaje.Enabled = true;
                Menu.obtenerDatosDeDataGridView(this.dgvListaViajes, out crucero, out viaje);
                foreach (Pasajero item in crucero.Pasajeros)
                {
                    if (this.listaViajeros.Contains(item))
                    {
                        hayRepetidos = true;
                        this.dgvGrupoFamiliar.Rows.RemoveAt(this.listaViajeros.IndexOf(item));
                        this.listaViajeros.Remove(item);
                        textoRepetido.AppendLine($"DNI:{item.NumeroDocumento}-Nombre:{item.Nombre}-Apellido:{item.Apellido}");
                    }  
                }
                if (hayRepetidos)
                {
                    MessageBox.Show(textoRepetido.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.listaViajeros.Count == 0)
                {
                    Menu.vaciarFormulario(this);

                }else
                    this.actualizar();
            }
            else
                this.btnVenderViaje.Enabled = false;
        }

        private void btnVenderViaje_Click(object sender, EventArgs e)
        {
            Crucero.Crucero crucero;
            Viaje viaje;
            List<Pasajero> filtrada = new List<Pasajero>();

            if (this.dgvListaViajes.Rows.Count > 0)
            {
                Menu.obtenerDatosDeDataGridView(this.dgvListaViajes,out crucero,out viaje);
                if (crucero is not null)
                {
                    
                    foreach (Pasajero item in this.listaViajeros)
                    {
                        if (!crucero.Pasajeros.Contains(item))
                        {
                            filtrada.Add(item);
                        }
                    }
                    foreach (Pasajero item in filtrada)
                    {
                        if (Historico.PasajerosConCantidadViajes.ContainsKey(item.NumeroDocumento))
                            Historico.PasajerosConCantidadViajes[item.NumeroDocumento]++;
                        else
                            Historico.PasajerosConCantidadViajes.Add(item.NumeroDocumento, 1);

                        if (!this.clientes.Contains(item))
                        {
                            this.cbSeleccionarCliente.Items.Add(item.NumeroDocumento + "," + item.Nombre + "," + item.Apellido);
                        }
                    }

                        crucero.agregarPasajeros(filtrada);
                        this.clientes.AddRange(filtrada);

                        Historico.DestinosConCantidadViajes[viaje.CiudadDestino]++;
                        Historico.CrucerosConHoras[crucero.Nombre] = viaje.DuracionViaje;
                        Historico.DestinosConFacturacion[viaje.CiudadDestino] += this.recaudacion;


                        MessageBox.Show("La venta del viaje se realizo de manera exitosa\n", "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                }
                    
            }
            this.listaViajeros.Clear();
            this.btnVenderViaje.Enabled = false;
        }

       

        private void actualizar()
        {
            Viaje viaje;
            Crucero.Crucero crucero;
            float costo=0;

            Menu.obtenerDatosDeDataGridView(this.dgvListaViajes, out crucero, out viaje);
            if (viaje is not null)
            {
                costo = viaje.calcularCostos(this.listaViajeros);
                this.txtCostoFinalBruto.Text = "$"+ costo.ToString(".##");
                this.txtNeto.Text = "$" + (costo*1.21).ToString(".##");
                this.recaudacion = (float)(costo * 1.21);
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

            this.recaudacion = 0;

            if(this.cbSeleccionarCliente.Items.Count > 0)
                this.cbSeleccionarCliente.SelectedIndex = 0;

            if (this.cbSexo.Items.Count > 0)
                this.cbSexo.SelectedIndex = 0;

            if (this.cbCantidadValijas.Items.Count > 0)
                this.cbCantidadValijas.SelectedIndex = 0;

            if (this.cbTipoPasaporte.Items.Count > 0)
                this.cbTipoPasaporte.SelectedIndex = 2;

            if (this.cbNacionalidad.Items.Count > 0)
                this.cbNacionalidad.SelectedIndex = 1;
        }

        protected virtual void cargarDatosPasajero(Pasajero pasajero)
        {
            //DATOS PERSONA
            if(pasajero is not null)
            {
                this.txtNombre.Text = pasajero.Nombre;
                this.txtApellido.Text = pasajero.Apellido;
                this.cbSexo.Text = pasajero.Sexo;
                this.cbNacionalidad.Text = pasajero.Nacionalidad;
                this.dtpFechaNacimiento.Text = pasajero.FechaNacimiento;
                this.nudNumeroDocumento.Text = pasajero.NumeroDocumento;
                this.txtDomicilio.Text = pasajero.Domicilio;
                this.txtCiudad.Text = pasajero.LugarNacimiento;
                //DATOS PASAPORTE
                this.txtPasaporte.Text = pasajero.Pasaporte.NumeroDocumentoViaje;
                this.dtpFechaEmision.Value = pasajero.Pasaporte.FechaEmision;
                this.dtpFechaVencimiento.Value = pasajero.Pasaporte.FechaVencimiento;
                this.cbTipoPasaporte.Text = pasajero.Pasaporte.TipoPasaporte;
                this.txtCodigoExterior.Text = pasajero.Pasaporte.CodigoPaisExterior;
                this.txtExpendidora.Text = pasajero.Pasaporte.AutoridadExpedidora;
            }

        }

        private void habiliarEstadoDatosPasajero(bool estado)
        {
            foreach (Control item in this.gbDatosPasajero.Controls)
            {
                item.Enabled = estado;
            }

            foreach (Control item in this.gbDatosPasaporte.Controls)
            {
                item.Enabled = estado;
            }
        }

        private void cbSeleccionarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = this.cbSeleccionarCliente.SelectedItem.ToString();
            if (texto != "Vacio")
            {
                texto = texto.Split(',')[0].ToString();
                Pasajero pasajero = Menu.buscarCliente(texto);
                this.cargarDatosPasajero(pasajero);
                this.habiliarEstadoDatosPasajero(false);
            }
            else
            {
                foreach (Control item in this.gbDatosPasajero.Controls)
                {
                    if(item is not Label && item is not ComboBox)
                    {
                        item.Text = "";
                    }
                    else if (item is ComboBox)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }

                foreach (Control item in this.gbDatosPasaporte.Controls)
                {
                    if (item is not Label && item is not ComboBox)
                    {
                        item.Text = "";
                    }else if (item is ComboBox)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }
                this.habiliarEstadoDatosPasajero(true);
            }



        }

        private void VentaViajesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.listaViajeros.Clear();
        }
    }
}
