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
    public partial class PielSeca : UserControl
    {
        private List<Producto> carritoDeCompras = new List<Producto>();
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public PielSeca()
        {
            InitializeComponent();
        }

        private void lblp1_Click(object sender, EventArgs e)
        {

        }

        private void btncar1_Click(object sender, EventArgs e)
        {
            // Producto 1, Fila 1 Columna 1: POND'S Clarant B3 Crema, $35
            string nombreProducto = "POND'S Clarant B3 Crema";
            decimal precioProducto = 35m;

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
            // Producto 2, Fila 1 Columna 2: CeraVe Limpiador Hidratante, $209
            string nombreProducto = "CeraVe Limpiador Hidratante";
            decimal precioProducto = 209m;

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
            // Producto 3, Fila 1 Columna 3: Eucerin PH5 Skin-Protection, $143
            string nombreProducto = "Eucerin PH5 Skin-Protection";
            decimal precioProducto = 143m;

            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };
            carritoDeCompras.Add(nuevoProducto);

            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito");
        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            // Producto 4, Fila 1 Columna 4: CeraVe Healing Ointment, $265
            string nombreProducto = "CeraVe Healing Ointment";
            decimal precioProducto = 265m;

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
            // Producto 5, Fila 2 Columna 1: Bio-Oil Gel para Piel Seca, $223
            string nombreProducto = "Bio-Oil Gel para Piel Seca";
            decimal precioProducto = 223m;

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
            // Producto 6, Fila 2 Columna 2: Eucerin Loción Piel Seca, $396
            string nombreProducto = "Eucerin Loción Piel Seca";
            decimal precioProducto = 396m;

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
            // Producto 7, Fila 2 Columna 3: Bioderma Atoderm Gel, $187
            string nombreProducto = "Bioderma Atoderm Gel";
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
