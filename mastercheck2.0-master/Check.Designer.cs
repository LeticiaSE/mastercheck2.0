namespace MasterCheck2._0
{
    partial class Check
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEx = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblEnt = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Timer(this.components);
            this.lbldept = new System.Windows.Forms.Label();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insertar = new System.Windows.Forms.Timer(this.components);
            this.Eliminar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(29, 28);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(75, 44);
            this.btnEx.TabIndex = 0;
            this.btnEx.Text = "Insertar";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(259, 245);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Nombre";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Enabled = false;
            this.lblEntrada.Location = new System.Drawing.Point(258, 312);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(66, 20);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Enabled = false;
            this.lblSalida.Location = new System.Drawing.Point(525, 312);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 20);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Salida";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(413, 245);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(13, 20);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = " ";
            // 
            // lblEnt
            // 
            this.lblEnt.AutoSize = true;
            this.lblEnt.Location = new System.Drawing.Point(329, 312);
            this.lblEnt.Name = "lblEnt";
            this.lblEnt.Size = new System.Drawing.Size(13, 20);
            this.lblEnt.TabIndex = 6;
            this.lblEnt.Text = " ";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(596, 312);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(13, 20);
            this.lblSal.TabIndex = 7;
            this.lblSal.Text = " ";
            // 
            // mensaje
            // 
            this.mensaje.Interval = 6000;
            this.mensaje.Tick += new System.EventHandler(this.mensaje_Tick);
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(259, 276);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(112, 20);
            this.lbldept.TabIndex = 8;
            this.lbldept.Text = "Departamento";
            // 
            // btnhistorial
            // 
            this.btnhistorial.Location = new System.Drawing.Point(25, 100);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(79, 44);
            this.btnhistorial.TabIndex = 9;
            this.btnhistorial.Text = "Historial";
            this.btnhistorial.UseVisualStyleBackColor = true;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Location = new System.Drawing.Point(377, 276);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(13, 20);
            this.lbldepartamento.TabIndex = 10;
            this.lbldepartamento.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 220);
            this.dataGridView1.TabIndex = 11;
            // 
            // Insertar
            // 
            this.Insertar.Interval = 3000;
            this.Insertar.Tick += new System.EventHandler(this.Insertar_Tick);
            // 
            // Eliminar
            // 
            this.Eliminar.Interval = 100000;
            this.Eliminar.Tick += new System.EventHandler(this.Eliminar_Tick);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 452);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbldepartamento);
            this.Controls.Add(this.btnhistorial);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblEnt);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Check";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEnt;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Timer mensaje;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Button btnhistorial;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer Insertar;
        private System.Windows.Forms.Timer Eliminar;
    }
}