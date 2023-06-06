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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void linkLblAlta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Alta frmAlta = new Alta();
            frmAlta.ShowDialog();
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Consulta frmConsulta = new Consulta();
            frmConsulta.ShowDialog();

        }
    }
}
