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
        public Menu(Vendedor usuario)
        {
            InitializeComponent();
            this.txtInformacionVendedor.Text = (string)usuario;
        }
    }
}
