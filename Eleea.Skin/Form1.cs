using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleea.Skin
{
    public partial class FrmTienda : Form
    {
        public FrmTienda()
        {
            InitializeComponent();
        }
        public void CargarUC(UserControl uc)
        {
            pnlContenido.Controls.Clear();       // Limpia lo que había
            uc.Dock = DockStyle.Fill;              // Ocupa todo el panel
            pnlContenido.Controls.Add(uc);       // Agrega el nuevo control
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            CargarUC(new PantallaPrincipal());
        }
        
    }
}
