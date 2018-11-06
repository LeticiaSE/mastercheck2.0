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
    public partial class Dummycs : Form
    {
        public Dummycs()
        {
            InitializeComponent();
            //insertar.Start();

        }
        BaseDeDatos db = new BaseDeDatos();

        private void insertar_Tick(object sender, EventArgs e)
        {
            string el = string.Format("insert into entrada values('{0}','{1}')",textBox1.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            if (db.executecommand(el))
            {
                MessageBox.Show("se elimino con exito");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            insertar.Start();
        }
    }
}
