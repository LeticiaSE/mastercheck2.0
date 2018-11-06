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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }
        BaseDeDatos db = new BaseDeDatos();
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345";

        private void Check_Load(object sender, EventArgs e)
        {
            Eliminar.Start();
            Insertar.Start();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            /*
            string sql = "select count(*) from checks where (ID = @ID)";
        //    string sql2 = "select count(*) from checks where (ID = @IDS) and (Entrada=@Entrada)";
            using (MySqlConnection cn = new MySqlConnection(cnn))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {
                       
                        string alter = string.Format("update checks set Salida ='{0}' where ID='{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBox1.Text);
                        string his = string.Format("insert into salida values('{0}','{1}')",  textBox1.Text ,DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        db.executecommand(alter);
                        db.executecommand(his);
                        lblNom.Text= textBox1.Text;
                        lblSal.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        lblEnt.Visible = true;
                        lblEntrada.Visible = true;
                        lblID.Visible = true;
                        lblNom.Visible = true;
                        lblSal.Visible = true;
                        lblSalida.Visible = true;
                      

                    }
                    else
                    {
                        //
                        var cn2 = new MySqlConnection(cnn);
                        cn2.Open();
                        MySqlCommand cmd2 = cn.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "select * from registros where idrfid='" + textBox1.Text + "'";
                        cmd2.ExecuteNonQuery();


                       
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                        da.Fill(dt);
                        foreach(DataRow dr in dt.Rows)
                        {
                            lblNom.Text = dr["Nombre"].ToString();
                            lbldepartamento.Text = dr["Departamento"].ToString();
                        }

                        //
                        string add = string.Format("insert into checks (`ID`,`Entrada`,`Salida`) values ('{0}','{1}','{2}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
                        string historial = string.Format("insert into entrada values ('{0}','{1}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
                        string asistencia = string.Format("update registros set Asistencias = Asistencias + 1 where idrfid = 1");
                        db.executecommand(asistencia);
                        db.executecommand(add);
                        db.executecommand(historial);
                       lblEnt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                     
                        mensaje.Enabled = true;
                        mensaje.Start();
                      
                    }
                }
            }
           
            */

            
        }

        private void mensaje_Tick(object sender, EventArgs e)
        {
            lblEnt.Text = "";
            lblNom.Text = "";
            lblSal.Text = "";
            lbldepartamento.Text = "";
            textBox1.Text = "";
         
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            string his = string.Format("select * from entrada where id='{0}'", textBox1.Text);
            dataGridView1.DataSource = db.SelectDataTable(his);
        }

        private void Insertar_Tick(object sender, EventArgs e)
        {
            string sql = "select count(*) from checks where (ID = @ID)";
            //   MessageBox.Show("Se inserto dato",textBox1.Text);
            using (MySqlConnection cn = new MySqlConnection(cnn))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    var result = Convert.ToInt32(cmd.ExecuteScalar());
                    if (result > 0)
                    {

                        string alter = string.Format("update checks set Salida ='{0}' where ID='{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBox1.Text);
                        string his = string.Format("insert into salida values('{0}','{1}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        db.executecommand(alter);
                        db.executecommand(his);
                        //
                        var cn2 = new MySqlConnection(cnn);
                        cn2.Open();
                        MySqlCommand cmd2 = cn.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "select * from registros where idrfid='" + textBox1.Text + "'";
                        cmd2.ExecuteNonQuery();



                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            lblNom.Text = dr["Nombre"].ToString();
                            lbldepartamento.Text = dr["Departamento"].ToString();
                            lblSal.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        }

                        //
                        lblEnt.Visible = true;
                        lblEntrada.Visible = true;
                        lblID.Visible = true;
                        lblNom.Visible = true;
                        lblSal.Visible = true;
                        lblSalida.Visible = true;
                        mensaje.Start();

                    }
                    else
                    {
                        //
                        var cn2 = new MySqlConnection(cnn);
                        cn2.Open();
                        MySqlCommand cmd2 = cn.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "select * from registros where idrfid='" + textBox1.Text + "'";
                        cmd2.ExecuteNonQuery();



                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                        da.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            lblNom.Text = dr["Nombre"].ToString();
                            lbldepartamento.Text = dr["Departamento"].ToString();
                            lblEnt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        }

                        //
                        string add = string.Format("insert into checks (`ID`,`Entrada`,`Salida`) values ('{0}','{1}','{2}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
                        string historial = string.Format("insert into entrada values ('{0}','{1}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
                        string asistencia = string.Format("update registros set Asistencias = Asistencias + 1 where idrfid = 1");
                        db.executecommand(asistencia);
                        db.executecommand(add);
                        db.executecommand(historial);
                       
                     //   mensaje.Enabled = true;
                        mensaje.Start();

                    }
                }
            }
        }

        private void Eliminar_Tick(object sender, EventArgs e)
        {
            string el = string.Format("delete table checks");
            if (db.executecommand(el))
            {
                MessageBox.Show("se borraron los registros");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
