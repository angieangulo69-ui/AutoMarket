namespace AutoMarket
{
    partial class RegistrarVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVendedor));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTime_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.dataGridRegistroVendedor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.mtxt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_id = new System.Windows.Forms.MaskedTextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idvendedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroVendedor)).BeginInit();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(256, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 79);
            this.label4.TabIndex = 11;
            this.label4.Text = "Registros de Vendedores";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(416, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha Ingreso:";
            // 
            // dateTime_nacimiento
            // 
            this.dateTime_nacimiento.Location = new System.Drawing.Point(656, 63);
            this.dateTime_nacimiento.Name = "dateTime_nacimiento";
            this.dateTime_nacimiento.Size = new System.Drawing.Size(233, 22);
            this.dateTime_nacimiento.TabIndex = 18;
            this.dateTime_nacimiento.ValueChanged += new System.EventHandler(this.dateTime_nacimiento_ValueChanged);
            // 
            // dateTime_Ingreso
            // 
            this.dateTime_Ingreso.Location = new System.Drawing.Point(187, 112);
            this.dateTime_Ingreso.Name = "dateTime_Ingreso";
            this.dateTime_Ingreso.Size = new System.Drawing.Size(194, 22);
            this.dateTime_Ingreso.TabIndex = 19;
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
            this.dataGridRegistroVendedor.Location = new System.Drawing.Point(93, 262);
            this.dataGridRegistroVendedor.Name = "dataGridRegistroVendedor";
            this.dataGridRegistroVendedor.RowHeadersWidth = 51;
            this.dataGridRegistroVendedor.RowTemplate.Height = 24;
            this.dataGridRegistroVendedor.Size = new System.Drawing.Size(806, 149);
            this.dataGridRegistroVendedor.TabIndex = 18;
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
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.ForeColor = System.Drawing.Color.Black;
            this.btn_atras.Location = new System.Drawing.Point(498, 497);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(109, 40);
            this.btn_atras.TabIndex = 32;
            this.btn_atras.Text = "Atràs";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(340, 497);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(109, 40);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Datos
            // 
            this.Datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Datos.Controls.Add(this.mtxt_telefono);
            this.Datos.Controls.Add(this.mtxt_id);
            this.Datos.Controls.Add(this.dateTime_nacimiento);
            this.Datos.Controls.Add(this.txt_nombre);
            this.Datos.Controls.Add(this.label5);
            this.Datos.Controls.Add(this.dateTime_Ingreso);
            this.Datos.Controls.Add(this.label1);
            this.Datos.Controls.Add(this.label7);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Controls.Add(this.txt_idvendedor);
            this.Datos.Controls.Add(this.label9);
            this.Datos.Controls.Add(this.label2);
            this.Datos.Location = new System.Drawing.Point(29, 88);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(920, 145);
            this.Datos.TabIndex = 33;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // mtxt_telefono
            // 
            this.mtxt_telefono.Location = new System.Drawing.Point(187, 84);
            this.mtxt_telefono.Mask = "0000-0000";
            this.mtxt_telefono.Name = "mtxt_telefono";
            this.mtxt_telefono.Size = new System.Drawing.Size(194, 22);
            this.mtxt_telefono.TabIndex = 21;
            // 
            // mtxt_id
            // 
            this.mtxt_id.Location = new System.Drawing.Point(187, 54);
            this.mtxt_id.Mask = "0-0000-0000";
            this.mtxt_id.Name = "mtxt_id";
            this.mtxt_id.Size = new System.Drawing.Size(194, 22);
            this.mtxt_id.TabIndex = 20;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(656, 25);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(233, 22);
            this.txt_nombre.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Vendedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(416, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre Completo:";
            // 
            // txt_idvendedor
            // 
            this.txt_idvendedor.Location = new System.Drawing.Point(187, 18);
            this.txt_idvendedor.Name = "txt_idvendedor";
            this.txt_idvendedor.Size = new System.Drawing.Size(194, 22);
            this.txt_idvendedor.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Identificación:";
            // 
            // RegistrarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(989, 578);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dataGridRegistroVendedor);
            this.Controls.Add(this.label4);
            this.Name = "RegistrarVendedor";
            this.Text = "RegistrarVendedor";
            this.Load += new System.EventHandler(this.RegistrarVendedor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistroVendedor)).EndInit();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTime_nacimiento;
        private System.Windows.Forms.DateTimePicker dateTime_Ingreso;
        private System.Windows.Forms.DataGridView dataGridRegistroVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idvendedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxt_telefono;
        private System.Windows.Forms.MaskedTextBox mtxt_id;
    }
}