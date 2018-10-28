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
        public void populate()
        {
          
            using (var cn = new MySqlConnection(cnn))
            {
                cn.Open();
                string consulta = "SELECT idrfid FROM registros";
                using(var cmd = new MySqlCommand(consulta, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            cbID.Items.Add(reader.GetString("idrfid"));
                        }
                }
            }
               

            DataTable dt = new DataTable();
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.SelectDataTable("select idrfid as `ID`, Nombre, Apellido, Edad, Departamento, FechaIn as `Fecha de Ingreso` from registros");
            //  label1.Text = DateTime.Now.ToString("h:mm:ss tt");
            populate();
   
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
            string delete = string.Format("DELETE FROM registros WHERE (idrfid = '{0}')", cbID.Text);
         if(db.executecommand(delete))
            {
                MessageBox.Show("eliminado");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string alter = string.Format("UPDATE `mastercheck`.`registros` SET `Nombre` = '{0}', `Apellido` = '{1}', `Edad` = '{2}', `Departamento` = '{3}' WHERE (`idrfid` = '{4}')"
                  , txtNombre.Text, txtApellido.Text, txtEdad.Text, cbDepartamento.Text, cbID.Text);


            if (db.executecommand(alter))
            {
                MessageBox.Show("Se modifico");
            }

        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cn = new MySqlConnection(cnn);
            cn.Open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registros where idrfid='" + cbID.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                

                txtId.Text = dr["idrfid"].ToString();
                txtNombre.Text = dr["Nombre"].ToString();
                txtApellido.Text = dr["Apellido"].ToString();
                txtEdad.Text = dr["Edad"].ToString();
                cbDepartamento.Text = dr["Departamento"].ToString();
            }
        }
    }
}
