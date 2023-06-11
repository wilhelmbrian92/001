using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CRUD
{
    class Logica
    {
        #region asignacion
       // instancia de la capa de datos
        Datos conexionDb = new Datos();

        //obtener valores                        métodos GET y SET
        private string Nombre, Tipo;
        string getNombre() {return Nombre;}
        string getTipo() {return Tipo;}
        //establecer valores 
        void setNombre(string nombre) {Nombre = nombre;}
        void setTipo(string tipo) { Tipo = tipo; }
        #endregion

        public void altaProducto(string nombre, string tipo)
        {
            setNombre(nombre);
            setTipo(tipo);
            conexionDb.altaProducto(Nombre, Tipo);
        }

        public string[] ObtenerNombresProductos() {
            return conexionDb.ObtenerNombresProductos();
        }

        public int ObtenerIDProducto(string nombreProducto)
        {
            return conexionDb.ObtenerIDProducto(nombreProducto);
        }

        public bool InsertarLote(int idProducto, int cantidad, DateTime fechaVencimiento, out int idLote)
        {
            return conexionDb.InsertarLote(idProducto, cantidad, fechaVencimiento, out idLote);
        }

        public bool InsertarEntrada(int loteID, DateTime fechaEntrada, string proveedor)
        {
            return conexionDb.InsertarEntrada(loteID, fechaEntrada, proveedor);
        }

        public DataTable ObtenerVistaProductoLoteEntradas()
        {
            return conexionDb.ObtenerVistaProductoLoteEntradas();
        }
    }

}
