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
    public partial class Alta : Form
    {
        
        
        public Alta()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {

                try
                {
                    Logica negocio = new Logica();
                    negocio.altaProducto(txtNombre.Text, txtTipo.Text);
                    MessageBox.Show("El proceso ha finalizado exitosamente.");
                }
                catch (Exception z)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else MessageBox.Show("El campo Nombre no puede estar vacío");
        }

        private void Alta_ResizeEnd(object sender, EventArgs e)
        {
            
        }
    }
}
