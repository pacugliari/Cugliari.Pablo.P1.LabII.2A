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
    public partial class Login : Form
    {
        private static string nombreEmpresa;
        private bool ejecutoMenu;


        static Login()
        {
            Login.nombreEmpresa = "Aida Cruceros";
        }
        public Login()
        {
            InitializeComponent();
            this.txtContrasenia.PasswordChar = '•';
            this.ckbVer.Text = "Ver";
            this.ejecutoMenu = false;

            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Ventana de logueo al sistema Aida Cruceros");
            textoAyuda.AppendLine("Ingrese el usuario y contraseña en los campos correspondientes ");
            textoAyuda.AppendLine("y luego presione el boton de Login. Puede utilizar el boton Ver, para ver la contraseña ingresada");
            Login.MostrarAyuda(this.lblAyuda, textoAyuda.ToString());
            
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
                    Menu menu = new Menu(usuario);
                    menu.ShowDialog();
                    this.ejecutoMenu = true;
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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!this.ejecutoMenu)
                Login.PreguntarPorSalida(e);
        }

        public static void PreguntarPorSalida (FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea salir?", Login.nombreEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      
            if (DialogResult.No == respuesta )
            {
                e.Cancel = true;
            }
        }

        public static void  MostrarAyuda(Label etiqueta,string mensaje)
        {
            ToolTip yourToolTip = new ToolTip();
            yourToolTip.ToolTipIcon = ToolTipIcon.Info;
            yourToolTip.IsBalloon = true;
            yourToolTip.ShowAlways = true;
            yourToolTip.SetToolTip(etiqueta, mensaje);
        }
    }
}
