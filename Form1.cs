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
    public partial class Form1 : Form
    {
        string cnn = @"SERVER=localhost; DATABASE=mastercheck; UID=root; PASSWORD=12345";
        string[] dept = new string[5] { "Computacion", "Industrial", "Bioquimica", "Literatura", "Aeronatica" };
        string[] puesto = new string[2] { "Empleado", "Profesor" };
        public Form1()
        {
            InitializeComponent();
            cbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
          btnid.Enabled =  txtNombre.Enabled = txtEdad.Enabled = txtApellido.Enabled = cbPuesto.Enabled = cbDepartamento.Enabled = false;
            dataGridView1.DataSource = db.SelectDataTable("select idrfid as `ID`, Nombre, Apellido, Edad, Departamento, FechaIn as `Fecha de Ingreso` from registros");
            //  label1.Text = DateTime.Now.ToString("h:mm:ss tt");
            for (int i = 0; i < dept.Length-1; i++)
            {
                cbDepartamento.Items.Add(dept[i]);
            }
            for (int i = 0; i < puesto.Length; i++)
            {
                cbPuesto.Items.Add(puesto[i]);
            }
   
        }
        BaseDeDatos db = new BaseDeDatos();

        private void btnid_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                string Agregar = string.Format("INSERT INTO `mastercheck`.`registros` (`idrfid`, `Nombre`, `Apellido`, `Edad`, `Departamento`, `FechaIn`, `puesto`, `Perfil`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}')",
                    txtId.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, cbDepartamento.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),cbPuesto.Text,img);

                if (db.executecommand(Agregar))
                {
                    MessageBox.Show("Agregado al Sistema");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Verifique si los Datos estan correctos "+ ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SelectDataTable("select idrfid as `ID`, Nombre, Apellido, Edad, Departamento, FechaIn as `Fecha de Ingreso` from registros");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
         btnid.Enabled=   txtNombre.Enabled = txtEdad.Enabled = txtApellido.Enabled = cbPuesto.Enabled = cbDepartamento.Enabled = !string.IsNullOrWhiteSpace(this.txtId.Text); 

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
      

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btnselimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
