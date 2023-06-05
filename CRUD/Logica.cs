using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Logica
    {
        //inicio
        private string Nombre, Tipo;
        Datos conexionDb = new Datos();

        //obtener valor
        string getNombre() {return Nombre;}
        string getTipo() {return Tipo;}
        //establecer valor
        void setNombre(string nombre) {Nombre = nombre;}
        void setTipo(string tipo) { Tipo = tipo; }

       public void altaProducto(string nombre, string tipo)
        {
            setNombre(nombre);
            setTipo(tipo);
            conexionDb.altaProducto(Nombre, Tipo);
        }
    }
}
