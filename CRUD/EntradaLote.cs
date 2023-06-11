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
        int idProducto;
        string proveedor;
        Logica logica = new Logica();

        //constructor
        public Registrar_ENTRADA()
        {
            InitializeComponent();

            CargarNombresProductos();
            
        }

        private void Registrar_ENTRADA_Load(object sender, EventArgs e)
        {
            rbtnSecretaria.Checked = true;
        }


        private void CargarNombresProductos()
        {
            cboxProductos.Items.Clear();
            cboxProductos.Items.AddRange(logica.ObtenerNombresProductos());

            // Habilitar la función de autocompletar y establecer la fuente de autocompletar como CustomSource
            cboxProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboxProductos.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Establecer la lista de sugerencias para el autocompletar utilizando los nombres de los productos
            cboxProductos.AutoCompleteCustomSource.AddRange(logica.ObtenerNombresProductos());
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idProducto.ToString()+proveedor);
        }

        private void rbtnSecretaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSecretaria.Checked) proveedor = "Secretaría";
            if (rbtnRemediar.Checked) proveedor = "Remediar";
            if (rbtnSecretaria.Checked == false) rbtnRemediar.Checked = true;
            else rbtnSecretaria.Checked = true;
        }

        private void cboxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreProducto = cboxProductos.SelectedItem.ToString();
            idProducto = logica.ObtenerIDProducto(nombreProducto);
        }

        
    }
}
