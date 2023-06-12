using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace CRUD
{
    class Datos
    {
        #region parametros_alta
        string Nombre, Tipo;
        string getNombre() { return Nombre; }
        string getTipo() { return Tipo; }
        //establecer valor
        void setNombre(string nombre) { Nombre = nombre; }
        void setTipo(string tipo) { Tipo = tipo; }
        #endregion
        // conexion con base
        static string s = "workstation id=wilsql92.mssql.somee.com;packet size=4096;user id=wilhelmbrian92_SQLLogin_1;pwd=91omw2ur8i;data source=wilsql92.mssql.somee.com;persist security info=False;initial catalog=wilsql92";

        public void altaProducto(string nombre,string tipo) {

            setNombre(nombre);
            setTipo(tipo);
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into Producto(Nombre,Tipo) values('" +
                              Nombre + "','" + Tipo + "')", conexion);
            comando.ExecuteNonQuery();
            
            conexion.Close();
        }
        
        //carga comboBox
        public string [] ObtenerNombresProductos()
        {
            //en este método se obtiene los nombres de todos los productos para mostrarlos en el combobox
            string query = "SELECT Nombre FROM Producto";

            using (SqlConnection connection = new SqlConnection(s))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    // Crear una lista para almacenar los nombres de los productos
                    List<string> nombresProductos = new List<string>();

                    while (reader.Read())
                    {
                        string nombreProducto = reader.GetString(0);
                        nombresProductos.Add(nombreProducto);
                    }

                    reader.Close();

                    return nombresProductos.ToArray();
                }
            }
        }
        //luego de cargar comboBox obtiene id prod seleccionado
        public int ObtenerIDProducto(string nombreProducto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(s))
                {
                    connection.Open();

                    string query = "SELECT ID FROM Producto WHERE Nombre = @Nombre";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombreProducto);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de fallo en la consulta
                Console.WriteLine("Ha ocurrido un error al obtener el ID del producto: " + ex.Message);
            }

            return 0; // Valor predeterminado si no se encuentra el producto o hay un error
        }

        //entrada lote
        public bool InsertarLote(int idProducto, int cantidad, DateTime fechaVencimiento, out int idLote)
        {

            idLote = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(s))
                {
                    connection.Open();

                    // Preparar la consulta SQL para la inserción
                    string query = "INSERT INTO Lote (ProductoID, Cantidad, FechaVencimiento) VALUES (@ProductoID, @Cantidad, @FechaVencimiento); SELECT SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignar los parámetros de la consulta
                        command.Parameters.AddWithValue("@ProductoID", idProducto);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);


                        // Ejecutar la consulta
                        // int rowsAffected = command.ExecuteNonQuery();

                        // return rowsAffected > 0;
                        idLote = Convert.ToInt32(command.ExecuteScalar());

                        return idLote > 0;


                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de fallo en la inserción
                Console.WriteLine("Ha ocurrido un error al insertar los registros en la tabla Lote: " + ex.Message);
                return false;
            }
        }

        public bool InsertarEntrada(int loteID, DateTime fechaEntrada, string proveedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(s))
                {
                    connection.Open();

                    // Preparar la consulta SQL para la inserción
                    string query = "INSERT INTO Entradas (LoteID, FechaEntrada, Proveedor) VALUES (@LoteID, @FechaEntrada, @Proveedor)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignar los parámetros de la consulta
                        command.Parameters.AddWithValue("@LoteID", loteID);
                        command.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);
                        command.Parameters.AddWithValue("@Proveedor", proveedor);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de fallo en la inserción
                Console.WriteLine("Ha ocurrido un error al insertar el registro en la tabla Entradas: " + ex.Message);
                return false;
            }
        }
    
    //consulta
        public DataTable ObtenerVistaProductoLoteEntradas()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(s))
                {
                    connection.Open();

                    string query = "SELECT * FROM VistaProductoLoteEntradas";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de fallo en la consulta
                Console.WriteLine("Ha ocurrido un error al obtener los datos: " + ex.Message);
            }

            return dataTable;
        }

        public DateTime[] ObtenerFechasVencimiento()
        {
            List<DateTime> fechasVencimiento = new List<DateTime>();

            using (SqlConnection connection = new SqlConnection(s))
            {
                connection.Open();

                string query = "SELECT FechaVencimiento FROM Lote"; // Query para obtener las fechas de vencimiento de todos los lotes

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime fechaVencimiento = reader.GetDateTime(0);
                            fechasVencimiento.Add(fechaVencimiento);
                        }
                    }
                }
            }

            return fechasVencimiento.ToArray();
        }


    }

}