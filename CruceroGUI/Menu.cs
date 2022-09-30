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
        private List<Viaje> listaViajes;
        private Flota flota;
        private List<Viajero> listaViajeros;
        public Menu(Vendedor usuario)
        {
            InitializeComponent();
            this.txtInformacionVendedor.Text = (string)usuario;
            this.listaViajes = new List<Viaje>();
            this.flota = new Flota();
            this.listaViajeros = new List<Viajero>();
            this.viajesForm = new ViajesForm(this.listaViajes,this.flota);
            this.ventaViajesForm = new VentaViajesForm(this.listaViajes,this.flota,this.listaViajeros);
            this.informesForm = new InformesForm();
            this.informesHistoricosForm = new InformesHistoricosForm();
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            this.viajesForm.ShowDialog();
        }

        private void btnVentaViajes_Click(object sender, EventArgs e)
        {
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
    }
}
