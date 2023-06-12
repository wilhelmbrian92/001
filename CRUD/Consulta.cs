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
    public partial class Consulta : Form
    {
        Logica negocio = new Logica();
        public Consulta()
        {
            InitializeComponent();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();      }

        private void Consulta_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = negocio.ObtenerVistaProductoLoteEntradas();
        }
    }
}
