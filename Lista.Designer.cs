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
            this.btnExp = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbcmd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(708, 492);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(87, 37);
            this.btnExp.TabIndex = 1;
            this.btnExp.Text = "Exportar";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnemp
            // 
            this.btnemp.Location = new System.Drawing.Point(16, 497);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(99, 39);
            this.btnemp.TabIndex = 2;
            this.btnemp.Text = "Regresar";
            this.btnemp.UseVisualStyleBackColor = true;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(909, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbcmd
            // 
            this.cbcmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcmd.FormattingEnabled = true;
            this.cbcmd.Location = new System.Drawing.Point(820, 497);
            this.cbcmd.Name = "cbcmd";
            this.cbcmd.Size = new System.Drawing.Size(121, 28);
            this.cbcmd.TabIndex = 4;
            this.cbcmd.SelectedIndexChanged += new System.EventHandler(this.cbcmd_SelectedIndexChanged);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 545);
            this.Controls.Add(this.cbcmd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnemp);
            this.Controls.Add(this.btnExp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbcmd;
    }
}