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
        
        Logica logica = new Logica();
        int loteID;
        int idProducto;
        string proveedor;
        DateTime fechaEntrada = DateTime.Now.Date;

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
            if ((cboxProductos.Text == "") || (txtCantidad.ToString() == "")) MessageBox.Show("Debe completar todos los campos");
            else
            {
                MessageBox.Show(fechaEntrada.ToString()+proveedor+ idProducto);
                //inserta registro en tabla Lote
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                DateTime fechaVencimiento = dtpVencimiento.Value.Date;

                if (logica.InsertarLote(idProducto, cantidad, fechaVencimiento, out int idLote))
                {
                    MessageBox.Show("Los registros se han insertado correctamente en la tabla Lote." + "ID del lote insertado: " + idLote);
                    loteID = idLote;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al insertar los registros en la tabla Lote.");
                }


                //insertar registro en tabla entradas

                //para esto vamos a necesitar hacer una consulta a la BD para conocer el ID asignado al lote

                //SELECT ID FROM Lote WHERE (
               


                //int loteID = Convert.ToInt32(txtLoteID.Text);

                if (logica.InsertarEntrada(loteID, fechaEntrada, proveedor))
                {
                    MessageBox.Show("El registro se ha insertado correctamente en la tabla Entradas.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al insertar el registro en la tabla Entradas.");
                }




            }
        }

            private void rbtnSecretaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSecretaria.Checked) proveedor = "Secretaría";
            if (rbtnRemediar.Checked) proveedor = "Remediar";
            if (rbtnSecretaria.Checked == false) rbtnRemediar.Checked = true;
            else rbtnSecretaria.Checked = true;
        }

       

        private void cboxProductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string nombreProducto = cboxProductos.SelectedItem.ToString();
            idProducto = logica.ObtenerIDProducto(nombreProducto);

            MessageBox.Show("id producto:" + idProducto);
        }
    }
}
