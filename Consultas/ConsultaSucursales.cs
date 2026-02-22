/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para consultar las sucursales registradas, 
mostrando su ID, nombre, dirección, teléfono, vendedor encargado 
y estado (activo/inactivo) en un DataGridView. Al cargar la ventana,
se configura el DataGridView para que las columnas se ajusten al
tamaño del control, se establezca como de solo lectura y se evite 
que el usuario agregue filas. Luego, se cargan las sucursales desde 
la clase Datos_Sucursal y se muestran en el DataGridView. Además, 
se proporciona un ComboBox para seleccionar una sucursal específica
y mostrar sus detalles en el DataGridView el hacer clic en el botón 
"Consultar". También hay un botón para 
mostrar todas las sucursales registradas.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Class;
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
    public partial class sucursalesRegistradas : Form
    {
        public sucursalesRegistradas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void ConsultaSucursales_Load(object sender, EventArgs e)
        {
            ConfiguracionDataGrid();
            CargarSucursales();

        }
            private void CargarSucursales()
            {
            comboBoxSucursal.DataSource = null;
            List<Sucursal> lista = new List<Sucursal>();

            for (int i = 0; i < Datos_Sucursal.contadorSucursal; i++)
            {
                lista.Add(Datos_Sucursal.sucursales[i]);
            }

            comboBoxSucursal.DataSource = lista;
            comboBoxSucursal.DisplayMember = "Nombre";
        } 
        private void CargarGrid()
        {
            DataGrid_Sucursales.Rows.Clear();

            if (comboBoxSucursal.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            Sucursal sucursalSeleccionada =
                (Sucursal)comboBoxSucursal.SelectedItem;

            DataGrid_Sucursales.Rows.Add(
                sucursalSeleccionada.IdSucursal,
                sucursalSeleccionada.Nombre,
                sucursalSeleccionada.Direccion,
                sucursalSeleccionada.Telefono,
                sucursalSeleccionada.VendedorEncargado.NombreCompleto,
                sucursalSeleccionada.VendedorEncargado.Identificacion,
                sucursalSeleccionada.Activo ? "Sí" : "No"
            );
        }
        
        public void ConfiguracionDataGrid()
        {
            DataGrid_Sucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid_Sucursales.ReadOnly = true;
            DataGrid_Sucursales.AllowUserToAddRows = false;
            DataGrid_Sucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid_Sucursales.MultiSelect = false;
        }
        private void MostrarTodas()
        {
            DataGrid_Sucursales.Rows.Clear();

            for (int i = 0; i < Datos_Sucursal.contadorSucursal; i++)
            {
                DataGrid_Sucursales.Rows.Add(
                    Datos_Sucursal.sucursales[i].IdSucursal,
                    Datos_Sucursal.sucursales[i].Nombre,
                    Datos_Sucursal.sucursales[i].Direccion,
                    Datos_Sucursal.sucursales[i].Telefono,
                    Datos_Sucursal.sucursales[i].VendedorEncargado.NombreCompleto,
                    Datos_Sucursal.sucursales[i].VendedorEncargado.Identificacion,
                    Datos_Sucursal.sucursales[i].Activo ? "Sí" : "No"
                );
            }
        }
        private void DataGried_Sucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu consultas
            Consulta MenuConsulta = new Consulta();
            MenuConsulta.Show();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        { //Salir de la aplicacion
            Application.Exit();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarTodas();
        }
    }
}