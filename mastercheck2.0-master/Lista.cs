using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop;
namespace MasterCheck2._0
{
    public partial class Lista : Form
    {
        string c = string.Format("Select idrfid, noEmp as `No Empleado`, Nombre, FechaIn as `Fecha de Ingreso`, Asistencias, Faltas, Puesto from registros");
        string es = string.Format("select * from entrada");
        string s = string.Format("select * from salida");
        string[] lis = new string[3] {"Empleados","Salida","Entrada"};
        public Lista()
        {
            InitializeComponent();
            btnExp.Enabled = false;
            //   dataGridView1.DataSource = db.SelectDataTable(c);
            for (int i = 0; i < lis.Length; i++)
            {
                cbcmd.Items.Add(lis[i]);
            }
        }
        BaseDeDatos db = new BaseDeDatos();
        private void copy()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btnExp_Click(object sender, EventArgs e)
        {
            //   string c = string.Format("Select idrfid, Nombre, FechaIn, Asistencias, Faltas, Puesto, noEmp from registros");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
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


        private void btnemp_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnhis_Click(object sender, EventArgs e)
        {
           
        }

        private void tEmpleados_Click(object sender, EventArgs e)
        {
            
        }

        private void tSalidas_Click(object sender, EventArgs e)
        {
           
        }

        private void tentradas_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbcmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbcmd.Text == "Empleados")
            {
                dataGridView1.DataSource = db.SelectDataTable(c);
                btnExp.Enabled = true;
            }
            else if(cbcmd.Text == "Salida")
            {
                dataGridView1.DataSource = db.SelectDataTable(s);
                btnExp.Enabled = true;
            }
            else if(cbcmd.Text == "Entrada")
            {
                dataGridView1.DataSource = db.SelectDataTable(es);
                btnExp.Enabled = true;
            }
        }
    }
}
