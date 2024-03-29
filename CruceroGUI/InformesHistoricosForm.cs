﻿using System;
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
    public partial class InformesHistoricosForm : Form
    {

        public InformesHistoricosForm()
        {
            InitializeComponent();

            //INICIALIZO CON LAS PROPIEDADES A LOS DATAGRIDVIEW
            foreach (Control item in this.Controls)
            {
                if(item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if(item2 is DataGridView)
                        {
                            DataGridView lista = (DataGridView)item2;
                            lista.Visible = false;
                            foreach (DataGridViewColumn Col in lista.Columns)
                            {
                                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
                            }
                            lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMo‌​de.AllCells;
                            lista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                            lista.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    
                }
            }
            this.rbDestinosOrdenados.Checked = false;
            this.rbPasajerosOrdenados.Checked = false;
            this.rbHorasCrucero.Checked = false;

            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Ventana para informes historicos de cruceros/pasajeros/viajes");
            textoAyuda.AppendLine("Para poder consultar la informacion solo seleccione una de las 3 opciones");


            Login.MostrarAyuda(this.lblAyuda, textoAyuda.ToString());
        }

        private void rbDestinosOrdenados_CheckedChanged(object sender, EventArgs e)
        {
            float gananciaRegionales = 0;
            float gananciaExtraRegionales = 0;
            Dictionary<string, float> lista = Historico.obtenerDestinosConFacturacion();
            this.dgvDestinosOrdenados.Visible = true;
            this.dgvListaPasajeros.Visible = false;
            this.dgvListaHorasCrucero.Visible = false;
            this.dgvDestinosOrdenados.Rows.Clear();
            foreach (KeyValuePair<string,float> item in lista)
            {
                this.dgvDestinosOrdenados.Rows.Add(item.Key, "$"+item.Value);
                if (Viaje.EsRegional(item.Key))
                {
                    gananciaRegionales += item.Value;
                }else
                    gananciaExtraRegionales += item.Value;
            }
            this.dgvDestinosOrdenados.Rows.Add();

            string destinoMasElegido = "No hay viajes";
            if (Historico.obtenerDestinosConCantidadViajes().First().Value != 0)
            {
                destinoMasElegido = Historico.obtenerDestinosConCantidadViajes().First().Key;
            }

            this.dgvDestinosOrdenados.Rows.Add("El destino mas pedido:", destinoMasElegido);
            this.dgvDestinosOrdenados.Rows.Add("Ganancia total a destinos regionales:", "$" + gananciaRegionales);
            this.dgvDestinosOrdenados.Rows.Add("Ganancia total a destinos extraregionales:", "$" + gananciaExtraRegionales);
            this.dgvDestinosOrdenados.Rows.Add("Ganancia total :","$" + (gananciaRegionales+ gananciaExtraRegionales));
            Menu.AplicarNumerosFilas(this.dgvDestinosOrdenados);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvDestinosOrdenados.Visible = false;
            this.dgvListaPasajeros.Visible = true;
            this.dgvListaHorasCrucero.Visible = false;
            this.dgvListaPasajeros.Rows.Clear();
            Dictionary<string, int> lista = Historico.obtenerPasajerosConCantidadViajes();
            foreach (KeyValuePair<string, int> item in lista)
            {
                Pasajero cliente = Pasajero.BuscarPasajero(Menu.Clientes,item.Key);
                if(cliente is not null)
                {
                    this.dgvListaPasajeros.Rows.Add(item.Value,cliente.Pasaporte.NumeroDocumentoViaje,cliente.Nombre,
                        cliente.Apellido,cliente.Edad);
                }
                
            }
            Menu.AplicarNumerosFilas(this.dgvListaPasajeros);
        }


        private void rbHorasCrucero_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvDestinosOrdenados.Visible = false;
            this.dgvListaPasajeros.Visible = false;
            this.dgvListaHorasCrucero.Visible = true;
            this.dgvListaHorasCrucero.Rows.Clear();
            Dictionary<string, int> lista = Historico.obtenerCrucerosConHoras();
            int cantidadPersonas = 0;
            foreach (KeyValuePair<string, int> item in lista)
            {
                Crucero crucero = Flota.ObtenerEmbarcacionDeNombre(item.Key);
                cantidadPersonas = 0;
                foreach (Viaje item2 in Menu.ListaViajes)
                {
                    
                    if (crucero == item2)
                    {
                        cantidadPersonas += item2.CantidadPasajeros;
                    }
            }
                this.dgvListaHorasCrucero.Rows.Add(item.Key,item.Value, cantidadPersonas);
            }
            Menu.AplicarNumerosFilas(this.dgvListaPasajeros);
        }

        private void InformesHistoricosForm_Load(object sender, EventArgs e)
        {
            this.rbDestinosOrdenados_CheckedChanged(sender, e);
        }
    }
}
