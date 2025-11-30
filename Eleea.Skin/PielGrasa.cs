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
    public partial class PielGrasa : UserControl
    {
        public PielGrasa()
        {
            InitializeComponent();
            
        }

        private void PielGrasa_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;

            // 2. Define el tamaño mínimo de desplazamiento (AutoScrollMinSize)
            // Esto 'fuerza' al panel a creer que su contenido tiene una altura mucho mayor 
            // que la altura visible, garantizando que el scroll aparezca.
            // Ajusta el valor '1500' a la altura total que necesites para tu contenido.
            // (0, 1500) significa: 0 de ancho, 1500 de alto.
            panel1.AutoScrollMinSize = new Size(0, 1500);

            // Opcional: Si necesitas asegurarte de que el panel no cambie su tamaño automáticamente:
            panel1.AutoSize = false;
        }

        private void btncar1_Click(object sender, EventArgs e)
        {

        }

        private void btncar2_Click(object sender, EventArgs e)
        {

        }
    }
}
