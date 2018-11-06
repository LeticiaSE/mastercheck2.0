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
    public partial class Consulta2 : Form
    {
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345";
        MySqlConnection cn = new MySqlConnection(@"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345");
        public Consulta2()
        {
            InitializeComponent();
           
          
            
        }
        public void Fill()
        {
            MySqlCommand cmd = new MySqlCommand("select * from registros", cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.RowTemplate.Height = 60;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = dt;
            DataGridViewImageColumn imgcol = new DataGridViewImageColumn();
            imgcol = (DataGridViewImageColumn)dataGridView2.Columns[10];
            imgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consulta2_Load(object sender, EventArgs e)
        {
            Fill();
           

  //fs = new FileStream(Name, FileMode.Create, FileAccess.Write);
  //ms.WriteTo(fs);
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
          //  e.Cancel = true;
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }
    }
}
/*if (conn == null) // Just to make sure that the connection was not severed
            {

           
                    conn = new MySqlConnection("server=" + hostname + ";uid=" + username + ";pwd=" + password + ";database=databaseimage;Charset=latin1;");
conn.Open();
               
            }
            MemoryStream ms = new MemoryStream();
FileStream fs;
Byte[] bindata;

cmd = new MySqlCommand("SELECT pic FROM mypic WHERE id=3", conn);
bindata = (byte[]) (cmd.ExecuteScalar());
            


            ms.Write(bindata, 0, bindata.Length);
            pb2.Image = new Bitmap(ms);

fs = new FileStream(name, FileMode.Create, FileAccess.Write);
ms.WriteTo(fs);*/