using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MasterCheck2._0
{
    public partial class Form1 : Form
    {
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345";
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.SelectDataTable("select idrfid as `ID`, Nombre, Apellido, Edad, Departamento, FechaIn as `Fecha de Ingreso` from registros");
            //  label1.Text = DateTime.Now.ToString("h:mm:ss tt");
         
   
        }
        BaseDeDatos db = new BaseDeDatos();

        private void btnid_Click(object sender, EventArgs e)
        {
            try
            {

                string Agregar = string.Format("INSERT INTO registros (`idrfid`,`Nombre`,`Apellido`,`Edad`,`Departamento`,`FechaIn`)" +
                    " VALUES('{0}','{1}','{2}','{3}','{4}','{5}');",
                    txtId.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, cbDepartamento.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                if (db.executecommand(Agregar))
                {
                    MessageBox.Show("Se inserto x persona");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo agregar "+ ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SelectDataTable("select * from registros");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
