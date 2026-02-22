namespace AutoMarket.Consultas
{
    partial class ConsultaVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVehiculos));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVehiculo = new System.Windows.Forms.ComboBox();
            this.btn_consultaVehiculos = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_vehiculos = new System.Windows.Forms.DataGridView();
            this.btnConsultraFiltro = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_vehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(132, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 43);
            this.label2.TabIndex = 57;
            this.label2.Text = "Vehiculo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxVehiculo
            // 
            this.comboBoxVehiculo.FormattingEnabled = true;
            this.comboBoxVehiculo.Location = new System.Drawing.Point(236, 178);
            this.comboBoxVehiculo.Name = "comboBoxVehiculo";
            this.comboBoxVehiculo.Size = new System.Drawing.Size(152, 24);
            this.comboBoxVehiculo.TabIndex = 56;
            // 
            // btn_consultaVehiculos
            // 
            this.btn_consultaVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_consultaVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultaVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultaVehiculos.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultaVehiculos.Location = new System.Drawing.Point(140, 441);
            this.btn_consultaVehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultaVehiculos.Name = "btn_consultaVehiculos";
            this.btn_consultaVehiculos.Size = new System.Drawing.Size(248, 42);
            this.btn_consultaVehiculos.TabIndex = 55;
            this.btn_consultaVehiculos.Text = "Vehiculos Registrados";
            this.btn_consultaVehiculos.UseVisualStyleBackColor = false;
            this.btn_consultaVehiculos.Click += new System.EventHandler(this.btn_consultaVehiculos_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(429, 441);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(152, 42);
            this.btn_atras.TabIndex = 54;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(613, 441);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(152, 42);
            this.btn_salir.TabIndex = 53;
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
            this.label4.Location = new System.Drawing.Point(205, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 79);
            this.label4.TabIndex = 52;
            this.label4.Text = "Consulta porVehiculo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DGV_vehiculos
            // 
            this.DGV_vehiculos.AllowUserToAddRows = false;
            this.DGV_vehiculos.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DGV_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_vehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.Marca,
            this.ColNombre,
            this.ColDescripcion,
            this.Precio,
            this.Categoria,
            this.Column1,
            this.Estado});
            this.DGV_vehiculos.Location = new System.Drawing.Point(12, 258);
            this.DGV_vehiculos.Name = "DGV_vehiculos";
            this.DGV_vehiculos.ReadOnly = true;
            this.DGV_vehiculos.RowHeadersWidth = 51;
            this.DGV_vehiculos.RowTemplate.Height = 24;
            this.DGV_vehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_vehiculos.Size = new System.Drawing.Size(873, 110);
            this.DGV_vehiculos.TabIndex = 58;
            // 
            // btnConsultraFiltro
            // 
            this.btnConsultraFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConsultraFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultraFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultraFiltro.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultraFiltro.Location = new System.Drawing.Point(413, 170);
            this.btnConsultraFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultraFiltro.Name = "btnConsultraFiltro";
            this.btnConsultraFiltro.Size = new System.Drawing.Size(152, 42);
            this.btnConsultraFiltro.TabIndex = 59;
            this.btnConsultraFiltro.Text = "Consulta Filtrada";
            this.btnConsultraFiltro.UseVisualStyleBackColor = false;
            this.btnConsultraFiltro.Click += new System.EventHandler(this.btnConsultraFiltro_Click);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID Vehiculo";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 125;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Modelo";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 125;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Año";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripción";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // ConsultaVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(897, 523);
            this.Controls.Add(this.btnConsultraFiltro);
            this.Controls.Add(this.DGV_vehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVehiculo);
            this.Controls.Add(this.btn_consultaVehiculos);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label4);
            this.Name = "ConsultaVehiculos";
            this.Text = "ConsultaVehiculos";
            this.Load += new System.EventHandler(this.ConsultaVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_vehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVehiculo;
        private System.Windows.Forms.Button btn_consultaVehiculos;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_vehiculos;
        private System.Windows.Forms.Button btnConsultraFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}