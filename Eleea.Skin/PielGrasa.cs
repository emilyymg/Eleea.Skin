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
        private List<Producto> carritoDeCompras = new List<Producto>();
        // Este código debe ir en un archivo 'Producto.cs' o en la parte superior de 'Form1.cs'
        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
        }
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
            // 1. Definir los datos del producto
            string nombreProducto = "La Roche-Posay Effaclar";
            decimal precioProducto = 365m; // La 'm' indica que es un valor decimal

            // 2. Crear el objeto Producto
            Producto nuevoProducto = new Producto
            {
                Nombre = nombreProducto,
                Precio = precioProducto
            };

            // 3. Agregar el producto a la base de datos (lista en memoria)
            carritoDeCompras.Add(nuevoProducto);

            // 4. Mostrar el mensaje de confirmación
            MessageBox.Show(
                $"¡Se ha agregado {nuevoProducto.Nombre} (Precio: ${nuevoProducto.Precio:F2}) a tu carrito!",
                "Producto Agregado con Éxito"
            );
        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            
            string nombreProducto = "INF. Crema Facial";
            decimal precioProducto = 677m; 

        
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

            string nombreProducto = "CeraVe Limpiador Hidratante";
            decimal precioProducto = 241m;


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

            string nombreProducto = "Avène Cleanance Gel";
            decimal precioProducto = 127m;


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

            string nombreProducto = "CeraVe Limpiador Espumoso";
            decimal precioProducto = 180m;


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

            string nombreProducto = "La Roche-Posay Hydraphase";
            decimal precioProducto = 300m;


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

            string nombreProducto = "Acniben Cleanser";
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

        private void btncar9_Click(object sender, EventArgs e)
        {

            string nombreProducto = "Pond's Sunscreen 50";
            decimal precioProducto = 111m;


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

        private void btncar10_Click(object sender, EventArgs e)
        {

            string nombreProducto = "Garnier Limpiador Lemon";
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

        private void btncar11_Click(object sender, EventArgs e)
        {

            string nombreProducto = "Cetaphil Optimal Hydration";
            decimal precioProducto = 665m;


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

        private void btncar12_Click(object sender, EventArgs e)
        {

            string nombreProducto = "Bioderma White Objective";
            decimal precioProducto = 160m;


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
            string nombreProducto = "CeraVe Crema Hidratante Pote";
            decimal precioProducto = 339m;


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
