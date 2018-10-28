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
            this.btnEx = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblEnt = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(67, 208);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(75, 44);
            this.btnEx.TabIndex = 0;
            this.btnEx.Text = "Insertar";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(63, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Nombre";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Enabled = false;
            this.lblEntrada.Location = new System.Drawing.Point(63, 101);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(66, 20);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Enabled = false;
            this.lblSalida.Location = new System.Drawing.Point(63, 150);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 20);
            this.lblSalida.TabIndex = 4;
            this.lblSalida.Text = "Salida";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Enabled = false;
            this.lblNom.Location = new System.Drawing.Point(134, 54);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(13, 20);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = " ";
            // 
            // lblEnt
            // 
            this.lblEnt.AutoSize = true;
            this.lblEnt.Enabled = false;
            this.lblEnt.Location = new System.Drawing.Point(134, 101);
            this.lblEnt.Name = "lblEnt";
            this.lblEnt.Size = new System.Drawing.Size(13, 20);
            this.lblEnt.TabIndex = 6;
            this.lblEnt.Text = " ";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Enabled = false;
            this.lblSal.Location = new System.Drawing.Point(134, 150);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(13, 20);
            this.lblSal.TabIndex = 7;
            this.lblSal.Text = " ";
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblEnt);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEx);
            this.Name = "Check";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Check_Load);
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
    }
}