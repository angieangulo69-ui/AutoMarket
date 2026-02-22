namespace AutoMarket.Consultas
{
    partial class ConsultaCateVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCateVehiculo));
            this.label4 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.DGV_categorias = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxcategoria = new System.Windows.Forms.ComboBox();
            this.btn_todascategorias = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_categorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(83, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 79);
            this.label4.TabIndex = 20;
            this.label4.Text = "Consulta por Categoría";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(405, 156);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(184, 42);
            this.btn_consultar.TabIndex = 37;
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
            this.btn_atras.Location = new System.Drawing.Point(395, 474);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(152, 42);
            this.btn_atras.TabIndex = 36;
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
            this.btn_salir.Location = new System.Drawing.Point(576, 474);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(152, 42);
            this.btn_salir.TabIndex = 35;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // DGV_categorias
            // 
            this.DGV_categorias.AllowUserToAddRows = false;
            this.DGV_categorias.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DGV_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_categorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColDescripcion});
            this.DGV_categorias.Location = new System.Drawing.Point(132, 281);
            this.DGV_categorias.Name = "DGV_categorias";
            this.DGV_categorias.ReadOnly = true;
            this.DGV_categorias.RowHeadersWidth = 51;
            this.DGV_categorias.RowTemplate.Height = 24;
            this.DGV_categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_categorias.Size = new System.Drawing.Size(532, 91);
            this.DGV_categorias.TabIndex = 40;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "IDCategoria";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre Categoria";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 125;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(104, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 43);
            this.label2.TabIndex = 39;
            this.label2.Text = "Categoría:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxcategoria
            // 
            this.comboBoxcategoria.FormattingEnabled = true;
            this.comboBoxcategoria.Location = new System.Drawing.Point(224, 166);
            this.comboBoxcategoria.Name = "comboBoxcategoria";
            this.comboBoxcategoria.Size = new System.Drawing.Size(152, 24);
            this.comboBoxcategoria.TabIndex = 38;
            this.comboBoxcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategoria_SelectedIndexChanged);
            // 
            // btn_todascategorias
            // 
            this.btn_todascategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_todascategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_todascategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_todascategorias.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todascategorias.Location = new System.Drawing.Point(31, 474);
            this.btn_todascategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btn_todascategorias.Name = "btn_todascategorias";
            this.btn_todascategorias.Size = new System.Drawing.Size(293, 42);
            this.btn_todascategorias.TabIndex = 41;
            this.btn_todascategorias.Text = "Categorías Registradas";
            this.btn_todascategorias.UseVisualStyleBackColor = false;
            this.btn_todascategorias.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(667, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaCateVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_todascategorias);
            this.Controls.Add(this.DGV_categorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxcategoria);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label4);
            this.Name = "ConsultaCateVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaCateVehiculo";
            this.Load += new System.EventHandler(this.ConsultaCateVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_categorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView DGV_categorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxcategoria;
        private System.Windows.Forms.Button btn_todascategorias;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}