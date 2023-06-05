using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CRUD
{
    class Datos
    {
        string Nombre, Tipo;
        string getNombre() { return Nombre; }
        string getTipo() { return Tipo; }
        //establecer valor
        void setNombre(string nombre) { Nombre = nombre; }
        void setTipo(string tipo) { Tipo = tipo; }

        static string s = "workstation id=wilsql92.mssql.somee.com;packet size=4096;user id=wilhelmbrian92_SQLLogin_1;pwd=91omw2ur8i;data source=wilsql92.mssql.somee.com;persist security info=False;initial catalog=wilsql92";


        public void altaProducto(string nombre,string tipo) {

            setNombre(nombre);
            setTipo(tipo);
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into productos(nombre,tipo) values('" +
                              Nombre + "','" + Tipo + "')", conexion);
            comando.ExecuteNonQuery();
            
            conexion.Close();
        }
        

    }

}