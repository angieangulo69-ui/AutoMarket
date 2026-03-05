/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para consultar los vehículos registrados en 
cada sucursal, mostrando su ID, marca, modelo, año, precio, categoría,
estado y cantidad en un DataGridView. Al cargar la ventana, se configura 
el DataGridView para que las columnas se ajusten al tamaño del control, 
se establezca como de solo lectura y se evite que el usuario agregue filas.
Luego, se cargan las sucursales desde la clase Datos_Sucursal y se muestran 
en un ComboBox para que el usuario pueda seleccionar una sucursal específica 
y filtrar los vehículos mostrados en el DataGridView.
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
    public partial class Consulta_VehiculoSucursal : Form
    {
        public Consulta_VehiculoSucursal()

        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CargarGrid();
            comboBoxSucursal.SelectedIndex = -1;
        }
            

        private void Consulta_VehiculoSucursal_Load(object sender, EventArgs e)
        {
            ConfigurarDataGrid();
            CargarComboBoxSucursales();
        }
        private void ConfigurarDataGrid()
        {
            dataGridViewSucursal_Vehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSucursal_Vehiculo.ReadOnly = true;
            dataGridViewSucursal_Vehiculo.AllowUserToAddRows = false;
            dataGridViewSucursal_Vehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSucursal_Vehiculo.MultiSelect = false;
        }
        private void CargarComboBoxSucursales()
        {
            comboBoxSucursal.DataSource = null;

            List<object> lista = new List<object>();

            for (int i = 0; i < Datos_Sucursal.contadorSucursal; i++)
            {
                lista.Add(new
                {
                    Id = Datos_Sucursal.sucursales[i].IdSucursal,
                    Nombre = Datos_Sucursal.sucursales[i].Nombre
                });
            }

            comboBoxSucursal.DataSource = lista;
            comboBoxSucursal.DisplayMember = "Nombre";
            comboBoxSucursal.ValueMember = "Id";
            comboBoxSucursal.SelectedIndex = -1; // Deja el ComboBox sin selección al cargar la ventana
        }


        // Botón filtro
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sucursal.");
                return;
            }

            int idSucursalSeleccionada = (int)comboBoxSucursal.SelectedValue;

            dataGridViewSucursal_Vehiculo.Rows.Clear();

            for (int i = 0; i < Datos_VehiculosSucursal.contador; i++)
            {
                if (Datos_VehiculosSucursal.registros[i].Sucursal.IdSucursal == idSucursalSeleccionada)
                {
                    var registro = Datos_VehiculosSucursal.registros[i];

                    dataGridViewSucursal_Vehiculo.Rows.Add(
                        registro.Vehiculo.IdVehiculo,
                        registro.Vehiculo.Marca,
                        registro.Vehiculo.Modelo,
                        registro.Vehiculo.Anio,
                        registro.Vehiculo.Precio.ToString("C"),
                        registro.Vehiculo.Categoria.NombreCategoria,
                        registro.Vehiculo.Estado == 'N' ? "Nuevo" : "Usado",
                        registro.Cantidad
                    );
                }
            }
        }
        // Método para cargar todos los vehículos 
        private void CargarGrid()
        {
            dataGridViewSucursal_Vehiculo.Rows.Clear();

            for (int i = 0; i < Datos_VehiculosSucursal.contador; i++)
            {
                var registro = Datos_VehiculosSucursal.registros[i];

                dataGridViewSucursal_Vehiculo.Rows.Add(
                    registro.Sucursal.Nombre,
                    registro.Vehiculo.IdVehiculo,
                    registro.Vehiculo.Marca,
                    registro.Vehiculo.Modelo,
                    registro.Vehiculo.Anio,
                    registro.Vehiculo.Precio.ToString("C"),
                    registro.Vehiculo.Categoria.NombreCategoria,
                    registro.Vehiculo.Estado == 'N' ? "Nuevo" : "Usado",
                    registro.Cantidad
                );
            }
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu de consultas
            Consulta MenuConsultas = new Consulta();
            MenuConsultas.Show();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }
    }
}
