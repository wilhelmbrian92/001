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
            void CargarUnDatagrid()
            {

                //https://easynetstudio.wixsite.com/easynetstudio/datagridview-sql-server-en-c-sharp

                //definir la consulta sql server
                string sql = "select * from Tabla_domicilios";


                //definimos una conexion al server
                SqlConnection cn = new SqlConnection(@"Data Source=SNAKE-PC ;" +
                     "user id = xxx; password = xxx;Initial Catalog=EMPRESA;Integrated Security=true;");
                try
                {
                    //abrir conexion
                    cn.Open(); 

​

               //definimos el adaptador para almacenar la información
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
                    DataTable dt = new DataTable();  

​

                 //cargamos la tabla en memoria "data table" con la información del adaptador    
                dataAdapter.Fill(dt);
                    MiDatagridView.DataSource = dt;                        //cargamos el datagrid                 
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }



        }
    }
}
