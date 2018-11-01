using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterCheck2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BaseDeDatos db = new BaseDeDatos();
        Form1 c = new Form1();
   //     Login l = new Login();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = string.Format("select * from users where users = '{0}' and pass= '{1}'", txtusuario.Text, txtpass.Text);
            if (db.executecommand(login))
            {
              // l.Hide();
                c.Show();
               
            }
        }
    }
}
