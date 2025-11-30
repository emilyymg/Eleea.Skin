using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleea.Skin
{
    public partial class Carrito : UserControl
    {
        public Carrito()
        {
            InitializeComponent();
        }
        public string NombreProducto
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        // 2. Propiedad para el Precio/Subtotal (Asigna el texto a otro Label interno)
        public decimal PrecioProducto
        {
            // Usamos el formato de moneda (C2) para mostrar el valor
            set { lblPrecio.Text = value.ToString("C2"); }
            // Nota: Si la propiedad que estás asignando es de tipo 'decimal', debes asegurarte
            // de que el tipo coincida en el setter/getter.
        }

        // 3. Propiedad para la Imagen (Asigna la imagen a un PictureBox interno)
        public Image ImagenProducto
        {
            set { pcImagen.Image = value; }
        }
        private void CargarCarritoVisual()
        {
            // Limpiar el FlowLayoutPanel (asegúrate de que se llama flowPanelItems)
            flowPanelItems.Controls.Clear();

            // 1. Obtener la lista de productos del carrito con detalles de la BD
            List<ProductoCarrito> listaProductos = SqlHelper.ObtenerCarritoConDetalles();

            if (listaProductos.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTotal.Text = "Total de la Compra: $0.00";
                return;
            }

            // 2. Crear un control personalizado (ItemCarrito) para cada producto
            foreach (var producto in listaProductos)
            {
                // ItemCarrito es tu UserControl para el elemento de la lista.
                Carrito item = new Carrito();

                // ¡Las propiedades ahora se asignan correctamente!
                item.NombreProducto = producto.NombreProducto;
                item.PrecioProducto = producto.Subtotal;

                // CARGA AUTOMÁTICA DE LA IMAGEN
                item.ImagenProducto = ObtenerImagenDeProducto(producto.RutaImagen);

                // Agregar el control al FlowLayoutPanel
                flowPanelItems.Controls.Add(item);
            }
            // 3. Calcular y mostrar el total
            decimal total = SqlHelper.CalcularTotalCarrito();
            lblTotal.Text = $"Total de la Compra: ${total:F2}";
        }

        // FUNCIÓN CLAVE: Carga la imagen basándose en la RutaImagen (nombre del recurso)
        private Image ObtenerImagenDeProducto(string nombreRecurso)
        {
            // Busca directamente el recurso usando el nombre proporcionado por la BD.
            object imagenObjeto = Properties.Resources.ResourceManager.GetObject(nombreRecurso);

            if (imagenObjeto is Image imagenCargada)
            {
                return imagenCargada;
            }
            else
            {
                // Devuelve una imagen de marcador de posición si el recurso no se encuentra
                // Asegúrate de que DefaultImage existe en tus recursos.
                return Properties.Resources.DefaultImage;
            }
        }
    }
    public static class SqlHelper
    {
        
        private const string ConnectionString = "Data Source=.;Initial Catalog=EleeaSkinDB;Integrated Security=True;";
        
        public static int ObtenerProductoID(string nombre, string tipoPiel)
        {
            int productoID = -1;
            string query = "SELECT ProductoID FROM Producto WHERE NombreProducto = @Nombre AND TipoPiel = @TipoPiel";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@TipoPiel", tipoPiel);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        productoID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ProductoID: " + ex.Message, "Error de Conexión a BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return productoID;
        }
        public static void InsertarEnCarrito(int productoID, int cantidad = 1)
        {
            string query = "INSERT INTO Carrito (ProductoID, Cantidad) VALUES (@ProductoID, @Cantidad)";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductoID", productoID);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en Carrito: " + ex.Message, "Error de Conexión a BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<ProductoCarrito> ObtenerCarritoConDetalles()
        {
            List<ProductoCarrito> lista = new List<ProductoCarrito>();
            string query = @"
            SELECT 
                P.NombreProducto, P.Precio, P.RutaImagen, C.Cantidad 
            FROM Carrito AS C
            JOIN Producto AS P ON C.ProductoID = P.ProductoID;";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProductoCarrito
                            {
                                NombreProducto = reader["NombreProducto"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                RutaImagen = reader["RutaImagen"].ToString(),
                                Cantidad = Convert.ToInt32(reader["Cantidad"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el carrito: " + ex.Message, "Error de Conexión a BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
        public static decimal CalcularTotalCarrito()
        {
            decimal total = 0m;
            string query = "SELECT SUM(P.Precio * C.Cantidad) AS TotalFinal FROM Carrito AS C JOIN Producto AS P ON C.ProductoID = P.ProductoID";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el total: " + ex.Message, "Error de Conexión a BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return total;
        }
    }
}
