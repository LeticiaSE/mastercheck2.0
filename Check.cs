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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }
        BaseDeDatos db = new BaseDeDatos();

        private void Check_Load(object sender, EventArgs e)
        {
            string in = "INSERT INTO "
        }
    }
}
