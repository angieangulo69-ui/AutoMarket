namespace AutoMarket.Consultas
{
    partial class ConsultaVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVendedores));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.btn_registrovendedores = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridRegistroVendedor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_consultrafiltrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(100, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 43);
            this.label2.TabIndex = 63;
            this.label2.Text = "Vendedor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(204, 170);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(152, 24);
            this.comboBoxVendedor.TabIndex = 62;
            this.comboBoxVendedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehiculo_SelectedIndexChanged);
            // 
            // btn_registrovendedores
            // 
            this.btn_registrovendedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_registrovendedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrovendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrovendedores.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrovendedores.Location = new System.Drawing.Point(109, 433);
            this.btn_registrovendedores.Margin = new System.Windows.Forms.Padding(4);
            this.btn_registrovendedores.Name = "btn_registrovendedores";
            this.btn_registrovendedores.Size = new System.Drawing.Size(247, 42);
            this.btn_registrovendedores.TabIndex = 61;
            this.btn_registrovendedores.Text = "Registro Vendedores";
            this.btn_registrovendedores.UseVisualStyleBackColor = false;
            this.btn_registrovendedores.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_atras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(397, 433);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(152, 42);
            this.btn_atras.TabIndex = 60;
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
            this.btn_salir.Location = new System.Drawing.Point(581, 433);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(152, 42);
            this.btn_salir.TabIndex = 59;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(173, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 79);
            this.label4.TabIndex = 58;
            this.label4.Text = "Consulta por Vendedor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridRegistroVendedor
            // 
            this.dataGridRegistroVendedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridRegistroVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistroVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridRegistroVendedor.Location = new System.Drawing.Point(14, 241);
            this.dataGridRegistroVendedor.Name = "dataGridRegistroVendedor";
            this.dataGridRegistroVendedor.RowHeadersWidth = 51;
            this.dataGridRegistroVendedor.RowTemplate.Height = 24;
            this.dataGridRegistroVendedor.Size = new System.Drawing.Size(806, 149);
            this.dataGridRegistroVendedor.TabIndex = 64;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Vendedor";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Identificacion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teléfono";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha Ingreso";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha Nacimiento";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // btn_consultrafiltrada
            // 
            this.btn_consultrafiltrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_consultrafiltrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultrafiltrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultrafiltrada.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultrafiltrada.Location = new System.Drawing.Point(385, 152);
            this.btn_consultrafiltrada.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultrafiltrada.Name = "btn_consultrafiltrada";
            this.btn_consultrafiltrada.Size = new System.Drawing.Size(202, 42);
            this.btn_consultrafiltrada.TabIndex = 65;
            this.btn_consultrafiltrada.Text = "Consulta Filtrada";
            this.btn_consultrafiltrada.UseVisualStyleBackColor = false;
            this.btn_consultrafiltrada.Click += new System.EventHandler(this.btn_consultrafiltrada_Click);
            // 
            // ConsultaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 493);
            this.Controls.Add(this.btn_consultrafiltrada);
            this.Controls.Add(this.dataGridRegistroVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVendedor);
            this.Controls.Add(this.btn_registrovendedores);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label4);
            this.Name = "ConsultaVendedores";
            this.Text = "ConsultaVendedores";
            this.Load += new System.EventHandler(this.ConsultaVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.Button btn_registrovendedores;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridRegistroVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_consultrafiltrada;
    }
}