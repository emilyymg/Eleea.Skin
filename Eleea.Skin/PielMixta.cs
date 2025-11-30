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
       
        public PielMixta()
        {
            InitializeComponent();
        }

        private void PielMixta_Load(object sender, EventArgs e)
        {
           
        }
        private void AgregarProductoAlCarrito(string nombreProducto, string tipoPiel)
        {
            // 1. OBTENER EL ID del producto del catálogo (tabla Producto)
            int productoID = SqlHelper.ObtenerProductoID(nombreProducto, tipoPiel);

            if (productoID > 0)
            {
                // 2. INSERTAR en la tabla Carrito de la BD
                SqlHelper.InsertarEnCarrito(productoID, 1); // Agrega 1 unidad.

                // 3. Mostrar el mensaje de confirmación
                MessageBox.Show(
                    $"¡Se ha agregado {nombreProducto} a tu carrito (BD)!",
                    "Producto Agregado con Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"Error: El producto '{nombreProducto}' no se encontró en el catálogo de la BD o la conexión falló.",
                    "Error de Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        private void btncar1_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Bioderma Hydrabio Gel", "MIXTA");
        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("La Roche-Posay Concentrado", "MIXTA");
        }

        private void btncar3_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("CeraVe Blemish Treatment", "MIXTA");



        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Uriage Hyseac Gel", "MIXTA");
        }

        private void btncar5_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Eucerin pH5 Loción", "MIXTA");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("POND'S Serum Pink", "MIXTA");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            // Producto 7, Fila 2 Columna 3: Bioderma Hydrabio Serum, $187
            AgregarProductoAlCarrito("Bioderma Hydrabio Serum", "MIXTA");
        }

        private void btncar8_Click(object sender, EventArgs e)
        {
            AgregarProductoAlCarrito("Dermatologist Solutions", "MIXTA");
        }
    }
}
