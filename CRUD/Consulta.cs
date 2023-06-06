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
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarUnDatagrid();

            void CargarUnDatagrid()
            {

                //https://easynetstudio.wixsite.com/easynetstudio/datagridview-sql-server-en-c-sharp

                //definir la consulta sql server
                string sql = "select * from productos";

                 string s = "workstation id=wilsql92.mssql.somee.com;packet size=4096;user id=wilhelmbrian92_SQLLogin_1;pwd=91omw2ur8i;data source=wilsql92.mssql.somee.com;persist security info=False;initial catalog=wilsql92";

                //definimos una conexion al server
                SqlConnection cn = new SqlConnection(s);
                try
                {
                    //abrir conexion
                    cn.Open(); 

               //definimos el adaptador para almacenar la información
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
                    DataTable dt = new DataTable();  

                 //cargamos la tabla en memoria "data table" con la información del adaptador    
                dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;                        //cargamos el datagrid                 
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
