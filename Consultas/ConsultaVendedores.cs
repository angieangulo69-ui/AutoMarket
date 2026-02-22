/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para consultar los vendedores registrados, mostrando su ID, 
identificación, nombre completo, fecha de nacimiento, fecha de ingreso y teléfono 
en un DataGridView. Al cargar la ventana, se configura el DataGridView para que las
columnas se ajusten al tamaño del control, se establezca como de solo lectura y se 
evite que el usuario agregue filas.Luego, se cargan los vendedores desde la clase 
Datos_Vendedor y se muestran en el DataGridView.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMarket.Consultas
{
    public partial class ConsultaVendedores : Form
    {
        public ConsultaVendedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CargarGrid();
            comboBoxVendedor.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu consultas
            Consulta MenuConsulta = new Consulta();
            MenuConsulta.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaVendedores_Load(object sender, EventArgs e)
        {

            ConfigurarDataGrid();
            CargarComboBoxVendedores();

        }
        private void ConfigurarDataGrid()
        {
            dataGridRegistroVendedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRegistroVendedor.ReadOnly = true;
            dataGridRegistroVendedor.AllowUserToAddRows = false;
            dataGridRegistroVendedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridRegistroVendedor.MultiSelect = false;
        }
        private void CargarGrid()
        {
            dataGridRegistroVendedor.Rows.Clear();

            for (int i = 0; i < Datos_Vendedor.contadorvendedor; i++)
            {
                dataGridRegistroVendedor.Rows.Add(
                    Datos_Vendedor.vendedor[i].Id,
                    Datos_Vendedor.vendedor[i].Identificacion,
                    Datos_Vendedor.vendedor[i].NombreCompleto,
                    Datos_Vendedor.vendedor[i].FechaNacimiento.ToShortDateString(),
                    Datos_Vendedor.vendedor[i].FechaIngreso.ToShortDateString(),
                    Datos_Vendedor.vendedor[i].Telefono
                );
            }
        }
        private void CargarComboBoxVendedores()
        {
            comboBoxVendedor.DataSource = null;

            List<object> listaVendedores = new List<object>();

            for (int i = 0; i < Datos_Vendedor.contadorvendedor; i++)
            {
                listaVendedores.Add(new
                {
                    Id = Datos_Vendedor.vendedor[i].Id,
                    Nombre = Datos_Vendedor.vendedor[i].NombreCompleto
                });
            }

            comboBoxVendedor.DataSource = listaVendedores;
            comboBoxVendedor.DisplayMember = "Nombre";
            comboBoxVendedor.ValueMember = "Id";
            comboBoxVendedor.SelectedIndex = -1;
        }


        private void btn_consultrafiltrada_Click(object sender, EventArgs e)
        {
            if (comboBoxVendedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un vendedor para filtrar.");
                return;
            }

            int idSeleccionado = (int)comboBoxVendedor.SelectedValue;

            dataGridRegistroVendedor.Rows.Clear();

            for (int i = 0; i < Datos_Vendedor.contadorvendedor; i++)
            {
                if (Datos_Vendedor.vendedor[i].Id == idSeleccionado)
                {
                    dataGridRegistroVendedor.Rows.Add(
                        Datos_Vendedor.vendedor[i].Id,
                        Datos_Vendedor.vendedor[i].Identificacion,
                        Datos_Vendedor.vendedor[i].NombreCompleto,
                        Datos_Vendedor.vendedor[i].FechaNacimiento.ToShortDateString(),
                        Datos_Vendedor.vendedor[i].FechaIngreso.ToShortDateString(),
                        Datos_Vendedor.vendedor[i].Telefono
                    );
                }
            }
        }
    }
}

