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
           
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
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
                        db.executecommand(alter);
                        lblNom.Text= textBox1.Text;
                        lblSal.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        lblEnt.Visible = true;
                        lblEntrada.Visible = true;
                        lblID.Visible = true;
                        lblNom.Visible = true;
                        lblSal.Visible = true;
                        lblSalida.Visible = true;
                        //timer de 5 segundos
                      /*  lblSal.Text = "";
                        lblNom.Text = "";
                        lblEnt.Visible = false;
                        lblEntrada.Visible = false;
                        lblID.Visible = false;
                        lblNom.Visible = false;
                        lblSal.Visible = false;
                        lblSalida.Visible = false;
                          /*
                        //

                        /*       cmd.Parameters.AddWithValue("@IDS", textBox1.Text);
                               cmd.Parameters.AddWithValue("@Entrada", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                               var r = Convert.ToInt32(cmd.ExecuteScalar());
                               if(r > 0) {
                                   label2.Text = "insertadoS";
                               string add = string.Format("insert into checks (`ID`,`Entrada`,`Salida`) values ('{0}','{1}','{2}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
                                   db.executecommand(add);
                           }
                           else {
                               string alter = string.Format("update checks set Salida '{0}' where ID='{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),textBox1.Text);
                                   db.executecommand(alter);
                               } */

                    }
                    else
                    {
                        
                        string add = string.Format("insert into checks (`ID`,`Entrada`,`Salida`) values ('{0}','{1}','{2}')", textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "");
                        db.executecommand(add);
                       lblEnt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        lblNom.Text = textBox1.Text;
                    //    lblEnt.Visible = true;
                      //  lblEntrada.Visible = true;
                      //  lblID.Visible = true;
                      //  lblNom.Visible = true;
                       // lblSal.Visible = true;
                       // lblSalida.Visible = true;
                        //timer de 5 segundos
                        mensaje.Enabled = true;
                        mensaje.Start();
                        //
                    }
                }
            }
           
            

            
            //String In = string.Format("INSERT INTO checks (`id`,`Entrada`,`Salida`) + VALUES('{0}','{1}','{2}');",
              //  )
        }

        private void mensaje_Tick(object sender, EventArgs e)
        {
            lblEnt.Text = "";
            lblNom.Text = "";
            lblSal.Text = "";
            
           // lblEnt.Visible = false;
         //   lblEntrada.Visible = false;
         //   lblID.Visible = false;
          //  lblNom.Visible = false;
           // lblSal.Visible = false;
         //   lblSalida.Visible = false;
        }
    }
}
