namespace AutoMarket.Consultas
{
    partial class sucursalesRegistradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sucursalesRegistradas));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSucursal = new System.Windows.Forms.ComboBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGrid_Sucursales = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_todassucursales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Sucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(81, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 43);
            this.label2.TabIndex = 51;
            this.label2.Text = "Sucursal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxSucursal
            // 
            this.comboBoxSucursal.FormattingEnabled = true;
            this.comboBoxSucursal.Location = new System.Drawing.Point(185, 137);
            this.comboBoxSucursal.Name = "comboBoxSucursal";
            this.comboBoxSucursal.Size = new System.Drawing.Size(152, 24);
            this.comboBoxSucursal.TabIndex = 50;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(390, 122);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(214, 42);
            this.btn_consultar.TabIndex = 49;
            this.btn_consultar.Text = "Consulta Filtrada";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(369, 447);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(152, 42);
            this.btn_atras.TabIndex = 48;
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
            this.btn_salir.Location = new System.Drawing.Point(562, 447);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(152, 42);
            this.btn_salir.TabIndex = 47;
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
            this.label4.Location = new System.Drawing.Point(288, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 79);
            this.label4.TabIndex = 46;
            this.label4.Text = "Consulta por Sucursal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataGrid_Sucursales
            // 
            this.DataGrid_Sucursales.AllowUserToAddRows = false;
            this.DataGrid_Sucursales.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DataGrid_Sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Sucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColDescripcion,
            this.Precio,
            this.Marca,
            this.Column1,
            this.Categoria});
            this.DataGrid_Sucursales.Location = new System.Drawing.Point(36, 208);
            this.DataGrid_Sucursales.Name = "DataGrid_Sucursales";
            this.DataGrid_Sucursales.ReadOnly = true;
            this.DataGrid_Sucursales.RowHeadersWidth = 51;
            this.DataGrid_Sucursales.RowTemplate.Height = 24;
            this.DataGrid_Sucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Sucursales.Size = new System.Drawing.Size(823, 168);
            this.DataGrid_Sucursales.TabIndex = 52;
            this.DataGrid_Sucursales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGried_Sucursales_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Id Sucursal";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 125;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Teléfono";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Dirección";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Vendedor Encargado";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificación Vendedor";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Activo";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // btn_todassucursales
            // 
            this.btn_todassucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_todassucursales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_todassucursales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_todassucursales.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todassucursales.Location = new System.Drawing.Point(67, 447);
            this.btn_todassucursales.Margin = new System.Windows.Forms.Padding(4);
            this.btn_todassucursales.Name = "btn_todassucursales";
            this.btn_todassucursales.Size = new System.Drawing.Size(246, 42);
            this.btn_todassucursales.TabIndex = 53;
            this.btn_todassucursales.Text = "Sucursales Registradas";
            this.btn_todassucursales.UseVisualStyleBackColor = false;
            this.btn_todassucursales.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(773, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // sucursalesRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_todassucursales);
            this.Controls.Add(this.DataGrid_Sucursales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSucursal);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label4);
            this.Name = "sucursalesRegistradas";
            this.Text = "ConsultaSucursales";
            this.Load += new System.EventHandler(this.ConsultaSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Sucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSucursal;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataGrid_Sucursales;
        private System.Windows.Forms.Button btn_todassucursales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}