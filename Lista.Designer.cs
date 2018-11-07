namespace MasterCheck2._0
{
    partial class Lista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.btnhis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(877, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(40, 480);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(87, 37);
            this.btnExp.TabIndex = 1;
            this.btnExp.Text = "Exportar";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnemp
            // 
            this.btnemp.Location = new System.Drawing.Point(488, 480);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(99, 39);
            this.btnemp.TabIndex = 2;
            this.btnemp.Text = "Empleados";
            this.btnemp.UseVisualStyleBackColor = true;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btnhis
            // 
            this.btnhis.Location = new System.Drawing.Point(593, 480);
            this.btnhis.Name = "btnhis";
            this.btnhis.Size = new System.Drawing.Size(110, 37);
            this.btnhis.TabIndex = 3;
            this.btnhis.Text = "Historial";
            this.btnhis.UseVisualStyleBackColor = true;
            this.btnhis.Click += new System.EventHandler(this.btnhis_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 545);
            this.Controls.Add(this.btnhis);
            this.Controls.Add(this.btnemp);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lista";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Button btnhis;
    }
}