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
    public partial class Login : Form
    {
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345";

        public Login()
        {
            InitializeComponent();
            populate();
            txtpass.Enabled = btnLogin.Enabled =  false;

        }
        BaseDeDatos db = new BaseDeDatos();
        Form1 c = new Form1();
        //     Login l = new Login();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cnn);
            con.Open();
         

            string login = string.Format("select * from users where users = '{0}' and pass= '{1}'", cbUsuarios.Text, txtpass.Text);
            MySqlCommand cmd = new MySqlCommand(login,con);
            MySqlDataReader l = cmd.ExecuteReader();
            if (l.Read())
            {
                this.Hide();
                c.Show();

            }
            else
                MessageBox.Show("No existe el usario");

/*          
                if (db.executecommand(login))
                {
                    this.Hide();
                    c.Show();

                }
                */
            }
            catch
            {
                MessageBox.Show("Usario no existe");
            }
        }
        public void populate()
        {

            using (var cn = new MySqlConnection(cnn))
            {
                cn.Open();
                string consulta = "SELECT users FROM users";
                using (var cmd = new MySqlCommand(consulta, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            cbUsuarios.Items.Add(reader.GetString("users"));
                        }
                }
            }
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtpass.Enabled= true;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(this.txtpass.Text);
        }
    }
}
