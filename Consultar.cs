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
    public partial class Consultar : Form
    {
        public void populate()
        {

            using (var cn = new MySqlConnection(cnn))
            {
                cn.Open();
                string consulta = "SELECT idrfid FROM registros";
                using (var cmd = new MySqlCommand(consulta, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("idrfid"));
                        }
                }
            }


            DataTable dt = new DataTable();
        }
        public Consultar()
        {
            InitializeComponent();
            lbltiempo.Text = DateTime.Now.ToString("yyyy-MM-dd");
            populate();
        }
        BaseDeDatos db = new BaseDeDatos();
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cn = new MySqlConnection(cnn);
            cn.Open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registros where idrfid='" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                //txtId.Text = dr["idrfid"].ToString();
                txtNombre.Text = dr["Nombre"].ToString();
             //   txtApellido.Text = dr["Apellido"].ToString();
               // txtEdad.Text = dr["Edad"].ToString();
                cbDepartamento.Text = dr["Departamento"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string his = string.Format("select * from historial where id='{0}'",comboBox1.Text);
            Consult.DataSource = db.SelectDataTable(his);

        }
    }
}
