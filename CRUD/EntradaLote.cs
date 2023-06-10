using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Registrar_ENTRADA : Form
    {
        public Registrar_ENTRADA()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos
            string connectionString = "workstation id=wilsql92.mssql.somee.com;packet size=4096;user id=wilhelmbrian92_SQLLogin_1;pwd=91omw2ur8i;data source=wilsql92.mssql.somee.com;persist security info=False;initial catalog=wilsql92";

            // Datos de ejemplo para la entrada
            //loteID sale de la consulta del combo box 
            int loteID = 1;
            DateTime fechaEntrada = DateTime.Now;
            string proveedor;
            if (rbtnSecretaria.Checked) proveedor = "Secretaría";
            else proveedor = "Remediar";

            // Inserción de datos en la tabla Entradas
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Consulta SQL para la inserción
                string query = "INSERT INTO Entradas (LoteID, FechaEntrada, Proveedor) VALUES (@LoteID, @FechaEntrada, @Proveedor)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parámetros de la consulta
                    command.Parameters.AddWithValue("@LoteID", loteID);
                    command.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);
                    command.Parameters.AddWithValue("@Proveedor", proveedor);

                    // Ejecutar la consulta
                    int rowsAffected = command.ExecuteNonQuery();

                    // Verificar si la inserción fue exitosa
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Los datos se han cargado correctamente en la tabla Entradas.");
                    }
                    else
                    {
                        Console.WriteLine("Ha ocurrido un error al cargar los datos en la tabla Entradas.");
                    }
                }
            }
        }

        private void rbtnSecretaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSecretaria.Checked == false) rbtnRemediar.Checked = true;
            else rbtnSecretaria.Checked = true;
        }
    }
}
