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
    public partial class Menu : Form
    {

        private VentaViajesForm ventaViajesForm;
        private ViajesForm viajesForm;
        private InformesForm informesForm;
        private InformesHistoricosForm informesHistoricosForm;
        private static List<Viaje> listaViajes;
        private static List<Pasajero> clientes;

        public static List<Pasajero> Clientes { get { return Menu.clientes; } }
        public static List<Viaje> ListaViajes { get { return Menu.listaViajes; } }

        public void HardCodearViajes()
        {
            Crucero cruceroPrueba = Flota.ObtenerListaEmbarcacion()[2];
            Viaje viajePrueba = Crucero.CrearViajePrueba(cruceroPrueba, eCiudades.Ushuaia_Argentina);

            Crucero cruceroPrueba2 = Flota.ObtenerListaEmbarcacion()[5];
            Viaje viajePrueba2 = Crucero.CrearViajePrueba(cruceroPrueba2, eCiudades.Venecia_Italia);

            Pasajero pasajero1 = new Pasajero("Pablo", "Cugliari", 'M', "Argentina", Convert.ToDateTime("13/06/1997"),
            "40549113", "Ricardo rojas 1099", "Quilmes", "PC13061997", Convert.ToDateTime("20/05/2020"),
            Convert.ToDateTime("20/05/2030"), ePasaportes.Especial.ToString(),
            "ARG", "RENAPER", new Equipaje(true, 1), false);

            Pasajero pasajero2 = new Pasajero("Ermelinda", "Vera", 'F', "Argentina", Convert.ToDateTime("4/04/1938"),
            "36016049", "Triunvirato 4305", "Quilmes", "EV4041938", Convert.ToDateTime("20/05/2020"),
            Convert.ToDateTime("20/05/2030"), ePasaportes.Diplomatico.ToString(),
            "ARG", "RENAPER", new Equipaje(true, 0), false);

            Pasajero pasajero3 = new Pasajero("Antonio", "Mena", 'M', "Argentina", Convert.ToDateTime("15/06/1997"),
            "7446831", "Blas Parera 1240", "Quilmes", "AM15061197", Convert.ToDateTime("20/05/2020"),
            Convert.ToDateTime("20/05/2030"), ePasaportes.Ordinario.ToString(),
            "ARG", "RENAPER", new Equipaje(false, 1), false);

            Pasajero pasajero4 = new Pasajero("Donna", "Benfenati", 'F', "Argentina", Convert.ToDateTime("19/09/1997"),
            "40862214", "Brandsen 4130", "Quilmes", "DB19091197", Convert.ToDateTime("20/05/2020"),
            Convert.ToDateTime("20/05/2030"), ePasaportes.Especial.ToString(),
            "ARG", "RENAPER", new Equipaje(true, 2), true);

            Pasajero pasajero5 = new Pasajero("Franco", "Albanese", 'M', "Argentina", Convert.ToDateTime("17/01/1965"),
            "17260214", "Islas Malvinas 2350", "Quilmes", "FC17011965", Convert.ToDateTime("20/05/2020"),
            Convert.ToDateTime("20/05/2030"), ePasaportes.Ordinario.ToString(),
            "ARG", "RENAPER", new Equipaje(false, 2), true);

            List<Pasajero> lista1 = new List<Pasajero> { pasajero1,pasajero2 };
            List<Pasajero> lista2 = new List<Pasajero> { pasajero3, pasajero4,pasajero5};

            viajePrueba.AgregarPasajeros(lista1);
            viajePrueba2.AgregarPasajeros(lista2);

            Menu.clientes.AddRange(lista1);
            Menu.clientes.AddRange(lista2);
            Menu.listaViajes.Add(viajePrueba);
            Menu.listaViajes.Add(viajePrueba2);

            Historico.DestinosConCantidadViajes[eCiudades.Ushuaia_Argentina.ToString()]++;
            Historico.DestinosConCantidadViajes[eCiudades.Venecia_Italia.ToString()]++;
            Historico.CrucerosConHoras[cruceroPrueba.Nombre] = viajePrueba.DuracionViaje;
            Historico.CrucerosConHoras[cruceroPrueba2.Nombre] = viajePrueba2.DuracionViaje;
            Historico.DestinosConFacturacion[viajePrueba.CiudadDestino] += viajePrueba.CalcularCostos(lista1)*1.21f;
            Historico.DestinosConFacturacion[viajePrueba2.CiudadDestino] += viajePrueba2.CalcularCostos(lista2)*1.21f;
            Historico.PasajerosConCantidadViajes.Add(pasajero1.NumeroDocumento, 1);
            Historico.PasajerosConCantidadViajes.Add(pasajero2.NumeroDocumento, 1);
            Historico.PasajerosConCantidadViajes.Add(pasajero3.NumeroDocumento, 1);
            Historico.PasajerosConCantidadViajes.Add(pasajero4.NumeroDocumento, 1);
            Historico.PasajerosConCantidadViajes.Add(pasajero5.NumeroDocumento, 1);

            
        }

        static Menu()
        {
            Menu.listaViajes = new List<Viaje>();
            Menu.clientes = new List<Pasajero>();
        }
        public Menu(Vendedor usuario)
        {
            InitializeComponent();
            this.txtInformacionVendedor.Text = (string)usuario; 
            this.viajesForm = new ViajesForm();
            this.ventaViajesForm = new VentaViajesForm();
            this.informesForm = new InformesForm();
            this.informesHistoricosForm = new InformesHistoricosForm();
            this.HardCodearViajes();

            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Ventana de menu donde podras encontrar los datos del operador actual");
            textoAyuda.AppendLine("ademas de las acciones disponibles para realizar, alta de viaje,vender viaje,");
            textoAyuda.AppendLine("consultar por el estado de los viajes,cruceros y pasajeros dentro de ese viaje ");
            textoAyuda.AppendLine("pudiendo ver un historial de los cruceros/pasajeros/destinos/etc");
            Login.MostrarAyuda(this.lblAyuda, textoAyuda.ToString());
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            Menu.VaciarFormulario(this.viajesForm);
            this.viajesForm.ShowDialog();
        }

        private void btnVentaViajes_Click(object sender, EventArgs e)
        {
            Menu.VaciarFormulario(this.ventaViajesForm);
            this.ventaViajesForm.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            Menu.VaciarFormulario(this.informesForm);
            this.informesForm.ShowDialog();
        }


        private void btnInformesHistoricos_Click(object sender, EventArgs e)
        {
            this.informesHistoricosForm.ShowDialog();
        }

        public static void AplicarNumerosFilas(DataGridView lista)
        {
            for (int i = 0; i < lista.Rows.Count; i++)
            {
                DataGridViewRow r = lista.Rows[i];
                r.HeaderCell.Value = string.Format("{0}", i + 1);
            }
            lista.Refresh();
        }


        public static void obtenerDatosDeDataGridView(DataGridView lista, out CruceroLOG.Crucero embarcacion, out Viaje viaje)
        {
            embarcacion = null;
            viaje = null;
            if(lista is not null)
            {
                string ciudadDestino = lista.CurrentRow.Cells[1].Value.ToString();
                string fechaInicioViaje = lista.CurrentRow.Cells[3].Value.ToString();
                string duracionViaje = lista.CurrentRow.Cells[8].Value.ToString();
                string nombreCrucero = lista.CurrentRow.Cells[2].Value.ToString();

                viaje = Viaje.BuscarViajePor(Menu.listaViajes,ciudadDestino, fechaInicioViaje, duracionViaje, nombreCrucero);
                embarcacion = Flota.ObtenerEmbarcacionDeNombre(nombreCrucero);
            }


        }

        public static void VaciarFormulario(Form formulario)
        {
            foreach (Control item in formulario.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2 is not Label && item2 is not CheckBox && item2 is not Button && item2 is not ComboBox
                            && item2 is not DataGridView)
                        {
                            item2.Text = "";
                            item2.BackColor = Color.White;
                        }else if (item2 is CheckBox)
                        {
                            ((CheckBox)item2).Checked = false;
                        }else if (item2 is ComboBox)
                        {
                            ((ComboBox)item2).SelectedItem = null;
                        }else if (item2 is DataGridView)
                        {
                            ((DataGridView)item2).Rows.Clear();
                        }

                    }
                }
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.PreguntarPorSalida(e);
        }

        public static void CargarListaViajesEn(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            foreach (Viaje item in Menu.ListaViajes)
            {
                dataGrid.Rows.Add(item.ToString().Split("-"));
            }
        }
    }
}
