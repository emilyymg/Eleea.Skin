using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Eleea.Skin.PielGrasa;

namespace Eleea.Skin
{

    public partial class PielMixta : UserControl
    {
        private List<Producto> carritoDeCompras = new List<Producto>();
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public PielMixta()
        {
            InitializeComponent();
        }

        private void PielMixta_Load(object sender, EventArgs e)
        {
           
        }

        private void btncar1_Click(object sender, EventArgs e)
        {
            // Producto 1, Fila 1 Columna 1: Bioderma Hydrabio Gel, $449
            string nombreProducto = "Bioderma Hydrabio Gel";
            decimal precioProducto = 449m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );
        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            // Producto 2, Fila 1 Columna 2: La Roche-Posay Concentrado, $616
            string nombreProducto = "La Roche-Posay Concentrado";
            decimal precioProducto = 616m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );

        }

        private void btncar3_Click(object sender, EventArgs e)
        {
            // Producto 3, Fila 1 Columna 3: CeraVe Blemish Treatment, $276
            string nombreProducto = "CeraVe Blemish Treatment";
            decimal precioProducto = 276m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );

        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            // Producto 4, Fila 1 Columna 4: Uriage Hyseac Gel, $450
            string nombreProducto = "Uriage Hyseac Gel";
            decimal precioProducto = 450m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );

        }

        private void btncar5_Click(object sender, EventArgs e)
        {
            // Producto 5, Fila 2 Columna 1: Eucerin pH5 Loción, $235
            string nombreProducto = "Eucerin pH5 Loción";
            decimal precioProducto = 235m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            // Producto 6, Fila 2 Columna 2: POND'S Serum Pink, $97
            string nombreProducto = "POND'S Serum Pink";
            decimal precioProducto = 97m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            // Producto 7, Fila 2 Columna 3: Bioderma Hydrabio Serum, $187
            string nombreProducto = "Bioderma Hydrabio Serum";
            decimal precioProducto = 187m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );
        }

        private void btncar8_Click(object sender, EventArgs e)
        {
            // Producto 8, Fila 2 Columna 4: Dermatologist Solutions, $406
            string nombreProducto = "Dermatologist Solutions";
            decimal precioProducto = 406m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );
        }
    }
}
