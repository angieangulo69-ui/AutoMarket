namespace AutoMarket.Consultas
{
    partial class Consulta_VehiculoSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_VehiculoSucursal));
            this.btn_filtro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSucursal = new System.Windows.Forms.ComboBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewSucursal_Vehiculo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursal_Vehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_filtro
            // 
            this.btn_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtro.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtro.Location = new System.Drawing.Point(411, 158);
            this.btn_filtro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(188, 42);
            this.btn_filtro.TabIndex = 54;
            this.btn_filtro.Text = "Consulta Filtrada";
            this.btn_filtro.UseVisualStyleBackColor = false;
            this.btn_filtro.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(133, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 53);
            this.label2.TabIndex = 53;
            this.label2.Text = "Sucursal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxSucursal
            // 
            this.comboBoxSucursal.FormattingEnabled = true;
            this.comboBoxSucursal.Location = new System.Drawing.Point(233, 166);
            this.comboBoxSucursal.Name = "comboBoxSucursal";
            this.comboBoxSucursal.Size = new System.Drawing.Size(152, 24);
            this.comboBoxSucursal.TabIndex = 52;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(62, 449);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(341, 42);
            this.btn_consultar.TabIndex = 51;
            this.btn_consultar.Text = "Registros Vehiculos por Sucursal";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(424, 449);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(152, 42);
            this.btn_atras.TabIndex = 50;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(612, 449);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(152, 42);
            this.btn_salir.TabIndex = 49;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(98, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(567, 79);
            this.label4.TabIndex = 48;
            this.label4.Text = "Consulta Vehiculo con Sucursal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewSucursal_Vehiculo
            // 
            this.dataGridViewSucursal_Vehiculo.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewSucursal_Vehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSucursal_Vehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewSucursal_Vehiculo.Location = new System.Drawing.Point(112, 241);
            this.dataGridViewSucursal_Vehiculo.Name = "dataGridViewSucursal_Vehiculo";
            this.dataGridViewSucursal_Vehiculo.RowHeadersWidth = 51;
            this.dataGridViewSucursal_Vehiculo.RowTemplate.Height = 24;
            this.dataGridViewSucursal_Vehiculo.Size = new System.Drawing.Size(593, 150);
            this.dataGridViewSucursal_Vehiculo.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id SucuraL";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Sucursal";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vehiculo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Consulta_VehiculoSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 534);
            this.Controls.Add(this.dataGridViewSucursal_Vehiculo);
            this.Controls.Add(this.btn_filtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSucursal);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label4);
            this.Name = "Consulta_VehiculoSucursal";
            this.Text = "Consulta_VehiculoSucursal";
            this.Load += new System.EventHandler(this.Consulta_VehiculoSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursal_Vehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSucursal;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSucursal_Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}