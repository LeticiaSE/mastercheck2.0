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
using System.IO;
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

        string[] dept = new string[5] { "Computacion", "Industrial", "Bioquimica", "Literatura", "Aeronatica" };
        string[] puesto = new string[2] { "Empleado", "Profesor" };

        public Consultar()
        {
            InitializeComponent();

            btneliminar.Enabled = btnGuardar.Enabled = button1.Enabled = txtNombre.Enabled = txtapellido.Enabled = txtedad.Enabled = cbpuesto.Enabled = cbDepartamento.Enabled = false;

            lbltiempo.Text = DateTime.Now.ToString("yyyy-MM-dd");
            populate();
            timer1.Start();
            lbltime.Text = DateTime.Now.ToLongTimeString();

            for (int i = 0; i < dept.Length - 1; i++)
            {
                cbDepartamento.Items.Add(dept[i]);
            }
            for (int i = 0; i < puesto.Length; i++)
            {
                cbpuesto.Items.Add(puesto[i]);
            }
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
             
               
              //  comboBox1.Text = dr["idrfid"].ToString();
                txtNombre.Text = dr["Nombre"].ToString();
               txtapellido.Text = dr["Apellido"].ToString();
               txtedad.Text = dr["Edad"].ToString();
                cbDepartamento.Text = dr["Departamento"].ToString();
                cbpuesto.Text = dr["puesto"].ToString();
                string his = string.Format("select * from entrada where id='{0}'", comboBox1.Text);
                string sal = string.Format("select sal as Salida from salida where id='{0}'", comboBox1.Text);
                Consult.DataSource = db.SelectDataTable(his);
                dgtSal.DataSource = db.SelectDataTable(sal);

            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   string c = string.Format("Select idrfid, Nombre, FechaIn, Asistencias, Faltas, Puesto, noEmp from registros");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(Consult, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }




        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           btneliminar.Enabled= btnGuardar.Enabled= button1.Enabled= txtNombre.Enabled = txtapellido.Enabled = txtedad.Enabled = cbpuesto.Enabled = cbDepartamento.Enabled = !string.IsNullOrWhiteSpace(this.comboBox1.Text);

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string alter = string.Format("UPDATE `mastercheck`.`registros` SET `Nombre` = '{0}', `Apellido` = '{1}', `Edad` = '{2}', `Departamento` = '{3}', `puesto` = '{4}' WHERE (`idrfid` = '{5}')", txtNombre.Text, txtapellido.Text, txtedad.Text, cbDepartamento.Text, cbpuesto.Text, comboBox1.Text);
                if (db.executecommand(alter))
                {
                    MessageBox.Show("Se guardo los cambios");
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error2 ",ex.Message);
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show( "Quiere eliminar este usuario", "Eliminar", MessageBoxButtons.YesNo);
                string delete = string.Format("DELETE FROM `mastercheck`.`registros` WHERE(`idrfid` = '{0}')", comboBox1.Text);
                if (dialogResult == DialogResult.Yes)
                {
                    if (db.executecommand(delete))
                    {


                        MessageBox.Show("Se Elimino");
                    
                 

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error");
            }

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
