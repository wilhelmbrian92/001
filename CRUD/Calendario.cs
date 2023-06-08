using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Calendario : Form
    {

      
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            // Obtener las fechas de vencimiento de los lotes (ejemplo)
            DateTime[] fechasVencimiento = ObtenerFechasVencimientoLotes();

            // Recorrer las fechas y resaltar las fechas de vencimiento en rojo
            foreach (DateTime fecha in fechasVencimiento)
            {
                calendarioVencimientos.AddBoldedDate(fecha);
                calendarioVencimientos.UpdateBoldedDates();
            }

            calendarioVencimientos.Update();
        }
        // Método de ejemplo para obtener las fechas de vencimiento de los lotes (reemplazar con tus propios datos o lógica)
        private DateTime[] ObtenerFechasVencimientoLotes()
        {
            // Ejemplo: obtén las fechas de vencimiento desde una base de datos o cualquier otra fuente de datos
            DateTime fecha1 = new DateTime(2023, 6, 15);
            DateTime fecha2 = new DateTime(2023, 6, 20);
            DateTime fecha3 = new DateTime(2023, 6, 25);

            return new DateTime[] { fecha1, fecha2, fecha3 };
        }


    }
}
