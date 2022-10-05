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
