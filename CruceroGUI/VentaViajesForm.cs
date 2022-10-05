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
    public partial class VentaViajesForm : Form 
    {
        private List<Pasajero> grupoFamiliar;
        private float recaudacion;


        public VentaViajesForm()
        {
            this.InitializeComponent();
            this.grupoFamiliar = new List<Pasajero>();
            this.recaudacion = 0;

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

            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Ventana para ventas de viajes");
            textoAyuda.AppendLine("Para poder dar de alta un pasajero se debe :");
            textoAyuda.AppendLine("1) Cargar los datos de pasajero,pasaporte y equipaje o seleccionar un cliente precargado");
            textoAyuda.AppendLine("2) Click boton agregar pasajero");
            textoAyuda.AppendLine("3) Seleccionamos el pasajero agregado en la tabla de grupo familiar o podemos agregar mas");
            textoAyuda.AppendLine("4) Click buscar viajes, el sistema nos trae los viajes que cumplen con las caracteristicas del");
            textoAyuda.AppendLine("     de las necesidades de viaje y los pasajeros cargados");
            textoAyuda.AppendLine("5) Seleccionamos de la lista de viajes el deseado");
            textoAyuda.AppendLine("6) Nos muestra el total a pagar y luego click en vender viaje");

            Login.MostrarAyuda(this.lblAyuda, textoAyuda.ToString());
        }

        private void HardcodearClientes()
        {
            this.cbSeleccionarCliente.Items.Clear();
            this.cbSeleccionarCliente.Items.Add("Vacio");
            foreach (Pasajero item in Menu.Clientes)
            {
                this.cbSeleccionarCliente.Items.Add(item.NumeroDocumento + "," + item.Nombre + "," + item.Apellido);
            }
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            this.txtCostoFinalBruto.Text = "";
            this.txtNeto.Text = "";
            this.btnVenderViaje.Enabled = false;
            this.dgvListaViajes.Rows.Clear();
            this.dgvGrupoFamiliar.Rows.Clear();

            foreach (Pasajero item in this.grupoFamiliar)
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
            Pasajero pasajeroNuevo = Pasajero.BuscarPasajero(Menu.Clientes,numeroDocumento.ToString());

            sexo = this.cbSexo.Text == "Femenino" ? 'F' : 'M';
            

            if (pasajeroNuevo is null && !estanTodosLosCamposCompletos())//NO ESTA COMO CLIENTE VERIFICO QUE CARGUE TODOS LOS DATOS
            {

                MessageBox.Show("Deben estar todos los campos completos de para dar de alta un pasajero:\n-Datos de pasajero\n-Datos de pasaporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                darAlta = false;
    
            }
            else if (pasajeroNuevo is not null && this.cbSeleccionarCliente.Text == "Vacio")//CARGO LOS DATOS PERO ESTA COMO CLIENTE
            {
                MessageBox.Show("El numero de documento ya se encuentra dado de alta como cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cbSeleccionarCliente.Focus();
                darAlta = false;
            }


            if (!this.grupoFamiliar.Contains(pasajeroNuevo) && darAlta )//CARGO EN EL GRUPO FAMILIAR SI NO ESTA YA DADO DE ALTA 
            {
                pasajeroNuevo = new Pasajero(nombre, apellido, sexo, nacionalidad, fechaNacimiento, numeroDocumento, domicilio, ciudad,
                                     numeroDocumentoViaje, fechaEmision, fechaVencimiento, tipoPasaporte, codigoPaisExterior, autoridadExpendidora, equipaje, esPremium);
                this.ActivarIngresoDatosPasajero(true);
                this.VentaViajesForm_Load(sender, e);
                this.grupoFamiliar.Add(pasajeroNuevo);
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
            foreach (Control item in this.gbDatosPasajero.Controls)
            {
                if(item.Text == "")
                {

                    item.BackColor = Color.Red;
                }
            }
            foreach (Control item in this.gbDatosPasaporte.Controls)
            {
                if (item.Text == "")
                {
                    item.BackColor = Color.Red;
                }
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
                this.grupoFamiliar.RemoveAt(this.dgvGrupoFamiliar.CurrentRow.Index);
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
                List<Crucero> listaFiltradaDeCruceros = Flota.FiltrarFlota(this.obtenerNecesidades(), this.grupoFamiliar);
                List<Viaje> listaFiltradaDeViajes = Viaje.FiltrarViajes(Menu.ListaViajes, listaFiltradaDeCruceros);
                foreach (Viaje item in listaFiltradaDeViajes)
                {

                    this.dgvListaViajes.Rows.Add(item.ToString().Split("-"));
                }
            }
        }

        private void dgvListaViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Crucero crucero;
            Viaje viaje;
            StringBuilder mensajeViajerosRepetidos = new StringBuilder();
            mensajeViajerosRepetidos.AppendLine("Los siguientes pasajeros ya se encuentran en el viaje: ");
            bool hayRepetidos = false;

            if (this.dgvListaViajes.Rows.Count > 0)
            {
                this.dgvListaViajes.CurrentRow.Selected = true;
                this.btnVenderViaje.Enabled = true;
                Menu.obtenerDatosDeDataGridView(this.dgvListaViajes, out crucero, out viaje);
                /*for (int i = 0; i < crucero.CantidadPasajeros; i++)
                {
                    if (this.grupoFamiliar.Contains(crucero[i]))//VERIFICO QUE LOS VIAJEROS NO SE ENCUENTREN EN EL VIAJE
                    {
                        hayRepetidos = true;
                        this.dgvGrupoFamiliar.Rows.RemoveAt(this.grupoFamiliar.IndexOf(crucero[i]));
                        this.grupoFamiliar.Remove(crucero[i]);
                        mensajeViajerosRepetidos.AppendLine($"DNI:{crucero[i].NumeroDocumento}-Nombre:{crucero[i].Nombre}" +
                            $"-Apellido:{crucero[i].Apellido}");
                    }
                }*/
                for (int i = 0; i < viaje.CantidadPasajeros; i++)
                {
                    if (this.grupoFamiliar.Contains(viaje[i]))//VERIFICO QUE LOS VIAJEROS NO SE ENCUENTREN EN EL VIAJE
                    {
                        hayRepetidos = true;
                        this.dgvGrupoFamiliar.Rows.RemoveAt(this.grupoFamiliar.IndexOf(viaje[i]));
                        this.grupoFamiliar.Remove(viaje[i]);
                        mensajeViajerosRepetidos.AppendLine($"DNI:{viaje[i].NumeroDocumento}-Nombre:{viaje[i].Nombre}" +
                            $"-Apellido:{viaje[i].Apellido}");
                    }
                }
                if (hayRepetidos)
                {
                    MessageBox.Show(mensajeViajerosRepetidos.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.grupoFamiliar.Count == 0)//REINICIO EL FORMULARIO SI ME QUEDO SIN PASAJEROS
                {
                    Menu.VaciarFormulario(this);

                }else // ACTUALIZO EL PRECIO
                    this.actualizar();
            }
            else
                this.btnVenderViaje.Enabled = false;
        }

        private void btnVenderViaje_Click(object sender, EventArgs e)
        {
            Crucero crucero;
            Viaje viaje;

            if (this.dgvListaViajes.Rows.Count > 0)
            {
                Menu.obtenerDatosDeDataGridView(this.dgvListaViajes,out crucero,out viaje);
                if (crucero is not null)
                {
                    foreach (Pasajero item in this.grupoFamiliar)
                    {
                        if (Historico.PasajerosConCantidadViajes.ContainsKey(item.NumeroDocumento))
                            Historico.PasajerosConCantidadViajes[item.NumeroDocumento]++;
                        else
                            Historico.PasajerosConCantidadViajes.Add(item.NumeroDocumento, 1);

                       if (!Menu.Clientes.Contains(item))
                        {
                            this.cbSeleccionarCliente.Items.Add(item.NumeroDocumento + "," + item.Nombre + "," + item.Apellido);
                            Menu.Clientes.Add(item);
                        }
                    }

                            //Menu.Clientes.AddRange(this.grupoFamiliar);
                        viaje.AgregarPasajeros(this.grupoFamiliar);

                        Historico.DestinosConCantidadViajes[viaje.CiudadDestino]++;
                        Historico.CrucerosConHoras[crucero.Nombre] = viaje.DuracionViaje;
                        Historico.DestinosConFacturacion[viaje.CiudadDestino] += this.recaudacion;


                        MessageBox.Show("La venta del viaje se realizo de manera exitosa\n", "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                }
                    
            }
            this.grupoFamiliar.Clear();
            this.btnVenderViaje.Enabled = false;
        }

       

        private void actualizar()
        {
            Viaje viaje;
            Crucero crucero;
            float costo=0;

            Menu.obtenerDatosDeDataGridView(this.dgvListaViajes, out crucero, out viaje);
            if (viaje is not null)
            {
                costo = viaje.CalcularCostos(this.grupoFamiliar);
                this.txtCostoFinalBruto.Text = "$"+ costo.ToString(".##");
                this.txtNeto.Text = "$" + (costo*1.21).ToString(".##");
                this.recaudacion = (float)(costo * 1.21);
            }
        }

        private void dgvGrupoFamiliar_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.AplicarNumerosFilas(this.dgvGrupoFamiliar);
        }

        private void dgvListaViajes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Menu.AplicarNumerosFilas(this.dgvListaViajes);
        }

        private void VentaViajesForm_Load(object sender, EventArgs e)
        {
            this.HardcodearClientes();
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
                string[] estadoPasajero = pasajero.ToString().Split("-");
                string[] estadoPasaporte = pasajero.Pasaporte.ToString().Split("-");
                this.txtNombre.Text = estadoPasajero[0];
                this.txtApellido.Text = estadoPasajero[1];
                this.cbSexo.Text = estadoPasajero[2];
                this.cbNacionalidad.Text = estadoPasajero[3];
                this.dtpFechaNacimiento.Text = estadoPasajero[4];
                this.nudNumeroDocumento.Text = estadoPasajero[5];
                this.txtDomicilio.Text = estadoPasajero[6];
                this.txtCiudad.Text = estadoPasajero[7];
                //DATOS PASAPORTE
                this.txtPasaporte.Text = estadoPasaporte[0];
                this.dtpFechaEmision.Value = DateTime.Parse(estadoPasaporte[1]);
                this.dtpFechaVencimiento.Value = DateTime.Parse(estadoPasaporte[2]);
                this.cbTipoPasaporte.Text = estadoPasaporte[3];
                this.txtCodigoExterior.Text = estadoPasaporte[4];
                this.txtExpendidora.Text = estadoPasaporte[5];
            }

        }

        protected void ActivarIngresoDatosPasajero(bool estado)
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
            string numeroDocumento = this.cbSeleccionarCliente.SelectedItem.ToString();
            if (numeroDocumento != "Vacio")
            {
                numeroDocumento = numeroDocumento.Split(',')[0].ToString();
                Pasajero pasajero = Pasajero.BuscarPasajero(Menu.Clientes,numeroDocumento);
                this.cargarDatosPasajero(pasajero);
                this.ActivarIngresoDatosPasajero(false);
                
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
                this.ActivarIngresoDatosPasajero(true);
            }



        }

        private void VentaViajesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.grupoFamiliar.Clear();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            this.txtNombre.BackColor = Color.White;
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            this.txtApellido.BackColor = Color.White;
        }

        private void nudNumeroDocumento_Click(object sender, EventArgs e)
        {
            this.nudNumeroDocumento.BackColor = Color.White;
        }

        private void txtCiudad_Click(object sender, EventArgs e)
        {
            this.txtCiudad.BackColor = Color.White;
        }

        private void txtDomicilio_Click(object sender, EventArgs e)
        {
            this.txtDomicilio.BackColor = Color.White;
        }

        private void cbSexo_Click(object sender, EventArgs e)
        {
            this.cbSexo.BackColor = Color.White;
        }

        private void cbNacionalidad_Click(object sender, EventArgs e)
        {
            this.cbNacionalidad.BackColor = Color.White;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaNacimiento.BackColor = Color.White;
        }

        private void txtPasaporte_Click(object sender, EventArgs e)
        {
            this.txtPasaporte.BackColor = Color.White;
        }

        private void dtpFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaVencimiento.BackColor = Color.White;
        }

        private void cbTipoPasaporte_Click(object sender, EventArgs e)
        {
            this.cbTipoPasaporte.BackColor = Color.White;
        }

        private void txtCodigoExterior_Click(object sender, EventArgs e)
        {
            this.txtCodigoExterior.BackColor = Color.White;
        }

        private void txtExpendidora_Click(object sender, EventArgs e)
        {
            this.txtExpendidora.BackColor = Color.White;
        }
    }
}
