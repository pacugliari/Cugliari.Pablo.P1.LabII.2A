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
    public partial class Menu : Form
    {

        private VentaViajesForm ventaViajesForm;
        private ViajesForm viajesForm;
        private InformesForm informesForm;
        private InformesHistoricosForm informesHistoricosForm;
        private static List<Viaje> listaViajes;
        private static Flota flota;
        private List<Viajero> listaViajeros;

        static Menu()
        {
            Menu.listaViajes = new List<Viaje>();
            Menu.flota = new Flota();
        }
        public Menu(Vendedor usuario)
        {
            InitializeComponent();
            this.txtInformacionVendedor.Text = (string)usuario;
            this.listaViajeros = new List<Viajero>();
            this.viajesForm = new ViajesForm(Menu.listaViajes, Menu.flota);
            this.ventaViajesForm = new VentaViajesForm(Menu.listaViajes, Menu.flota,this.listaViajeros);
            this.informesForm = new InformesForm(Menu.listaViajes);
            this.informesHistoricosForm = new InformesHistoricosForm();
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            Menu.vaciarFormulario(this.viajesForm);
            this.viajesForm.ShowDialog();
        }

        private void btnVentaViajes_Click(object sender, EventArgs e)
        {
            Menu.vaciarFormulario(this.ventaViajesForm);
            this.ventaViajesForm.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            this.informesForm.ShowDialog();
        }

        private void btnInformesHistoricos_Click(object sender, EventArgs e)
        {
            this.informesHistoricosForm.ShowDialog();
        }

        public static void aplicarNumerosFilas(DataGridView lista)
        {
            for (int i = 0; i < lista.Rows.Count; i++)
            {
                DataGridViewRow r = lista.Rows[i];
                r.HeaderCell.Value = string.Format("{0}", i + 1);
            }
            lista.Refresh();
        }

        public static void obtenerDatosDeDataGridView(DataGridView lista, out Embarcacion embarcacion, out Viaje viaje)
        {
            embarcacion = null;
            viaje = null;
            string ciudadDestino = lista.CurrentRow.Cells[1].Value.ToString();
            string fechaInicioViaje = lista.CurrentRow.Cells[3].Value.ToString();
            string duracionViaje = lista.CurrentRow.Cells[8].Value.ToString();
            string nombreCrucero = lista.CurrentRow.Cells[2].Value.ToString();

            foreach (Viaje item in Menu.listaViajes)
            {

                if (item.CiudadDestino == ciudadDestino &&
                    item.DuracionViaje.ToString() == duracionViaje &&
                    item.Crucero == nombreCrucero &&
                    item.FechaInicioViaje.ToString() == fechaInicioViaje
                    )
                {//ES EL MISMO VIAJE
                    viaje = item;
                    embarcacion = Menu.flota.obtenerEmbarcacionDeNombre(nombreCrucero);
                    break;
                }
            }

        }

        public static void vaciarFormulario(Form formulario)
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
    }
}
