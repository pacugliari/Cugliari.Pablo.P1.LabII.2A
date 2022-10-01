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
    public partial class Login : Form
    {
        private Menu menu;
        public Login()
        {
            InitializeComponent();
            this.txtContrasenia.PasswordChar = '•';
            this.ckbVer.Text = "Ver";
        }

        private bool esUsuarioValido(string usuario,string contrasenia,out Vendedor vendedor)
        {
            Vendedor vendedor1 = new Vendedor("pacugliari", "pacugliari", "Pablo", "Cugliari");
            Vendedor vendedor2 = new Vendedor("maxineinerutn", "maxineinerutn", "Maximiliano", "Neiner");
            Vendedor vendedor3 = new Vendedor("facc15", "facc15", "Facundo", "Rocha");
            Vendedor vendedor4 = new Vendedor("felipebg1", "felipebg1", "Felipe", "Bustos");
            List<Vendedor> listaVendedoresValidos = new List<Vendedor>{vendedor1, vendedor2, vendedor3, vendedor4};
            Vendedor vendedorIngresado = vendedor = new Vendedor(usuario, contrasenia, "", "");
            bool retorno = false;

            foreach (Vendedor vendedorIndice in listaVendedoresValidos)
            {
                if(vendedorIndice == vendedorIngresado)
                {
                    vendedor = vendedorIndice;
                    retorno = true;
                    break;
                }

            }
                return retorno;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Vendedor usuario;
            if(txtUsuario.Text != "" || txtContrasenia.Text != "")
            {
                if (esUsuarioValido(txtUsuario.Text,txtContrasenia.Text,out usuario))
                {
                    this.Hide();
                    menu = new Menu(usuario);
                    menu.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("El campo usuario o contrasenia no son validos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo usuario y contrasenia deben estar completos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ckbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtContrasenia.PasswordChar == '•')
            {
                this.txtContrasenia.PasswordChar = '\0';
            }
            else
            {
                this.txtContrasenia.PasswordChar = '•';
            }
        }
    }
}
